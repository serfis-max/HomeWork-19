#pragma checksum "E:\C#\HomwWorks\BazalukM_HomeWork_19\HomeWork_19\HW_192\Views\MyDefault\UsersInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ffd40f05b5b604f0a7c99437dcac4c5fd5b3181"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyDefault_UsersInfo), @"mvc.1.0.view", @"/Views/MyDefault/UsersInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MyDefault/UsersInfo.cshtml", typeof(AspNetCore.Views_MyDefault_UsersInfo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ffd40f05b5b604f0a7c99437dcac4c5fd5b3181", @"/Views/MyDefault/UsersInfo.cshtml")]
    public class Views_MyDefault_UsersInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/img/PhoneBook.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(35, 201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6db225d8f3164bc8803c45a71ff6a0aa", async() => {
                BeginContext(41, 116, true);
                WriteLiteral("\r\n  <meta charset=\"utf-8\">\r\n  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n  <title>User_");
                EndContext();
                BeginContext(158, 8, false);
#line 6 "E:\C#\HomwWorks\BazalukM_HomeWork_19\HomeWork_19\HW_192\Views\MyDefault\UsersInfo.cshtml"
         Write(Model.Id);

#line default
#line hidden
                EndContext();
                BeginContext(166, 12, true);
                WriteLiteral("</title>\r\n  ");
                EndContext();
                BeginContext(178, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "47a5c5356e804c798f8852dd47baccfb", async() => {
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
                BeginContext(227, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(236, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(240, 740, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7b30f6f2ebb43bd8417f9c8a58fc648", async() => {
                BeginContext(246, 15, true);
                WriteLiteral("\r\n  <div>\r\n    ");
                EndContext();
                BeginContext(261, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a8b1acdfbb1f42e48b824a2514484f1c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(331, 52, true);
                WriteLiteral("\r\n    <h1 class=\"HeaderAbs\">\r\n      <span>\r\n        ");
                EndContext();
                BeginContext(384, 8, false);
#line 15 "E:\C#\HomwWorks\BazalukM_HomeWork_19\HomeWork_19\HW_192\Views\MyDefault\UsersInfo.cshtml"
   Write(Model.Id);

#line default
#line hidden
                EndContext();
                BeginContext(392, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(394, 13, false);
#line 15 "E:\C#\HomwWorks\BazalukM_HomeWork_19\HomeWork_19\HW_192\Views\MyDefault\UsersInfo.cshtml"
             Write(Model.Surname);

#line default
#line hidden
                EndContext();
                BeginContext(407, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(409, 15, false);
#line 15 "E:\C#\HomwWorks\BazalukM_HomeWork_19\HomeWork_19\HW_192\Views\MyDefault\UsersInfo.cshtml"
                            Write(Model.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(424, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(426, 16, false);
#line 15 "E:\C#\HomwWorks\BazalukM_HomeWork_19\HomeWork_19\HW_192\Views\MyDefault\UsersInfo.cshtml"
                                             Write(Model.Patronymic);

#line default
#line hidden
                EndContext();
                BeginContext(442, 146, true);
                WriteLiteral("\r\n      </span>\r\n    </h1>\r\n  </div>\r\n\r\n  <table class=\"TableUser\">\r\n    <tr>\r\n      <td>\r\n        Phone number\r\n      </td>\r\n      <td>\r\n        ");
                EndContext();
                BeginContext(589, 17, false);
#line 26 "E:\C#\HomwWorks\BazalukM_HomeWork_19\HomeWork_19\HW_192\Views\MyDefault\UsersInfo.cshtml"
   Write(Model.PhoneNumber);

#line default
#line hidden
                EndContext();
                BeginContext(606, 97, true);
                WriteLiteral("\r\n      </td>\r\n    </tr>\r\n    <tr>\r\n      <td>\r\n        Adress\r\n      </td>\r\n      <td>\r\n        ");
                EndContext();
                BeginContext(704, 12, false);
#line 34 "E:\C#\HomwWorks\BazalukM_HomeWork_19\HomeWork_19\HW_192\Views\MyDefault\UsersInfo.cshtml"
   Write(Model.Adress);

#line default
#line hidden
                EndContext();
                BeginContext(716, 102, true);
                WriteLiteral("\r\n      </td>\r\n    </tr>\r\n    <tr>\r\n      <td>\r\n        Description\r\n      </td>\r\n      <td>\r\n        ");
                EndContext();
                BeginContext(819, 17, false);
#line 42 "E:\C#\HomwWorks\BazalukM_HomeWork_19\HomeWork_19\HW_192\Views\MyDefault\UsersInfo.cshtml"
   Write(Model.Description);

#line default
#line hidden
                EndContext();
                BeginContext(836, 137, true);
                WriteLiteral("\r\n      </td>\r\n    </tr>\r\n  </table>\r\n\r\n  <p>\r\n    <input class=\"Button\" type=\"button\" onclick=\"history.back();\" value=\"Назад\">\r\n  </p>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(980, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
