#pragma checksum "C:\Users\Pawan\Documents\DoctorPatientPortal\DoctorPatientPortal\DocPatientPortal\Views\Admin_Customers\View_Customers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e5767a7e253fb6859fd5d1403399ef194588df4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Customers_View_Customers), @"mvc.1.0.razor-page", @"/Views/Admin_Customers/View_Customers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e5767a7e253fb6859fd5d1403399ef194588df4", @"/Views/Admin_Customers/View_Customers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f9966a5f75c439dee45931d539b07351b3cdd91", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Customers_View_Customers : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Pawan\Documents\DoctorPatientPortal\DoctorPatientPortal\DocPatientPortal\Views\Admin_Customers\View_Customers.cshtml"
  
    Layout = "_LayoutPractice";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(document).ready(function () {\r\n            $(\'.datatablejquery\').DataTable();\r\n\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"    <br />


    <div class=""row"">
        <div class=""col-md-12 grid-margin stretch-card"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""d-sm-flex align-items-center mb-4"">
                        <h4 class=""card-title mb-sm-0"">Customer List</h4>
                    </div>
                    <table class=""table table-light table-hover datatablejquery"">
                        <thead>

                            <tr>
                                <th>sn</th>
                                <th>Name</th>
                                <th>Phone number</th>
                                <th>Email</th>
                                <th>Blood Group</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 39 "C:\Users\Pawan\Documents\DoctorPatientPortal\DoctorPatientPortal\DocPatientPortal\Views\Admin_Customers\View_Customers.cshtml"
                              
                                var i = 1;
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Pawan\Documents\DoctorPatientPortal\DoctorPatientPortal\DocPatientPortal\Views\Admin_Customers\View_Customers.cshtml"
                             foreach (var item in ViewBag.customers)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 46 "C:\Users\Pawan\Documents\DoctorPatientPortal\DoctorPatientPortal\DocPatientPortal\Views\Admin_Customers\View_Customers.cshtml"
                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 47 "C:\Users\Pawan\Documents\DoctorPatientPortal\DoctorPatientPortal\DocPatientPortal\Views\Admin_Customers\View_Customers.cshtml"
                                   Write(item.p_fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 48 "C:\Users\Pawan\Documents\DoctorPatientPortal\DoctorPatientPortal\DocPatientPortal\Views\Admin_Customers\View_Customers.cshtml"
                                   Write(item.p_contact);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 49 "C:\Users\Pawan\Documents\DoctorPatientPortal\DoctorPatientPortal\DocPatientPortal\Views\Admin_Customers\View_Customers.cshtml"
                                   Write(item.p_email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 50 "C:\Users\Pawan\Documents\DoctorPatientPortal\DoctorPatientPortal\DocPatientPortal\Views\Admin_Customers\View_Customers.cshtml"
                                   Write(item.p_blood);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 52 "C:\Users\Pawan\Documents\DoctorPatientPortal\DoctorPatientPortal\DocPatientPortal\Views\Admin_Customers\View_Customers.cshtml"
                                i++;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DocPatientPortal.Views.Admin_Doctors.View_DoctorsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DocPatientPortal.Views.Admin_Doctors.View_DoctorsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DocPatientPortal.Views.Admin_Doctors.View_DoctorsModel>)PageContext?.ViewData;
        public DocPatientPortal.Views.Admin_Doctors.View_DoctorsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
