#pragma checksum "C:\Users\Elkanah Pc\source\repos\WiderBoard\Views\Admin\POSSingle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26eb7527b7a79762746940065a2be17f075472bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_POSSingle), @"mvc.1.0.view", @"/Views/Admin/POSSingle.cshtml")]
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
#line 2 "C:\Users\Elkanah Pc\source\repos\WiderBoard\Views\Admin\POSSingle.cshtml"
using WiderBoard.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26eb7527b7a79762746940065a2be17f075472bd", @"/Views/Admin/POSSingle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d39e9aa3013fcec9431a0e09aeb0d0d99d089b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_POSSingle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Merchant>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Elkanah Pc\source\repos\WiderBoard\Views\Admin\POSSingle.cshtml"
  
    ViewData["Title"] = "POS Single";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>

    .center_div {
        display: flex;
        flex-direction: column;
        justify-content: center;
        align-items: center;
        text-align: center;
    }

    .card {
        box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
        transition: 0.3s;
        padding: 30px;
    }

        .card:hover {
            box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2);
        }

    .container {
        padding: 2px 16px;
    }
</style>
<!-- Begin Page Content -->
<div class=""container-fluid"">
    <!-- Page Heading -->
    <h1 class=""h3 mb-1 text-gray-800"">POS Single Upload </h1>
    <p class=""mb-4"">
        Bootstrap's default utility classes can be found on the official <a href=""https://getbootstrap.com/docs"">Bootstrap Documentation</a> page. The custom utilities
        below were created to extend this theme past the default utility classes built into Bootstrap's
        framework.
    </p>
</div>
<br />
<!-- Page Heading -->
<div class=""card"">
    <h6 class=""text-gra");
            WriteLiteral(@"y-800"">Add New POS to Record :</h6>
    <div class=""form-row"">
        <div class=""form-group col-md-5"">
            <label class=""small text-gray-600"" for=""leadCapLastName"">Enter POS Mac Address: </label>
            <input class=""form-control"" required id=""f_oaddress"" name=""f_oaddress"" type=""text"" />
        </div>
        
        <div class=""form-group col-md-2"">
            <label class=""small text-gray-600"" for=""leadCapLastName""> &nbsp;</label>
            <button style=""padding-block:10px"" class=""btn-block btn-primary""> Add</button>
        </div>
    </div>
</div>
<br />


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
