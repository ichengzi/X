﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    
    #line 1 "..\..\Views\Shared\_LoginPartial.cshtml"
    using XCode.Membership;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_LoginPartial.cshtml")]
    public partial class _Views_Shared__LoginPartial_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__LoginPartial_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Shared\_LoginPartial.cshtml"
 if (ManageProvider.User != null)
{

            
            #line default
            #line hidden
WriteLiteral("    ");

WriteLiteral("\r\n        你好，");

            
            #line 5 "..\..\Views\Shared\_LoginPartial.cshtml"
      Write(Html.ActionLink(ManageProvider.User + "", "Info", "Admin/User", routeValues: new { id = ManageProvider.User.ID }, htmlAttributes: new { @class = "username", title = "管理" }));

            
            #line default
            #line hidden
WriteLiteral("!\r\n");

WriteLiteral("        ");

            
            #line 6 "..\..\Views\Shared\_LoginPartial.cshtml"
   Write(Html.ActionLink("注销", "Logout", "Admin/User"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");

WriteLiteral("\r\n");

            
            #line 8 "..\..\Views\Shared\_LoginPartial.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <ul>\r\n        <li>");

            
            #line 12 "..\..\Views\Shared\_LoginPartial.cshtml"
       Write(Html.ActionLink("注册", "Login", "Admin/User", routeValues: new { ReturnUrl = Request.Url, act = "Register" }, htmlAttributes: new { id = "registerLink" }));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        <li>");

            
            #line 13 "..\..\Views\Shared\_LoginPartial.cshtml"
       Write(Html.ActionLink("登录", "Login", "Admin/User", routeValues: new { ReturnUrl = Request.Url }, htmlAttributes: new { id = "loginLink" }));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n    </ul>\r\n");

            
            #line 15 "..\..\Views\Shared\_LoginPartial.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
