#pragma checksum "C:\Users\User\Desktop\githubs\Tasarim\BilgisayarMuhendisligiTasarimi\BrandStore\BrandStore\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fd640a9675f120fce68a292f2816938a923b942"
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
#line 1 "C:\Users\User\Desktop\githubs\Tasarim\BilgisayarMuhendisligiTasarimi\BrandStore\BrandStore\Views\_ViewImports.cshtml"
using BrandStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\githubs\Tasarim\BilgisayarMuhendisligiTasarimi\BrandStore\BrandStore\Views\_ViewImports.cshtml"
using BrandStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fd640a9675f120fce68a292f2816938a923b942", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1be913c05b64572871c417d1ead2a01dd694f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "/Views/Shared/_LoginPartial.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fd640a9675f120fce68a292f2816938a923b9424830", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->

    <title>");
#nullable restore
#line 9 "C:\Users\User\Desktop\githubs\Tasarim\BilgisayarMuhendisligiTasarimi\BrandStore\BrandStore\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" - BrandStore</title>

    <!-- Google font -->
    <link href=""https://fonts.googleapis.com/css?family=Montserrat:400,500,700"" rel=""stylesheet"">

    <!-- Bootstrap -->
    <link type=""text/css"" rel=""stylesheet"" href=""css/bootstrap.min.css"" />

    <!-- Slick -->
    <link type=""text/css"" rel=""stylesheet"" href=""css/slick.css"" />
    <link type=""text/css"" rel=""stylesheet"" href=""css/slick-theme.css"" />

    <!-- nouislider -->
    <link type=""text/css"" rel=""stylesheet"" href=""css/nouislider.min.css"" />

    <!-- Font Awesome Icon -->
    <link rel=""stylesheet"" href=""css/font-awesome.min.css"">

    <!-- Custom stlylesheet -->
    <link type=""text/css"" rel=""stylesheet"" href=""css/style.css"" />

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src=""https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js""></script>
      <script src=""htt");
                WriteLiteral("ps://oss.maxcdn.com/respond/1.4.2/respond.min.js\"></script>\r\n    <![endif]-->\r\n\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fd640a9675f120fce68a292f2816938a923b9427554", async() => {
                WriteLiteral(@"
    <header>
        <!-- TOP HEADER -->
        <div id=""top-header"">
            <div class=""container"">
                <ul class=""header-links pull-left"">
                    <li><a href=""#""><i class=""fa fa-phone""></i> +90-554-54-54</a></li>
                    <li><a href=""#""><i class=""fa fa-envelope-o""></i> sule.aktas1@email.com</a></li>
                    <li><a href=""#""><i class=""fa fa-map-marker""></i> Sakarya Universitesi</a></li>
                </ul>
                <ul class=""header-links pull-right"">
                    <li><a href=""#""><i class=""fa fa-dollar""></i> TL</a></li>
                    <li><a href=""#""><i class=""fa fa-user-o""></i> Benim Hesabim</a></li>
                </ul>
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6fd640a9675f120fce68a292f2816938a923b9428575", async() => {
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
                WriteLiteral(@"
            </div>
        </div>
        <!-- /TOP HEADER -->
        <!-- MAIN HEADER -->
        <div id=""header"">
            <!-- container -->
            <div class=""container"">
                <!-- row -->
                <div class=""row"">
                    <!-- LOGO -->
                    <div class=""col-md-3"">
                        <div class=""header-logo"">
                            <a href=""#"" class=""logo"">
                                <!--<img src=""./img/logo.png"" alt=""""> -->
                                <h1 style=""color:white;"">BrandStore</h1>
                            </a>
                        </div>
                    </div>
                    <!-- /LOGO -->
                    <!-- SEARCH BAR -->
                    <div class=""col-md-6"">
                        <div class=""header-search"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fd640a9675f120fce68a292f2816938a923b94210661", async() => {
                    WriteLiteral("\r\n                                <select class=\"input-select\">\r\n                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fd640a9675f120fce68a292f2816938a923b94211031", async() => {
                        WriteLiteral("Kategoriler");
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
                    WriteLiteral("\r\n                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fd640a9675f120fce68a292f2816938a923b94212360", async() => {
                        WriteLiteral("Kiyafet");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fd640a9675f120fce68a292f2816938a923b94213685", async() => {
                        WriteLiteral("Ayakkabi");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                </select>\r\n                                <input class=\"input\" placeholder=\"Search here\">\r\n                                <button class=\"search-btn\">Ara</button>\r\n                            ");
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
                    <!-- /SEARCH BAR -->
                    <!-- ACCOUNT -->
                    <div class=""col-md-3 clearfix"">
                        <div class=""header-ctn"">
                            <!-- Wishlist -->
                            <div>
                                <a href=""#"">
                                    <i class=""fa fa-heart-o""></i>
                                    <span>Istek Listem</span>
                                    <div class=""qty"">2</div>
                                </a>
                            </div>
                            <!-- /Wishlist -->
                            <!-- Cart -->
                            <div class=""dropdown"">
                                <a class=""dropdown-toggle"" data-toggle=""dropdown"" aria-expanded=""true"">
                                    <i class=""fa fa-shopping-cart""></i>
                                    <span>Sepetim</span>
      ");
                WriteLiteral(@"                              <div class=""qty"">3</div>
                                </a>
                                <div class=""cart-dropdown"">
                                    <div class=""cart-list"">
                                        <div class=""product-widget"">
                                            <div class=""product-img"">
                                                <img src=""./img/product01.png""");
                BeginWriteAttribute("alt", " alt=\"", 5137, "\"", 5143, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            </div>
                                            <div class=""product-body"">
                                                <h3 class=""product-name""><a href=""#"">product name goes here</a></h3>
                                                <h4 class=""product-price""><span class=""qty"">1x</span>980.00TL</h4>
                                            </div>
                                            <button class=""delete""><i class=""fa fa-close""></i></button>
                                        </div>

                                        <div class=""product-widget"">
                                            <div class=""product-img"">
                                                <img src=""./img/product02.png""");
                BeginWriteAttribute("alt", " alt=\"", 5931, "\"", 5937, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            </div>
                                            <div class=""product-body"">
                                                <h3 class=""product-name""><a href=""#"">product name goes here</a></h3>
                                                <h4 class=""product-price""><span class=""qty"">3x</span>980.00TL</h4>
                                            </div>
                                            <button class=""delete""><i class=""fa fa-close""></i></button>
                                        </div>
                                    </div>
                                    <div class=""cart-summary"">
                                        <small>3 Item(s) selected</small>
                                        <h5>SUBTOTAL: $2940.00</h5>
                                    </div>
                                    <div class=""cart-btns"">
                                        <a href=""#"">Sepeti Goruntule</a>
                           ");
                WriteLiteral(@"             <a href=""#"">Ode  <i class=""fa fa-arrow-circle-right""></i></a>
                                    </div>
                                </div>
                            </div>
                            <!-- /Cart -->
                            <!-- Menu Toogle -->
                            <div class=""menu-toggle"">
                                <a href=""#"">
                                    <i class=""fa fa-bars""></i>
                                    <span>Menu</span>
                                </a>
                            </div>
                            <!-- /Menu Toogle -->
                        </div>
                    </div>
                    <!-- /ACCOUNT -->
                </div>
                <!-- row -->
            </div>
            <!-- container -->
        </div>
        <!-- /MAIN HEADER -->
    </header>
    <div class=""container"">
        <main role=""main"" class=""pb-3"">
            ");
#nullable restore
#line 161 "C:\Users\User\Desktop\githubs\Tasarim\BilgisayarMuhendisligiTasarimi\BrandStore\BrandStore\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </main>
    </div>

    <footer id=""footer"">
        <!-- top footer -->
        <div class=""section"">
            <!-- container -->
            <div class=""container"">
                <!-- row -->
                <div class=""row"">
                    <div class=""col-md-3 col-xs-6"">
                        <div class=""footer"">
                            <h3 class=""footer-title"">Hakkimizda</h3>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut.</p>
                            <ul class=""footer-links"">
                                <li><a href=""#""><i class=""fa fa-map-marker""></i>Sakarya Universitesi</a></li>
                                <li><a href=""#""><i class=""fa fa-phone""></i>+90-554-54-54</a></li>
                                <li><a href=""#""><i class=""fa fa-envelope-o""></i>merve.keceli@email.com</a></li>
                            </ul>
                        </div>
                    </div>");
                WriteLiteral(@"

                    <div class=""col-md-3 col-xs-6"">
                        <div class=""footer"">
                            <h3 class=""footer-title"">Kategoriler</h3>
                            <ul class=""footer-links"">
                                <li><a href=""#"">Indirimler</a></li>
                                <li><a href=""#"">Elbise</a></li>
                                <li><a href=""#"">Pantolon</a></li>
                                <li><a href=""#"">Ayakkabi</a></li>
                                <li><a href=""#"">Aksesuar</a></li>
                            </ul>
                        </div>
                    </div>

                    <div class=""clearfix visible-xs""></div>

                    <div class=""col-md-3 col-xs-6"">
                        <div class=""footer"">
                            <h3 class=""footer-title"">Bilgiler</h3>
                            <ul class=""footer-links"">
                                <li><a href=""#"">Hakkimizda</a></li>
         ");
                WriteLiteral(@"                       <li><a href=""#"">Bize Ulas</a></li>
                                <li><a href=""#"">Gizlilik</a></li>
                                <li><a href=""#"">Siparisler ve Geri Donusler</a></li>
                                <li><a href=""#"">Terms & Conditions</a></li>
                            </ul>
                        </div>
                    </div>

                    <div class=""col-md-3 col-xs-6"">
                        <div class=""footer"">
                            <h3 class=""footer-title"">Servisler</h3>
                            <ul class=""footer-links"">
                                <li><a href=""#"">Hesabim</a></li>
                                <li><a href=""#"">Sepeti Goruntule</a></li>
                                <li><a href=""#"">Istek Listesi</a></li>
                                <li><a href=""#"">Siparisimi Izle</a></li>
                                <li><a href=""#"">Yardim</a></li>
                            </ul>
                        </di");
                WriteLiteral(@"v>
                    </div>
                </div>
                <!-- /row -->
            </div>
            <!-- /container -->
        </div>
        <!-- /top footer -->
        <!-- bottom footer -->
        <div id=""bottom-footer"" class=""section"">
            <div class=""container"">
                <!-- row -->
                <div class=""row"">
                    <div class=""col-md-12 text-center"">
                        <ul class=""footer-payments"">
                            <li><a href=""#""><i class=""fa fa-cc-visa""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-credit-card""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-cc-paypal""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-cc-mastercard""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-cc-discover""></i></a></li>
                            <li><a href=""#""><i class=""fa fa-cc-amex""></i></a></li>
                       ");
                WriteLiteral(@" </ul>
                        <span class=""copyright"">
                            <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                            Copyright &copy;
                            <script>document.write(new Date().getFullYear());</script> Tum Haklar Korunur.
                            <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                        </span>
                    </div>
                </div>
                <!-- /row -->
            </div>
            <!-- /container -->
        </div>
        <!-- /bottom footer -->
    </footer>
    <!-- /FOOTER -->
    <!-- jQuery Plugins -->
    <script src=""js/jquery.min.js""></script>
    <script src=""js/bootstrap.min.js""></script>
    <script src=""js/slick.min.js""></script>
    <script src=""js/nouislider.min.js""></script>
    <script src=""js/jquery.zoom.min.js""></script>
    <script src=""js/main.js""></script>
");
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
            WriteLiteral("\r\n\r\n</html>\r\n");
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