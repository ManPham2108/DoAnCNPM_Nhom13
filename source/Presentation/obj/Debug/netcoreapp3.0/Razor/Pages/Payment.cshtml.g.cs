#pragma checksum "C:\Users\LENOVO\Desktop\DoAnCNPM_Nhom13\source\presentation\Pages\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "774cba34bd5020dc6106711b90b541606f6548d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Presentation.Pages.Pages_Payment), @"mvc.1.0.razor-page", @"/Pages/Payment.cshtml")]
namespace Presentation.Pages
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
#line 1 "C:\Users\LENOVO\Desktop\DoAnCNPM_Nhom13\source\presentation\Pages\_ViewImports.cshtml"
using Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\LENOVO\Desktop\DoAnCNPM_Nhom13\source\presentation\Pages\Payment.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\LENOVO\Desktop\DoAnCNPM_Nhom13\source\presentation\Pages\Payment.cshtml"
using Presentation.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"774cba34bd5020dc6106711b90b541606f6548d3", @"/Pages/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d76d778d4c858045a827ae28cbb9bc28e1d5c23", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Payment : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "mr", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "ms", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\LENOVO\Desktop\DoAnCNPM_Nhom13\source\presentation\Pages\Payment.cshtml"
  
    ViewData["title"]="Payment";

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\LENOVO\Desktop\DoAnCNPM_Nhom13\source\presentation\Pages\Payment.cshtml"
 if(SessionHelper.GetObjectFromJson<Dictionary<string,object>>(HttpContext.Session,"FlightSearch") == null)
    {
        Response.Redirect("Index");    
    }
    else{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""hero-wrap js-fullheight"" style=""background-image: url('images/bg_1.jpg');"">
        <div class=""overlay""></div>
        <div class=""container"">
            <div class=""row no-gutters slider-text js-fullheight align-items-center justify-content-center"" data-scrollax-parent=""true"">
                <div class=""col-md-9 text-center ftco-animate"" data-scrollax="" properties: { translateY: '70%' }"">
                    <p class=""breadcrumbs"" data-scrollax=""properties: { translateY: '30%', opacity: 1.6 }""><span class=""mr-2""><a href=""index.html"">Home</a></span> <span>Blog</span></p>
                    <h1 class=""mb-3 bread"" data-scrollax=""properties: { translateY: '30%', opacity: 1.6 }"">Tips &amp; Articles</h1>
                </div>
            </div>
        </div>
    </div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-4"">
                <div class=""payment-headding"">
                    <h3>Contact Information</h3>
                </div>
  ");
            WriteLiteral(@"          </div>
        </div>
        <div class=""row"">
            <div class=""col-md-5 "">
                <p class=""alg-r"">Name</p>
            </div>
            <div class=""col-md-5"">
                <div class=""form-group"">
                    <input type=""text"" class=""form-control"">
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-5 "">
                <p class=""alg-r"">Phone</p>
            </div>
            <div class=""col-md-5"">
                <div class=""form-group"">
                    <input type=""text"" class=""form-control"">
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-5"">
                <p class="" alg-r"">Email</p>
            </div>
            <div class=""col-md-5"">
                <div class=""form-group"">
                    <input type=""text"" class=""form-control"">
                </div>
            </div>
        </div>
       ");
            WriteLiteral(@" <div class=""row"">
            <div class=""col-md-5 "">
                <p class=""alg-r"">Address</p>
            </div>
            <div class=""col-md-5"">
                <div class=""form-group"">
                    <input type=""area"" class=""form-control"">
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-4"">
                <div class=""payment-headding"">
                    <h3>Customer Information</h3>
                </div>
            </div>
        </div>
");
#nullable restore
#line 79 "C:\Users\LENOVO\Desktop\DoAnCNPM_Nhom13\source\presentation\Pages\Payment.cshtml"
         for(int i=0;i < Model.Adults; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <!-- Adults -->
            <div class=""row"">
                <div class=""col-md-2"" style=""text-align:center"">
                    <p style=""margin-top:15px"">Adult 1:</p>
                </div>
                <div class=""col-md-2"">
                    <div class=""form-group"">
                        <select class=""form-control"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "774cba34bd5020dc6106711b90b541606f6548d37787", async() => {
                WriteLiteral("Mr");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "774cba34bd5020dc6106711b90b541606f6548d39281", async() => {
                WriteLiteral("Ms");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </select>
                    </div>
                </div>
                <div class=""col-md-3"">
                    <div class=""form-group"">
                        <input type=""text"" class=""form-control"" placeholder=""Example: John Smith"" />
                    </div>
                </div>
            </div>
");
#nullable restore
#line 100 "C:\Users\LENOVO\Desktop\DoAnCNPM_Nhom13\source\presentation\Pages\Payment.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!-- end of adult -->\r\n");
#nullable restore
#line 102 "C:\Users\LENOVO\Desktop\DoAnCNPM_Nhom13\source\presentation\Pages\Payment.cshtml"
         for(int i=0;i < Model.Childs; i++)
        {    
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <!-- child -->
            <div class=""row"">
                <div class=""col-md-2"" style=""text-align:center"">
                    <p style=""margin-top:15px"">Children 1:</p>
                </div>
                <div class=""col-md-2"">
                    <div class=""form-group"">
                        <select class=""form-control"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "774cba34bd5020dc6106711b90b541606f6548d311695", async() => {
                WriteLiteral("Male");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "774cba34bd5020dc6106711b90b541606f6548d313192", async() => {
                WriteLiteral("Female");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </select>
                    </div>
                    <div>
                        <label style=""float:right"">Birth Date:</label>
                    </div>
                </div>
                <div class=""col-md-3"">
                    <div class=""form-group"">
                        <input type=""text"" class=""form-control"" placeholder=""Example: John Smith"" />
                    </div>
                    <div class=""form-group"">
                        <input type=""text"" class=""form-control birth_date"" />
                    </div>
                </div>
            </div>
");
#nullable restore
#line 130 "C:\Users\LENOVO\Desktop\DoAnCNPM_Nhom13\source\presentation\Pages\Payment.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-md-4"">
                <div class=""payment-headding"">
                    <h3>Choose your payment</h3>
                </div>
            </div>
        </div>
        
        <div class=""row"">
            <div class=""col-md-12"">
                <input type=""radio"">
            </div>
        </div>
    </div>
");
#nullable restore
#line 145 "C:\Users\LENOVO\Desktop\DoAnCNPM_Nhom13\source\presentation\Pages\Payment.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaymentModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PaymentModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PaymentModel>)PageContext?.ViewData;
        public PaymentModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
