#pragma checksum "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b657ce774b8a6eb58d118a9091931657e6b018b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b657ce774b8a6eb58d118a9091931657e6b018b", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa20e2268b79c993717e226215ffedb90f93602c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Produtos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Produto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Carrinho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_LoginPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n<html lang=\"pt-br\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b657ce774b8a6eb58d118a9091931657e6b018b7896", async() => {
                WriteLiteral(@"
  <meta charset=""utf-8"">
  <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
  <meta content=""width=device-width, initial-scale=1.0"" name=""viewport"">
  <meta content=""Free HTML Templates"" name=""keywords"">
  <meta content=""Free HTML Templates"" name=""description"">

  <link rel=""apple-touch-icon"" sizes=""180x180"" href=""/img/favicon/apple-icon-180x180.png"">
  <link rel=""icon"" type=""image/png"" sizes=""192x192"" href=""/img/favicon/android-icon-192x192.png"">
  <link rel=""icon"" type=""image/png"" sizes=""32x32"" href=""/img/favicon/favicon-32x32.png"">
  <link rel=""icon"" type=""image/png"" sizes=""96x96"" href=""/img/favicon/favicon-96x96.png"">
  <link rel=""icon"" type=""image/png"" sizes=""16x16"" href=""/img/favicon/favicon-16x16.png"">
  <link rel=""manifest"" href=""/img/favicon/manifest.json"">
  <meta name=""msapplication-TileColor"" content=""#ffffff"">
  <meta name=""msapplication-TileImage"" content=""/img/favicon/ms-icon-144x144.png"">
  <meta name=""theme-color"" content=""#ffffff"">

  <link rel=""styleshe");
                WriteLiteral(@"et"" href=""/lib/bootstrap/dist/css/bootstrap.min.css"">
  <link rel=""stylesheet"" href=""/lib/bootstrap-icons/font/bootstrap-icons.css"">
  <link rel=""stylesheet"" href=""/css/estilos.css"">
  <link rel=""stylesheet"" href=""/css/estilos.css"">

  <link href=""https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"" rel=""stylesheet"">
  
  <!-- Favicon -->
  <link href=""img/favicon.ico"" rel=""icon"">

  <!-- Google Web Fonts -->
  <link rel=""preconnect"" href=""https://fonts.gstatic.com"">
  <link href=""https://fonts.googleapis.com/css2?family=Roboto:wght@400;500;700&display=swap"" rel=""stylesheet"">

  <!-- Font Awesome -->
  <link href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.10.0/css/all.min.css"" rel=""stylesheet"">

  <!-- Libraries Stylesheet -->
  <link href=""lib/animate/animate.min.css"" rel=""stylesheet"">
  <link href=""lib/owlcarousel/assets/owl.carousel.min.css"" rel=""stylesheet"">
  <title>");
#nullable restore
#line 41 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Shared\_Layout.cshtml"
    Write(ViewBag.Subtitulo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b657ce774b8a6eb58d118a9091931657e6b018b11220", async() => {
                WriteLiteral("\r\n  <div class=\"d-flex flex-column wrapper\">\r\n    <div class=\"container-fluid\">\r\n      <div class=\"row align-items-center bg-dark py-3 px-xl-5 d-none d-lg-flex\">\r\n        <div class=\"col-lg-4\">\r\n          <a");
                BeginWriteAttribute("href", " href=\"", 2265, "\"", 2272, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""text-decoration-none"">
            <span class=""h1 text-uppercase text-primary bg-dark px-2"">BUY</span>
            <span class=""h1 text-uppercase text-dark bg-primary px-2 ml-n1"">SELL</span>
          </a>
        </div>
        <div class=""col-lg-4 col-6 text-left"">
          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3b657ce774b8a6eb58d118a9091931657e6b018b12154", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</partial>
        </div>
        <div class=""col-lg-4 col-6 text-right "">
          <p class=""m-0 text-white"">Customer Service</p>
          <h5 class=""m-0 text-white"">+012 345 6789</h5>
        </div>
      </div>
    </div>

    <div class=""container-fluid bg-dark mb-30"">
      <div class=""row px-xl-5"">
        <div class=""col-lg-3 d-none d-lg-block"">
          <a class=""btn d-flex align-items-center justify-content-between bg-primary w-100"" data-toggle=""collapse""
            href=""#navbar-vertical"" style=""height: 65px; padding: 0 30px;"">
            <h6 class=""text-dark m-0""><i class=""fa fa-bars mr-2""></i>Categorias</h6>
            <i class=""fa fa-angle-down text-dark""></i>
          </a>
          <nav class=""collapse position-absolute navbar navbar-vertical navbar-light align-items-start p-0 bg-light""
            id=""navbar-vertical"" style=""width: calc(100% - 30px); z-index: 999;"">
            <div class=""navbar-nav w-100"">
              ");
#nullable restore
#line 75 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Shared\_Layout.cshtml"
         Write(await Component.InvokeAsync("CategoryMenu"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n          </nav>\r\n        </div>\r\n        <div class=\"col-lg-9\">\r\n          <nav class=\"navbar navbar-expand-lg bg-dark navbar-dark py-3 py-lg-0 px-0\">\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 3802, "\"", 3809, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""text-decoration-none d-block d-lg-none"">
              <span class=""h1 text-uppercase text-dark bg-light px-2"">Multi</span>
              <span class=""h1 text-uppercase text-light bg-primary px-2 ml-n1"">Shop</span>
            </a>
            <button type=""button"" class=""navbar-toggler"" data-toggle=""collapse"" data-target=""#navbarCollapse"">
              <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse justify-content-between"" id=""navbarCollapse"">
              <div class=""navbar-nav mr-auto py-0"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b657ce774b8a6eb58d118a9091931657e6b018b15580", async() => {
                    WriteLiteral("Home");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b657ce774b8a6eb58d118a9091931657e6b018b17154", async() => {
                    WriteLiteral("Shop");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b657ce774b8a6eb58d118a9091931657e6b018b18689", async() => {
                    WriteLiteral("Shop Detail");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                <div class=""nav-item dropdown"">
                  <a href=""#"" class=""nav-link dropdown-toggle"" data-toggle=""dropdown"">Pages <i
                      class=""fa fa-angle-down mt-1""></i></a>
                  <div class=""dropdown-menu bg-primary rounded-0 border-0 m-0"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b657ce774b8a6eb58d118a9091931657e6b018b20534", async() => {
                    WriteLiteral("Shopping Cart");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b657ce774b8a6eb58d118a9091931657e6b018b22082", async() => {
                    WriteLiteral("Checkout");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b657ce774b8a6eb58d118a9091931657e6b018b23625", async() => {
                    WriteLiteral("Cadastrar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                  </div>\r\n                </div>\r\n                <a href=\"contact.html\" class=\"nav-item nav-link\">Contact</a>\r\n              </div>\r\n              <div class=\"navbar-nav ml-auto py-0 d-none d-lg-block\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3b657ce774b8a6eb58d118a9091931657e6b018b25404", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</partial>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 5673, "\"", 5680, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""btn px-0 ml-3"">
                  <i class=""fas fa-heart text-primary"" style=""font-size: 20px;""></i>
                  <span class=""badge text-secondary border border-secondary rounded-circle""
                    style=""padding-bottom: 2px;"">0</span>
                </a>
                ");
#nullable restore
#line 113 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Shared\_Layout.cshtml"
           Write(await Component.InvokeAsync("ShoppingCartSummary"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n              </div>\r\n            </div>\r\n          </nav>\r\n        </div>\r\n      </div>\r\n    </div>\r\n\r\n    <main class=\"flex-fill\">\r\n      ");
#nullable restore
#line 122 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Shared\_Layout.cshtml"
 Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"    </main>

    <!-- Footer Start -->
    <div class=""container-fluid bg-dark text-secondary mt-5 pt-5"">
      <div class=""row px-xl-5 pt-5"">
        <div class=""col-lg-4 col-md-12 mb-5 pr-3 pr-xl-5"">
          <h5 class=""text-secondary text-uppercase mb-4"">Get In Touch</h5>
          <p class=""mb-4"">No dolore ipsum accusam no lorem. Invidunt sed clita kasd clita et et dolor sed dolor. Rebum
            tempor no vero est magna amet no</p>
          <p class=""mb-2""><i class=""fa fa-map-marker-alt text-primary mr-3""></i>123 Street, New York, USA</p>
          <p class=""mb-2""><i class=""fa fa-envelope text-primary mr-3""></i>info@example.com</p>
          <p class=""mb-0""><i class=""fa fa-phone-alt text-primary mr-3""></i>+012 345 67890</p>
        </div>
        <div class=""col-lg-8 col-md-12"">
          <div class=""row"">
            <div class=""col-md-4 mb-5"">
              <h5 class=""text-secondary text-uppercase mb-4"">Quick Shop</h5>
              <div class=""d-flex flex-column justify-content-s");
                WriteLiteral(@"tart"">
                <a class=""text-secondary mb-2"" href=""#""><i class=""fa fa-angle-right mr-2""></i>Home</a>
                <a class=""text-secondary mb-2"" href=""#""><i class=""fa fa-angle-right mr-2""></i>Our Shop</a>
                <a class=""text-secondary mb-2"" href=""#""><i class=""fa fa-angle-right mr-2""></i>Shop Detail</a>
                <a class=""text-secondary mb-2"" href=""#""><i class=""fa fa-angle-right mr-2""></i>Shopping Cart</a>
                <a class=""text-secondary mb-2"" href=""#""><i class=""fa fa-angle-right mr-2""></i>Checkout</a>
                <a class=""text-secondary"" href=""#""><i class=""fa fa-angle-right mr-2""></i>Contact Us</a>
              </div>
            </div>
            <div class=""col-md-4 mb-5"">
              <h5 class=""text-secondary text-uppercase mb-4"">My Account</h5>
              <div class=""d-flex flex-column justify-content-start"">
                <a class=""text-secondary mb-2"" href=""#""><i class=""fa fa-angle-right mr-2""></i>Home</a>
                <a class=""text-s");
                WriteLiteral(@"econdary mb-2"" href=""#""><i class=""fa fa-angle-right mr-2""></i>Our Shop</a>
                <a class=""text-secondary mb-2"" href=""#""><i class=""fa fa-angle-right mr-2""></i>Shop Detail</a>
                <a class=""text-secondary mb-2"" href=""#""><i class=""fa fa-angle-right mr-2""></i>Shopping Cart</a>
                <a class=""text-secondary mb-2"" href=""#""><i class=""fa fa-angle-right mr-2""></i>Checkout</a>
                <a class=""text-secondary"" href=""#""><i class=""fa fa-angle-right mr-2""></i>Contact Us</a>
              </div>
            </div>
            <div class=""col-md-4 mb-5"">
              <h5 class=""text-secondary text-uppercase mb-4"">Newsletter</h5>
              <p>Duo stet tempor ipsum sit amet magna ipsum tempor est</p>
              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b657ce774b8a6eb58d118a9091931657e6b018b30762", async() => {
                    WriteLiteral(@"
                <div class=""input-group"">
                  <input type=""text"" class=""form-control"" placeholder=""Your Email Address"">
                  <div class=""input-group-append"">
                    <button class=""btn btn-primary"">Sign Up</button>
                  </div>
                </div>
              ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
              <h6 class=""text-secondary text-uppercase mt-4 mb-3"">Follow Us</h6>
              <div class=""d-flex"">
                <a class=""btn btn-primary btn-square mr-2"" href=""#""><i class=""fab fa-twitter""></i></a>
                <a class=""btn btn-primary btn-square mr-2"" href=""#""><i class=""fab fa-facebook-f""></i></a>
                <a class=""btn btn-primary btn-square mr-2"" href=""#""><i class=""fab fa-linkedin-in""></i></a>
                <a class=""btn btn-primary btn-square"" href=""#""><i class=""fab fa-instagram""></i></a>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class=""row border-top mx-xl-5 py-4"" style=""border-color: rgba(256, 256, 256, .1) !important;"">
        <div class=""col-md-6 px-xl-0"">
          <p class=""mb-md-0 text-center text-md-left text-secondary"">
            &copy; <a class=""text-primary"" href=""#"">Domain</a>. All Rights Reserved. Designed
            by
            <a class=""text-primary"" href=""https://htmlcodex.com"">");
                WriteLiteral("HTML Codex</a>\r\n          </p>\r\n        </div>\r\n        <div class=\"col-md-6 px-xl-0 text-center text-md-right\">\r\n          <img class=\"img-fluid\" src=\"img/payments.png\"");
                BeginWriteAttribute("alt", " alt=\"", 10597, "\"", 10603, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <!-- Footer End -->\r\n\r\n\r\n");
                WriteLiteral(@"  </div>
  <script src=""/node_modules/bootstrap/dist/js/bootstrap.bundle.min.js""></script>

  <!-- Back to Top -->
  <a href=""#"" class=""btn btn-primary back-to-top""><i class=""fa fa-angle-double-up""></i></a>


  <!-- JavaScript Libraries -->
  <script src=""https://code.jquery.com/jquery-3.4.1.min.js""></script>
  <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.bundle.min.js""></script>
  <script src=""/lib/easing/easing.min.js""></script>
  <script src=""/lib/owlcarousel/owl.carousel.min.js""></script>

  <!-- Contact Javascript File -->
  <script src=""/mail/jqBootstrapValidation.min.js""></script>
  <script src=""/mail/contact.js""></script>

  <!-- Template Javascript -->
  <script src=""/js/main.js""></script>
  <script src=""/js/site.js""></script>
  ");
#nullable restore
#line 257 "C:\Users\igors\Desktop\Curso\Projetos\AppEcommerce\Views\Shared\_Layout.cshtml"
Write(RenderSectionAsync("Scripts", required : false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
