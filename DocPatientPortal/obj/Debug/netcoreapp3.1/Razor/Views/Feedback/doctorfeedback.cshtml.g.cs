#pragma checksum "C:\Users\Pawan\Documents\DoctorPatientPortal\DoctorPatientPortal\DocPatientPortal\Views\Feedback\doctorfeedback.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d3fae544eba533ab27bc56e283269374266c781"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feedback_doctorfeedback), @"mvc.1.0.razor-page", @"/Views/Feedback/doctorfeedback.cshtml")]
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
#line 1 "C:\Users\Pawan\Documents\DoctorPatientPortal\DoctorPatientPortal\DocPatientPortal\Views\_ViewImports.cshtml"
using DocPatientPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pawan\Documents\DoctorPatientPortal\DoctorPatientPortal\DocPatientPortal\Views\_ViewImports.cshtml"
using DocPatientPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d3fae544eba533ab27bc56e283269374266c781", @"/Views/Feedback/doctorfeedback.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f9966a5f75c439dee45931d539b07351b3cdd91", @"/Views/_ViewImports.cshtml")]
    public class Views_Feedback_doctorfeedback : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Pawan\Documents\DoctorPatientPortal\DoctorPatientPortal\DocPatientPortal\Views\Feedback\doctorfeedback.cshtml"
  
    Layout = "_LayoutDoctor";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<div class=\"card\">\r\n    Feedback:\r\n    <div class=\"col-4\">\r\n        <textarea></textarea>\r\n        <a href=\"#\" class=\"btn btn-primary\">Send</a>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DocPatientPortal.Views.Feedback.doctorfeedbackModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DocPatientPortal.Views.Feedback.doctorfeedbackModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DocPatientPortal.Views.Feedback.doctorfeedbackModel>)PageContext?.ViewData;
        public DocPatientPortal.Views.Feedback.doctorfeedbackModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
