#pragma checksum "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88ce20b8aecf4d8142e5668177d96e1d1e8116eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Index), @"mvc.1.0.view", @"/Views/Produto/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88ce20b8aecf4d8142e5668177d96e1d1e8116eb", @"/Views/Produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa20e2268b79c993717e226215ffedb90f93602c", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Produto\Index.cshtml"
  
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
                        <img class=""w-100 h-100"" src=""img/product-1.jpg"" alt=""Image"">
                    </div>
                    <div class=""carousel-item"">
                        <img class=""w-100 h-100"" src=""img/product-2.jpg"" alt=""Image"">
                    </div>
                    <div class=""carousel-item"">
                        <img class=""w-100 h-100"" src=""img/product-3.jpg"" alt=""Image"">
                    </div>
                    <div class=""carousel-item"">
                        <img class=""w-100 h-100"" src=""img/product-4.jpg"" alt=""Image"">
                    </div>
                </div>
                <a class=""carousel-control-prev"" href=""#produc");
            WriteLiteral(@"t-carousel"" data-slide=""prev"">
                    <i class=""fa fa-2x fa-angle-left text-dark""></i>
                </a>
                <a class=""carousel-control-next"" href=""#product-carousel"" data-slide=""next"">
                    <i class=""fa fa-2x fa-angle-right text-dark""></i>
                </a>
            </div>
        </div>

        <div class=""col-lg-7 h-auto mb-30"">
            <div class=""h-100 bg-light p-30"">
                <h3>Product Name Goes Here</h3>
");
            WriteLiteral(@"                <h3 class=""font-weight-semi-bold mb-4"">R$150,00</h3>
                <p class=""mb-4"">Volup erat ipsum diam elitr rebum et dolor. Est nonumy elitr erat diam stet sit
                    clita ea. Sanc ipsum et, labore clita lorem magna duo dolor no sea
                    Nonumy</p>
");
            WriteLiteral(@"                <div class=""d-flex align-items-center mb-4 pt-2"">
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
                    <button class=""btn btn-primary px-3""><i class=""fa fa-shopping-cart mr-1""></i> Add To
                        Cart</button>
                </div>
                <div class=""d-flex pt-2"">
        ");
            WriteLiteral("            <strong class=\"text-dark mr-2\">Share on:</strong>\r\n                    <div class=\"d-inline-flex\">\r\n                        <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 7127, "\"", 7134, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"fab fa-facebook-f\"></i>\r\n                        </a>\r\n                        <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 7280, "\"", 7287, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"fab fa-twitter\"></i>\r\n                        </a>\r\n                        <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 7430, "\"", 7437, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"fab fa-linkedin-in\"></i>\r\n                        </a>\r\n                        <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 7584, "\"", 7591, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""fab fa-pinterest""></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row px-xl-5"">
        <div class=""col"">
            <div class=""bg-light p-30"">
                <div class=""nav nav-tabs mb-4"">
                    <a class=""nav-item nav-link text-dark active"" data-toggle=""tab"" href=""#tab-pane-1"">Description</a>
                    <a class=""nav-item nav-link text-dark"" data-toggle=""tab"" href=""#tab-pane-2"">Information</a>
");
            WriteLiteral(@"                </div>
                <div class=""tab-content"">
                    <div class=""tab-pane fade show active"" id=""tab-pane-1"">
                        <h4 class=""mb-3"">Product Description</h4>
                        <p>Eos no lorem eirmod diam diam, eos elitr et gubergren diam sea. Consetetur vero aliquyam
                            invidunt duo dolores et duo sit. Vero diam ea vero et dolore rebum, dolor rebum eirmod
                            consetetur invidunt sed sed et, lorem duo et eos elitr, sadipscing kasd ipsum rebum diam.
                            Dolore diam stet rebum sed tempor kasd eirmod. Takimata kasd ipsum accusam sadipscing, eos
                            dolores sit no ut diam consetetur duo justo est, sit sanctus diam tempor aliquyam eirmod
                            nonumy rebum dolor accusam, ipsum kasd eos consetetur at sit rebum, diam kasd invidunt
                            tempor lorem, ipsum lorem elitr sanctus eirmod takimata dolor ea invidunt.</p>");
            WriteLiteral(@"
                        <p>Dolore magna est eirmod sanctus dolor, amet diam et eirmod et ipsum. Amet dolore tempor
                            consetetur sed lorem dolor sit lorem tempor. Gubergren amet amet labore sadipscing clita
                            clita diam clita. Sea amet et sed ipsum lorem elitr et, amet et labore voluptua sit rebum.
                            Ea erat sed et diam takimata sed justo. Magna takimata justo et amet magna et.</p>
                    </div>
                    <div class=""tab-pane fade"" id=""tab-pane-2"">
                        <h4 class=""mb-3"">Additional Information</h4>
                        <p>Eos no lorem eirmod diam diam, eos elitr et gubergren diam sea. Consetetur vero aliquyam
                            invidunt duo dolores et duo sit. Vero diam ea vero et dolore rebum, dolor rebum eirmod
                            consetetur invidunt sed sed et, lorem duo et eos elitr, sadipscing kasd ipsum rebum diam.
                            Dolore diam st");
            WriteLiteral(@"et rebum sed tempor kasd eirmod. Takimata kasd ipsum accusam sadipscing, eos
                            dolores sit no ut diam consetetur duo justo est, sit sanctus diam tempor aliquyam eirmod
                            nonumy rebum dolor accusam, ipsum kasd eos consetetur at sit rebum, diam kasd invidunt
                            tempor lorem, ipsum lorem elitr sanctus eirmod takimata dolor ea invidunt.</p>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <ul class=""list-group list-group-flush"">
                                    <li class=""list-group-item px-0"">
                                        Sit erat duo lorem duo ea consetetur, et eirmod takimata.
                                    </li>
                                    <li class=""list-group-item px-0"">
                                        Amet kasd gubergren sit sanctus et lorem eos sadipscing at.
                                    </li>
       ");
            WriteLiteral(@"                             <li class=""list-group-item px-0"">
                                        Duo amet accusam eirmod nonumy stet et et stet eirmod.
                                    </li>
                                    <li class=""list-group-item px-0"">
                                        Takimata ea clita labore amet ipsum erat justo voluptua. Nonumy.
                                    </li>
                                </ul>
                            </div>
                            <div class=""col-md-6"">
                                <ul class=""list-group list-group-flush"">
                                    <li class=""list-group-item px-0"">
                                        Sit erat duo lorem duo ea consetetur, et eirmod takimata.
                                    </li>
                                    <li class=""list-group-item px-0"">
                                        Amet kasd gubergren sit sanctus et lorem eos sadipscing at.
               ");
            WriteLiteral(@"                     </li>
                                    <li class=""list-group-item px-0"">
                                        Duo amet accusam eirmod nonumy stet et et stet eirmod.
                                    </li>
                                    <li class=""list-group-item px-0"">
                                        Takimata ea clita labore amet ipsum erat justo voluptua. Nonumy.
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
");
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>
<!-- Shop Detail End -->

<!-- Products Start -->
<div class=""container-fluid py-5"">
    <h2 class=""section-title position-relative text-uppercase mx-xl-5 mb-4""><span class=""bg-secondary pr-3"">You May Also
            Like</span></h2>
    <div class=""row px-xl-5"">
        <div class=""col"">
            <div class=""owl-carousel related-carousel"">
                <div class=""product-item bg-light"">
                    <div class=""product-img position-relative overflow-hidden"">
                        <img class=""img-fluid w-100"" src=""img/product-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 17244, "\"", 17250, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"product-action\">\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 17378, "\"", 17385, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-shopping-cart\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 17498, "\"", 17505, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-heart\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 17611, "\"", 17618, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-sync-alt\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 17726, "\"", 17733, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-search\"></i></a>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"text-center py-4\">\r\n                        <a class=\"h6 text-decoration-none text-truncate\"");
            BeginWriteAttribute("href", " href=\"", 17953, "\"", 17960, 0);
            EndWriteAttribute();
            WriteLiteral(@">Product Name Goes Here</a>
                        <div class=""d-flex align-items-center justify-content-center mt-2"">
                            <h5>$123.00</h5>
                            <h6 class=""text-muted ml-2""><del>$123.00</del></h6>
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
                <div class=""product-item bg-light"">
                    <div class=""product-img position-r");
            WriteLiteral("elative overflow-hidden\">\r\n                        <img class=\"img-fluid w-100\" src=\"img/product-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 19088, "\"", 19094, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"product-action\">\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 19222, "\"", 19229, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-shopping-cart\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 19342, "\"", 19349, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-heart\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 19455, "\"", 19462, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-sync-alt\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 19570, "\"", 19577, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-search\"></i></a>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"text-center py-4\">\r\n                        <a class=\"h6 text-decoration-none text-truncate\"");
            BeginWriteAttribute("href", " href=\"", 19797, "\"", 19804, 0);
            EndWriteAttribute();
            WriteLiteral(@">Product Name Goes Here</a>
                        <div class=""d-flex align-items-center justify-content-center mt-2"">
                            <h5>$123.00</h5>
                            <h6 class=""text-muted ml-2""><del>$123.00</del></h6>
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
                <div class=""product-item bg-light"">
                    <div class=""product-img position-r");
            WriteLiteral("elative overflow-hidden\">\r\n                        <img class=\"img-fluid w-100\" src=\"img/product-3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 20932, "\"", 20938, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"product-action\">\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 21066, "\"", 21073, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-shopping-cart\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 21186, "\"", 21193, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-heart\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 21299, "\"", 21306, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-sync-alt\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 21414, "\"", 21421, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-search\"></i></a>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"text-center py-4\">\r\n                        <a class=\"h6 text-decoration-none text-truncate\"");
            BeginWriteAttribute("href", " href=\"", 21641, "\"", 21648, 0);
            EndWriteAttribute();
            WriteLiteral(@">Product Name Goes Here</a>
                        <div class=""d-flex align-items-center justify-content-center mt-2"">
                            <h5>$123.00</h5>
                            <h6 class=""text-muted ml-2""><del>$123.00</del></h6>
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
                <div class=""product-item bg-light"">
                    <div class=""product-img position-r");
            WriteLiteral("elative overflow-hidden\">\r\n                        <img class=\"img-fluid w-100\" src=\"img/product-4.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 22776, "\"", 22782, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"product-action\">\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 22910, "\"", 22917, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-shopping-cart\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 23030, "\"", 23037, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-heart\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 23143, "\"", 23150, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-sync-alt\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 23258, "\"", 23265, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-search\"></i></a>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"text-center py-4\">\r\n                        <a class=\"h6 text-decoration-none text-truncate\"");
            BeginWriteAttribute("href", " href=\"", 23485, "\"", 23492, 0);
            EndWriteAttribute();
            WriteLiteral(@">Product Name Goes Here</a>
                        <div class=""d-flex align-items-center justify-content-center mt-2"">
                            <h5>$123.00</h5>
                            <h6 class=""text-muted ml-2""><del>$123.00</del></h6>
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
                <div class=""product-item bg-light"">
                    <div class=""product-img position-r");
            WriteLiteral("elative overflow-hidden\">\r\n                        <img class=\"img-fluid w-100\" src=\"img/product-5.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 24620, "\"", 24626, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"product-action\">\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 24754, "\"", 24761, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-shopping-cart\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 24874, "\"", 24881, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-heart\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 24987, "\"", 24994, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-sync-alt\"></i></a>\r\n                            <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", " href=\"", 25102, "\"", 25109, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-search\"></i></a>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"text-center py-4\">\r\n                        <a class=\"h6 text-decoration-none text-truncate\"");
            BeginWriteAttribute("href", " href=\"", 25329, "\"", 25336, 0);
            EndWriteAttribute();
            WriteLiteral(@">Product Name Goes Here</a>
                        <div class=""d-flex align-items-center justify-content-center mt-2"">
                            <h5>$123.00</h5>
                            <h6 class=""text-muted ml-2""><del>$123.00</del></h6>
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
        </div>
    </div>
</div>
<!-- Products End -->");
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
