#pragma checksum "C:\Users\Coti-Maq04\Desktop\Aula23\Projeto.Presentation\Views\Produto\Exclusao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41bef88146089c7b11411a6717d8ac8083695c33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Exclusao), @"mvc.1.0.view", @"/Views/Produto/Exclusao.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Exclusao.cshtml", typeof(AspNetCore.Views_Produto_Exclusao))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41bef88146089c7b11411a6717d8ac8083695c33", @"/Views/Produto/Exclusao.cshtml")]
    public class Views_Produto_Exclusao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Coti-Maq04\Desktop\Aula23\Projeto.Presentation\Views\Produto\Exclusao.cshtml"
  
    ViewData["Title"] = "Exclusao";
    Layout = "~/Views/Templates/Layout.cshtml";

#line default
#line hidden
            BeginContext(95, 174, true);
            WriteLiteral("\r\n<h4>Exclusao</h4>\r\n<hr />\r\n<a href=\"/Produto/Consulta\">Voltar</a>\r\n<br />\r\n<a href=\"/Home/Index\">Pagina Inicial</a>\r\n<div class=\"alert alert-danger col-md-4\">\r\n    <strong>");
            EndContext();
            BeginContext(270, 20, false);
#line 13 "C:\Users\Coti-Maq04\Desktop\Aula23\Projeto.Presentation\Views\Produto\Exclusao.cshtml"
       Write(TempData["Mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(290, 25, true);
            WriteLiteral("</strong>\r\n</div>\r\n\r\n\r\n\r\n");
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