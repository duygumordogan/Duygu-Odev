#pragma checksum "C:\Users\Duygu\Desktop\duygu ödev\Duygu-Odev\DuyguOdev\Views\Departments\StudentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e547c5d2a0b33292d0924ee4eaa0a16b8f8fa9c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departments_StudentList), @"mvc.1.0.view", @"/Views/Departments/StudentList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Departments/StudentList.cshtml", typeof(AspNetCore.Views_Departments_StudentList))]
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
#line 1 "C:\Users\Duygu\Desktop\duygu ödev\Duygu-Odev\DuyguOdev\Views\_ViewImports.cshtml"
using DuyguOdev;

#line default
#line hidden
#line 2 "C:\Users\Duygu\Desktop\duygu ödev\Duygu-Odev\DuyguOdev\Views\_ViewImports.cshtml"
using DuyguOdev.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e547c5d2a0b33292d0924ee4eaa0a16b8f8fa9c0", @"/Views/Departments/StudentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fac4f89f22dc51fcca748de42ee17ea96a29707c", @"/Views/_ViewImports.cshtml")]
    public class Views_Departments_StudentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DuyguOdev.Models.Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Duygu\Desktop\duygu ödev\Duygu-Odev\DuyguOdev\Views\Departments\StudentList.cshtml"
  
    ViewData["Title"] = "StudentList";

#line default
#line hidden
            BeginContext(95, 35, true);
            WriteLiteral("\r\n<h1>StudentList</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(130, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e547c5d2a0b33292d0924ee4eaa0a16b8f8fa9c03910", async() => {
                BeginContext(153, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(167, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(260, 40, false);
#line 16 "C:\Users\Duygu\Desktop\duygu ödev\Duygu-Odev\DuyguOdev\Views\Departments\StudentList.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(300, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(356, 41, false);
#line 19 "C:\Users\Duygu\Desktop\duygu ödev\Duygu-Odev\DuyguOdev\Views\Departments\StudentList.cshtml"
           Write(Html.DisplayNameFor(model => model.StuID));

#line default
#line hidden
            EndContext();
            BeginContext(397, 39, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n");
            EndContext();
            BeginContext(505, 84, true);
            WriteLiteral("            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\Duygu\Desktop\duygu ödev\Duygu-Odev\DuyguOdev\Views\Departments\StudentList.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(621, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(670, 39, false);
#line 31 "C:\Users\Duygu\Desktop\duygu ödev\Duygu-Odev\DuyguOdev\Views\Departments\StudentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(709, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(765, 40, false);
#line 34 "C:\Users\Duygu\Desktop\duygu ödev\Duygu-Odev\DuyguOdev\Views\Departments\StudentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.StuID));

#line default
#line hidden
            EndContext();
            BeginContext(805, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
            BeginContext(915, 37, true);
            WriteLiteral("            </td>\r\n            <td>\r\n");
            EndContext();
            BeginContext(1108, 4, true);
            WriteLiteral(" |\r\n");
            EndContext();
            BeginContext(1191, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 45 "C:\Users\Duygu\Desktop\duygu ödev\Duygu-Odev\DuyguOdev\Views\Departments\StudentList.cshtml"
}

#line default
#line hidden
            BeginContext(1228, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DuyguOdev.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
