#pragma checksum "C:\Users\LENOVO\Desktop\DoAnCNPM\source\presentation\Pages\Admin\Maker.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "743c2951dac19a5e93330e7e643db4e36e6885e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Presentation.Pages.Admin.Pages_Admin_Maker), @"mvc.1.0.razor-page", @"/Pages/Admin/Maker.cshtml")]
namespace Presentation.Pages.Admin
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
#line 1 "C:\Users\LENOVO\Desktop\DoAnCNPM\source\presentation\Pages\_ViewImports.cshtml"
using Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\LENOVO\Desktop\DoAnCNPM\source\presentation\Pages\Admin\Maker.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"743c2951dac19a5e93330e7e643db4e36e6885e7", @"/Pages/Admin/Maker.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d76d778d4c858045a827ae28cbb9bc28e1d5c23", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Maker : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("SearchMaker"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search Here"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "searchString", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("cursor:pointer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/Maker", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pagination_link active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pagination_link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\LENOVO\Desktop\DoAnCNPM\source\presentation\Pages\Admin\Maker.cshtml"
  
  Layout = "_LayoutAdmin";
	ViewData["Title"] = "Admin Page";

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\LENOVO\Desktop\DoAnCNPM\source\presentation\Pages\Admin\Maker.cshtml"
  
  if(HttpContext.Session.GetString("username") == null)
  {
    Response.Redirect("Index");
  }
  string job = HttpContext.Session.GetString("job");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""main-panel"">
  <div class=""content-wrapper"">
     <!-- row button create -->
    <div class=""row"">
      <div class=""col-lg-12 stretch-card"">
        <a href=""#CreateMakerForm"" data-toggle=""modal"" id=""btCreateMaker"" type=""button"" class=""btn  btn-primary btn-lg btn-inverse-*"">
          <i class=""mdi mdi-upload""></i>Create Maker
        </a>
      </div>
    </div>
    <!-- row table -->
    <div class=""row"">
      <div class=""col-lg-12 stretch-card"">
        <div class=""card"">
          <div class=""card-body"">
            <div class=""form-group row"">
              <div class=""col-sm-7""></div>
              <div class=""col-sm-5"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "743c2951dac19a5e93330e7e643db4e36e6885e78146", async() => {
                WriteLiteral("\r\n                  <div class=\"input-group\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "743c2951dac19a5e93330e7e643db4e36e6885e78473", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 35 "C:\Users\LENOVO\Desktop\DoAnCNPM\source\presentation\Pages\Admin\Maker.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchString);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <button type=\"submit\" id=\"btsubmitSearchMaker\" class=\"btn btn-icons btn-rounded btn-outline-primary\"><i class=\"fa fa-search\"></i></button>\r\n                  </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            <h3 align=""center"">List of Makers </h3>
            <table class=""table table-bordered table-striped table-hover"" id=""TableMaker"">
            <thead>
              <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Address</th>
                <th></th>
              </tr>
            </thead>
            <tbody> 
");
#nullable restore
#line 52 "C:\Users\LENOVO\Desktop\DoAnCNPM\source\presentation\Pages\Admin\Maker.cshtml"
               foreach (var item in Model.ListMakerPage.Makers){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                <!-- <tr id=\"");
#nullable restore
#line 54 "C:\Users\LENOVO\Desktop\DoAnCNPM\source\presentation\Pages\Admin\Maker.cshtml"
                        Write(item.MakerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"list-maker\"> -->\r\n                  <td>");
#nullable restore
#line 55 "C:\Users\LENOVO\Desktop\DoAnCNPM\source\presentation\Pages\Admin\Maker.cshtml"
                 Write(item.MakerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                  <td>");
#nullable restore
#line 56 "C:\Users\LENOVO\Desktop\DoAnCNPM\source\presentation\Pages\Admin\Maker.cshtml"
                 Write(item.MakerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                  <td>");
#nullable restore
#line 57 "C:\Users\LENOVO\Desktop\DoAnCNPM\source\presentation\Pages\Admin\Maker.cshtml"
                 Write(item.Address.toString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                  <td> \r\n                    <button");
            BeginWriteAttribute("id", "  id=\"", 2179, "\"", 2198, 1);
#nullable restore
#line 59 "C:\Users\LENOVO\Desktop\DoAnCNPM\source\presentation\Pages\Admin\Maker.cshtml"
WriteAttributeValue("", 2185, item.MakerId, 2185, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#EditMakerForm\"  type=\"button\" class=\"btn btn-dark btn-sm  btn-rounded EditMaker\"><i class=\"fa fa-cog\"></i></button>\r\n                    <button");
            BeginWriteAttribute("id", "  id=\"", 2378, "\"", 2397, 1);
#nullable restore
#line 60 "C:\Users\LENOVO\Desktop\DoAnCNPM\source\presentation\Pages\Admin\Maker.cshtml"
WriteAttributeValue("", 2384, item.MakerId, 2384, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-danger btn-sm  btn-rounded DeleteMaker\"><i class=\"fa fa-times\" ></i></button>\r\n                  </td>\r\n                </tr>\r\n");
#nullable restore
#line 63 "C:\Users\LENOVO\Desktop\DoAnCNPM\source\presentation\Pages\Admin\Maker.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("              </tbody>\r\n            </table>\r\n            <br />\r\n");
#nullable restore
#line 67 "C:\Users\LENOVO\Desktop\DoAnCNPM\source\presentation\Pages\Admin\Maker.cshtml"
                
              var preDisabled = !Model.ListMakerPage.Makers.HasPrevious ? "disabled" : "";
              var nextDisabled = !Model.ListMakerPage.Makers.HasNext ? "disabled" : "";
              var pageNow =Model.ListMakerPage.Makers.PageIndex;
              

#line default
#line hidden
#nullable disable
            WriteLiteral("              <!-- pagination -->\r\n              <div class=\"pagination\" >\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "743c2951dac19a5e93330e7e643db4e36e6885e715606", async() => {
                WriteLiteral("Previous");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageIndex", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "C:\Users\LENOVO\Desktop\DoAnCNPM\source\presentation\Pages\Admin\Maker.cshtml"
                          WriteLiteral(Model.ListMakerPage.Makers.PageIndex - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageIndex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3171, "pagination_link", 3171, 15, true);
#nullable restore
#line 76 "C:\Users\LENOVO\Desktop\DoAnCNPM\source\presentation\Pages\Admin\Maker.cshtml"
AddHtmlAttributeValue(" ", 3186, preDisabled, 3187, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 77 "C:\Users\LENOVO\Desktop\DoAnCNPM\source\presentation\Pages\Admin\Maker.cshtml"
                 for (int i=1;i<=Model.ListMakerPage.Makers.TotalPages;++i)
                {
                    if(i==pageNow)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "743c2951dac19a5e93330e7e643db4e36e6885e718793", async() => {
#nullable restore
#line 81 "C:\Users\LENOVO\Desktop\DoAnCNPM\source\presentation\Pages\Admin\Maker.cshtml"
                                                                                                                            Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageIndex", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "C:\Users\LENOVO\Desktop\DoAnCNPM\source\presentation\Pages\Admin\Maker.cshtml"
                                                                                 WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageIndex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 82 "C:\Users\LENOVO\Desktop\DoAnCNPM\source\presentation\Pages\Admin\Maker.cshtml"
                    }
                    else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "743c2951dac19a5e93330e7e643db4e36e6885e721684", async() => {
#nullable restore
#line 84 "C:\Users\LENOVO\Desktop\DoAnCNPM\source\presentation\Pages\Admin\Maker.cshtml"
                                                                                                                    Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageIndex", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\LENOVO\Desktop\DoAnCNPM\source\presentation\Pages\Admin\Maker.cshtml"
                                                                                 WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageIndex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 85 "C:\Users\LENOVO\Desktop\DoAnCNPM\source\presentation\Pages\Admin\Maker.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "743c2951dac19a5e93330e7e643db4e36e6885e724553", async() => {
                WriteLiteral("Next");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageIndex", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "C:\Users\LENOVO\Desktop\DoAnCNPM\source\presentation\Pages\Admin\Maker.cshtml"
                          WriteLiteral(Model.ListMakerPage.Makers.PageIndex + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageIndex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageIndex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3905, "pagination_link", 3905, 15, true);
#nullable restore
#line 89 "C:\Users\LENOVO\Desktop\DoAnCNPM\source\presentation\Pages\Admin\Maker.cshtml"
AddHtmlAttributeValue(" ", 3920, nextDisabled, 3921, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
      </div>
    </div>
    <!-- end table maker  -->

  </div> 
  <!-- end content_warper -->



</div>
<!-- end main body -->

<!--create maker form  -->
<div class=""modal fade"" id=""CreateMakerForm"" role=""dialog"">
  <div class=""modal-dialog modal-dialog-centered modal-sm"">
    <div class=""modal-content"" >
      <div class=""modal-header"" style=""text-align:center !important; background-color:aliceblue;"">
        <h4 class=""modal-title"" style="" color:#000; font-weight: bold;font-size:34"">Create Maker</h4>
      </div>
		  <div class=""model-body"" style=""margin: 15px"">
				");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "743c2951dac19a5e93330e7e643db4e36e6885e728044", async() => {
                WriteLiteral(@"
          <div class=""form-group row"">
            <label class=""col-sm-3 col-form-label"">Name</label>
            <div class=""col-sm-9"">
              <input id=""CreateMaker-name"" type=""text"" class=""form-control""  placeholder=""Enter name"">
            </div>    
          </div>
          <div class=""form-group row"">
            <label class=""col-sm-3 col-form-label"">Address</label>
            <div class=""col-sm-9"">
              <input id=""CreateMaker-address"" type=""text"" class=""form-control"" placeholder=""Enter address"">
            </div>
          </div>
          <button id=""btsubmitCreateMaker"" type=""submit"" class=""btn btn-success mr-2"" ><b>Create</b></button>
          <button class=""btn btn-light"" data-dismiss=""modal""><b>Cancel</b></button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
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
</div>

 <!-- edit maker form -->
<div class=""modal fade"" id=""EditMakerForm"" role=""dialog"">
  <div class=""modal-dialog modal-dialog-centered modal-sm"">
    <div class=""modal-content"" >
      <div class=""modal-header"" style=""text-align:center !important; background-color:aliceblue;"">
        <h4 class=""modal-title"" style="" color:#000; font-weight: bold;font-size:34"">Edit Maker</h4>
      </div>
      <div class=""model-body"" style=""margin: 15px"" id=""bodyEditMaker"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "743c2951dac19a5e93330e7e643db4e36e6885e730722", async() => {
                WriteLiteral(@"
          <input id=""EditMaker-id"" type=""hidden"" class=""form-control""   >
          <div class=""form-group row"">
            <label class=""col-sm-3 col-form-label"">Name</label>
            <div class=""col-sm-9"">
              <input id=""EditMaker-name"" type=""text"" class=""form-control""  placeholder=""Enter name"">
            </div>
            <span style=""color: red bold"" class=""z-mak-name""></span>
          </div>
          <div class=""form-group row"">
            <label class=""col-sm-3 col-form-label"">Address</label>
            <div class=""col-sm-9"">
              <input id=""EditMaker-address"" type=""text"" class=""form-control"" placeholder=""Enter address"">
            </div>
            <span style=""color: red bold"" class=""z-mak-address""></span>
          </div>
          <button  id=""btsubmitEditMaker"" class=""btn btn-success mr-2""><b>Update</b></button>
          <button class=""btn btn-light"" data-dismiss=""modal""><b>Cancel</b></button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n      </div>\r\n    </div>    \r\n  </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Presentation.Pages.Admin.MakerModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Presentation.Pages.Admin.MakerModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Presentation.Pages.Admin.MakerModel>)PageContext?.ViewData;
        public Presentation.Pages.Admin.MakerModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591