Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace SirajGadhiaBT
    Public Class EmployeesController
        Inherits System.Web.Mvc.Controller

        Private db As New FDEntities

        ' GET: /Employees/
        Function Index() As ActionResult
            Return View(db.Employees.ToList())
        End Function


        ' GET: /Employees/Create
        Function Create() As ActionResult
            Dim employees As New Employees()
            employees.HireDate = DateTime.Now.AddDays(-7).Date
            employees.CourseList = db.Courses.ToList()

            For Each c As Courses In employees.CourseList
                c.isSelect = False
                c.isDisable = False
            Next

            Return View(employees)
        End Function

        ' POST: /Employees/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="EmployeeID,HireDate,Name")> ByVal employees As Employees, ByVal courseList As ICollection(Of Courses)) As ActionResult
            If ModelState.IsValid Then
                If Not courseList.Where(Function(d) d.isSelect = True).Any Then
                    ModelState.AddModelError("courseList", "Please select a course")
                Else
                    For Each item As Courses In courseList
                        If item.isSelect Then
                            Dim _EmployeeCourse As New EmployeeCourses
                            _EmployeeCourse.CourseID = item.CourseID
                            _EmployeeCourse.isComplete = False
                            'db.EmployeeCourses.Add(_EmployeeCourse)
                            employees.EmployeeCourses.Add(_EmployeeCourse)
                        End If
                    Next
                    db.Employees.Add(employees)
                    db.SaveChanges()
                    Return RedirectToAction("Index")
                End If
            End If
            employees.CourseList = db.Courses.ToList()
            Return View(employees)
        End Function

        ' GET: /Employees/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim employees As Employees = db.Employees.Find(id)
            If IsNothing(employees) Then
                Return HttpNotFound()
            End If

            employees.CourseList = db.Courses.ToList()

            For Each c As Courses In employees.CourseList

                For Each ec As EmployeeCourses In employees.EmployeeCourses
                    If c.CourseID = ec.CourseID Then
                        c.isSelect = True
                        c.isDisable = ec.isComplete
                    End If
                Next

            Next

            Return View(employees)
        End Function

        ' POST: /Employees/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="EmployeeID,HireDate,Name")> ByVal employees As Employees, ByVal courseList As ICollection(Of Courses)) As ActionResult

            If ModelState.IsValid Then
                If Not courseList.Where(Function(d) d.isSelect = True).Any Then
                    ModelState.AddModelError("courseList", "Please select a course")
                Else

                    Dim employees_org As Employees = db.Employees.Find(employees.EmployeeID)

                    While employees_org.EmployeeCourses.Any
                        Dim _EmployeeCourses As EmployeeCourses = employees_org.EmployeeCourses(0)
                        db.EmployeeCourses.Remove(_EmployeeCourses)
                    End While
                    db.SaveChanges()
                    employees_org.HireDate = employees.HireDate
                    employees_org.Name = employees.Name
                    For Each item As Courses In courseList
                        If item.isSelect Then
                            Dim _EmployeeCourse As New EmployeeCourses
                            _EmployeeCourse.CourseID = item.CourseID
                            _EmployeeCourse.EmployeeID = employees.EmployeeID
                            _EmployeeCourse.isComplete = item.isDisable
                            db.EmployeeCourses.Add(_EmployeeCourse)
                        End If
                    Next
                    db.SaveChanges()

                    Return RedirectToAction("Index")
                End If
            End If
            employees.CourseList = db.Courses.ToList()
            Return View(employees)

        End Function

        '' GET: /Employees/Delete/5
        'Function Delete(ByVal id As Integer?) As ActionResult
        '    If IsNothing(id) Then
        '        Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
        '    End If
        '    Dim employees As Employees = db.Employees.Find(id)
        '    If IsNothing(employees) Then
        '        Return HttpNotFound()
        '    End If
        '    Return View(employees)
        'End Function

        '' POST: /Employees/Delete/5
        '<HttpPost()>
        '<ActionName("Delete")>
        '<ValidateAntiForgeryToken()>
        'Function DeleteConfirmed(ByVal id As Integer) As ActionResult
        '    Dim employees As Employees = db.Employees.Find(id)
        '    db.Employees.Remove(employees)
        '    db.SaveChanges()
        '    Return RedirectToAction("Index")
        'End Function


        Function Complete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim employeeCourses As EmployeeCourses = db.EmployeeCourses.Find(id)
            If IsNothing(employeeCourses) Then
                Return HttpNotFound()
            End If

            employeeCourses.isComplete = True
            db.Entry(employeeCourses).State = EntityState.Modified
            db.SaveChanges()
            Return RedirectToAction("Index")

        End Function

        Function Uncomplete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim employeeCourses As EmployeeCourses = db.EmployeeCourses.Find(id)
            If IsNothing(employeeCourses) Then
                Return HttpNotFound()
            End If

            employeeCourses.isComplete = False
            db.Entry(employeeCourses).State = EntityState.Modified
            db.SaveChanges()
            Return RedirectToAction("Index")

        End Function


        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
