@ModelType Employees
<br />


<div class="panel panel-primary">
    <div class="panel-heading">
        <h2 class="panel-title"><b>Edit a course assignment:</b></h2>
    </div>

    <div class="panel-body">
        @Using (Html.BeginForm())
            @Html.AntiForgeryToken()

            @<div class="form-horizontal">
                @Html.ValidationSummary(True)

                <div class="form-group">
                    @Html.LabelFor(Function(model) model.HireDate, New With {.class = "control-label col-md-2"})
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.HireDate) @Html.HiddenFor(Function(Model) Model.EmployeeID)
                        @Html.ValidationMessageFor(Function(model) model.HireDate)
                    </div>
                </div>

                <div class="form-group">
                    @Html.LabelFor(Function(model) model.Name, New With {.class = "control-label col-md-2"})
                    <div class="col-md-10">
                        @Html.TextBoxFor(Function(model) model.Name, New With {.class = "col-md-10"})
                        @Html.ValidationMessageFor(Function(model) model.Name)
                    </div>
                </div>

                <div class="form-group">
                    @Html.LabelFor(Function(model) model.CourseList, New With {.class = "control-label col-md-2"})
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.CourseList)
                        @Html.ValidationMessageFor(Function(model) model.CourseList)
                        @*@Html.Partial("_CoursesList", Model.CourseList)*@
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


