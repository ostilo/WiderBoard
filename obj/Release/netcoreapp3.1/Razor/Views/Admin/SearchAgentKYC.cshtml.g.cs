#pragma checksum "C:\Users\Elkanah Pc\source\repos\WiderBoard\Views\Admin\SearchAgentKYC.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12f49ee72694b0fcf87d996a22c9ea9648350a8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_SearchAgentKYC), @"mvc.1.0.view", @"/Views/Admin/SearchAgentKYC.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Elkanah Pc\source\repos\WiderBoard\Views\_ViewImports.cshtml"
using WiderBoard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Elkanah Pc\source\repos\WiderBoard\Views\Admin\SearchAgentKYC.cshtml"
using WiderBoard.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12f49ee72694b0fcf87d996a22c9ea9648350a8e", @"/Views/Admin/SearchAgentKYC.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d39e9aa3013fcec9431a0e09aeb0d0d99d089b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_SearchAgentKYC : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Merchant>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("small text-gray-300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none d-sm-inline-block form-inline navbar-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Elkanah Pc\source\repos\WiderBoard\Views\Admin\SearchAgentKYC.cshtml"
  
    ViewData["Title"] = "KYC Level 1";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .card {
        box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
        transition: 0.3s;
        padding: 30px;
    }

        .card:hover {
            box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2);
        }
</style>
<!-- Begin Page Content -->
<div class=""container-fluid"">
    <!-- Page Heading -->
    <h1 class=""h3 mb-1 text-gray-800"">Search Agent </h1>
    <p class=""mb-4"">
        Bootstrap's default utility classes can be found on the official <a href=""https://getbootstrap.com/docs"">Bootstrap Documentation</a> page. The custom utilities
        below were created to extend this theme past the default utility classes built into Bootstrap's
        framework.
    </p>
    <br />
    <!-- Page Heading -->
    <div class=""card"">

        <div class=""form-row"">
            <div class=""form-group col-md-5"">
                <label class=""small text-gray-600"" for=""leadCapLastName"">Search By: </label>
                <fieldset>
                    <select class=""form-control"" name=""p");
            WriteLiteral("rogramme\" id=\"amt\" required selected=\"selected\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12f49ee72694b0fcf87d996a22c9ea9648350a8e6357", async() => {
                WriteLiteral("-- Search By --");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12f49ee72694b0fcf87d996a22c9ea9648350a8e7943", async() => {
                WriteLiteral("TID");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12f49ee72694b0fcf87d996a22c9ea9648350a8e9123", async() => {
                WriteLiteral("Merchant Name ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </select>\r\n                </fieldset>\r\n            </div>\r\n\r\n            <div class=\"form-group col-md-7\">\r\n\r\n                <br/>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12f49ee72694b0fcf87d996a22c9ea9648350a8e10476", async() => {
                WriteLiteral(@"
                    <div class=""input-group"">
                        <input type=""text"" class=""form-control bg-light border-0 small"" placeholder=""Search for...""
                               aria-label=""Search"" aria-describedby=""basic-addon2"">
                        <div class=""input-group-append"">
                            <button class=""btn btn-primary"" type=""button"">
                                <i class=""fas fa-search fa-sm""></i>
                            </button>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


            </div>

        </div>
    </div>
    <br />
    <div class=""card"">
        <br />
        <div class=""modal-body"">
            <div class=""row"">
                <div class=""col-md-12 col-lg-6 "">

                    <div class=""form-group form-focus"">
                        <label class=""focus-label"">Home Phone </label>
                        <div class=""input-group"">
                            <span class=""input-group-addon""></span>
                            <input readonly type=""tel"" class=""form-control floating"" name=""HomePhone"">
                        </div>
                        

                    </div>
                    <div class=""form-group form-focus"">
                        <label class=""focus-label"">Work Phone </label>
                        <input type=""tel"" class=""form-control floating"" name=""WorkPhone"">

                    </div>
                    <div class=""form-group form-focus"">
                        <label class=""focus-label""");
            WriteLiteral(@">Mobile Phone </label>
                        <input type=""tel"" class=""form-control floating"" name=""MobilePhone"">

                    </div>
                    <div class=""form-group form-focus"">
                        <label class=""focus-label"">MediCare No </label>
                        <input type=""text"" class=""form-control floating"" name=""MediCareNo"">

                    </div>
                    <div class=""form-group form-focus"">
                        <label class=""focus-label"">MediCare LineNo </label>
                        <input type=""text"" class=""form-control floating"" name=""MediCareLineNo"">

                    </div>
                    <div class=""form-group form-focus"">
                        <label class=""focus-label"">Email </label>
                        <input type=""email"" class=""form-control floating"" name=""Email"">

                    </div>
                    <div class=""form-group form-focus"">
                        <label class=""focus-label"">Username</la");
            WriteLiteral(@"bel>
                        <input type=""text"" class=""form-control floating"" name=""uname"">

                    </div>
                    <div class=""form-group form-focus"">
                        <label class=""focus-label"">Password</label>
                        <input type=""password"" class=""form-control floating"" name=""pass"">

                    </div>
                </div>
                <div class=""col-md-12 col-lg-6 "">

                    <div class=""form-group form-focus"">
                        <label class=""focus-label"">Home Phone </label>
                        <input type=""tel"" class=""form-control floating"" name=""HomePhone"">

                    </div>
                    <div class=""form-group form-focus"">
                        <label class=""focus-label"">Work Phone </label>
                        <input type=""tel"" class=""form-control floating"" name=""WorkPhone"">

                    </div>
                    <div class=""form-group form-focus"">
                   ");
            WriteLiteral(@"     <label class=""focus-label"">Mobile Phone </label>
                        <input type=""tel"" class=""form-control floating"" name=""MobilePhone"">

                    </div>
                    <div class=""form-group form-focus"">
                        <label class=""focus-label"">MediCare No </label>
                        <input type=""text"" class=""form-control floating"" name=""MediCareNo"">

                    </div>
                    <div class=""form-group form-focus"">
                        <label class=""focus-label"">MediCare LineNo </label>
                        <input type=""text"" class=""form-control floating"" name=""MediCareLineNo"">

                    </div>
                    <div class=""form-group form-focus"">
                        <label class=""focus-label"">Email </label>
                        <input type=""email"" class=""form-control floating"" name=""Email"">

                    </div>
                    <div class=""form-group form-focus"">
                        <label c");
            WriteLiteral(@"lass=""focus-label"">Username</label>
                        <input type=""text"" class=""form-control floating"" name=""uname"">

                    </div>
                    <div class=""form-group form-focus"">
                        <label class=""focus-label"">Password</label>
                        <input type=""password"" class=""form-control floating"" name=""pass"">

                    </div>
                </div>
            </div>

        </div>




    </div>

</div>
 ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Merchant>> Html { get; private set; }
    }
}
#pragma warning restore 1591
