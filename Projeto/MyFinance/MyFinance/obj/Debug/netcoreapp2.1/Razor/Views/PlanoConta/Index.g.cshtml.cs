#pragma checksum "C:\Users\Jean\Documents\projetos\Cursos\Sistema de Gestao Financeira\Projeto\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4324793d90d4e337eb25ea59bf5175772bacb39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PlanoConta_Index), @"mvc.1.0.view", @"/Views/PlanoConta/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PlanoConta/Index.cshtml", typeof(AspNetCore.Views_PlanoConta_Index))]
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
#line 1 "C:\Users\Jean\Documents\projetos\Cursos\Sistema de Gestao Financeira\Projeto\MyFinance\MyFinance\Views\_ViewImports.cshtml"
using MyFinance;

#line default
#line hidden
#line 2 "C:\Users\Jean\Documents\projetos\Cursos\Sistema de Gestao Financeira\Projeto\MyFinance\MyFinance\Views\_ViewImports.cshtml"
using MyFinance.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4324793d90d4e337eb25ea59bf5175772bacb39", @"/Views/PlanoConta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d05dd6abef5a8ff60f9a555c67ee727241a6c480", @"/Views/_ViewImports.cshtml")]
    public class Views_PlanoConta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Jean\Documents\projetos\Cursos\Sistema de Gestao Financeira\Projeto\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 256, true);
            WriteLiteral(@"
<h3>Plano de contas</h3>

<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>#</th>
            <th>#</th>
            <th>ID</th>
            <th>Descricao</th>
            <th>Tipo</th>
        </tr>
    </thead>
");
            EndContext();
#line 18 "C:\Users\Jean\Documents\projetos\Cursos\Sistema de Gestao Financeira\Projeto\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml"
      

        
        foreach (var item in (List<PlanoContasModel>)ViewBag.ListaPlanoContas)
        {

#line default
#line hidden
            BeginContext(410, 82, true);
            WriteLiteral("            <tbody>\r\n                <td><button type=\"button\" class=\"btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 492, "\"", 529, 3);
            WriteAttributeValue("", 502, "Editar(", 502, 7, true);
#line 24 "C:\Users\Jean\Documents\projetos\Cursos\Sistema de Gestao Financeira\Projeto\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml"
WriteAttributeValue("", 509, item.Id.ToString(), 509, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 528, ")", 528, 1, true);
            EndWriteAttribute();
            BeginContext(530, 83, true);
            WriteLiteral(">Editar</button></td>\r\n                <td><button type=\"button\" class=\"btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 613, "\"", 651, 3);
            WriteAttributeValue("", 623, "Excluir(", 623, 8, true);
#line 25 "C:\Users\Jean\Documents\projetos\Cursos\Sistema de Gestao Financeira\Projeto\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml"
WriteAttributeValue("", 631, item.Id.ToString(), 631, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 650, ")", 650, 1, true);
            EndWriteAttribute();
            BeginContext(652, 44, true);
            WriteLiteral(">Excluir</button></td>\r\n                <td>");
            EndContext();
            BeginContext(697, 18, false);
#line 26 "C:\Users\Jean\Documents\projetos\Cursos\Sistema de Gestao Financeira\Projeto\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml"
               Write(item.Id.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(715, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(743, 25, false);
#line 27 "C:\Users\Jean\Documents\projetos\Cursos\Sistema de Gestao Financeira\Projeto\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml"
               Write(item.Descricao.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(768, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(796, 20, false);
#line 28 "C:\Users\Jean\Documents\projetos\Cursos\Sistema de Gestao Financeira\Projeto\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml"
               Write(item.Tipo.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(816, 29, true);
            WriteLiteral("</td>\r\n            </tbody>\r\n");
            EndContext();
#line 30 "C:\Users\Jean\Documents\projetos\Cursos\Sistema de Gestao Financeira\Projeto\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml"
        }
        
    

#line default
#line hidden
            BeginContext(873, 503, true);
            WriteLiteral(@"
</table>

<button type=""button"" class=""btn btn-block btn-primary"" onclick=""CriarPlanoConta()"">Criar Plano de Conta</button>

<script>
    function CriarPlanoConta() {
        window.location.href = ""../PlanoConta/CriarPlanoConta"";
    }

    function Excluir(id_conta) {
        window.location.href = ""../PlanoConta/ExcluirPlanoConta/"" + id_conta;
    }

    function Editar(id_conta) {
        window.location.href = ""../PlanoConta/CriarPlanoConta/"" + id_conta;
    }

</script>

");
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