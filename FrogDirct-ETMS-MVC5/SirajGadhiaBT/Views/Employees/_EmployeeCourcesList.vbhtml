@ModelType IEnumerable(Of EmployeeCourses)


                @Code
                    For Each item In Model

                        If item.isComplete Then

                @*@:<img src="../../Content/true.gif" />*@

                 @: <span class="glyphicon glyphicon-ok"></span>&nbsp;&nbsp;
                      Else
                  @*@:    <img src="../../Content/false.gif" />*@
                            
                             @: <span class="glyphicon glyphicon-remove"></span>&nbsp;&nbsp;




End If

    @item.Courses.Code @:&nbsp; - @item.Courses.Name




    @:      <br />
                    Next
End Code




