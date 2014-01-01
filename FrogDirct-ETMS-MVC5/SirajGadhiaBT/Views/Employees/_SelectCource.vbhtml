@ModelType IEnumerable(Of Courses)



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

    @For Each item In Model
        @<tr>
             <td>
                 @Html.CheckBox("", item.isSelect)
             </td>
            <td>
                @item.Code
            </td>
            <td>
                @item.Name
            </td>
            @*<td>
                @item.Description
            </td>*@
        </tr>
    Next

</table>
