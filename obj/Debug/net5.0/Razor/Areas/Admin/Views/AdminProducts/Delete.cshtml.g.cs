#pragma checksum "E:\FPT\CN8\PRN231\CODE\PE\ecomerce_asp.net_core_5.0\Areas\Admin\Views\AdminProducts\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "725b5684cf3fa44acdd87753ac58d1c8d8d3d2ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminProducts_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminProducts/Delete.cshtml")]
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
#line 1 "E:\FPT\CN8\PRN231\CODE\PE\ecomerce_asp.net_core_5.0\Areas\Admin\Views\_ViewImports.cshtml"
using PE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\FPT\CN8\PRN231\CODE\PE\ecomerce_asp.net_core_5.0\Areas\Admin\Views\_ViewImports.cshtml"
using PE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"725b5684cf3fa44acdd87753ac58d1c8d8d3d2ff", @"/Areas/Admin/Views/AdminProducts/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"417ad21fb1c9b9d2fb92160ba014bbf49f8a7f15", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminProducts_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PE.Models.Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("breadcrumb-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminProducts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("max"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("max"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\FPT\CN8\PRN231\CODE\PE\ecomerce_asp.net_core_5.0\Areas\Admin\Views\AdminProducts\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n<div class=\"page-header\">\r\n    <div class=\"header-sub-title\">\r\n        <nav class=\"breadcrumb breadcrumb-dash\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "725b5684cf3fa44acdd87753ac58d1c8d8d3d2ff7476", async() => {
                WriteLiteral("<i class=\"anticon anticon-home m-r-5\"></i>Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "725b5684cf3fa44acdd87753ac58d1c8d8d3d2ff9174", async() => {
                WriteLiteral("<i class=\"anticon anticon-home m-r-5\"></i>Product list");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <span class=""breadcrumb-item active"">Delete</span>
        </nav>
        </di

        <h3>Are you sure you want to delete this?</h3>
        <div>
            <h4>Product</h4>
            <hr />
            <div class=""row"">
                <!-- Column -->
                <div class=""col-lg-4 col-xlg-3 col-md-12"">
                    <div class=""white-box"">
                        <div class=""user-bg"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "725b5684cf3fa44acdd87753ac58d1c8d8d3d2ff11338", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1088, "~/images/products/", 1088, 18, true);
#nullable restore
#line 27 "E:\FPT\CN8\PRN231\CODE\PE\ecomerce_asp.net_core_5.0\Areas\Admin\Views\AdminProducts\Delete.cshtml"
AddHtmlAttributeValue("", 1106, Model.Thumb, 1106, 12, false);

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
            WriteLiteral("\r\n\r\n                        </div>\r\n                        <div class=\"user-btm-box mt-5 d-md-flex\">\r\n                            <div class=\"col-md-4 col-sm-4 text-center\">\r\n                                <h1>\r\n");
#nullable restore
#line 33 "E:\FPT\CN8\PRN231\CODE\PE\ecomerce_asp.net_core_5.0\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                     if (@Model.Thumb != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p>");
#nullable restore
#line 35 "E:\FPT\CN8\PRN231\CODE\PE\ecomerce_asp.net_core_5.0\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                      Write(Model.Thumb);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 36 "E:\FPT\CN8\PRN231\CODE\PE\ecomerce_asp.net_core_5.0\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p>Unknown</p>\r\n");
#nullable restore
#line 40 "E:\FPT\CN8\PRN231\CODE\PE\ecomerce_asp.net_core_5.0\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </h1>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Column -->
                <!-- Column -->
                <div class=""col-lg-8 col-xlg-9 col-md-12"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <div class=""form-group mb-4"">
                                <label class=""col-md-12 p-0"">Full Name</label>
                                <div class=""col-md-12 border-bottom p-0"">
                                    <p>");
#nullable restore
#line 54 "E:\FPT\CN8\PRN231\CODE\PE\ecomerce_asp.net_core_5.0\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                  Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                </div>
                                <div class=""form-group mb-4"">
                                    <label class=""col-md-12 p-0"">Title</label>
                                    <div class=""col-md-12 border-bottom p-0"">
                                        <p>");
#nullable restore
#line 59 "E:\FPT\CN8\PRN231\CODE\PE\ecomerce_asp.net_core_5.0\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                      Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                                <div class=""form-group mb-4"">
                                    <label class=""col-md-12 p-0"">Unit in stock</label>
                                    <div class=""col-md-12 border-bottom p-0"">
                                        <p>");
#nullable restore
#line 65 "E:\FPT\CN8\PRN231\CODE\PE\ecomerce_asp.net_core_5.0\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                      Write(Model.UnitInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                                <div class=""form-group mb-4"">
                                    <label class=""col-md-12 p-0"">Short Description</label>
                                    <div class=""col-md-12 border-bottom p-0"">
                                        <p>");
#nullable restore
#line 71 "E:\FPT\CN8\PRN231\CODE\PE\ecomerce_asp.net_core_5.0\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                      Write(Model.ShortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                                <div class=""form-group mb-4"">
                                    <label class=""col-md-12 p-0"">Description</label>
                                    <div class=""col-md-12 border-bottom p-0"">
                                        <p>");
#nullable restore
#line 77 "E:\FPT\CN8\PRN231\CODE\PE\ecomerce_asp.net_core_5.0\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                                <div class=""form-group mb-4"">
                                    <label class=""col-md-12 p-0"">Price</label>
                                    <div class=""col-md-12 border-bottom p-0"">
                                        <p>");
#nullable restore
#line 83 "E:\FPT\CN8\PRN231\CODE\PE\ecomerce_asp.net_core_5.0\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                      Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                                <div class=""form-group mb-4"">
                                    <label class=""col-md-12 p-0"">Discount</label>
                                    <div class=""col-md-12 border-bottom p-0"">
                                        <p>");
#nullable restore
#line 89 "E:\FPT\CN8\PRN231\CODE\PE\ecomerce_asp.net_core_5.0\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                      Write(Model.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" %</p>
                                    </div>
                                </div>
                                <div class=""form-group mb-4"">
                                    <label class=""col-md-12 p-0"">Category</label>
                                    <div class=""col-md-12 border-bottom p-0"">
                                        <p>
");
#nullable restore
#line 96 "E:\FPT\CN8\PRN231\CODE\PE\ecomerce_asp.net_core_5.0\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                             if (@Model.Cat == null)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <div class=""d-flex align-items-center"">
                                                    <div class=""badge badge-success badge-dot m-r-10""></div>
                                                    <div>Unknow</div>
                                                </div>
");
#nullable restore
#line 102 "E:\FPT\CN8\PRN231\CODE\PE\ecomerce_asp.net_core_5.0\Areas\Admin\Views\AdminProducts\Delete.cshtml"

                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <div class=""d-flex align-items-center"">
                                                    <div class=""badge badge-success badge-dot m-r-10""></div>
                                                    <div>");
#nullable restore
#line 108 "E:\FPT\CN8\PRN231\CODE\PE\ecomerce_asp.net_core_5.0\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                                    Write(Model.Cat.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                </div>\r\n");
#nullable restore
#line 110 "E:\FPT\CN8\PRN231\CODE\PE\ecomerce_asp.net_core_5.0\Areas\Admin\Views\AdminProducts\Delete.cshtml"

                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </p>
                                    </div>
                                </div>
                                <div class=""form-group mb-4"">
                                    <label class=""col-md-12 p-0"">Home flag</label>
                                    <div class=""col-md-12 border-bottom p-0"">
                                        <p>");
#nullable restore
#line 118 "E:\FPT\CN8\PRN231\CODE\PE\ecomerce_asp.net_core_5.0\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                      Write(Model.HomeFlag);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                                <div class=""form-group mb-4"">
                                    <label class=""col-md-12 p-0"">Active</label>
                                    <div class=""col-md-12 border-bottom p-0"">
                                        <p>");
#nullable restore
#line 124 "E:\FPT\CN8\PRN231\CODE\PE\ecomerce_asp.net_core_5.0\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                      Write(Model.Active);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                                <div class=""form-group mb-4"">
                                    <label class=""col-md-12 p-0"">Best sellers</label>
                                    <p>");
#nullable restore
#line 129 "E:\FPT\CN8\PRN231\CODE\PE\ecomerce_asp.net_core_5.0\Areas\Admin\Views\AdminProducts\Delete.cshtml"
                                  Write(Model.BestSellers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <!-- Column -->\r\n            </div>\r\n\r\n\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "725b5684cf3fa44acdd87753ac58d1c8d8d3d2ff23689", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "725b5684cf3fa44acdd87753ac58d1c8d8d3d2ff23964", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#nullable restore
#line 142 "E:\FPT\CN8\PRN231\CODE\PE\ecomerce_asp.net_core_5.0\Areas\Admin\Views\AdminProducts\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductId);

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
                WriteLiteral("\r\n                <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "725b5684cf3fa44acdd87753ac58d1c8d8d3d2ff25793", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PE.Models.Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
