#pragma checksum "C:\Users\leand\OneDrive\Área de Trabalho\Biblioteca\Views\Emprestimo\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd0e3e42231f1e9cfd20730db5cbeaa4d38e6635"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Emprestimo_Listagem), @"mvc.1.0.view", @"/Views/Emprestimo/Listagem.cshtml")]
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
#line 1 "C:\Users\leand\OneDrive\Área de Trabalho\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leand\OneDrive\Área de Trabalho\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd0e3e42231f1e9cfd20730db5cbeaa4d38e6635", @"/Views/Emprestimo/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac979cfa6f9c2014e1ebeda333546c494974b6fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Emprestimo_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Emprestimo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Usuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Livro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\leand\OneDrive\Área de Trabalho\Biblioteca\Views\Emprestimo\Listagem.cshtml"
  

    ViewData["Title"] = "Listagem de Empréstimos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-12\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd0e3e42231f1e9cfd20730db5cbeaa4d38e66354914", async() => {
                WriteLiteral("\n            <div class=\"form-group mb-2\">\n                <select name=\"TipoFiltro\" class=\"form-control\">\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd0e3e42231f1e9cfd20730db5cbeaa4d38e66355304", async() => {
                    WriteLiteral("Usuário");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd0e3e42231f1e9cfd20730db5cbeaa4d38e66356546", async() => {
                    WriteLiteral("Livro");
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
                WriteLiteral(@"
                </select>
            </div>
            <div class=""form-group mb-2 mx-sm-3"">
                <input type=""text"" placeholder=""Filtro"" name=""Filtro"" class=""form-control"" />
            </div>
            <button type=""submit"" class=""btn btn-primary mb-2"">Pesquisar</button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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

<div class=""row"">
    <div class=""col-md-12"">
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Usuario</th>
                    <th>Data Empréstimo</th>
                    <th>Data Devolução</th>
                    <th>Livro</th>
                    <th>Autor</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 39 "C:\Users\leand\OneDrive\Área de Trabalho\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                 foreach (Emprestimo e in Model)

                {
                    DateTime emprestimo = new DateTime();
                    emprestimo = e.DataDevolucao;
                    int result = DateTime.Compare(emprestimo, DateTime.Now);

                    if (result < 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <style>
                            .atraso{
                                background-color: #ff99c2;
                            }
                        </style>
                    <tr class=""atraso"">
                        <td>");
#nullable restore
#line 54 "C:\Users\leand\OneDrive\Área de Trabalho\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                       Write(e.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 55 "C:\Users\leand\OneDrive\Área de Trabalho\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                       Write(e.NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 56 "C:\Users\leand\OneDrive\Área de Trabalho\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                       Write(e.DataEmprestimo.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 57 "C:\Users\leand\OneDrive\Área de Trabalho\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                       Write(e.DataDevolucao.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 58 "C:\Users\leand\OneDrive\Área de Trabalho\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                       Write(e.Livro.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 59 "C:\Users\leand\OneDrive\Área de Trabalho\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                       Write(e.Livro.Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 2089, "\"", 2120, 2);
            WriteAttributeValue("", 2096, "/Emprestimo/Edicao/", 2096, 19, true);
#nullable restore
#line 60 "C:\Users\leand\OneDrive\Área de Trabalho\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 2115, e.Id, 2115, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\n                    </tr>\n");
#nullable restore
#line 62 "C:\Users\leand\OneDrive\Área de Trabalho\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                    } else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                        <td>");
#nullable restore
#line 64 "C:\Users\leand\OneDrive\Área de Trabalho\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                       Write(e.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 65 "C:\Users\leand\OneDrive\Área de Trabalho\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                       Write(e.NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 66 "C:\Users\leand\OneDrive\Área de Trabalho\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                       Write(e.DataEmprestimo.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 67 "C:\Users\leand\OneDrive\Área de Trabalho\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                       Write(e.DataDevolucao.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 68 "C:\Users\leand\OneDrive\Área de Trabalho\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                       Write(e.Livro.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 69 "C:\Users\leand\OneDrive\Área de Trabalho\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                       Write(e.Livro.Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 2582, "\"", 2613, 2);
            WriteAttributeValue("", 2589, "/Emprestimo/Edicao/", 2589, 19, true);
#nullable restore
#line 70 "C:\Users\leand\OneDrive\Área de Trabalho\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 2608, e.Id, 2608, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\n                    </tr>\n");
#nullable restore
#line 72 "C:\Users\leand\OneDrive\Área de Trabalho\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                    }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                }\n            </tbody>\n        </table>\n");
#nullable restore
#line 78 "C:\Users\leand\OneDrive\Área de Trabalho\Biblioteca\Views\Emprestimo\Listagem.cshtml"
         for (int i = 1; i <= (int)ViewData["Paginas"]; i++)

        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 2844, "\"", 2877, 2);
            WriteAttributeValue("", 2851, "/Emprestimo/Listagem/?p=", 2851, 24, true);
#nullable restore
#line 81 "C:\Users\leand\OneDrive\Área de Trabalho\Biblioteca\Views\Emprestimo\Listagem.cshtml"
WriteAttributeValue("", 2875, i, 2875, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 81 "C:\Users\leand\OneDrive\Área de Trabalho\Biblioteca\Views\Emprestimo\Listagem.cshtml"
                                            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n");
#nullable restore
#line 82 "C:\Users\leand\OneDrive\Área de Trabalho\Biblioteca\Views\Emprestimo\Listagem.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n");
#nullable restore
#line 86 "C:\Users\leand\OneDrive\Área de Trabalho\Biblioteca\Views\Emprestimo\Listagem.cshtml"
Write(ViewData["MensagemE"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Emprestimo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
