@ModelType IEnumerable(Of Courses)
@Code
    ViewData("Title") = "Index"
    Dim _str As String = "in"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>



<div class="panel-group" id="accordion">


@For Each item In Model
    @<div class="panel panel-info">
        <div class="panel-heading">
            <h4 class="panel-title">
                @*<a data-toggle="collapse" data-parent="#accordion" href="#collapse-@item.Code">
                    <span class="glyphicon glyphicon-th-list">&nbsp;</span>  @item.Code : @item.Name <span class="badge  pull-right">@item.EmployeeCourses.Count</span>
                </a>*@
                <span class="glyphicon glyphicon-th-list"></span>  @item.Code : @item.Name <span class="badge  pull-right">@item.EmployeeCourses.Count</span>

            </h4>
        </div>
         <div id="collapse-@item.Code" class="panel-collapse collapse @_str">
             @*<div class="panel-body">
                 <p>Employee:</p>
                 <span class="badge">@item.EmployeeCourses.Count</span>
             </div>*@
        
             <ul class="list-group">
                 @For Each item2 In item.EmployeeCourses
                     @<li class="list-group-item">
                         @item2.isComplete &nbsp;&nbsp;@item2.Employees.Name
                     </li>
                 Next
             </ul>
                
             </div>
    </div>
                         _str = String.Empty
                     Next
</div>


@*<div class="table-responsive">
    <table class="table table-hover table-condensed table-bordered table-responsive">
        <thead>
            <tr><th>Employee Name</th></tr>
        </thead>
        @For Each item2 In item.EmployeeCourses

            @<tr>
                <td>
                    @item2.isComplete &nbsp;&nbsp;
                    @item2.Employees.Name
                </td>
            </tr>
        Next
    </table>
</div>*@