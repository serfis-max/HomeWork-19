#pragma checksum "E:\C#\HomwWorks\BazalukM_HomeWork_19\HomeWork_19\HW_191\Views\MyDefault\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce58a12947966a4733b3e69061358e5980702e40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyDefault_Index), @"mvc.1.0.view", @"/Views/MyDefault/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MyDefault/Index.cshtml", typeof(AspNetCore.Views_MyDefault_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce58a12947966a4733b3e69061358e5980702e40", @"/Views/MyDefault/Index.cshtml")]
    public class Views_MyDefault_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("BodyBackground"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"ru\">\r\n");
            EndContext();
            BeginContext(35, 293, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02516280dd2946928a1c980a718e047c", async() => {
                BeginContext(41, 136, true);
                WriteLiteral("\r\n  <meta charset=\"utf-8\">\r\n  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n  <title>Phone numbers</title>\r\n  ");
                EndContext();
                BeginContext(177, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "975558ce497b45e3b25fef3cdfa09630", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(226, 95, true);
                WriteLiteral("\r\n  <script>\r\n    function VoIP() {\r\n      alert(\"VoIP is unavailable.\");\r\n    }\r\n  </script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(328, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(332, 492, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42720241af044f558df738129f9751cf", async() => {
                BeginContext(361, 122, true);
                WriteLiteral("\r\n  <div>\r\n    <h1>\r\n      <span>\r\n        Phone book\r\n      </span>\r\n    </h1>\r\n  </div>\r\n\r\n  <table class=\"TableMain\">\r\n");
                EndContext();
#line 25 "E:\C#\HomwWorks\BazalukM_HomeWork_19\HomeWork_19\HW_191\Views\MyDefault\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
                BeginContext(524, 9, true);
                WriteLiteral("      <tr");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 533, "\"", 546, 1);
#line 27 "E:\C#\HomwWorks\BazalukM_HomeWork_19\HomeWork_19\HW_191\Views\MyDefault\Index.cshtml"
WriteAttributeValue("", 538, item.Id, 538, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(547, 44, true);
                WriteLiteral(">\r\n        <td align=\"center\">\r\n            ");
                EndContext();
                BeginContext(592, 7, false);
#line 29 "E:\C#\HomwWorks\BazalukM_HomeWork_19\HomeWork_19\HW_191\Views\MyDefault\Index.cshtml"
       Write(item.Id);

#line default
#line hidden
                EndContext();
                BeginContext(599, 41, true);
                WriteLiteral("\r\n        </td>\r\n        <td>\r\n          ");
                EndContext();
                BeginContext(641, 12, false);
#line 32 "E:\C#\HomwWorks\BazalukM_HomeWork_19\HomeWork_19\HW_191\Views\MyDefault\Index.cshtml"
     Write(item.Surname);

#line default
#line hidden
                EndContext();
                BeginContext(653, 41, true);
                WriteLiteral("\r\n        </td>\r\n        <td>\r\n          ");
                EndContext();
                BeginContext(695, 14, false);
#line 35 "E:\C#\HomwWorks\BazalukM_HomeWork_19\HomeWork_19\HW_191\Views\MyDefault\Index.cshtml"
     Write(item.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(709, 41, true);
                WriteLiteral("\r\n        </td>\r\n        <td>\r\n          ");
                EndContext();
                BeginContext(751, 15, false);
#line 38 "E:\C#\HomwWorks\BazalukM_HomeWork_19\HomeWork_19\HW_191\Views\MyDefault\Index.cshtml"
     Write(item.Patronymic);

#line default
#line hidden
                EndContext();
                BeginContext(766, 30, true);
                WriteLiteral("\r\n        </td>\r\n      </tr>\r\n");
                EndContext();
#line 41 "E:\C#\HomwWorks\BazalukM_HomeWork_19\HomeWork_19\HW_191\Views\MyDefault\Index.cshtml"
    }

#line default
#line hidden
                BeginContext(803, 14, true);
                WriteLiteral("  </table>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(824, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591