@ModelType IEnumerable(Of Courses)

<ui class="list-group">
    @For i As Integer = 0 To Model.Count - 1
        @<li class="list-group-item">
            @Html.CheckBoxFor(Function(d) d(i).isSelect)&nbsp;@Html.DisplayFor(Function(d) d(i).Code) : @Html.DisplayFor(Function(d) d(i).Name)
        </li>
    Next
</ui>