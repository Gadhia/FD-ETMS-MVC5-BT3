@ModelType Courses

@code
    If Model.isDisable Then
         @Html.CheckBox("dis-Model" + Model.CourseID.ToString(), True, New With {.disabled = "disabled"}) 
         @Html.HiddenFor(Function(Model) Model.isSelect)
    Else
       @Html.CheckBoxFor(Function(Model) Model.isSelect) 
    End If
End Code

&nbsp;
@Html.DisplayFor(Function(Model) Model.Code) : @Html.DisplayFor(Function(Model) Model.Name)
    
@code
    If Model.isDisable Then
        @:<span class="label label-success">Completed</span>
    End If
End Code



<br />
@Html.HiddenFor(Function(Model) Model.CourseID)
@Html.HiddenFor(Function(Model) Model.isDisable)
@Html.HiddenFor(Function(Model) Model.Code) 
@Html.HiddenFor(Function(Model) Model.Name)
