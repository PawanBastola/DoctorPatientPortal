#pragma checksum "E:\Projects\DocPatientPortal\DocPatientPortal\Views\Profile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c837c64afebbb4258b3bf690da1cca0fd0643a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Index), @"mvc.1.0.view", @"/Views/Profile/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c837c64afebbb4258b3bf690da1cca0fd0643a7", @"/Views/Profile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f9966a5f75c439dee45931d539b07351b3cdd91", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DocPatientPortal.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Projects\DocPatientPortal\DocPatientPortal\Views\Profile\Index.cshtml"
  
    Layout = "_LayoutPatient";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<div class=""mainContainer"">
    <!--first card-->
    <div class=""personalinfo-card"">
        <div class=""container"">
            <div class=""headings"">
                <p>Doctor Profile</p>
                <hr>
            </div>
            <div class=""content"">
                <div class=""leftContent"">

                    
                    <p>Name: ");
#nullable restore
#line 19 "E:\Projects\DocPatientPortal\DocPatientPortal\Views\Profile\Index.cshtml"
                        Write(ViewBag.ViewProfile.d_full_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>Gender: ");
#nullable restore
#line 20 "E:\Projects\DocPatientPortal\DocPatientPortal\Views\Profile\Index.cshtml"
                          Write(ViewBag.ViewProfile.d_gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <!--<p>Blood gp.: O+ve</p>\r\n                    <p>DOB: 1999 A.D.</p>-->\r\n                    <p>Address: ");
#nullable restore
#line 23 "E:\Projects\DocPatientPortal\DocPatientPortal\Views\Profile\Index.cshtml"
                           Write(ViewBag.ViewProfile.d_full_address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>Nationality: Nepalese</p>\r\n                    <!--<p>Weight: 55 kg.</p>\r\n                    <p>Height: 5.5\"</p>-->\r\n                    <p>Contact: ");
#nullable restore
#line 27 "E:\Projects\DocPatientPortal\DocPatientPortal\Views\Profile\Index.cshtml"
                           Write(ViewBag.ViewProfile.d_contact);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>Email: ");
#nullable restore
#line 28 "E:\Projects\DocPatientPortal\DocPatientPortal\Views\Profile\Index.cshtml"
                         Write(ViewBag.ViewProfile.d_email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>Speciality: ");
#nullable restore
#line 29 "E:\Projects\DocPatientPortal\DocPatientPortal\Views\Profile\Index.cshtml"
                              Write(ViewBag.ViewProfile.d_speciality);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n                </div>\r\n                <div class=\"rightContent\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1170, "\"", 1210, 1);
#nullable restore
#line 34 "E:\Projects\DocPatientPortal\DocPatientPortal\Views\Profile\Index.cshtml"
WriteAttributeValue("", 1176, ViewBag.ViewProfile.d_certificate, 1176, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"profilepic\" />\r\n\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DocPatientPortal.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
