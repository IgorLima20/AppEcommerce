#pragma checksum "C:\Users\etec\Desktop\AppEcommerce\Views\Home\Filtro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa16960cd2e4cf4dff88993cf7743be08eec7f4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Filtro), @"mvc.1.0.view", @"/Views/Home/Filtro.cshtml")]
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
#line 1 "C:\Users\etec\Desktop\AppEcommerce\Views\_ViewImports.cshtml"
using AppEcommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\etec\Desktop\AppEcommerce\Views\_ViewImports.cshtml"
using AppEcommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa16960cd2e4cf4dff88993cf7743be08eec7f4b", @"/Views/Home/Filtro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa20e2268b79c993717e226215ffedb90f93602c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Filtro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppEcommerce.Models.Produto>>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\etec\Desktop\AppEcommerce\Views\Home\Filtro.cshtml"
  
    ViewBag.Subtitulo = "InfoTech";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Shop Start -->
<div class=""container-fluid"">
    <div class=""row px-xl-5"">
        <!-- Shop Sidebar Start -->
        <div class=""col-lg-3 col-md-4"">
            <!-- Price Start -->
            <h5 class=""section-title position-relative text-uppercase mb-3""><span class=""bg-secondary pr-3"">Filter by
                    price</span></h5>
            <div class=""bg-light p-4 mb-30"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa16960cd2e4cf4dff88993cf7743be08eec7f4b3803", async() => {
                WriteLiteral(@"
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" checked id=""price-all"">
                        <label class=""custom-control-label"" for=""price-all"">All Price</label>
                        <span class=""badge border font-weight-normal"">1000</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""price-1"">
                        <label class=""custom-control-label"" for=""price-1"">$0 - $100</label>
                        <span class=""badge border font-weight-normal"">150</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""cust");
                WriteLiteral(@"om-control-input"" id=""price-2"">
                        <label class=""custom-control-label"" for=""price-2"">$100 - $200</label>
                        <span class=""badge border font-weight-normal"">295</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""price-3"">
                        <label class=""custom-control-label"" for=""price-3"">$200 - $300</label>
                        <span class=""badge border font-weight-normal"">246</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""price-4"">
                        <label class=""custom-control-label"" for=""price-4"">$300 - $400</label>
                        <span class=""badge border font-weight-");
                WriteLiteral(@"normal"">145</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""price-5"">
                        <label class=""custom-control-label"" for=""price-5"">$400 - $500</label>
                        <span class=""badge border font-weight-normal"">168</span>
                    </div>
                ");
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
            <!-- Price End -->

            <!-- Color Start -->
            <h5 class=""section-title position-relative text-uppercase mb-3""><span class=""bg-secondary pr-3"">Filter by
                    color</span></h5>
            <div class=""bg-light p-4 mb-30"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa16960cd2e4cf4dff88993cf7743be08eec7f4b8024", async() => {
                WriteLiteral(@"
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" checked id=""color-all"">
                        <label class=""custom-control-label"" for=""price-all"">All Color</label>
                        <span class=""badge border font-weight-normal"">1000</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""color-1"">
                        <label class=""custom-control-label"" for=""color-1"">Black</label>
                        <span class=""badge border font-weight-normal"">150</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-c");
                WriteLiteral(@"ontrol-input"" id=""color-2"">
                        <label class=""custom-control-label"" for=""color-2"">White</label>
                        <span class=""badge border font-weight-normal"">295</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""color-3"">
                        <label class=""custom-control-label"" for=""color-3"">Red</label>
                        <span class=""badge border font-weight-normal"">246</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""color-4"">
                        <label class=""custom-control-label"" for=""color-4"">Blue</label>
                        <span class=""badge border font-weight-normal"">145</span>
     ");
                WriteLiteral(@"               </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""color-5"">
                        <label class=""custom-control-label"" for=""color-5"">Green</label>
                        <span class=""badge border font-weight-normal"">168</span>
                    </div>
                ");
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
            <!-- Color End -->

            <!-- Size Start -->
            <h5 class=""section-title position-relative text-uppercase mb-3""><span class=""bg-secondary pr-3"">Filter by
                    size</span></h5>
            <div class=""bg-light p-4 mb-30"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa16960cd2e4cf4dff88993cf7743be08eec7f4b12212", async() => {
                WriteLiteral(@"
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" checked id=""size-all"">
                        <label class=""custom-control-label"" for=""size-all"">All Size</label>
                        <span class=""badge border font-weight-normal"">1000</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""size-1"">
                        <label class=""custom-control-label"" for=""size-1"">XS</label>
                        <span class=""badge border font-weight-normal"">150</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-i");
                WriteLiteral(@"nput"" id=""size-2"">
                        <label class=""custom-control-label"" for=""size-2"">S</label>
                        <span class=""badge border font-weight-normal"">295</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""size-3"">
                        <label class=""custom-control-label"" for=""size-3"">M</label>
                        <span class=""badge border font-weight-normal"">246</span>
                    </div>
                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between mb-3"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""size-4"">
                        <label class=""custom-control-label"" for=""size-4"">L</label>
                        <span class=""badge border font-weight-normal"">145</span>
                    </div>
");
                WriteLiteral(@"                    <div class=""custom-control custom-checkbox d-flex align-items-center justify-content-between"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""size-5"">
                        <label class=""custom-control-label"" for=""size-5"">XL</label>
                        <span class=""badge border font-weight-normal"">168</span>
                    </div>
                ");
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
            <!-- Size End -->
        </div>
        <!-- Shop Sidebar End -->


        <!-- Shop Product Start -->
        <div class=""col-lg-9 col-md-8"">
            <div class=""row pb-3"">
                <div class=""col-12 pb-1"">
                    <div class=""d-flex align-items-center justify-content-between mb-4"">
                        <div>
                            <button class=""btn btn-sm btn-light""><i class=""fa fa-th-large""></i></button>
                            <button class=""btn btn-sm btn-light ml-2""><i class=""fa fa-bars""></i></button>
                        </div>
                        <div class=""ml-2"">
                            <div class=""btn-group"">
                                <button type=""button"" class=""btn btn-sm btn-light dropdown-toggle""
                                    data-toggle=""dropdown"">Sorting</button>
                                <div class=""dropdown-menu dropdown-menu-right"">
                                    <a");
            WriteLiteral(@" class=""dropdown-item"" href=""#"">Latest</a>
                                    <a class=""dropdown-item"" href=""#"">Popularity</a>
                                    <a class=""dropdown-item"" href=""#"">Best Rating</a>
                                </div>
                            </div>
                            <div class=""btn-group ml-2"">
                                <button type=""button"" class=""btn btn-sm btn-light dropdown-toggle""
                                    data-toggle=""dropdown"">Showing</button>
                                <div class=""dropdown-menu dropdown-menu-right"">
                                    <a class=""dropdown-item"" href=""#"">10</a>
                                    <a class=""dropdown-item"" href=""#"">20</a>
                                    <a class=""dropdown-item"" href=""#"">30</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 162 "C:\Users\etec\Desktop\AppEcommerce\Views\Home\Filtro.cshtml"
                 foreach (var produto in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-lg-4 col-md-6 col-sm-6 pb-1"">
                        <div class=""product-item bg-light mb-4"">
                            <div class=""product-img position-relative overflow-hidden"">
                                <img class=""img-fluid w-100""");
            BeginWriteAttribute("src", " src=\"", 11026, "\"", 11061, 1);
#nullable restore
#line 167 "C:\Users\etec\Desktop\AppEcommerce\Views\Home\Filtro.cshtml"
WriteAttributeValue("", 11032, Url.Content(@produto.Imagem), 11032, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 11062, "\"", 11068, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"product-action\">\r\n                                    <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 11212, "\"", 11219, 0);
            EndWriteAttribute();
            WriteLiteral("><i\r\n                                        class=\"fa fa-shopping-cart\"></i></a>\r\n                                    <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 11381, "\"", 11388, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-heart\"></i></a>\r\n                                    <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 11502, "\"", 11509, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-sync-alt\"></i></a>\r\n                                    <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 11625, "\"", 11632, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-search\"></i></a>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"text-center py-4\">\r\n                                <a class=\"h6 text-decoration-none truncar-3l\"");
            BeginWriteAttribute("href", " href=\"", 11881, "\"", 11888, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 177 "C:\Users\etec\Desktop\AppEcommerce\Views\Home\Filtro.cshtml"
                                                                                 Write(produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                <div class=\"d-flex align-items-center justify-content-center mt-2\">\r\n                                    <h5>");
#nullable restore
#line 179 "C:\Users\etec\Desktop\AppEcommerce\Views\Home\Filtro.cshtml"
                                   Write(produto.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                    <h6 class=""text-muted ml-2""><del></del></h6>
                                </div>
                                <div class=""d-flex align-items-center justify-content-center mb-1"">
                                    <small class=""fa fa-star text-primary mr-1""></small>
                                    <small class=""fa fa-star text-primary mr-1""></small>
                                    <small class=""fa fa-star text-primary mr-1""></small>
                                    <small class=""fa fa-star text-primary mr-1""></small>
                                    <small class=""fa fa-star text-primary mr-1""></small>
                                    <small>(99)</small>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 193 "C:\Users\etec\Desktop\AppEcommerce\Views\Home\Filtro.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("            </div>\r\n        </div>\r\n        <!-- Shop Product End -->\r\n    </div>\r\n</div>\r\n<!-- Shop End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppEcommerce.Models.Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591