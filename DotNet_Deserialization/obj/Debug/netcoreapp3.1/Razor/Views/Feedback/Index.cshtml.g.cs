#pragma checksum "/Users/jigerjain/Jiger Jain/CTF_Cit/ctf/challenges/DotNet-Deserialization/DotNet_Deserialization/Views/Feedback/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1d3dad603d1d0acd9d9e58f79d5d72560c315e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feedback_Index), @"mvc.1.0.view", @"/Views/Feedback/Index.cshtml")]
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
#line 1 "/Users/jigerjain/Jiger Jain/CTF_Cit/ctf/challenges/DotNet-Deserialization/DotNet_Deserialization/Views/_ViewImports.cshtml"
using DotNet_Deserialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jigerjain/Jiger Jain/CTF_Cit/ctf/challenges/DotNet-Deserialization/DotNet_Deserialization/Views/_ViewImports.cshtml"
using DotNet_Deserialization.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1d3dad603d1d0acd9d9e58f79d5d72560c315e4", @"/Views/Feedback/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b2ebfa859fa98370ce6a717da0e6e3b77632c3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Feedback_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "/Users/jigerjain/Jiger Jain/CTF_Cit/ctf/challenges/DotNet-Deserialization/DotNet_Deserialization/Views/Feedback/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""imagebg""></div>
<div class=""row "" style=""margin-top: 50px"">
    <div class=""col-md-6 col-md-offset-3 form-container"">
        <h2>Feedback</h2>
        <p>
            Please provide your feedback below:
        </p>

        <div class=""row"">
            <div class=""col-sm-6"">
                <label for=""name"">
                    Your Name:
                </label>
                <input type=""text"" class=""form-control"" id=""name"" name=""name"" placeholder=""Name"" required>
            </div>
            <div class=""col-sm-6"">
                <label for=""email"">
                    Email:
                </label>
                <input type=""email"" class=""form-control"" id=""email"" name=""email"" placeholder=""Email"" required>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-sm-12"">
                <label for=""comments"">
                    Comments:
                </label>
                <textarea class=""form-control"" type=""textarea"" ");
            WriteLiteral(@"name=""comments"" id=""comments"" placeholder=""Your Comments"" cols=""50"" rows=""7""></textarea>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-sm-12 form-group"">
                <label for=""Submit"">
                    Submit:
                </label>
                <button onclick=""sendJSON()"" class=""btn btn-lg btn-warning btn-block"">Submit</button>


                <!-- Include the JavaScript file -->
                <script src=""js/index.js""></script>

                <!--
                    
                Hint 1: Let's go JSON!
                using Newtonsoft.Json;

                    namespace MVC
                    {
                        public class Info
                        {
                            public string Name { get; set; }
                            public string Email { get; set; }
                            [JsonProperty(TypeNameHandling = TypeNameHandling.All)]
                            public dynamic Comme");
            WriteLiteral("nts{ get; set; }\r\n                        }\r\n                    }\r\n                 -->\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>");
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
