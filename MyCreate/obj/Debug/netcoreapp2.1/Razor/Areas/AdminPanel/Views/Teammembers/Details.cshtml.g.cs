#pragma checksum "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\Teammembers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "defff822cc4a0d3aa124d881d79baac650f23bd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Teammembers_Details), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Teammembers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AdminPanel/Views/Teammembers/Details.cshtml", typeof(AspNetCore.Areas_AdminPanel_Views_Teammembers_Details))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\_ViewImports.cshtml"
using MyCreate;

#line default
#line hidden
#line 2 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\_ViewImports.cshtml"
using MyCreate.model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"defff822cc4a0d3aa124d881d79baac650f23bd7", @"/Areas/AdminPanel/Views/Teammembers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"740999e1c5f99042b6870d9b6c7159674e777e28", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_Teammembers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyCreate.model.Teammember>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DetailsPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(74, 176, true);
            WriteLiteral("\n<h2>Details</h2>\n<div class=\"au-card recent-report\">\n    <div>\n\n        <h4>Teammember</h4>\n        <hr />\n        <dl class=\"dl-horizontal\">\n            <dt>\n                ");
            EndContext();
            BeginContext(251, 40, false);
#line 15 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(291, 52, true);
            WriteLiteral("\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(344, 36, false);
#line 18 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(380, 52, true);
            WriteLiteral("\n            </dd>\n            <dt>\n                ");
            EndContext();
            BeginContext(433, 39, false);
#line 21 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Jop));

#line default
#line hidden
            EndContext();
            BeginContext(472, 52, true);
            WriteLiteral("\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(525, 35, false);
#line 24 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayFor(model => model.Jop));

#line default
#line hidden
            EndContext();
            BeginContext(560, 52, true);
            WriteLiteral("\n            </dd>\n            <dt>\n                ");
            EndContext();
            BeginContext(613, 41, false);
#line 27 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(654, 52, true);
            WriteLiteral("\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(707, 37, false);
#line 30 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(744, 52, true);
            WriteLiteral("\n            </dd>\n            <dt>\n                ");
            EndContext();
            BeginContext(797, 43, false);
#line 33 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.twitter));

#line default
#line hidden
            EndContext();
            BeginContext(840, 52, true);
            WriteLiteral("\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(893, 39, false);
#line 36 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayFor(model => model.twitter));

#line default
#line hidden
            EndContext();
            BeginContext(932, 52, true);
            WriteLiteral("\n            </dd>\n            <dt>\n                ");
            EndContext();
            BeginContext(985, 44, false);
#line 39 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Facebook));

#line default
#line hidden
            EndContext();
            BeginContext(1029, 52, true);
            WriteLiteral("\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(1082, 40, false);
#line 42 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayFor(model => model.Facebook));

#line default
#line hidden
            EndContext();
            BeginContext(1122, 52, true);
            WriteLiteral("\n            </dd>\n            <dt>\n                ");
            EndContext();
            BeginContext(1175, 45, false);
#line 45 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.instagram));

#line default
#line hidden
            EndContext();
            BeginContext(1220, 52, true);
            WriteLiteral("\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(1273, 41, false);
#line 48 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayFor(model => model.instagram));

#line default
#line hidden
            EndContext();
            BeginContext(1314, 52, true);
            WriteLiteral("\n            </dd>\n            <dt>\n                ");
            EndContext();
            BeginContext(1367, 44, false);
#line 51 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.whatsapp));

#line default
#line hidden
            EndContext();
            BeginContext(1411, 52, true);
            WriteLiteral("\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(1464, 40, false);
#line 54 "C:\Users\jalla\OneDrive\Desktop\Our Group\Our Group\MyCreate\Areas\AdminPanel\Views\Teammembers\Details.cshtml"
           Write(Html.DisplayFor(model => model.whatsapp));

#line default
#line hidden
            EndContext();
            BeginContext(1504, 140, true);
            WriteLiteral("\n            </dd>\n        </dl>\n    </div>\n    <div>\n        <div class=\"form-group row\">\n            <div class=\"col-5 \">\n                ");
            EndContext();
            BeginContext(1644, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8130ab7bb884437b81127dda19f33c16", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1675, 52, true);
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyCreate.model.Teammember> Html { get; private set; }
    }
}
#pragma warning restore 1591