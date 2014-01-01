@ModelType Courses


@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <h4>Courses</h4>
        <hr />
        @Html.ValidationSummary(True)
        <div class="form-group">
            @Html.LabelFor(Function(model) model.Name, New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Name)
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
                @Html.EditorFor(Function(model) model.Description)
                @Html.ValidationMessageFor(Function(model) model.Description)
            </div>
        </div>

        @*<div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Create" class="btn btn-default" />
            </div>
        </div>*@
    </div>
End Using




