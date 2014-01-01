@ModelType Employees
@Code
    Dim hire_date As String = Model.HireDate.ToString("d")
    Dim _Sucess As Integer = Model.EmployeeCourses.Where(Function(d) d.isComplete = True).Count
    Dim _cource_count As Integer = Model.EmployeeCourses.Count
    Dim panel_class As String = "panel-info"
    
    If _Sucess = 0 Then
        panel_class = "panel-danger"
    End If
    
    If _Sucess = _cource_count Then
        panel_class = "panel-success"
    End If
End Code



    <div class="panel @panel_class">
        <!-- Default panel contents -->
        <div class="panel-heading">
            @*<span class="badge">@ViewBag.Number</span>*@  
            <span class="glyphicon glyphicon-user"></span> <b>@ViewBag.Number - @Html.DisplayFor(Function(model) model.Name)</b> (@hire_date)
            &nbsp;@Html.ActionLink("Edit", "Edit", New With {.id = Model.EmployeeID}, New With {.class = "btn btn-xs btn-primary"})
             <span class="badge  pull-right hidden-xs">@_Sucess / @Model.EmployeeCourses.Count</span>
</div>

        <!-- Table -->
        <div class="table-responsive">
            <table class="table table-hover table-condensed table-bordered table-responsive">
                <thead>
                    <tr class="warning" align="center">
                        
                        <th align="center" class="hidden-xs">
                            
                        </th>
                        <th align="center">
                            Status
                        </th>
                        <th align="center">
                            Course Code
                        </th>
                        <th class="hidden-sm hidden-xs">
                            Course Name
                        </th>
                        <th align="center">Action</th>
                    </tr>
                </thead>
                <tbody>

                    @Code
                        Dim i As Integer = 1
                        For Each item In Model.EmployeeCourses
                            If item.isComplete Then
                        @:<tr class="success"> <td align="center" class="hidden-xs"> 
                                                                                                Else
    @:<tr class="default"> <td align="center" class="hidden-xs">
                                                                                            End If

                                    @:<span class="badge">
                    @i

                    @:                </span>            </td> <td align="center">
                                                                                            If item.isComplete Then
    @:<span class="glyphicon glyphicon-ok"></span>&nbsp;&nbsp;
                                                                                            Else
    @:<span class="glyphicon glyphicon-remove"></span>&nbsp;&nbsp;
                                                                                            End If

    @:</td><td align="center"><b>
                    @item.Courses.Code
                    @:</b>          </td> <td class="hidden-sm hidden-xs">
                    @item.Courses.Name
                    @:   </td><td>


                            If item.isComplete Then
                    @Html.ActionLink("Mark Pending", "uncomplete", New With {.id = item.EmployeeCourseID}, New With {.class = "btn btn-xs btn-default"})
                            Else
                    @Html.ActionLink("Mark Complete", "complete", New With {.id = item.EmployeeCourseID}, New With {.class = "btn btn-xs btn-success"})
                            End If



                    @:</td> </tr>
                        i = i + 1
                        Next
                    End Code

                </tbody>
            </table>


        </div>
