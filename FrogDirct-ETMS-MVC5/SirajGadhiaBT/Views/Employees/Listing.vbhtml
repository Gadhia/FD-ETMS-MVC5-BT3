@ModelType IEnumerable(Of Employees)
@Code
'ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>

@*<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.HireDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.HireDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Name)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.EmployeeID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.EmployeeID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.EmployeeID })
        </td>
    </tr>
Next

</table>*@

<table class="table table-responsive" >
    <tr>

        <th>
            Name
        </th>
        <th>
            Hire Date
        </th>
        <th>Course</th>
        <th>


        </th>

    </tr>

    @For Each item In Model
        Dim itemValue = item
        @<tr>

            <td>
                <b>	@Html.DisplayFor(Function(modelItem) item.Name)</b>
            </td>
            <td>
                @String.Format("{0:d}", Html.DisplayFor(Function(modelItem) item.HireDate))
            </td>

            <td>
                @Html.Partial("_EmployeeCourcesList", item.EmployeeCourses) 


                @*@Code
                For Each _EmployeeCourse As EmployeeCourses In item.EmployeeCourses

                If _EmployeeCourse.isComplete Then

                    @:<img src="../../Content/true.gif" />

                Else

                    @:<img src="../../Content/false.gif" />

                End If

                    @_EmployeeCourse.Courses.Code @:&nbsp; - @_EmployeeCourse.Courses.Name




                    @:      <br />
                    Next
                End Code*@

            </td>

            <td>
                @Html.ActionLink("Edit", "Edit", New With {.id = itemValue.EmployeeID}) |
                @Html.ActionLink("Details", "Details", New With {.id = itemValue.EmployeeID}) |
                @Html.ActionLink("Delete", "Delete", New With {.id = itemValue.EmployeeID})
            </td>
        </tr>


    Next

</table>

