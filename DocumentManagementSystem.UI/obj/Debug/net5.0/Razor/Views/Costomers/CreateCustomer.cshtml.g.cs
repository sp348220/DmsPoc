#pragma checksum "D:\LapTop\document-management-system\DocumentManagementSystem.UI\Views\Costomers\CreateCustomer.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "cd175c43ee35d6840eab6016f47611f740f4068bf03ae16a2cfac33b4174bc36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Costomers_CreateCustomer), @"mvc.1.0.view", @"/Views/Costomers/CreateCustomer.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "D:\LapTop\document-management-system\DocumentManagementSystem.UI\Views\_ViewImports.cshtml"
using DocumentManagementSystem.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\LapTop\document-management-system\DocumentManagementSystem.UI\Views\_ViewImports.cshtml"
using DocumentManagementSystem.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"cd175c43ee35d6840eab6016f47611f740f4068bf03ae16a2cfac33b4174bc36", @"/Views/Costomers/CreateCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1a18de8055096d203ad421445364a0fe8bb7a9415f3f7c821b21286facfe9f7d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Costomers_CreateCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 11 "D:\LapTop\document-management-system\DocumentManagementSystem.UI\Views\Costomers\CreateCustomer.cshtml"
  
    ViewData["Title"] = "Create Customer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Create Customer</h2>\r\n\r\n");
#nullable restore
#line 17 "D:\LapTop\document-management-system\DocumentManagementSystem.UI\Views\Costomers\CreateCustomer.cshtml"
 using (Html.BeginForm("Create", "Customer", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <input type=""text"" id=""Name"" name=""Name"" class=""form-control"" placeholder=""Name"" />
    <input type=""text"" id=""Address"" name=""Address"" class=""form-control"" placeholder=""Address"" />
    <input type=""text"" id=""MobileNumber"" name=""MobileNumber"" class=""form-control"" placeholder=""Mobile Number"" />
    <input type=""text"" id=""Budget"" name=""Budget"" class=""form-control"" placeholder=""Budget"" />
");
            WriteLiteral("    <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n");
#nullable restore
#line 25 "D:\LapTop\document-management-system\DocumentManagementSystem.UI\Views\Costomers\CreateCustomer.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591