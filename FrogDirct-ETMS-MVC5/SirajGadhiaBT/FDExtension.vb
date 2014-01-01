Imports System.Web.DynamicData
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web



<MetadataType(GetType(CoursesMD))>
Partial Public Class Courses
    Public Property isSelect As Boolean
    Public Property isDisable As Boolean

End Class


Public Class CoursesMD

    <Required(ErrorMessage:="Course Name is required.")>
  <StringLength(100)>
  <DisplayName("Course Name:")>
    Public Property Name As String

    <Required(ErrorMessage:="Code is required.")>
 <StringLength(4, ErrorMessage:="Maximum 4 charecters.")>
  <DisplayName("Course Code:")>
    Public Property Code As String


    <StringLength(500)>
    <DataType(DataType.MultilineText)>
    Public Property Description As String

End Class


<MetadataType(GetType(EmployeesMD))>
Partial Public Class Employees
    Public Overridable Property CourseList As ICollection(Of Courses) = New HashSet(Of Courses)


End Class

Public Class EmployeesMD

    <Required(ErrorMessage:=" Hire Date is required.")>
    <DisplayName("Hire Date:")>
    Public Property HireDate() As DateTime

    <Required(ErrorMessage:=" Employe Name is required.")>
    <StringLength(100)>
     <DisplayName("Employee Name:")>
    Public Property Name() As String

    <DisplayName("Select Course(s):")>
    Public Overridable Property CourseList As ICollection(Of Courses) = New HashSet(Of Courses)
End Class
