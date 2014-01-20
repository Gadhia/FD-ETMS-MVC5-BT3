@ModelType IEnumerable(Of Courses)
@Code
    Dim _str As String = "in"
End Code

    <div class="col-xs-9">
             <h3 class="hidden-xs"><span class="glyphicon glyphicon-dashboard"></span> Training Course Dashboard</h3>
        <h3 class="visible-xs">Course Dashboard</h3>
    </div>
    <div class="col-xs-3 ">
        <span class="hidden-xs">  <br /><b> @Html.ActionLink("Create a new Course", "Create", "Cources", New With {.class = "btn btn-primary pull-right "})</b></span>
        <span class="visible-xs">  <br /><b> @Html.ActionLink("Create New", "Create", "Cources", New With {.class = "btn btn-sm btn-primary "})</b></span>
    </div>



    <div class="col-xs-12 clearfix">

    <div class="panel-group" id="accordion">


        @For Each item In Model

            @code
            Dim _Sucess As Integer = item.EmployeeCourses.Where(Function(d) d.isComplete = True).Count
            End Code

            @<div class="panel panel-info">
                <div class="panel-heading">
                    <h4 class="panel-title">
                        <a data-toggle="collapse" data-parent="#accordion" href="#collapse-@item.Code">
                            <span class="glyphicon glyphicon-th-large"></span>  
                            @item.Code : @item.Name 
                            @Html.ActionLink("Edit", "Edit", New With {.id = item.CourseID}, New With {.class = "btn btn-xs btn-default"})
                        </a>
                        &nbsp; <span class="badge  pull-right hidden-xs">@_Sucess / @item.EmployeeCourses.Count</span>
                    </h4>
                </div>
                <div id="collapse-@item.Code" class="panel-collapse collapse @_str">


                    <div class="table-responsive">
                        <table class="table table-hover table-condensed table-bordered table-responsive">
                            <thead>
                                <tr class="warning">

                                    <th align="center" class="hidden-xs">

                                    </th>
                                    <th align="center">
                                        Status
                                    </th>
                                    <th align="center">
                                        Employee
                                    </th>
                                    <th align="center" class="hidden-xs">
                                        Hire On
                                    </th>
                                    <th align="center">Action</th>
                                </tr>
                            </thead>
                            <tbody>
                                @code
                                Dim i As Integer = 1
                                End Code
                                @For Each item2 In item.EmployeeCourses
                                    @If item2.isComplete Then
                                        @:    <tr class="success">  <td align="center" class="hidden-xs">
                                    Else

                                        @:<tr class="default"><td align="center" class="hidden-xs">
                                    End If

                                    @: <span class="badge">
                                    @i
                                    @:</span></td>
                                    @:<td align="center">
                                    @If item2.isComplete Then
                                        @:<span class="glyphicon glyphicon-ok"></span>&nbsp;&nbsp;
                                                                            Else
                                        @: <span class="glyphicon glyphicon-remove"></span>&nbsp;&nbsp;
                               End If

                                    @:            </td>                        <td>
                                    @item2.Employees.Name
                                    @:     </td>   <td class="hidden-xs">
                                    @item2.Employees.HireDate.ToString("d")
                                    @:               </td>           <td>


                                    @If item2.isComplete Then
                                        @Html.ActionLink("Mark Pending", "uncomplete", New With {.id = item2.EmployeeCourseID}, New With {.class = "btn btn-xs btn-default"})
                                    Else
                                        @Html.ActionLink("Mark Complete", "complete", New With {.id = item2.EmployeeCourseID}, New With {.class = "btn btn-xs btn-success"})
                                    End If
                                    @:      </td> </tr>
                                i = i + 1
                                Next


                            </tbody>
                        </table>


                    </div>






                    @*<ul class="list-group">
                            @For Each item2 In item.EmployeeCourses
                                @<li class="list-group-item">
                                    @item2.isComplete &nbsp;&nbsp;@item2.Employees.Name
                                </li>
                            Next
                        </ul>*@

                </div>
            </div>
            _str = String.Empty
        Next
    </div>
        <br /><br />
</div>


<br /><br />


@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
<!-- Modal -->
