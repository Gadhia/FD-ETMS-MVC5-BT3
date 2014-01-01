<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>MVC 5 and Bootstrap Sample Application</title>
    @*<title>@ViewBag.Title  - MVC 5 and Bootstrap Sample Application</title>*@
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <div class="navbar navbar-default navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @*ForgDirect Employee Training Managment System*@
                @Html.ActionLink("ForgDirect : ETMS", "Index", "Home", Nothing, New With {.class = "navbar-brand primary visible-sm visible-xs"})
                @Html.ActionLink("ForgDirect Employee Training Managment System", "Index", "Home", Nothing, New With {.class = "navbar-brand hidden-sm hidden-xs"})
            </div>

            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("Home", "Index", "Home")</li>
                    <li>@Html.ActionLink("Employee Dashboard", "Index", "Employees")</li>
                    <li>@Html.ActionLink("Courses Dashboard", "Index", "Courses")</li>

                </ul> 
                
                                    <ul class="nav navbar-nav navbar-right">
                                              <li class="dropdown">
                                            <a href="#" class="dropdown-toggle" data-toggle="dropdown">About<strong class="caret"></strong></a>
                                            <ul class="dropdown-menu">
                                                <li>
                                                    <a href="#">Action</a>
                                                </li>
                                                <li>
                                                    <a href="#">Another action</a>
                                                </li>
                                                <li>
                                                    <a href="#">Something else here</a>
                                                </li>
                                                <li class="divider"></li>
                                                <li>
                                                    <a href="#">Separated link</a>
                                                </li>
                                            </ul>
                                        </li>
                                    </ul>

                    


                   

</div>
        </div>
    </div>


    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - www.GadhiaSiraj.net, All Rights Reserved.</p>       
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>


@*<li>@Html.ActionLink("EmployeeCourses", "Index", "EmployeeCourses")</li>
    <li class="dropdown dropdown-large">
        <a href="#" class="dropdown-toggle" data-toggle="dropdown">Download<b class="caret"></b></a>

        <ul class="dropdown-menu dropdown-menu-large row">
            <li class="col-sm-3">
                <ul>
                    <li>

                        <div class="panel panel-primary">
                            <div class="panel-heading">
                                <h3 class="panel-title">
                                    Download MVC application
                                </h3>
                            </div>
                            <div class="panel-body">

                                <img src="~/Content/the7-iphone.png" width="160" />
                            </div>
                            <div class="panel-footer">
                                <button type="button" class="btn btn-primary">Default</button>
                            </div>
                        </div>

                    </li>


                </ul>
            </li>
            <li class="col-sm-3">
                <ul>
                    <li class="dropdown-header">Button groups</li>
                    <li><a href="#">Basic example</a></li>
                    <li><a href="#">Button toolbar</a></li>
                    <li><a href="#">Sizing</a></li>
                    <li><a href="#">Nesting</a></li>
                    <li><a href="#">Vertical variation</a></li>
                    <li class="divider"></li>
                    <li class="dropdown-header">Button dropdowns</li>
                    <li><a href="#">Single button dropdowns</a></li>
                </ul>
            </li>
            <li class="col-sm-3">
                <ul>
                    <li class="dropdown-header">Input groups</li>
                    <li><a href="#">Basic example</a></li>
                    <li><a href="#">Sizing</a></li>
                    <li><a href="#">Checkboxes and radio addons</a></li>
                    <li class="divider"></li>
                    <li class="dropdown-header">Navs</li>
                    <li><a href="#">Tabs</a></li>
                    <li><a href="#">Pills</a></li>
                    <li><a href="#">Justified</a></li>
                </ul>
            </li>
            <li class="col-sm-3">
                <ul>
                    <li class="dropdown-header">Navbar</li>
                    <li><a href="#">Default navbar</a></li>
                    <li><a href="#">Buttons</a></li>
                    <li><a href="#">Text</a></li>
                    <li><a href="#">Non-nav links</a></li>
                    <li><a href="#">Component alignment</a></li>
                    <li><a href="#">Fixed to top</a></li>
                    <li><a href="#">Fixed to bottom</a></li>
                    <li><a href="#">Static top</a></li>
                    <li><a href="#">Inverted navbar</a></li>
                </ul>
            </li>
        </ul>

    </li>*@
