<div>

    <table class="table">
        <tr>
            <th>
                Select?
            <th>
                Code
            </th>
            <th>
                Name
            </th>
        </tr>

        @For i As Integer = 0 To Model.CourseList.Count - 1
            'Dim Model2 As Object = Model.CourseList(i)
            @<tr>
                <td>
                    @*@Html.CheckBox("test", Model.CourseList(i).isSelect)*@
@Html.CheckBoxFor(Function(Model) Model.CourseList(i).isSelect)

                </td>
<td>
    @*@Model.CourseList(i).Code*@
    @Html.DisplayFor(Function(Model) Model.CourseList(i).Code)
</td>
<td>
    @*@Model.CourseList(i).Name*@
    @Html.DisplayFor(Function(Model) Model.CourseList(i).Name)
</td>
@*<td>
        @item.Description
    </td>*@
            </tr>
        Next

    </table>

</div>
