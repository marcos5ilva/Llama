#pragma checksum "C:\Users\nerea\source\repos\NewLlama\Llama\Llama\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31a59dcb2a3ff02c2e5d08336d47c0732b514a0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\nerea\source\repos\NewLlama\Llama\Llama\Views\_ViewImports.cshtml"
using Llama;

#line default
#line hidden
#line 2 "C:\Users\nerea\source\repos\NewLlama\Llama\Llama\Views\_ViewImports.cshtml"
using Llama.Models;

#line default
#line hidden
#line 3 "C:\Users\nerea\source\repos\NewLlama\Llama\Llama\Views\_ViewImports.cshtml"
using Llama.Models.Miscellaneous;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31a59dcb2a3ff02c2e5d08336d47c0732b514a0e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f05c742b7425d53b84a35901cf85f131aa0a7f05", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/llamaLogo.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imgLlamaLogo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/llamaBus.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imgLlamaBus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/floorLine.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/landPageLlama.svg "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imgLandPageLlama "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\nerea\source\repos\NewLlama\Llama\Llama\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 5118, true);
            WriteLiteral(@"
<!-- ASP.NET example page 
<div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"" data-interval=""6000"">
    <ol class=""carousel-indicators"">
        <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#myCarousel"" data-slide-to=""1""></li>
        <li data-target=""#myCarousel"" data-slide-to=""2""></li>
    </ol>
    <div class=""carousel-inner"" role=""listbox"">
        <div class=""item active"">
            <img src=""~/images/banner1.svg"" alt=""ASP.NET"" class=""img-responsive"" />
            <div class=""carousel-caption"" role=""option"">
                <p>
                    Learn how to build ASP.NET apps that can run anywhere.
                    <a class=""btn btn-default"" href=""https://go.microsoft.com/fwlink/?LinkID=525028&clcid=0x409"">
                        Learn More
                    </a>
                </p>
            </div>
        </div>
        <div class=""item"">
            <img src=""~/images/banner2.svg"" alt=""Visual Studio"" cl");
            WriteLiteral(@"ass=""img-responsive"" />
            <div class=""carousel-caption"" role=""option"">
                <p>
                    There are powerful new features in Visual Studio for building modern web apps.
                    <a class=""btn btn-default"" href=""https://go.microsoft.com/fwlink/?LinkID=525030&clcid=0x409"">
                        Learn More
                    </a>
                </p>
            </div>
        </div>
        <div class=""item"">
            <img src=""~/images/banner3.svg"" alt=""Microsoft Azure"" class=""img-responsive"" />
            <div class=""carousel-caption"" role=""option"">
                <p>
                    Learn how Microsoft's Azure cloud platform allows you to build, deploy, and scale web apps.
                    <a class=""btn btn-default"" href=""https://go.microsoft.com/fwlink/?LinkID=525027&clcid=0x409"">
                        Learn More
                    </a>
                </p>
            </div>
        </div>
    </div>
    <a class=""left carous");
            WriteLiteral(@"el-control"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
        <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""right carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""next"">
        <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>

<div class=""row"">
    <div class=""col-md-3"">
        <h2>Application uses</h2>
        <ul>
            <li>Sample pages using ASP.NET Core MVC</li>
            <li>Theming using <a href=""https://go.microsoft.com/fwlink/?LinkID=398939"">Bootstrap</a></li>
        </ul>
    </div>
    <div class=""col-md-3"">
        <h2>How to</h2>
        <ul>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=398600"">Add a Controller and View</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699315"">Manage User Secrets using Secret Manager.</a");
            WriteLiteral(@"></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699316"">Use logging to log a message.</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699317"">Add packages using NuGet.</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699319"">Target development, staging or production environment.</a></li>
        </ul>
    </div>
    <div class=""col-md-3"">
        <h2>Overview</h2>
        <ul>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=518008"">Conceptual overview of what is ASP.NET Core</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699320"">Fundamentals of ASP.NET Core such as Startup and middleware.</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=398602"">Working with Data</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=398603"">Security</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=699321"">Client side development");
            WriteLiteral(@"</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=699322"">Develop on different platforms</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=699323"">Read more on the documentation site</a></li>
        </ul>
    </div>
    <div class=""col-md-3"">
        <h2>Run &amp; Deploy</h2>
        <ul>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=517851"">Run your app</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=517853"">Run tools such as EF migrations and more</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=398609"">Publish to Microsoft Azure Web Apps</a></li>
        </ul>
    </div>
</div>
-->
<div class=""container landPageContainer "">
   <!--Llama app Navbar -->
      <nav class=""navbar navbar-default  navbar-fixed-top  "">
            <div class=""container-fluid"">
                    <div class=""navbar-header navbar-right"">
                    <a class=""navbar-brand "" href=""#"">");
            EndContext();
            BeginContext(5163, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "31a59dcb2a3ff02c2e5d08336d47c0732b514a0e11386", async() => {
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
            EndContext();
            BeginContext(5218, 626, true);
            WriteLiteral(@"</a>
                    </div>
                    <ul class=""nav navbar-nav navbar-right"">
                    <li class=""active""><a href=""#"">Home</a></li>
                    <li><a href=""#"">Join</a></li>
                    <li><a href=""#"">Parents</a></li>
                    <li><a href=""#"">Help</a></li>
                    </ul>
                
            </div>
        </nav>
    <!--End of Llama app Navbar -->
    
    

    
        <!--<div class="" text-center imgLlamaBus"">
            <img src=""~/images/llamaBus.svg"">
        </div>-->

        <div class="" floorLandPage"">
            ");
            EndContext();
            BeginContext(5844, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "31a59dcb2a3ff02c2e5d08336d47c0732b514a0e13284", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5897, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(5911, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "31a59dcb2a3ff02c2e5d08336d47c0732b514a0e14552", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5945, 58, true);
            WriteLiteral("  \r\n        </div>\r\n        \r\n        <div >\r\n            ");
            EndContext();
            BeginContext(6003, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "31a59dcb2a3ff02c2e5d08336d47c0732b514a0e15787", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6069, 182, true);
            WriteLiteral("\r\n        </div>\r\n    \r\n    <div class=\"text-center\">\r\n        <button class=\"btnPlay\">PLAY</button>\r\n    </div>\r\n                    \r\n            \r\n        \r\n    \r\n\r\n    \r\n</div>\r\n");
            EndContext();
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
