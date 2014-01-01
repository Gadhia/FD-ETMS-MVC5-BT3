@ModelType EmployeeCourses
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>EmployeeCourses</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.isComplete)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.isComplete)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Courses.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Courses.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Employees.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Employees.Name)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.EmployeeCourseID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
