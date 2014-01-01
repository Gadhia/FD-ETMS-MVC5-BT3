@ModelType EmployeeCourses
@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>EmployeeCourses</h4>
        <hr />
        @Html.ValidationSummary(true)
        <div class="form-group">
            @Html.LabelFor(Function(model) model.EmployeeID, "EmployeeID", New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownList("EmployeeID", String.Empty)
                @Html.ValidationMessageFor(Function(model) model.EmployeeID)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CourseID, "CourseID", New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownList("CourseID", String.Empty)
                @Html.ValidationMessageFor(Function(model) model.CourseID)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.isComplete, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.isComplete)
                @Html.ValidationMessageFor(Function(model) model.isComplete)
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Create" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
