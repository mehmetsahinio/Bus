#pragma checksum "C:\Users\WissenAkademie\Desktop\Buss-main\SahinTurizim\SahinTurizim.WebUI\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4128d14429158634504c2234a58953e67f3f26c0"
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
#line 1 "C:\Users\WissenAkademie\Desktop\Buss-main\SahinTurizim\SahinTurizim.WebUI\Views\_ViewImports.cshtml"
using SahinTurizim.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\WissenAkademie\Desktop\Buss-main\SahinTurizim\SahinTurizim.WebUI\Views\_ViewImports.cshtml"
using SahinTurizim.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\WissenAkademie\Desktop\Buss-main\SahinTurizim\SahinTurizim.WebUI\Views\_ViewImports.cshtml"
using SahinTurizim.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4128d14429158634504c2234a58953e67f3f26c0", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70beb6cee5c89ecc5a798eca34a0f5cd3e967bce", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/style-starter.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Header", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("subscribe"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--\nAuthor: W3layouts\nAuthor URL: http://w3layouts.com\n-->\n<!doctype html>\n<html lang=\"zxx\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4128d14429158634504c2234a58953e67f3f26c06552", async() => {
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <title>SahinTurizim</title>
    <!-- google fonts -->
    <link href=""//fonts.googleapis.com/css2?family=Montserrat:wght@300;400;600;700&display=swap"" rel=""stylesheet"">
    <link href=""//fonts.googleapis.com/css2?family=Lato:ital,wght@0,300;0,400;0,700;1,400&display=swap""
          rel=""stylesheet"">
    <!-- google fonts -->
    <!-- Template CSS -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4128d14429158634504c2234a58953e67f3f26c07333", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    <!-- Template CSS -->\n");
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
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4128d14429158634504c2234a58953e67f3f26c09241", async() => {
                WriteLiteral("\n    <!--header-->\n    <!-- //header -->\n    <!--banner-slider-->\n    <!-- main-slider -->\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4128d14429158634504c2234a58953e67f3f26c09595", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n    <main role=\"main\">\n        ");
#nullable restore
#line 31 "C:\Users\WissenAkademie\Desktop\Buss-main\SahinTurizim\SahinTurizim.WebUI\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </main>


    <footer>
        <!-- footer -->
        <section class=""w3l-footer"">
            <div class=""w3l-footer-16-main py-5"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-lg-6 column"">
                            <div class=""row"">
                                <div class=""col-md-4 column"">
                                    <h3>Company</h3>
                                    <ul class=""footer-gd-16"">
                                        <li><a href=""index.html"">Home</a></li>
                                        <li><a href=""about.html"">About Us</a></li>
                                        <li><a href=""services.html"">Services</a></li>
                                        <li><a href=""blog.html"">Blog</a></li>
                                        <li><a href=""contact.html"">Contact Us</a></li>
                                    </ul>
                                </div>
                                <div");
                WriteLiteral(@" class=""col-md-4 column mt-md-0 mt-4"">
                                    <h3>Useful Links</h3>
                                    <ul class=""footer-gd-16"">
                                        <li><a href=""#url"">Destinations</a></li>
                                        <li><a href=""#url"">Our Branches</a></li>
                                        <li><a href=""#url"">Latest Media</a></li>
                                        <li><a href=""about.html"">About Company</a></li>
                                        <li><a href=""#url"">Our Packages</a></li>
                                    </ul>
                                </div>
                                <div class=""col-md-4 column mt-md-0 mt-4"">
                                    <h3>Our Services</h3>
                                    <ul class=""footer-gd-16"">
                                        <li><a href=""#url"">Privacy Policy</a></li>
                                        <li><a href=""#url"">Our Terms</a></li>
                ");
                WriteLiteral(@"                        <li><a href=""services.html"">Services</a></li>
                                        <li><a href=""landing-single.html"">Landing Page</a></li>
                                        <li><a href=""#url"">Our Guides</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-6 col-md-12 column pl-lg-5 column4 mt-lg-0 mt-5"">
                            <h3>Newsletter </h3>
                            <div class=""end-column"">
                                <h4>Get latest updates and offers.</h4>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4128d14429158634504c2234a58953e67f3f26c013918", async() => {
                    WriteLiteral("\n                                    <input type=\"email\" name=\"email\" placeholder=\"Email Address\"");
                    BeginWriteAttribute("required", " required=\"", 3768, "\"", 3779, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\n                                    <button type=\"submit\">Go</button>\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                <p>Sign up for our latest news & articles. We won’t give you spam mails.</p>
                            </div>
                        </div>
                    </div>
                    <div class=""d-flex below-section justify-content-between align-items-center pt-4 mt-5"">
                        <div class=""columns text-lg-left text-center"">
                            <p>
                                &copy; 2020 Traversal. All rights reserved.Design by <a href=""https://w3layouts.com/"" target=""_blank"">
                                    W3Layouts
                                </a>
                            </p>
                        </div>
                        <div class=""columns-2 mt-lg-0 mt-3"">
                            <ul class=""social"">
                                <li>
                                    <a href=""#facebook""><span class=""fa fa-facebook"" aria-hidden=""true""></span></a>
                                </li>
                            ");
                WriteLiteral(@"    <li>
                                    <a href=""#linkedin""><span class=""fa fa-linkedin"" aria-hidden=""true""></span></a>
                                </li>
                                <li>
                                    <a href=""#twitter""><span class=""fa fa-twitter"" aria-hidden=""true""></span></a>
                                </li>
                                <li>
                                    <a href=""#google""><span class=""fa fa-google-plus"" aria-hidden=""true""></span></a>
                                </li>
                                <li>
                                    <a href=""#github""><span class=""fa fa-github"" aria-hidden=""true""></span></a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>

            <!-- move top -->
            <button onclick=""topFunction()"" id=""movetop"" title=""Go to top"">
                <span class=""fa fa-angle-up""></span>");
                WriteLiteral(@"
            </button>
            <script>// When the user scrolls down 20px from the top of the document, show the button
                window.onscroll = function () {
                    scrollFunction()
                };

                function scrollFunction() {
                    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
                        document.getElementById(""movetop"").style.display = ""block"";
                    } else {
                        document.getElementById(""movetop"").style.display = ""none"";
                    }
                }

                // When the user clicks on the button, scroll to the top of the document
                function topFunction() {
                    document.body.scrollTop = 0;
                    document.documentElement.scrollTop = 0;
                }</script>
            <!-- //move top -->
            <script>$(function () {
                    $('.navbar-toggler').click(function () {
                    ");
                WriteLiteral(@"    $('body').toggleClass('noscroll');
                    })
                });</script>
        </section>
        <!-- //footer -->
    </footer>
    <!-- Template JavaScript -->
    <script src=""assets/js/jquery-3.3.1.min.js""></script>
    <script src=""assets/js/theme-change.js""></script>
    <!--/slider-js-->
    <script src=""assets/js/jquery.min.js""></script>
    <script src=""assets/js/modernizr-2.6.2.min.js""></script>
    <script src=""assets/js/jquery.zoomslider.min.js""></script>
    <!--//slider-js-->
    <script src=""assets/js/owl.carousel.js""></script>
    <!-- script for tesimonials carousel slider -->

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4128d14429158634504c2234a58953e67f3f26c019850", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n");
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
            WriteLiteral("\n\n</html>");
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
