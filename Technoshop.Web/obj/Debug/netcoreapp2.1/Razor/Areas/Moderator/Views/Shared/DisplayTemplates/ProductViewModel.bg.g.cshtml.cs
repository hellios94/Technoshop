#pragma checksum "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Moderator\Views\Shared\DisplayTemplates\ProductViewModel.bg.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d53e36e4b67289745412fe283f179aca397c38f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Technoshop.Common.Moderator.Shared.DisplayTemplates.Areas_Moderator_Views_Shared_DisplayTemplates_ProductViewModel_bg), @"mvc.1.0.view", @"/Areas/Moderator/Views/Shared/DisplayTemplates/ProductViewModel.bg.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Moderator/Views/Shared/DisplayTemplates/ProductViewModel.bg.cshtml", typeof(Technoshop.Common.Moderator.Shared.DisplayTemplates.Areas_Moderator_Views_Shared_DisplayTemplates_ProductViewModel_bg))]
namespace Technoshop.Common.Moderator.Shared.DisplayTemplates
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Moderator\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Moderator\Views\_ViewImports.cshtml"
using Technoshop.Web.Areas.Moderator;

#line default
#line hidden
#line 3 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Moderator\Views\_ViewImports.cshtml"
using Technoshop.Models;

#line default
#line hidden
#line 4 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Moderator\Views\_ViewImports.cshtml"
using Technoshop.Common.Buyer.ViewModels;

#line default
#line hidden
#line 5 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Moderator\Views\_ViewImports.cshtml"
using Technoshop.Common.Admin.BindingModels;

#line default
#line hidden
#line 6 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Moderator\Views\_ViewImports.cshtml"
using Technoshop.Common.Admin.ViewModels;

#line default
#line hidden
#line 7 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Moderator\Views\_ViewImports.cshtml"
using Technoshop.Web.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d53e36e4b67289745412fe283f179aca397c38f3", @"/Areas/Moderator/Views/Shared/DisplayTemplates/ProductViewModel.bg.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdb62e1e73840df681ee0fbb2e9b883a7ced19d2", @"/Areas/Moderator/Views/_ViewImports.cshtml")]
    public class Areas_Moderator_Views_Shared_DisplayTemplates_ProductViewModel_bg : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Moderator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info fa fa-bars"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger fa fa-trash"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 65, true);
            WriteLiteral("\r\n<tr class=\"table-bordered\">\r\n    <th scope=\"row\">\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 90, "\"", 118, 1);
#line 5 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Moderator\Views\Shared\DisplayTemplates\ProductViewModel.bg.cshtml"
WriteAttributeValue("", 96, Model.ProductImageUrl, 96, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(119, 92, true);
            WriteLiteral(" width=\"100\" height=\"100\" />\r\n    </th>\r\n    <td class=\"text-center align-middle\">\r\n        ");
            EndContext();
            BeginContext(212, 15, false);
#line 8 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Moderator\Views\Shared\DisplayTemplates\ProductViewModel.bg.cshtml"
   Write(Model.ModelName);

#line default
#line hidden
            EndContext();
            BeginContext(227, 64, true);
            WriteLiteral("\r\n    </td>\r\n    <td class=\"text-center align-middle\">\r\n        ");
            EndContext();
            BeginContext(292, 17, false);
#line 11 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Moderator\Views\Shared\DisplayTemplates\ProductViewModel.bg.cshtml"
   Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(309, 64, true);
            WriteLiteral("\r\n    </td>\r\n    <td class=\"text-center align-middle\">\r\n        ");
            EndContext();
            BeginContext(374, 11, false);
#line 14 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Moderator\Views\Shared\DisplayTemplates\ProductViewModel.bg.cshtml"
   Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(385, 69, true);
            WriteLiteral(" лева\r\n    </td>\r\n    <td class=\"text-center align-middle\">\r\n        ");
            EndContext();
            BeginContext(454, 180, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fe37f41adf04293a43e641badfac1bf", async() => {
                BeginContext(623, 7, true);
                WriteLiteral("Детайли");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Moderator\Views\Shared\DisplayTemplates\ProductViewModel.bg.cshtml"
                                                                                 WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 17 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Moderator\Views\Shared\DisplayTemplates\ProductViewModel.bg.cshtml"
                                                                                                            WriteLiteral(Model.Slug);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-slug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(634, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(644, 188, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3e6e16295f9457fbf6c89d5931233ef", async() => {
                BeginContext(822, 6, true);
                WriteLiteral("Изтрий");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 19 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Moderator\Views\Shared\DisplayTemplates\ProductViewModel.bg.cshtml"
                                                                                       WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 19 "C:\Моите Проекти\Web Project\Technoshop\Technoshop.Web\Areas\Moderator\Views\Shared\DisplayTemplates\ProductViewModel.bg.cshtml"
                                                                                                                  WriteLiteral(Model.Slug);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-slug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(832, 17, true);
            WriteLiteral("\r\n    </td>\r\n<tr>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
