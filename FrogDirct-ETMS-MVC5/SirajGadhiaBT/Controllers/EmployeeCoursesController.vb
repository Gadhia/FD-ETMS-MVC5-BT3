Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace SirajGadhiaBT
    Public Class EmployeeCoursesController
        Inherits System.Web.Mvc.Controller

        Private db As New FDEntities

        ' GET: /EmployeeCourses/
        Function Index() As ActionResult
            Dim employeecourses = db.EmployeeCourses.Include(Function(e) e.Courses).Include(Function(e) e.Employees)
            Return View(employeecourses.ToList())
        End Function

        ' GET: /EmployeeCourses/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim employeecourses As EmployeeCourses = db.EmployeeCourses.Find(id)
            If IsNothing(employeecourses) Then
                Return HttpNotFound()
            End If
            Return View(employeecourses)
        End Function

        ' GET: /EmployeeCourses/Create
        Function Create() As ActionResult
            ViewBag.CourseID = New SelectList(db.Courses, "CourseID", "Name")
            ViewBag.EmployeeID = New SelectList(db.Employees, "EmployeeID", "Name")
            Return View()
        End Function

        ' POST: /EmployeeCourses/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include := "EmployeeCourseID,EmployeeID,CourseID,isComplete")> ByVal employeecourses As EmployeeCourses) As ActionResult
            If ModelState.IsValid Then
                db.EmployeeCourses.Add(employeecourses)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If 
            ViewBag.CourseID = New SelectList(db.Courses, "CourseID", "Name", employeecourses.CourseID)
            ViewBag.EmployeeID = New SelectList(db.Employees, "EmployeeID", "Name", employeecourses.EmployeeID)
            Return View(employeecourses)
        End Function

        ' GET: /EmployeeCourses/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim employeecourses As EmployeeCourses = db.EmployeeCourses.Find(id)
            If IsNothing(employeecourses) Then
                Return HttpNotFound()
            End If
            ViewBag.CourseID = New SelectList(db.Courses, "CourseID", "Name", employeecourses.CourseID)
            ViewBag.EmployeeID = New SelectList(db.Employees, "EmployeeID", "Name", employeecourses.EmployeeID)
            Return View(employeecourses)
        End Function

        ' POST: /EmployeeCourses/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include := "EmployeeCourseID,EmployeeID,CourseID,isComplete")> ByVal employeecourses As EmployeeCourses) As ActionResult
            If ModelState.IsValid Then
                db.Entry(employeecourses).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.CourseID = New SelectList(db.Courses, "CourseID", "Name", employeecourses.CourseID)
            ViewBag.EmployeeID = New SelectList(db.Employees, "EmployeeID", "Name", employeecourses.EmployeeID)
            Return View(employeecourses)
        End Function

        ' GET: /EmployeeCourses/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim employeecourses As EmployeeCourses = db.EmployeeCourses.Find(id)
            If IsNothing(employeecourses) Then
                Return HttpNotFound()
            End If
            Return View(employeecourses)
        End Function

        ' POST: /EmployeeCourses/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim employeecourses As EmployeeCourses = db.EmployeeCourses.Find(id)
            db.EmployeeCourses.Remove(employeecourses)
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
