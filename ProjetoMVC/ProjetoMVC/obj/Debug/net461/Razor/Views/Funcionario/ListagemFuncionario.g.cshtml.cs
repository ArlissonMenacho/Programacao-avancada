#pragma checksum "D:\Arquivos\Donwload's\Antigos\Github\Programacao-avancada\ProjetoMVC\ProjetoMVC\Views\Funcionario\ListagemFuncionario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86efd640539faf3fa26303f30228d541609bfe10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionario_ListagemFuncionario), @"mvc.1.0.view", @"/Views/Funcionario/ListagemFuncionario.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Funcionario/ListagemFuncionario.cshtml", typeof(AspNetCore.Views_Funcionario_ListagemFuncionario))]
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
#line 1 "D:\Arquivos\Donwload's\Antigos\Github\Programacao-avancada\ProjetoMVC\ProjetoMVC\Views\_ViewImports.cshtml"
using ProjetoMVC;

#line default
#line hidden
#line 2 "D:\Arquivos\Donwload's\Antigos\Github\Programacao-avancada\ProjetoMVC\ProjetoMVC\Views\_ViewImports.cshtml"
using ProjetoMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86efd640539faf3fa26303f30228d541609bfe10", @"/Views/Funcionario/ListagemFuncionario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d9614e30ac05eda474dd37096940e5ebaae5c83", @"/Views/_ViewImports.cshtml")]
    public class Views_Funcionario_ListagemFuncionario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjetoMVC.Models.Funcionario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Arquivos\Donwload's\Antigos\Github\Programacao-avancada\ProjetoMVC\ProjetoMVC\Views\Funcionario\ListagemFuncionario.cshtml"
  
    ViewData["Title"] = "Listagem Funcionario";

#line default
#line hidden
            BeginContext(107, 702, true);
            WriteLiteral(@"
<h2>ListagemFuncionario</h2>
div>
<input type=""text"" name=""campo1"" placeholder=""Informe o Funcionario"" />
<input type=""submit"" name=""botao1"" value=""Buscar"" />
</div><br />

<a href=""/Funcionario/Novo"" class=""btn btn-default"">Novo Funcionario</a>
<table class=""table table-hover table-striped"">
    <tr>
        <th>
            Nome
        </th>
        <th>
            CPF
        </th>
        <th>
            Cargo
        </th>
        <th>
            Matricula
        </th>
        <th>
           Pis
        </th>
        <th>
            Data de Admissão
        </th>
        <th>
            Salário 
        </th>        
        <th></th>
    </tr>

");
            EndContext();
#line 39 "D:\Arquivos\Donwload's\Antigos\Github\Programacao-avancada\ProjetoMVC\ProjetoMVC\Views\Funcionario\ListagemFuncionario.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(850, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(899, 9, false);
#line 43 "D:\Arquivos\Donwload's\Antigos\Github\Programacao-avancada\ProjetoMVC\ProjetoMVC\Views\Funcionario\ListagemFuncionario.cshtml"
           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(908, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(964, 8, false);
#line 46 "D:\Arquivos\Donwload's\Antigos\Github\Programacao-avancada\ProjetoMVC\ProjetoMVC\Views\Funcionario\ListagemFuncionario.cshtml"
           Write(item.Cpf);

#line default
#line hidden
            EndContext();
            BeginContext(972, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1028, 10, false);
#line 49 "D:\Arquivos\Donwload's\Antigos\Github\Programacao-avancada\ProjetoMVC\ProjetoMVC\Views\Funcionario\ListagemFuncionario.cshtml"
           Write(item.Cargo);

#line default
#line hidden
            EndContext();
            BeginContext(1038, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1094, 14, false);
#line 52 "D:\Arquivos\Donwload's\Antigos\Github\Programacao-avancada\ProjetoMVC\ProjetoMVC\Views\Funcionario\ListagemFuncionario.cshtml"
           Write(item.Matricula);

#line default
#line hidden
            EndContext();
            BeginContext(1108, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1164, 8, false);
#line 55 "D:\Arquivos\Donwload's\Antigos\Github\Programacao-avancada\ProjetoMVC\ProjetoMVC\Views\Funcionario\ListagemFuncionario.cshtml"
           Write(item.Pis);

#line default
#line hidden
            EndContext();
            BeginContext(1172, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1228, 17, false);
#line 58 "D:\Arquivos\Donwload's\Antigos\Github\Programacao-avancada\ProjetoMVC\ProjetoMVC\Views\Funcionario\ListagemFuncionario.cshtml"
           Write(item.DataAdmissao);

#line default
#line hidden
            EndContext();
            BeginContext(1245, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1301, 12, false);
#line 61 "D:\Arquivos\Donwload's\Antigos\Github\Programacao-avancada\ProjetoMVC\ProjetoMVC\Views\Funcionario\ListagemFuncionario.cshtml"
           Write(item.Salario);

#line default
#line hidden
            EndContext();
            BeginContext(1313, 69, true);
            WriteLiteral("\r\n            </td>            \r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1382, "\"", 1411, 2);
            WriteAttributeValue("", 1389, "/livro/editar/", 1389, 14, true);
#line 64 "D:\Arquivos\Donwload's\Antigos\Github\Programacao-avancada\ProjetoMVC\ProjetoMVC\Views\Funcionario\ListagemFuncionario.cshtml"
WriteAttributeValue("", 1403, item.Id, 1403, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1412, 89, true);
            WriteLiteral(" class=\"btn btn-default\"><i class=\"glyphicon glyphicon-edit\"></i></a>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1501, "\"", 1531, 2);
            WriteAttributeValue("", 1508, "/livro/Excluir/", 1508, 15, true);
#line 65 "D:\Arquivos\Donwload's\Antigos\Github\Programacao-avancada\ProjetoMVC\ProjetoMVC\Views\Funcionario\ListagemFuncionario.cshtml"
WriteAttributeValue("", 1523, item.Id, 1523, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1532, 105, true);
            WriteLiteral(" class=\"btn btn-danger\"><i class=\"glyphicon glyphicon-trash\"></i></a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 68 "D:\Arquivos\Donwload's\Antigos\Github\Programacao-avancada\ProjetoMVC\ProjetoMVC\Views\Funcionario\ListagemFuncionario.cshtml"
    }

#line default
#line hidden
            BeginContext(1644, 12, true);
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjetoMVC.Models.Funcionario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
