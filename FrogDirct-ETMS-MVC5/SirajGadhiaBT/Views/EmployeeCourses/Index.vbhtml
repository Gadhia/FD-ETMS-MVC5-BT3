@ModelType IEnumerable(Of EmployeeCourses)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.isComplete)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Courses.Name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Employees.Name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.isComplete)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Courses.Name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Employees.Name)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.EmployeeCourseID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.EmployeeCourseID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.EmployeeCourseID })
        </td>
    </tr>
Next

</table>
