@ModelType Courses
<br />


<div class="panel panel-primary">
    <div class="panel-heading">
        <h2 class="panel-title"><b>Edit a course:</b></h2>
    </div>

    <div class="panel-body">
     @Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">

        @Html.ValidationSummary(True)
        @Html.HiddenFor(Function(model) model.CourseID)

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Name, New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @*@Html.EditorFor(Function(model) model.Name)*@
                @Html.TextBoxFor(Function(model) model.Name, New With {.class = "col-md-10"})
                @Html.ValidationMessageFor(Function(model) model.Name)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Code, New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Code)
                @Html.ValidationMessageFor(Function(model) model.Code)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Description, New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @*@Html.EditorFor(Function(model) model.Description)*@
                @Html.TextAreaFor(Function(model) model.Description, New With {.class = "col-md-10"})
                @Html.ValidationMessageFor(Function(model) model.Description)
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Save" class="btn btn-primary" />
            </div>
        </div>
    </div>
End Using
    </div>

    <div class="panel-footer">

        <div>
            @Html.ActionLink("Back to Dashboard", "Index", Nothing, New With {.class = "btn btn-primary"})

        </div>
    </div>

</div>





















@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
