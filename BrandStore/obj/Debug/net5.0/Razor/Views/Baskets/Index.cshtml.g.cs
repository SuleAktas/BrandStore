#pragma checksum "C:\Users\merve\Desktop\tasarim\BrandStore\BrandStore\Views\Baskets\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3099e3025acf7d9df9eaab2b020afb7d54c1b23f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Baskets_Index), @"mvc.1.0.view", @"/Views/Baskets/Index.cshtml")]
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
#line 1 "C:\Users\merve\Desktop\tasarim\BrandStore\BrandStore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\merve\Desktop\tasarim\BrandStore\BrandStore\Views\_ViewImports.cshtml"
using BrandStore.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\merve\Desktop\tasarim\BrandStore\BrandStore\Views\_ViewImports.cshtml"
using BrandStore.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3099e3025acf7d9df9eaab2b020afb7d54c1b23f", @"/Views/Baskets/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c30212125b8a6f84fdd7ddff03e0a54681013bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Baskets_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BrandStore.Models.BasketItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-full "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "removeFromBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Baskets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BuyProducts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\merve\Desktop\tasarim\BrandStore\BrandStore\Views\Baskets\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3099e3025acf7d9df9eaab2b020afb7d54c1b23f6186", async() => {
                WriteLiteral(@"

    <link href=""https://unpkg.com/tailwindcss@2.2.19/dist/tailwind.min.css"" rel=""stylesheet"" />
    <link href=""https://cdn.jsdelivr.net/gh/alpinejs/alpine@v2.x.x/dist/alpine.min.js"" rel=""stylesheet"" />
    <link href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"" rel=""stylesheet"" />
    <link href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"" rel=""stylesheet"" />
    <script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>
    <style>
        .card {
            margin: 50px;
            margin-block-start: 50px;
            border: 0px green;
        }
    </style>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3099e3025acf7d9df9eaab2b020afb7d54c1b23f7852", async() => {
                WriteLiteral("\r\n    <div class=\"card w-full p-4 px-5 py-5\">\r\n        <div class=\"md:grid md:grid-cols-3 gap-2 \">\r\n            <div class=\"col-span-2 p-5\">\r\n                <h1 class=\"text-xl font-medium \">My Basket</h1>\r\n");
#nullable restore
#line 27 "C:\Users\merve\Desktop\tasarim\BrandStore\BrandStore\Views\Baskets\Index.cshtml"
                 if (Model != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\merve\Desktop\tasarim\BrandStore\BrandStore\Views\Baskets\Index.cshtml"
                     if (Model.Any())
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\merve\Desktop\tasarim\BrandStore\BrandStore\Views\Baskets\Index.cshtml"
                         foreach (var _basket in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div");
                BeginWriteAttribute("class", " class=\"", 1261, "\"", 1269, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <div class=\"flex justify-between items-center mt-6 pt-6\">\r\n                                    <div class=\"flex items-center\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3099e3025acf7d9df9eaab2b020afb7d54c1b23f9498", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1483, "~/img/", 1483, 6, true);
#nullable restore
#line 36 "C:\Users\merve\Desktop\tasarim\BrandStore\BrandStore\Views\Baskets\Index.cshtml"
AddHtmlAttributeValue("", 1489, _basket.Product.MainPhoto, 1489, 26, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        <div class=\"flex flex-col ml-3\"> <span class=\"md:text-md font-medium\"> ");
#nullable restore
#line 37 "C:\Users\merve\Desktop\tasarim\BrandStore\BrandStore\Views\Baskets\Index.cshtml"
                                                                                                          Write(_basket.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span> <span class=""text-xs font-light text-gray-400""></span> </div>
                                    </div>
                                    <div class=""flex justify-center items-center"">
                                        <div class=""pr-8 md:text-md font-medium""> <span class=""text-xs font-medium"">Fiyat: $");
#nullable restore
#line 40 "C:\Users\merve\Desktop\tasarim\BrandStore\BrandStore\Views\Baskets\Index.cshtml"
                                                                                                                       Write(_basket.Product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span> </div>\r\n                                        <div>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3099e3025acf7d9df9eaab2b020afb7d54c1b23f12416", async() => {
                    WriteLiteral("<i class=\"fa fa-close text-xs font-medium\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\merve\Desktop\tasarim\BrandStore\BrandStore\Views\Baskets\Index.cshtml"
                                                                                       WriteLiteral(_basket.Product.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 45 "C:\Users\merve\Desktop\tasarim\BrandStore\BrandStore\Views\Baskets\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\merve\Desktop\tasarim\BrandStore\BrandStore\Views\Baskets\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\merve\Desktop\tasarim\BrandStore\BrandStore\Views\Baskets\Index.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <p style=\"margin-left:50px;\">Sepetin bos gorunuyor...</p>\r\n");
#nullable restore
#line 51 "C:\Users\merve\Desktop\tasarim\BrandStore\BrandStore\Views\Baskets\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                <div class=""flex justify-between items-center mt-6 pt-6 border-t"">
                    <div class=""flex items-center""> <i class=""fa fa-arrow-left text-sm pr-2""></i> <span class=""text-md font-medium text-green-500"">Contiune Shopping</span> </div>
                    <div class=""flex justify-center items-end""> <span class=""text-sm font-medium text-gray-400 mr-1"">Total Price:</span><span class=""text-lg font-bold text-gray-800 ""> ");
#nullable restore
#line 55 "C:\Users\merve\Desktop\tasarim\BrandStore\BrandStore\Views\Baskets\Index.cshtml"
                                                                                                                                                                                   Write(ViewData["ToplamFiyat"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" TL</span> </div>
                </div>
            </div>
            <div class=""card p-5 bg-gray-800 rounded overflow-visible"">
                <span class=""text-xl font-medium text-gray-100 block pb-3"">Card Details</span> <span class=""text-xs text-gray-400 "">Kart Tipi</span>
                <div class=""overflow-visible flex justify-between items-center mt-2"">
                    <div class=""rounded w-52 h-28 bg-gray-500 py-2 px-4 relative right-10"">
                        <span class=""italic text-lg font-medium text-gray-200 underline"">VISA</span>
                        <div class=""flex justify-between items-center pt-4 ""> <span class=""text-xs text-gray-200 font-medium"">****</span> <span class=""text-xs text-gray-200 font-medium"">****</span> <span class=""text-xs text-gray-200 font-medium"">****</span> <span class=""text-xs text-gray-200 font-medium"">****</span> </div>
                        <div class=""flex justify-between items-center mt-3""> <span class=""text-xs text-gray-200"">Giga Tamarashvili");
                WriteLiteral(@"</span> <span class=""text-xs text-gray-200"">12/18</span> </div>
                    </div>
                    <div class=""flex justify-center items-center flex-col""> <img src=""https://img.icons8.com/color/96/000000/mastercard-logo.png"" width=""40"" class=""relative right-5"" /> <span class=""text-xs font-medium text-gray-200 bottom-2 relative right-5"">mastercard.</span> </div>
                </div>
                <div class=""flex justify-center flex-col pt-3""> <label class=""text-xs text-gray-400 "">Card Name</label> <input type=""text"" class=""focus:outline-none w-full h-6 bg-gray-800 text-white placeholder-gray-300 text-sm border-b border-gray-600 py-4""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4711, "\"", 4725, 0);
                EndWriteAttribute();
                WriteLiteral(@"> </div>
                <div class=""flex justify-center flex-col pt-3""> <label class=""text-xs text-gray-400 "">Card </label> <input type=""text"" class=""focus:outline-none w-full h-6 bg-gray-800 text-white placeholder-gray-300 text-sm border-b border-gray-600 py-4"" placeholder=""**** **** **** ****""> </div>
                <div class=""grid grid-cols-3 gap-2 pt-2 mb-3"">
                    <div class=""col-span-2 "">
                        <label class=""text-xs text-gray-400"">Son Kullanma Tarihi</label>
                        <div class=""grid grid-cols-2 gap-2""> <input type=""text"" class=""focus:outline-none w-full h-6 bg-gray-800 text-white placeholder-gray-300 text-sm border-b border-gray-600 py-4"" placeholder=""mm""> <input type=""text"" class=""focus:outline-none w-full h-6 bg-gray-800 text-white placeholder-gray-300 text-sm border-b border-gray-600 py-4"" placeholder=""yyyy""> </div>
                    </div>
                    <div");
                BeginWriteAttribute("class", " class=\"", 5672, "\"", 5680, 0);
                EndWriteAttribute();
                WriteLiteral(@"> <label class=""text-xs text-gray-400"">CVV</label> <input type=""text"" class=""focus:outline-none w-full h-6 bg-gray-800 text-white placeholder-gray-300 text-sm border-b border-gray-600 py-4"" placeholder=""XXX""> </div>
                </div>
            </div> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3099e3025acf7d9df9eaab2b020afb7d54c1b23f20107", async() => {
                    WriteLiteral("\r\n                <button name=\"basketId\"");
                    BeginWriteAttribute("value", " value=\"", 6052, "\"", 6081, 1);
#nullable restore
#line 78 "C:\Users\merve\Desktop\tasarim\BrandStore\BrandStore\Views\Baskets\Index.cshtml"
WriteAttributeValue("", 6060, ViewData["BasketID"], 6060, 21, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" class=\"h-12 w-full bg-green-500 rounded focus:outline-none text-white hover:bg-blue-600\">Order</button>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    </div>                    \r\n\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BrandStore.Models.BasketItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
