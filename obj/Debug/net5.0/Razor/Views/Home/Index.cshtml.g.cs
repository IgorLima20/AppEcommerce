#pragma checksum "C:\Users\etec\Desktop\AppEcommerce\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfa35ebc1c9f0ceff634169c486949b96e8b3ebb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfa35ebc1c9f0ceff634169c486949b96e8b3ebb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa20e2268b79c993717e226215ffedb90f93602c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppEcommerce.Models.Produto>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Filtro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cat-img position-relative overflow-hidden mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Produtos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Produto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark btn-square"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Show", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\etec\Desktop\AppEcommerce\Views\Home\Index.cshtml"
  
    ViewBag.Subtitulo = "InfoTech";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""container-fluid mb-3"">
    <div class=""row px-xl-5"">
        <div class=""col-lg-8"">
            <div id=""header-carousel"" class=""carousel slide carousel-fade mb-30 mb-lg-0"" data-ride=""carousel"">
                <ol class=""carousel-indicators"">
                    <li data-target=""#header-carousel"" data-slide-to=""0"" class=""active""></li>
                    <li data-target=""#header-carousel"" data-slide-to=""1""></li>
                    <li data-target=""#header-carousel"" data-slide-to=""2""></li>
                </ol>
                <div class=""carousel-inner"">
                    <div class=""carousel-item position-relative active"" style=""height: 430px;"">
                        <img class=""position-absolute w-100 h-100"" src=""/img/carousel-1.jpg"" style=""object-fit: cover;"">
                        <div class=""carousel-caption d-flex flex-column align-items-center justify-content-center"">
                            <div class=""p-3"" style=""max-width: 700px;"">
                            ");
            WriteLiteral(@"    <h1 class=""display-4 text-white mb-3 animate__animated animate__fadeInDown"">Men Fashion
                                </h1>
                                <p class=""mx-md-5 px-5 animate__animated animate__bounceIn"">Lorem rebum magna amet lorem
                                    magna erat diam stet. Sadips duo stet amet amet ndiam elitr ipsum diam</p>
                                <a class=""btn btn-outline-light py-2 px-4 mt-3 animate__animated animate__fadeInUp""
                                    href=""#"">Shop</a>
                            </div>
                        </div>
                    </div>
                    <div class=""carousel-item position-relative"" style=""height: 430px;"">
                        <img class=""position-absolute w-100 h-100"" src=""/img/carousel-2.jpg"" style=""object-fit: cover;"">
                        <div class=""carousel-caption d-flex flex-column align-items-center justify-content-center"">
                            <div class=""p-3"" style=""max-width");
            WriteLiteral(@": 700px;"">
                                <h1 class=""display-4 text-white mb-3 animate__animated animate__fadeInDown"">Women
                                    Fashion</h1>
                                <p class=""mx-md-5 px-5 animate__animated animate__bounceIn"">Lorem rebum magna amet lorem
                                    magna erat diam stet. Sadips duo stet amet amet ndiam elitr ipsum diam</p>
                                <a class=""btn btn-outline-light py-2 px-4 mt-3 animate__animated animate__fadeInUp""
                                    href=""#"">Shop</a>
                            </div>
                        </div>
                    </div>
                    <div class=""carousel-item position-relative"" style=""height: 430px;"">
                        <img class=""position-absolute w-100 h-100"" src=""/img/carousel-3.jpg"" style=""object-fit: cover;"">
                        <div class=""carousel-caption d-flex flex-column align-items-center justify-content-center"">
                ");
            WriteLiteral(@"            <div class=""p-3"" style=""max-width: 700px;"">
                                <h1 class=""display-4 text-white mb-3 animate__animated animate__fadeInDown"">Kids Fashion
                                </h1>
                                <p class=""mx-md-5 px-5 animate__animated animate__bounceIn"">Lorem rebum magna amet lorem
                                    magna erat diam stet. Sadips duo stet amet amet ndiam elitr ipsum diam</p>
                                <a class=""btn btn-outline-light py-2 px-4 mt-3 animate__animated animate__fadeInUp""
                                    href=""#"">Shop</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-4"">
            <div class=""product-offer mb-30"" style=""height: 200px;"">
                <img class=""img-fluid"" src=""/img/offer-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5779, "\"", 5785, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""offer-text"">
                    <h6 class=""text-white text-uppercase"">Save 20%</h6>
                    <h3 class=""text-white mb-3"">Special Offer</h3>
                    <a class=""btn btn-outline-light py-2 px-4 mt-3 animate__animated animate__fadeInUp""
                        href=""#"">Shop</a>
                </div>
            </div>
            <div class=""product-offer mb-30"" style=""height: 200px;"">
                <img class=""img-fluid"" src=""/img/offer-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6295, "\"", 6301, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""offer-text"">
                    <h6 class=""text-white text-uppercase"">Save 20%</h6>
                    <h3 class=""text-white mb-3"">Special Offer</h3>
                    <a class=""btn btn-outline-light py-2 px-4 mt-3 animate__animated animate__fadeInUp""
                        href=""#"">Shop</a>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""container-fluid pt-5"">
    <div class=""row px-xl-5 pb-3"">
        <div class=""col-lg-3 col-md-6 col-sm-12 pb-1"">
            <div class=""d-flex align-items-center bg-light mb-4"" style=""padding: 30px;"">
                <h1 class=""fa fa-check text-primary m-0 mr-3""></h1>
                <h5 class=""font-weight-semi-bold m-0"">Quality Product</h5>
            </div>
        </div>
        <div class=""col-lg-3 col-md-6 col-sm-12 pb-1"">
            <div class=""d-flex align-items-center bg-light mb-4"" style=""padding: 30px;"">
                <h1 class=""fa fa-shipping-fast text-primary m-0");
            WriteLiteral(@" mr-2""></h1>
                <h5 class=""font-weight-semi-bold m-0"">Free Shipping</h5>
            </div>
        </div>
        <div class=""col-lg-3 col-md-6 col-sm-12 pb-1"">
            <div class=""d-flex align-items-center bg-light mb-4"" style=""padding: 30px;"">
                <h1 class=""fas fa-exchange-alt text-primary m-0 mr-3""></h1>
                <h5 class=""font-weight-semi-bold m-0"">14-Day Return</h5>
            </div>
        </div>
        <div class=""col-lg-3 col-md-6 col-sm-12 pb-1"">
            <div class=""d-flex align-items-center bg-light mb-4"" style=""padding: 30px;"">
                <h1 class=""fa fa-phone-volume text-primary m-0 mr-3""></h1>
                <h5 class=""font-weight-semi-bold m-0"">24/7 Support</h5>
            </div>
        </div>
    </div>
</div>

<!-- Categories Start -->
<div class=""container-fluid pt-5"">
    <h2 class=""section-title position-relative text-uppercase mx-xl-5 mb-4""><span
            class=""bg-secondary pr-3"">Categorias</span></h2>
    <d");
            WriteLiteral("iv class=\"row px-xl-5 pb-3\">\r\n");
#nullable restore
#line 145 "C:\Users\etec\Desktop\AppEcommerce\Views\Home\Index.cshtml"
         foreach (var categoria in ViewBag.Categorias)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-4 col-md-6 pb-1\">\r\n                <div class=\"cat-item d-flex flex-column border mb-4\" style=\"padding: 30px;\">\r\n");
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfa35ebc1c9f0ceff634169c486949b96e8b3ebb13565", async() => {
                WriteLiteral("\r\n                        <img class=\"img-fluid\"");
                BeginWriteAttribute("src", " src=\"", 8871, "\"", 8908, 1);
#nullable restore
#line 152 "C:\Users\etec\Desktop\AppEcommerce\Views\Home\Index.cshtml"
WriteAttributeValue("", 8877, Url.Content(@categoria.Imagem), 8877, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 8909, "\"", 8915, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 150 "C:\Users\etec\Desktop\AppEcommerce\Views\Home\Index.cshtml"
                                             WriteLiteral(categoria.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <h5 class=\"font-weight-semi-bold m-0\">");
#nullable restore
#line 154 "C:\Users\etec\Desktop\AppEcommerce\Views\Home\Index.cshtml"
                                                     Write(categoria.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 157 "C:\Users\etec\Desktop\AppEcommerce\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<!-- Categories End -->\r\n\r\n<!-- Categories Start -->\r\n");
            WriteLiteral(@"<!-- Categories End -->

<!-- Products Start -->
<div class=""container-fluid pt-5 pb-3"">
    <h2 class=""section-title position-relative text-uppercase mx-xl-5 mb-4""><span
            class=""bg-secondary pr-3"">Produtos</span></h2>
    <div class=""row px-xl-5"">
");
#nullable restore
#line 192 "C:\Users\etec\Desktop\AppEcommerce\Views\Home\Index.cshtml"
         foreach (var produtos in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card-group col-lg-3 col-md-4 col-sm-6 pb-1\">\r\n                <div class=\"product-item bg-light mb-4\">\r\n                    <div class=\"product-img position-relative overflow-hidden\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfa35ebc1c9f0ceff634169c486949b96e8b3ebb17757", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 197 "C:\Users\etec\Desktop\AppEcommerce\Views\Home\Index.cshtml"
                                                                            WriteLiteral(produtos.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <img class=\"img-fluid w-100\"");
            BeginWriteAttribute("src", " src=\"", 10617, "\"", 10652, 1);
#nullable restore
#line 198 "C:\Users\etec\Desktop\AppEcommerce\Views\Home\Index.cshtml"
WriteAttributeValue("", 10623, Url.Content(produtos.Imagem), 10623, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 10653, "\"", 10659, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"product-action\">\r\n");
#nullable restore
#line 200 "C:\Users\etec\Desktop\AppEcommerce\Views\Home\Index.cshtml"
                             if (@produtos.Estoque >= 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfa35ebc1c9f0ceff634169c486949b96e8b3ebb20974", async() => {
                WriteLiteral("<i class=\"fa fa-shopping-cart\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 202 "C:\Users\etec\Desktop\AppEcommerce\Views\Home\Index.cshtml"
                                                                                                                                          WriteLiteral(produtos.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 203 "C:\Users\etec\Desktop\AppEcommerce\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 11112, "\"", 11119, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-heart\"></i></a>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfa35ebc1c9f0ceff634169c486949b96e8b3ebb24011", async() => {
                WriteLiteral("<i\r\n                                class=\"fa fa-search\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 205 "C:\Users\etec\Desktop\AppEcommerce\Views\Home\Index.cshtml"
                                                                                           WriteLiteral(produtos.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 205 "C:\Users\etec\Desktop\AppEcommerce\Views\Home\Index.cshtml"
                                                                                                                                WriteLiteral(produtos.IdCategoria);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["IdCategoria"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-IdCategoria", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["IdCategoria"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"text-center py-4\">\r\n                        <p class=\"card-text truncar-3l\">\r\n                            <a class=\"h5 text-decoration-none\"");
            BeginWriteAttribute("href", " href=\"", 11617, "\"", 11624, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 211 "C:\Users\etec\Desktop\AppEcommerce\Views\Home\Index.cshtml"
                                                                  Write(produtos.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a </p>\r\n                        <div class=\"d-flex align-items-center justify-content-center mt-2\">\r\n                            <h5>R$ ");
#nullable restore
#line 213 "C:\Users\etec\Desktop\AppEcommerce\Views\Home\Index.cshtml"
                              Write(produtos.Valor.ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        </div>\r\n                        <div class=\"d-flex align-items-center justify-content-center mb-1\">\r\n");
            WriteLiteral("                            <small>");
#nullable restore
#line 221 "C:\Users\etec\Desktop\AppEcommerce\Views\Home\Index.cshtml"
                              Write(produtos.Estoque);

#line default
#line hidden
#nullable disable
            WriteLiteral(" em Estoque</small>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 226 "C:\Users\etec\Desktop\AppEcommerce\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>
<!-- Products End -->

<!-- Offer Start -->
<div class=""container-fluid pt-5 pb-3"">
    <div class=""row px-xl-5"">
        <div class=""col-md-6"">
            <div class=""product-offer mb-30"" style=""height: 300px;"">
                <img class=""img-fluid"" src=""img/offer-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 12860, "\"", 12866, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"offer-text\">\r\n                    <h6 class=\"text-white text-uppercase\">Save 20%</h6>\r\n                    <h3 class=\"text-white mb-3\">Special Offer</h3>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 13075, "\"", 13082, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"">Shop Now</a>
                </div>
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""product-offer mb-30"" style=""height: 300px;"">
                <img class=""img-fluid"" src=""img/offer-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 13344, "\"", 13350, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"offer-text\">\r\n                    <h6 class=\"text-white text-uppercase\">Save 20%</h6>\r\n                    <h3 class=\"text-white mb-3\">Special Offer</h3>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 13559, "\"", 13566, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"">Shop Now</a>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Offer End -->

<!-- Vendor Start -->
<div class=""container-fluid py-5"">
    <div class=""row px-xl-5"">
        <div class=""col"">
            <div class=""owl-carousel vendor-carousel"">
                <div class=""bg-light p-4"">
                    <img src=""img/vendor-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 13972, "\"", 13978, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"bg-light p-4\">\r\n                    <img src=\"img/vendor-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 14097, "\"", 14103, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"bg-light p-4\">\r\n                    <img src=\"img/vendor-3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 14222, "\"", 14228, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"bg-light p-4\">\r\n                    <img src=\"img/vendor-4.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 14347, "\"", 14353, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"bg-light p-4\">\r\n                    <img src=\"img/vendor-5.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 14472, "\"", 14478, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"bg-light p-4\">\r\n                    <img src=\"img/vendor-6.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 14597, "\"", 14603, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"bg-light p-4\">\r\n                    <img src=\"img/vendor-7.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 14722, "\"", 14728, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"bg-light p-4\">\r\n                    <img src=\"img/vendor-8.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 14847, "\"", 14853, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Vendor End -->\r\n\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppEcommerce.Models.Produto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
