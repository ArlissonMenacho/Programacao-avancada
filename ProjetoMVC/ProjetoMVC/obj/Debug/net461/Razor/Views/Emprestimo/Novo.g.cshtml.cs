#pragma checksum "D:\Arquivos\Donwload's\Antigos\Github\Programacao-avancada\ProjetoMVC\ProjetoMVC\Views\Emprestimo\Novo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18ee47e4cceb22a3ce1a0b8b5ab7e815afaacf3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Emprestimo_Novo), @"mvc.1.0.view", @"/Views/Emprestimo/Novo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Emprestimo/Novo.cshtml", typeof(AspNetCore.Views_Emprestimo_Novo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18ee47e4cceb22a3ce1a0b8b5ab7e815afaacf3f", @"/Views/Emprestimo/Novo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d9614e30ac05eda474dd37096940e5ebaae5c83", @"/Views/_ViewImports.cshtml")]
    public class Views_Emprestimo_Novo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjetoMVC.Models.Emprestimo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Arquivos\Donwload's\Antigos\Github\Programacao-avancada\ProjetoMVC\ProjetoMVC\Views\Emprestimo\Novo.cshtml"
  
    ViewData["Title"] = "Novo";

#line default
#line hidden
            BeginContext(90, 251, true);
            WriteLiteral("<h2> Cadastro de Emprestimos</h2>\r\n\r\n<div class=\"container\">\r\n\r\n    <div class=\"page-header\">\r\n        <h1>Cadastro de Livros</h1>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-12\">\r\n            <h3>Informe os dados</h3>\r\n            ");
            EndContext();
            BeginContext(341, 639, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a655b565e8bf4bc3862e3144afeba68e", async() => {
                BeginContext(361, 612, true);
                WriteLiteral(@"

                <div class=""form-grup"">
                    <label for=""DtEmprestimo"">Data de Emprestimo: </label>
                    <input type=""date"" class=""form-control"" id=""DtEmprestimo"" name=""DtEmprestimo"">
                </div>

                <div class=""form-grup"">
                    <label for=""valorTotal"">Valor Total: </label>
                    <input type=""number"" class=""form-control"" id=""valorTotal"" name=""valorTotal"">
                </div>

                <button type=""submit"" class=""btn btn-default"">
                    Salvar
                </button>

            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(980, 36, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjetoMVC.Models.Emprestimo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
