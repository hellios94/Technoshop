#pragma checksum "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Admin\Views\Shared\DisplayTemplates\UserDetailsViewModel.bg.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "681e10b3cbde7ed507372da233ede5b9db7f1962"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Technoshop.Common.Admin.Shared.DisplayTemplates.Areas_Admin_Views_Shared_DisplayTemplates_UserDetailsViewModel_bg), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/DisplayTemplates/UserDetailsViewModel.bg.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/DisplayTemplates/UserDetailsViewModel.bg.cshtml", typeof(Technoshop.Common.Admin.Shared.DisplayTemplates.Areas_Admin_Views_Shared_DisplayTemplates_UserDetailsViewModel_bg))]
namespace Technoshop.Common.Admin.Shared.DisplayTemplates
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Technoshop.Web.Areas.Admin;

#line default
#line hidden
#line 3 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Technoshop.Models;

#line default
#line hidden
#line 4 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Technoshop.Common.Buyer.ViewModels;

#line default
#line hidden
#line 5 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Technoshop.Common.Admin.BindingModels;

#line default
#line hidden
#line 6 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Technoshop.Common.Admin.ViewModels;

#line default
#line hidden
#line 7 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Technoshop.Web.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"681e10b3cbde7ed507372da233ede5b9db7f1962", @"/Areas/Admin/Views/Shared/DisplayTemplates/UserDetailsViewModel.bg.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e4e36aa0aaa97c8b6a937f4cf2a9e3a18b7d441", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_DisplayTemplates_UserDetailsViewModel_bg : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 9, true);
            WriteLiteral("\r\n<p><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 38, "\"", 60, 1);
#line 3 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Admin\Views\Shared\DisplayTemplates\UserDetailsViewModel.bg.cshtml"
WriteAttributeValue("", 44, Model.AvatarUrl, 44, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(61, 73, true);
            WriteLiteral(" height=\"200\" width=\"200\" /></p>\r\n<p><strong>Потребителско име:</strong> ");
            EndContext();
            BeginContext(135, 14, false);
#line 4 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Admin\Views\Shared\DisplayTemplates\UserDetailsViewModel.bg.cshtml"
                                  Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(149, 35, true);
            WriteLiteral("</p>\r\n<p><strong>Емейл:</strong> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 184, "\"", 212, 2);
            WriteAttributeValue("", 191, "mailto://", 191, 9, true);
#line 5 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Admin\Views\Shared\DisplayTemplates\UserDetailsViewModel.bg.cshtml"
WriteAttributeValue("", 200, Model.Email, 200, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(213, 5, true);
            WriteLiteral("></a>");
            EndContext();
            BeginContext(219, 11, false);
#line 5 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Admin\Views\Shared\DisplayTemplates\UserDetailsViewModel.bg.cshtml"
                                                          Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(230, 41, true);
            WriteLiteral("</p>\r\n<p><strong>Собствено име:</strong> ");
            EndContext();
            BeginContext(272, 15, false);
#line 6 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Admin\Views\Shared\DisplayTemplates\UserDetailsViewModel.bg.cshtml"
                              Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(287, 35, true);
            WriteLiteral("</p>\r\n<p><strong>Фамилия:</strong> ");
            EndContext();
            BeginContext(323, 14, false);
#line 7 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Admin\Views\Shared\DisplayTemplates\UserDetailsViewModel.bg.cshtml"
                        Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(337, 75, true);
            WriteLiteral("</p>\r\n<p>\r\n    <strong>Роли:</strong>\r\n    <ul>\r\n        <li>Купувач</li>\r\n");
            EndContext();
#line 12 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Admin\Views\Shared\DisplayTemplates\UserDetailsViewModel.bg.cshtml"
         if(Model.Roles.Any())
        {
            

#line default
#line hidden
#line 14 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Admin\Views\Shared\DisplayTemplates\UserDetailsViewModel.bg.cshtml"
             foreach (var role in Model.Roles)
            {


#line default
#line hidden
            BeginContext(520, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(537, 4, false);
#line 17 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Admin\Views\Shared\DisplayTemplates\UserDetailsViewModel.bg.cshtml"
           Write(role);

#line default
#line hidden
            EndContext();
            BeginContext(541, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 18 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Admin\Views\Shared\DisplayTemplates\UserDetailsViewModel.bg.cshtml"

            }

#line default
#line hidden
#line 19 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Admin\Views\Shared\DisplayTemplates\UserDetailsViewModel.bg.cshtml"
             
         }

#line default
#line hidden
            BeginContext(577, 17, true);
            WriteLiteral("    </ul>\r\n</p>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591