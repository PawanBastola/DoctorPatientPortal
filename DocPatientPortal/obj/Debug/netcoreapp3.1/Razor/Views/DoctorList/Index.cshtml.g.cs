#pragma checksum "E:\Projects\DocPatientPortal\DocPatientPortal\Views\DoctorList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c9ff0d5df4508f5246f436bc08bb2cc542bb4bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DoctorList_Index), @"mvc.1.0.razor-page", @"/Views/DoctorList/Index.cshtml")]
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
#line 1 "E:\Projects\DocPatientPortal\DocPatientPortal\Views\_ViewImports.cshtml"
using DocPatientPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\DocPatientPortal\DocPatientPortal\Views\_ViewImports.cshtml"
using DocPatientPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c9ff0d5df4508f5246f436bc08bb2cc542bb4bd", @"/Views/DoctorList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f9966a5f75c439dee45931d539b07351b3cdd91", @"/Views/_ViewImports.cshtml")]
    public class Views_DoctorList_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Projects\DocPatientPortal\DocPatientPortal\Views\DoctorList\Index.cshtml"
  
    Layout = "_LayoutPatient";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(document).ready(function () {\r\n            $(\'#datatable\').DataTable();\r\n\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"<table class=""table table-secondary table-hover "" id=""datatable"">
    <thead>

        <tr>
            <th>sn</th>
            <th>Name</th>
            <th>Speciality</th>
            <th>Phone number</th>
            <th>Email</th>

        </tr>
    </thead>
    <tbody>
        <tr>
            <td>1</td>
            <td>abcd</td>
            <td>Bone</td>
            <td>+91 9845784125</td>
            <td>abcd@gmail.com</td>

        </tr>
        <tr>
            <td>2</td>
            <td>efgh</td>
            <td>Skin</td>
            <td>+91 984556825</td>
            <td>efgh@gmail.com</td>

        </tr>
    </tbody>
</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DocPatientPortal.Views.DoctorList.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DocPatientPortal.Views.DoctorList.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DocPatientPortal.Views.DoctorList.IndexModel>)PageContext?.ViewData;
        public DocPatientPortal.Views.DoctorList.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
