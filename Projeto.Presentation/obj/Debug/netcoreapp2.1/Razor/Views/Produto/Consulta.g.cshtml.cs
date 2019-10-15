#pragma checksum "C:\Users\Coti-Maq04\Desktop\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "567b599a1e50e6ce748ee966b6aece76f0c5d37a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Consulta), @"mvc.1.0.view", @"/Views/Produto/Consulta.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Consulta.cshtml", typeof(AspNetCore.Views_Produto_Consulta))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"567b599a1e50e6ce748ee966b6aece76f0c5d37a", @"/Views/Produto/Consulta.cshtml")]
    public class Views_Produto_Consulta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Projeto.Presentation.Models.ProdutoConsultaModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Coti-Maq04\Desktop\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
  
    ViewData["Title"] = "Consulta";
    Layout = "~/Views/Templates/Layout.cshtml";

#line default
#line hidden
            BeginContext(157, 95, true);
            WriteLiteral("\r\n<h4>Consulta de Produto</h4>\r\n<hr />\r\n<a href=\"/Home/Index\">voltar</a>\r\n\r\n<div>\r\n    <strong>");
            EndContext();
            BeginContext(253, 20, false);
#line 12 "C:\Users\Coti-Maq04\Desktop\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
       Write(TempData["Mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(273, 431, true);
            WriteLiteral(@"</strong>
</div>


<table class=""table table-bordered table-striped table-hover"">
    <thead>
        <tr>
            <td>Código</td>
            <td>Nome de Produto</td>
            <td width=""120"">Preço</td>
            <td>Quantidade</td>
            <td width=""120"">Total</td>
            <td>Data de Cadastro</td>
            <td width=""180"">Operações</td>
        </tr>
        
    </thead>

    <tbody>
");
            EndContext();
#line 31 "C:\Users\Coti-Maq04\Desktop\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(753, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(784, 14, false);
#line 34 "C:\Users\Coti-Maq04\Desktop\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
           Write(item.IdProduto);

#line default
#line hidden
            EndContext();
            BeginContext(798, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(822, 9, false);
#line 35 "C:\Users\Coti-Maq04\Desktop\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(831, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(855, 24, false);
#line 36 "C:\Users\Coti-Maq04\Desktop\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
           Write(item.Preco.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(879, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(903, 15, false);
#line 37 "C:\Users\Coti-Maq04\Desktop\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
           Write(item.Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(918, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(942, 24, false);
#line 38 "C:\Users\Coti-Maq04\Desktop\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
           Write(item.Total.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(966, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(990, 40, false);
#line 39 "C:\Users\Coti-Maq04\Desktop\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
           Write(item.DataCadastro.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1030, 43, true);
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1073, "\"", 1111, 2);
            WriteAttributeValue("", 1080, "/Produto/Edicao/", 1080, 16, true);
#line 41 "C:\Users\Coti-Maq04\Desktop\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
WriteAttributeValue("", 1096, item.IdProduto, 1096, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1112, 87, true);
            WriteLiteral(" \r\n                   class=\"btn btn-primary btn-sm\"> Atualizar</a>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1199, "\"", 1239, 2);
            WriteAttributeValue("", 1206, "/Produto/Exclusao/", 1206, 18, true);
#line 43 "C:\Users\Coti-Maq04\Desktop\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
WriteAttributeValue("", 1224, item.IdProduto, 1224, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1240, 99, true);
            WriteLiteral(" \r\n                   class=\"btn btn-danger btn-sm\">Excluir</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 47 "C:\Users\Coti-Maq04\Desktop\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
        }        

#line default
#line hidden
            BeginContext(1358, 95, true);
            WriteLiteral("    </tbody>\r\n\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"7\">Quantidade de Registro: ");
            EndContext();
            BeginContext(1454, 11, false);
#line 52 "C:\Users\Coti-Maq04\Desktop\Aula23\Projeto.Presentation\Views\Produto\Consulta.cshtml"
                                               Write(Model.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1465, 52, true);
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n\r\n    </tfoot>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Projeto.Presentation.Models.ProdutoConsultaModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
