#pragma checksum "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27070cb57831531e84305d6199fd9da305afc1a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Show), @"mvc.1.0.view", @"/Views/Home/Show.cshtml")]
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
#line 1 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\_ViewImports.cshtml"
using AppEcommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\_ViewImports.cshtml"
using AppEcommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27070cb57831531e84305d6199fd9da305afc1a2", @"/Views/Home/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa20e2268b79c993717e226215ffedb90f93602c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppEcommerce.Models.Produto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Produtos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Produto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark btn-square"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Show", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
  
    ViewBag.Subtitulo = "InfoTech";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Shop Detail Start -->
<div class=""container-fluid pb-5"">
    <div class=""row px-xl-5"">
        <div class=""col-lg-5 mb-30"">
            <div id=""product-carousel"" class=""carousel slide"" data-ride=""carousel"">
                <div class=""carousel-inner bg-light"">
                    <div class=""carousel-item active"">
                        <img class=""w-100 h-100""");
            BeginWriteAttribute("src", " src=\"", 459, "\"", 492, 1);
#nullable restore
#line 13 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
WriteAttributeValue("", 465, Url.Content(@Model.Imagem), 465, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Image"">
                    </div>
                </div>
                <a class=""carousel-control-prev"" href=""#product-carousel"" data-slide=""prev"">
                    <i class=""fa fa-2x fa-angle-left text-dark""></i>
                </a>
                <a class=""carousel-control-next"" href=""#product-carousel"" data-slide=""next"">
                    <i class=""fa fa-2x fa-angle-right text-dark""></i>
                </a>
            </div>
        </div>

        <div class=""col-lg-7 h-auto mb-30"">
            <div class=""h-100 bg-light p-30"">
                <h3>");
#nullable restore
#line 27 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
               Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
            WriteLiteral("                <h3 class=\"font-weight-semi-bold mb-4\">");
#nullable restore
#line 38 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
                                                  Write(Model.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <p class=\"mb-4\">");
#nullable restore
#line 39 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
                           Write(Model.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 90 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
                 if (@Model.Estoque <= 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>\r\n                        ");
#nullable restore
#line 93 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
                   Write(Model.Estoque);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Disponível\r\n                    </p>\r\n");
#nullable restore
#line 95 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>\r\n                        ");
#nullable restore
#line 99 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
                   Write(Model.Estoque);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Disponíveis\r\n                    </p>\r\n");
#nullable restore
#line 101 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
                 if (@Model.Estoque <= 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>\r\n                        <button class=\"btn btn-secondary btn-plus\" disabled=\"true\">\r\n                            <b>Sem Estoque</b>\r\n                        </button>\r\n\r\n                    </p>\r\n");
#nullable restore
#line 110 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""d-flex align-items-center mb-2"">
                        <div class=""input-group quantity mr-3"" style=""width: 130px;"">
                            <div class=""input-group-btn"">
                                <button class=""btn btn-primary btn-minus"">
                                    <i class=""fa fa-minus""></i>
                                </button>
                            </div>
                            <input type=""text"" class=""form-control bg-secondary border-0 text-center"" value=""1"">
                            <div class=""input-group-btn"">
                                <button class=""btn btn-primary btn-plus"">
                                    <i class=""fa fa-plus""></i>
                                </button>
                            </div>
                        </div>
                        <button class=""btn btn-primary px-3""><i class=""fa fa-shopping-cart mr-1""></i> Adicionar</button>
                    </div>
");
#nullable restore
#line 129 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
    <div class=""row px-xl-5"">
        <div class=""col"">
            <div class=""bg-light p-30"">
                <div class=""nav nav-tabs mb-4"">
                    <a class=""nav-item nav-link text-dark active"" data-toggle=""tab"" href=""#tab-pane-1"">Descrição</a>
                    <a class=""nav-item nav-link text-dark"" data-toggle=""tab"" href=""#tab-pane-2"">Informações</a>
");
            WriteLiteral(@"                </div>
                <div class=""tab-content"">
                    <div class=""tab-pane fade show active"" id=""tab-pane-1"">
                        <h4 class=""mb-3"">Descrição</h4>
                        <p>
                            ");
#nullable restore
#line 145 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
                       Write(Model.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </p>
                    </div>
                    <div class=""tab-pane fade"" id=""tab-pane-2"">
                        <h4 class=""mb-3""><b>Informações Sobre o Produto</b></h4>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <ul class=""list-group list-group-flush"">
                                    <li class=""list-group-item px-0"">
                                        <b>Produto:</b> ");
#nullable restore
#line 154 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
                                                   Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </li>\r\n                                    <li class=\"list-group-item px-0\">\r\n                                        <b>Marca:</b> ");
#nullable restore
#line 157 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
                                                 Write(Model.Marca.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </li>\r\n                                </ul>\r\n                            </div>\r\n");
            WriteLiteral("                        </div>\r\n                    </div>\r\n");
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Shop Detail End -->\r\n\r\n\r\n");
#nullable restore
#line 241 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
 if (@ViewBag.Produtos.Count > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container-fluid pt-5 pb-3\">\r\n        <h2 class=\"section-title position-relative text-uppercase mx-xl-5 mb-4\"><span class=\"bg-secondary pr-3\">Produtos\r\n                Relacionados</span></h2>\r\n        <div class=\"row px-xl-5\">\r\n\r\n");
#nullable restore
#line 248 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
             foreach (var produtos in ViewBag.Produtos)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card-group col-lg-3 col-md-4 col-sm-6 pb-1\">\r\n                    <div class=\"product-item bg-light mb-4\">\r\n                        <div class=\"product-img position-relative overflow-hidden\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27070cb57831531e84305d6199fd9da305afc1a213669", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 253 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
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
            WriteLiteral("\r\n                            <img class=\"img-fluid w-100\"");
            BeginWriteAttribute("src", " src=\"", 13328, "\"", 13363, 1);
#nullable restore
#line 254 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
WriteAttributeValue("", 13334, Url.Content(produtos.Imagem), 13334, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 13364, "\"", 13370, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"product-action\">\r\n                                <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 13506, "\"", 13513, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-shopping-cart\"></i></a>\r\n                                <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 13630, "\"", 13637, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-heart\"></i></a>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27070cb57831531e84305d6199fd9da305afc1a217188", async() => {
                WriteLiteral("<i class=\"fa fa-search\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 258 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
                                                                                               WriteLiteral(produtos.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 259 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
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
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"text-center py-4\">\r\n                            <p class=\"card-text truncar-3l\">\r\n                                <a class=\"h5 text-decoration-none\"");
            BeginWriteAttribute("href", " href=\"", 14155, "\"", 14162, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 264 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
                                                                      Write(produtos.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a </p>\r\n                            <div class=\"d-flex align-items-center justify-content-center mt-2\">\r\n                                <h5>");
#nullable restore
#line 266 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
                               Write(produtos.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            </div>\r\n                            <div class=\"d-flex align-items-center justify-content-center mb-1\">\r\n");
            WriteLiteral("                                <small>");
#nullable restore
#line 274 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
                                  Write(produtos.Estoque);

#line default
#line hidden
#nullable disable
            WriteLiteral(" em Estoque</small>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 279 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 283 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Home\Show.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppEcommerce.Models.Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591
