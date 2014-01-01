@Code
    If Model Is Nothing Then
    @Html.TextBox("", String.Empty, New With {.class = "datepicker"})
Else
    @Html.TextBox("", String.Format("{0:d}", Model.Date.ToShortDateString()), New With {.class = "datepicker"})
End If
End Code