#pragma checksum "C:\Users\bruna\Desktop\TRABALHO EDUARDO_VIOTTI\LojaInformatica - Versoes\LojaDeInformatica_V15\LojaDeInformatica\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51c7eed10f1209a7a9136e1dee3191212cfd1109"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Index), @"mvc.1.0.view", @"/Views/Produto/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Index.cshtml", typeof(AspNetCore.Views_Produto_Index))]
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
#line 1 "C:\Users\bruna\Desktop\TRABALHO EDUARDO_VIOTTI\LojaInformatica - Versoes\LojaDeInformatica_V15\LojaDeInformatica\Views\_ViewImports.cshtml"
using LojaDeInformatica;

#line default
#line hidden
#line 2 "C:\Users\bruna\Desktop\TRABALHO EDUARDO_VIOTTI\LojaInformatica - Versoes\LojaDeInformatica_V15\LojaDeInformatica\Views\_ViewImports.cshtml"
using LojaDeInformatica.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51c7eed10f1209a7a9136e1dee3191212cfd1109", @"/Views/Produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17d40d11851634eac522dbebd22e243c8d3fcc01", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProdutoViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/form.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("include", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\bruna\Desktop\TRABALHO EDUARDO_VIOTTI\LojaInformatica - Versoes\LojaDeInformatica_V15\LojaDeInformatica\Views\Produto\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(87, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(89, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05a2f31038ad444083dcc9f187d2ac71", async() => {
                BeginContext(124, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(130, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c6bcdb99485440eb9edefe88afeb6d63", async() => {
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
                BeginContext(196, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Include = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(212, 394, true);
            WriteLiteral(@"

<h2>Lista de Produtos</h2>
<a href=""/produto/create"" class=""btn btn-default"">Novo Produto </a>
<br />

<table class=""table table-responsive"">
    <tr>
        <th>Ações</th>
        <th>Codigo do Produto</th>
        <th>Descrição</th>
        <th>Categoria</th>
        <th>Preço</th>
        <th>Marca</th>
        <th>Quant. Estoque</th>
        <th>Imagem</th>
    </tr>
");
            EndContext();
#line 26 "C:\Users\bruna\Desktop\TRABALHO EDUARDO_VIOTTI\LojaInformatica - Versoes\LojaDeInformatica_V15\LojaDeInformatica\Views\Produto\Index.cshtml"
     foreach (var produto in Model)
    {

#line default
#line hidden
            BeginContext(650, 74, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                <a class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 724, "\"", 759, 2);
            WriteAttributeValue("", 731, "/produto/Edit?id=", 731, 17, true);
#line 30 "C:\Users\bruna\Desktop\TRABALHO EDUARDO_VIOTTI\LojaInformatica - Versoes\LojaDeInformatica_V15\LojaDeInformatica\Views\Produto\Index.cshtml"
WriteAttributeValue("", 748, produto.Id, 748, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(760, 54, true);
            WriteLiteral(">Editar</a>\r\n                <a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 814, "\"", 858, 3);
            WriteAttributeValue("", 821, "javascript:apagarProduto(", 821, 25, true);
#line 31 "C:\Users\bruna\Desktop\TRABALHO EDUARDO_VIOTTI\LojaInformatica - Versoes\LojaDeInformatica_V15\LojaDeInformatica\Views\Produto\Index.cshtml"
WriteAttributeValue("", 846, produto.Id, 846, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 857, ")", 857, 1, true);
            EndWriteAttribute();
            BeginContext(859, 50, true);
            WriteLiteral(">Apagar</a>\r\n            </td>\r\n\r\n            <td>");
            EndContext();
            BeginContext(910, 10, false);
#line 34 "C:\Users\bruna\Desktop\TRABALHO EDUARDO_VIOTTI\LojaInformatica - Versoes\LojaDeInformatica_V15\LojaDeInformatica\Views\Produto\Index.cshtml"
           Write(produto.Id);

#line default
#line hidden
            EndContext();
            BeginContext(920, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(944, 17, false);
#line 35 "C:\Users\bruna\Desktop\TRABALHO EDUARDO_VIOTTI\LojaInformatica - Versoes\LojaDeInformatica_V15\LojaDeInformatica\Views\Produto\Index.cshtml"
           Write(produto.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(961, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(985, 22, false);
#line 36 "C:\Users\bruna\Desktop\TRABALHO EDUARDO_VIOTTI\LojaInformatica - Versoes\LojaDeInformatica_V15\LojaDeInformatica\Views\Produto\Index.cshtml"
           Write(produto.Desc_Categoria);

#line default
#line hidden
            EndContext();
            BeginContext(1007, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1031, 13, false);
#line 37 "C:\Users\bruna\Desktop\TRABALHO EDUARDO_VIOTTI\LojaInformatica - Versoes\LojaDeInformatica_V15\LojaDeInformatica\Views\Produto\Index.cshtml"
           Write(produto.Preco);

#line default
#line hidden
            EndContext();
            BeginContext(1044, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1068, 18, false);
#line 38 "C:\Users\bruna\Desktop\TRABALHO EDUARDO_VIOTTI\LojaInformatica - Versoes\LojaDeInformatica_V15\LojaDeInformatica\Views\Produto\Index.cshtml"
           Write(produto.Desc_Marca);

#line default
#line hidden
            EndContext();
            BeginContext(1086, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1110, 19, false);
#line 39 "C:\Users\bruna\Desktop\TRABALHO EDUARDO_VIOTTI\LojaInformatica - Versoes\LojaDeInformatica_V15\LojaDeInformatica\Views\Produto\Index.cshtml"
           Write(produto.Qtd_Estoque);

#line default
#line hidden
            EndContext();
            BeginContext(1129, 63, true);
            WriteLiteral("</td>\r\n\r\n            <td>\r\n                <img id=\"imgPreview\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1192, "\"", 1245, 2);
            WriteAttributeValue("", 1198, "data:image/jpeg;base64,", 1198, 23, true);
#line 42 "C:\Users\bruna\Desktop\TRABALHO EDUARDO_VIOTTI\LojaInformatica - Versoes\LojaDeInformatica_V15\LojaDeInformatica\Views\Produto\Index.cshtml"
WriteAttributeValue(" ", 1221, produto.ImagemEmBase64, 1222, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1246, 94, true);
            WriteLiteral("\r\n                     class=\"img-responsive\" width=\"120\">\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 46 "C:\Users\bruna\Desktop\TRABALHO EDUARDO_VIOTTI\LojaInformatica - Versoes\LojaDeInformatica_V15\LojaDeInformatica\Views\Produto\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1347, 32, true);
            WriteLiteral("\r\n    <span class=\"text-danger\">");
            EndContext();
            BeginContext(1380, 12, false);
#line 48 "C:\Users\bruna\Desktop\TRABALHO EDUARDO_VIOTTI\LojaInformatica - Versoes\LojaDeInformatica_V15\LojaDeInformatica\Views\Produto\Index.cshtml"
                         Write(ViewBag.Erro);

#line default
#line hidden
            EndContext();
            BeginContext(1392, 212, true);
            WriteLiteral("</span>\r\n</table>\r\n<script>\r\n    function apagarProduto(id) {\r\n        if (confirm(\'Tem certeza que deseja excluir esse produto?\'))\r\n            location.href = \'/produto/Delete?id=\' + id;\r\n    }\r\n\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProdutoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591