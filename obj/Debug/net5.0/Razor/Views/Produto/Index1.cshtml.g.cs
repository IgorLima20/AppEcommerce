#pragma checksum "C:\Users\etec\Desktop\AppEcommerce\Views\Produto\Index1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "015ea3312fb3d65bb1072efc8b83f30944208b49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Index1), @"mvc.1.0.view", @"/Views/Produto/Index1.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"015ea3312fb3d65bb1072efc8b83f30944208b49", @"/Views/Produto/Index1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa20e2268b79c993717e226215ffedb90f93602c", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Index1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\etec\Desktop\AppEcommerce\Views\Produto\Index1.cshtml"
  
    ViewBag.Subtitulo = "InfoTech";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row g-3"">
    <div class=""col-12 col-sm-6"">
        <img src=""/img/produtos/000001.jpg"" class=""img-thumbnail"" id=""imgProduto"">
        <br class=""clearfix"">
        <div class=""row my-3 gx-3"">
            <div class=""col-3"">
                <img src=""/img/produtos/000001.jpg"" class=""img-thumbnail"" onclick=""trocarImagem(this)"">
            </div>
            <div class=""col-3"">
                <img src=""/img/produtos/000002.jpg"" class=""img-thumbnail"" onclick=""trocarImagem(this)"">
            </div>
            <div class=""col-3"">
                <img src=""/img/produtos/000003.jpg"" class=""img-thumbnail"" onclick=""trocarImagem(this)"">
            </div>
            <div class=""col-3"">
                <img src=""/img/produtos/000004.jpg"" class=""img-thumbnail"" onclick=""trocarImagem(this)"">
            </div>
        </div>
    </div>
    <div class=""col-12 col-sm-6"">
        <h1>Banana Prata</h1>
        <p>
            Quis officia irure deserunt reprehenderit sunt non ut amet. S");
            WriteLiteral(@"unt veniam cillum aliqua. Elit
            labore duis laboris reprehenderit laborum magna velit dolor veniam sint.
        </p>
        <p>
            Do ut ad quis et qui qui tempor do irure laborum ullamco excepteur. Adipisicing ipsum ad
            excepteur sit ipsum adipisicing. Ut ut elit proident fugiat. Ad deserunt et consequat
            aliquip nisi ut dolore sit ut veniam fugiat culpa nulla. Consequat eiusmod ad deserunt ad
            sunt adipisicing deserunt nulla est cupidatat commodo do. Minim aliquip dolor in deserunt
            elit officia. Anim duis ullamco cillum nulla voluptate dolore velit ad Lorem adipisicing.
        </p>
        <p>
            <button class=""btn btn-lg btn-danger mb-3 mb-xl-0 me-2"">
                <i class=""bi-cart""></i> Adicionar ao Carrinho
            </button>
            <button class=""btn btn-lg btn-outline-danger"">
                <i class=""bi-heart""></i> Adicionar aos Favoritos
            </button>
        </p>
    </div>
</div>");
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
