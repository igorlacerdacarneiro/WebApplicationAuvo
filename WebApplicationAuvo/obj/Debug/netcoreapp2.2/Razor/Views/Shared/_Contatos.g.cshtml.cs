#pragma checksum "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b85e98e39ce6f991c50e52920df21a6d256758de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Contatos), @"mvc.1.0.view", @"/Views/Shared/_Contatos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Contatos.cshtml", typeof(AspNetCore.Views_Shared__Contatos))]
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
#line 1 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\_ViewImports.cshtml"
using WebApplicationAuvo;

#line default
#line hidden
#line 2 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\_ViewImports.cshtml"
using WebApplicationAuvo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b85e98e39ce6f991c50e52920df21a6d256758de", @"/Views/Shared/_Contatos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdb58cac71faca833866d4ec5604514649f430ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Contatos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ContatoModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formEditar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditarContato", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-2 mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(29, 137, true);
            WriteLiteral("\r\n<div class=\"card p-3 mb-4\" id=\"divFormEditar\" style=\"display: none;\">\r\n    <h6 class=\"text-left\"><span>Editar Contato</span></h6>\r\n    ");
            EndContext();
            BeginContext(166, 1419, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b85e98e39ce6f991c50e52920df21a6d256758de5005", async() => {
                BeginContext(237, 1341, true);
                WriteLiteral(@"
        <div class=""form-group"" style=""display: none;"">
            <label for=""exampleInputId"">Id</label>
            <input type=""number"" class=""form-control"" name=""id"" id=""exampleInputId"" placeholder=""Id"">
        </div>
        <div class=""form-group"">
            <label for=""exampleInputNome"">Nome</label>
            <input type=""text"" class=""form-control"" name=""nome"" id=""exampleInputNome"" placeholder=""Nome"">
        </div>
        <div class=""form-group"">
            <label for=""exampleInputCargo"">Cargo</label>
            <input type=""text"" class=""form-control"" name=""cargo"" id=""exampleInputCargo"" placeholder=""Cargo"">
        </div>
        <div class=""form-group"">
            <label for=""exampleInputEmail"">Email</label>
            <input type=""text"" class=""form-control"" name=""email"" id=""exampleInputEmail"" placeholder=""Email"">
        </div>
        <div class=""form-group"">
            <label for=""exampleInputTelefone"">Telefone</label>
            <input type=""text"" class=""form-cont");
                WriteLiteral(@"rol"" name=""telefone"" id=""exampleInputTelefone"" placeholder=""Telefone"">
        </div>
        <button type=""submit"" style=""color: #8300E9;"" class=""btn btn-link"">Salvar</button>
        <a id=""lnk"" href=""javascript:;"" class=""btn btn-link"" style=""color: #8300E9;"" onclick=""editarContatoCancelar()"">Cancelar</a>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1585, 133, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"card p-3\">\r\n    <h5 class=\"text-left\"><span style=\"border-bottom: 2px solid #000;\">Contatos</span></h5>\r\n    ");
            EndContext();
            BeginContext(1718, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b85e98e39ce6f991c50e52920df21a6d256758de8552", async() => {
                BeginContext(1742, 175, true);
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <input type=\"text\" class=\"form-control\" id=\"input_buscar\" aria-describedby=\"Buscar\" placeholder=\"Buscar\">\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1924, 15, true);
            WriteLiteral("\r\n\r\n    <div>\r\n");
            EndContext();
#line 41 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
         foreach (var contato in Model)
        {

#line default
#line hidden
            BeginContext(1991, 248, true);
            WriteLiteral("            <div id=\"accordion\">\r\n                <div class=\"border mb-2\">\r\n                    <h5 class=\"mb-0\">\r\n                        <button class=\"btn btn-link\" style=\"width:100%; color: #000;\" data-toggle=\"collapse\" data-target=\"#collapse_");
            EndContext();
            BeginContext(2240, 10, false);
#line 46 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
                                                                                                                               Write(contato.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2250, 23, true);
            WriteLiteral("\" aria-expanded=\"false\"");
            EndContext();
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 2273, "\"", 2309, 2);
            WriteAttributeValue("", 2289, "collapse_", 2289, 9, true);
#line 46 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
WriteAttributeValue("", 2298, contato.Id, 2298, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2310, 168, true);
            WriteLiteral(">\r\n                            <i class=\"fa fa-user\" style=\"float: left; padding: 3px;\" aria-hidden=\"true\"></i>\r\n                            <span style=\"float: left;\">");
            EndContext();
            BeginContext(2479, 12, false);
#line 48 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
                                                  Write(contato.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2491, 212, true);
            WriteLiteral("</span>\r\n                            <i class=\"fa fa-angle-down\" style=\"float: right; padding: 3px;\" aria-hidden=\"true\"></i>\r\n                        </button>\r\n                    </h5>\r\n                    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2703, "\"", 2728, 2);
            WriteAttributeValue("", 2708, "collapse_", 2708, 9, true);
#line 52 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
WriteAttributeValue("", 2717, contato.Id, 2717, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2729, 69, true);
            WriteLiteral(" class=\"collapse\" data-parent=\"#accordion\">\r\n                        ");
            EndContext();
            BeginContext(2798, 1744, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b85e98e39ce6f991c50e52920df21a6d256758de13224", async() => {
                BeginContext(2826, 224, true);
                WriteLiteral("\r\n                            <div class=\"form-group m-0\" style=\"display: none;\">\r\n                                <input type=\"number\" disabled class=\"form-control\" style=\"background:none; border: none;\" id=\"exampleInputId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3050, "\"", 3069, 1);
#line 55 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
WriteAttributeValue("", 3058, contato.Id, 3058, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3070, 278, true);
                WriteLiteral(@" placeholder=""Id"">
                            </div>
                            <div class=""form-group m-0"" style=""display: none;"">
                                <input type=""text"" disabled class=""form-control"" style=""background:none; border: none;"" id=""exampleInputNome""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3348, "\"", 3369, 1);
#line 58 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
WriteAttributeValue("", 3356, contato.Nome, 3356, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3370, 258, true);
                WriteLiteral(@" placeholder=""Nome"">
                            </div>
                            <div class=""form-group m-0"">
                                <input type=""text"" disabled class=""form-control"" style=""background:none; border: none;"" id=""exampleInputCargo""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3628, "\"", 3650, 1);
#line 61 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
WriteAttributeValue("", 3636, contato.Cargo, 3636, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3651, 259, true);
                WriteLiteral(@" placeholder=""Cargo"">
                            </div>
                            <div class=""form-group m-0"">
                                <input type=""text"" disabled class=""form-control"" style=""background:none; border: none;"" id=""exampleInputEmail""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3910, "\"", 3932, 1);
#line 64 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
WriteAttributeValue("", 3918, contato.Email, 3918, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3933, 262, true);
                WriteLiteral(@" placeholder=""Email"">
                            </div>
                            <div class=""form-group m-0"">
                                <input type=""text"" disabled class=""form-control"" style=""background:none; border: none;"" id=""exampleInputTelefone""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4195, "\"", 4220, 1);
#line 67 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
WriteAttributeValue("", 4203, contato.Telefone, 4203, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4221, 166, true);
                WriteLiteral(" placeholder=\"Telefone\">\r\n                            </div>\r\n                            <a id=\"lnk\" href=\"javascript:;\" class=\"btn btn-link\" style=\"color: #8300E9;\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 4387, "\"", 4497, 15);
                WriteAttributeValue("", 4397, "editarContato(", 4397, 14, true);
#line 69 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
WriteAttributeValue("", 4411, contato.Id, 4411, 11, false);

#line default
#line hidden
                WriteAttributeValue("", 4422, ",", 4422, 1, true);
                WriteAttributeValue(" ", 4423, "\'", 4424, 2, true);
#line 69 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
WriteAttributeValue("", 4425, contato.Nome, 4425, 13, false);

#line default
#line hidden
                WriteAttributeValue("", 4438, "\',", 4438, 2, true);
                WriteAttributeValue(" ", 4440, "\'", 4441, 2, true);
#line 69 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
WriteAttributeValue("", 4442, contato.Cargo, 4442, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 4456, "\',", 4456, 2, true);
                WriteAttributeValue(" ", 4458, "\'", 4459, 2, true);
#line 69 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
WriteAttributeValue("", 4460, contato.Email, 4460, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 4474, "\',", 4474, 2, true);
                WriteAttributeValue(" ", 4476, "\'", 4477, 2, true);
#line 69 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
WriteAttributeValue("", 4478, contato.Telefone, 4478, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 4495, "\')", 4495, 2, true);
                EndWriteAttribute();
                BeginContext(4498, 37, true);
                WriteLiteral(">Editar</a>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2808, "form_", 2808, 5, true);
#line 53 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
AddHtmlAttributeValue("", 2813, contato.Id, 2813, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4542, 74, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 74 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
        }

#line default
#line hidden
            BeginContext(4627, 575, true);
            WriteLiteral(@"    </div>
</div>

<script type=""text/javascript"">
    function editarContato(id, nome, cargo, email, telefone) {
        $(""#formEditar input[name=id]"").val(id);
        $(""#formEditar input[name=nome]"").val(nome);
        $(""#formEditar input[name=cargo]"").val(cargo);
        $(""#formEditar input[name=email]"").val(email);
        $(""#formEditar input[name=telefone]"").val(telefone);
        $('#divFormEditar').css('display', 'block');
    }

    function editarContatoCancelar() {
        $('#divFormEditar').css('display', 'none');
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ContatoModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
