#pragma checksum "C:\Users\angelo\Desktop\Svi Folderi!\4_godina_I_semestar\.NET\Covid19WebApp\Covid19WebApp\wwwroot\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52d85c2fd18b4c522e2796b9fa4b1ffee652657a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.wwwroot_Create), @"mvc.1.0.view", @"/wwwroot/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d85c2fd18b4c522e2796b9fa4b1ffee652657a", @"/wwwroot/Create.cshtml")]
    public class wwwroot_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Covid19WebApp.Models.Covid>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\angelo\Desktop\Svi Folderi!\4_godina_I_semestar\.NET\Covid19WebApp\Covid19WebApp\wwwroot\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Covid</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Oib"" class=""control-label""></label>
                <input asp-for=""Oib"" class=""form-control"" />
                <span asp-validation-for=""Oib"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ImePrezime"" class=""control-label""></label>
                <input asp-for=""ImePrezime"" class=""form-control"" />
                <span asp-validation-for=""ImePrezime"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""rezultatiTesta"" class=""control-label""></label>
                <input asp-for=""rezultatiTesta"" class=""form-control"" />
                <span asp-validation-for=""rezultatiTesta"" class=""text-dang");
            WriteLiteral(@"er""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Users\angelo\Desktop\Svi Folderi!\4_godina_I_semestar\.NET\Covid19WebApp\Covid19WebApp\wwwroot\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Covid19WebApp.Models.Covid> Html { get; private set; }
    }
}
#pragma warning restore 1591
