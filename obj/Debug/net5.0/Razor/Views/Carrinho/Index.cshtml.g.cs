#pragma checksum "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Carrinho\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5ab1f9a17d21b49bd1d7a6ac4c09c229222ae8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carrinho_Index), @"mvc.1.0.view", @"/Views/Carrinho/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5ab1f9a17d21b49bd1d7a6ac4c09c229222ae8d", @"/Views/Carrinho/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40962baed32f6c86f8ef8e0d9c0dc8925191f37a", @"/Views/_ViewImports.cshtml")]
    public class Views_Carrinho_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Carrinho\Index.cshtml"
  
    ViewBag.Subtitulo = "InfoTech";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Cart Start -->
<div class=""container-fluid"">
    <div class=""row px-xl-5"">
        <div class=""col-lg-8 table-responsive mb-5"">
            <table class=""table table-light table-borderless table-hover text-center mb-0"">
                <thead class=""thead-dark"">
                    <tr>
                        <th>Products</th>
                        <th>Price</th>
                        <th>Quantity</th>
                        <th>Total</th>
                        <th>Remove</th>
                    </tr>
                </thead>
                <tbody class=""align-middle"">
                    <tr>
                        <td class=""align-middle""><img src=""img/product-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 735, "\"", 741, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 50px;""> Product Name
                        </td>
                        <td class=""align-middle"">$150</td>
                        <td class=""align-middle"">
                            <div class=""input-group quantity mx-auto"" style=""width: 100px;"">
                                <div class=""input-group-btn"">
                                    <button class=""btn btn-sm btn-primary btn-minus"">
                                        <i class=""fa fa-minus""></i>
                                    </button>
                                </div>
                                <input type=""text""
                                    class=""form-control form-control-sm bg-secondary border-0 text-center"" value=""1"">
                                <div class=""input-group-btn"">
                                    <button class=""btn btn-sm btn-primary btn-plus"">
                                        <i class=""fa fa-plus""></i>
                                    </button>
                          ");
            WriteLiteral(@"      </div>
                            </div>
                        </td>
                        <td class=""align-middle"">$150</td>
                        <td class=""align-middle""><button class=""btn btn-sm btn-danger""><i
                                    class=""fa fa-times""></i></button></td>
                    </tr>
                    <tr>
                        <td class=""align-middle""><img src=""img/product-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2196, "\"", 2202, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 50px;""> Product Name
                        </td>
                        <td class=""align-middle"">$150</td>
                        <td class=""align-middle"">
                            <div class=""input-group quantity mx-auto"" style=""width: 100px;"">
                                <div class=""input-group-btn"">
                                    <button class=""btn btn-sm btn-primary btn-minus"">
                                        <i class=""fa fa-minus""></i>
                                    </button>
                                </div>
                                <input type=""text""
                                    class=""form-control form-control-sm bg-secondary border-0 text-center"" value=""1"">
                                <div class=""input-group-btn"">
                                    <button class=""btn btn-sm btn-primary btn-plus"">
                                        <i class=""fa fa-plus""></i>
                                    </button>
                          ");
            WriteLiteral(@"      </div>
                            </div>
                        </td>
                        <td class=""align-middle"">$150</td>
                        <td class=""align-middle""><button class=""btn btn-sm btn-danger""><i
                                    class=""fa fa-times""></i></button></td>
                    </tr>
                    <tr>
                        <td class=""align-middle""><img src=""img/product-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3657, "\"", 3663, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 50px;""> Product Name
                        </td>
                        <td class=""align-middle"">$150</td>
                        <td class=""align-middle"">
                            <div class=""input-group quantity mx-auto"" style=""width: 100px;"">
                                <div class=""input-group-btn"">
                                    <button class=""btn btn-sm btn-primary btn-minus"">
                                        <i class=""fa fa-minus""></i>
                                    </button>
                                </div>
                                <input type=""text""
                                    class=""form-control form-control-sm bg-secondary border-0 text-center"" value=""1"">
                                <div class=""input-group-btn"">
                                    <button class=""btn btn-sm btn-primary btn-plus"">
                                        <i class=""fa fa-plus""></i>
                                    </button>
                          ");
            WriteLiteral(@"      </div>
                            </div>
                        </td>
                        <td class=""align-middle"">$150</td>
                        <td class=""align-middle""><button class=""btn btn-sm btn-danger""><i
                                    class=""fa fa-times""></i></button></td>
                    </tr>
                    <tr>
                        <td class=""align-middle""><img src=""img/product-4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5118, "\"", 5124, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 50px;""> Product Name
                        </td>
                        <td class=""align-middle"">$150</td>
                        <td class=""align-middle"">
                            <div class=""input-group quantity mx-auto"" style=""width: 100px;"">
                                <div class=""input-group-btn"">
                                    <button class=""btn btn-sm btn-primary btn-minus"">
                                        <i class=""fa fa-minus""></i>
                                    </button>
                                </div>
                                <input type=""text""
                                    class=""form-control form-control-sm bg-secondary border-0 text-center"" value=""1"">
                                <div class=""input-group-btn"">
                                    <button class=""btn btn-sm btn-primary btn-plus"">
                                        <i class=""fa fa-plus""></i>
                                    </button>
                          ");
            WriteLiteral(@"      </div>
                            </div>
                        </td>
                        <td class=""align-middle"">$150</td>
                        <td class=""align-middle""><button class=""btn btn-sm btn-danger""><i
                                    class=""fa fa-times""></i></button></td>
                    </tr>
                    <tr>
                        <td class=""align-middle""><img src=""img/product-5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6579, "\"", 6585, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 50px;""> Product Name
                        </td>
                        <td class=""align-middle"">$150</td>
                        <td class=""align-middle"">
                            <div class=""input-group quantity mx-auto"" style=""width: 100px;"">
                                <div class=""input-group-btn"">
                                    <button class=""btn btn-sm btn-primary btn-minus"">
                                        <i class=""fa fa-minus""></i>
                                    </button>
                                </div>
                                <input type=""text""
                                    class=""form-control form-control-sm bg-secondary border-0 text-center"" value=""1"">
                                <div class=""input-group-btn"">
                                    <button class=""btn btn-sm btn-primary btn-plus"">
                                        <i class=""fa fa-plus""></i>
                                    </button>
                          ");
            WriteLiteral(@"      </div>
                            </div>
                        </td>
                        <td class=""align-middle"">$150</td>
                        <td class=""align-middle""><button class=""btn btn-sm btn-danger""><i
                                    class=""fa fa-times""></i></button></td>
                    </tr>
                </tbody>
            </table>
        </div>
        <div class=""col-lg-4"">
");
            WriteLiteral(@"            <h5 class=""section-title position-relative text-uppercase mb-3""><span class=""bg-secondary pr-3"">Cart
                    Summary</span></h5>
            <div class=""bg-light p-30 mb-5"">
                <div class=""border-bottom pb-2"">
                    <div class=""d-flex justify-content-between mb-3"">
                        <h6>Subtotal</h6>
                        <h6>$150</h6>
                    </div>
                    <div class=""d-flex justify-content-between"">
                        <h6 class=""font-weight-medium"">Shipping</h6>
                        <h6 class=""font-weight-medium"">$10</h6>
                    </div>
                </div>
                <div class=""pt-2"">
                    <div class=""d-flex justify-content-between mt-2"">
                        <h5>Total</h5>
                        <h5>$160</h5>
                    </div>
                    <button class=""btn btn-block btn-primary font-weight-bold my-3 py-3"">Proceed To Checkout</button>
                </div>
  ");
            WriteLiteral("          </div>\n        </div>\n    </div>\n</div>\n<!-- Cart End -->");
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
