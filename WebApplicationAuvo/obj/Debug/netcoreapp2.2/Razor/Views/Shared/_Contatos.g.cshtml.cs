#pragma checksum "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8eb1df7ade2d7c70da2dd116f0fb3d40f3f8e02"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8eb1df7ade2d7c70da2dd116f0fb3d40f3f8e02", @"/Views/Shared/_Contatos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdb58cac71faca833866d4ec5604514649f430ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Contatos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ContatoModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formEditar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditarContato", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-2 mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RebaseContatos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8eb1df7ade2d7c70da2dd116f0fb3d40f3f8e025614", async() => {
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
            BeginContext(1585, 176, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"card p-3\">\r\n    <h5 class=\"text-left\"><span style=\"border-bottom: 2px solid #000;\">Contatos</span></h5>\r\n    <div style=\"display: flex;\" class=\"mb-4\">\r\n");
            EndContext();
            BeginContext(2175, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(2185, 219, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8eb1df7ade2d7c70da2dd116f0fb3d40f3f8e029323", async() => {
                BeginContext(2232, 165, true);
                WriteLiteral("\r\n            <p>\r\n                Title: <input type=\"text\" name=\"SearchString\">\r\n                <input type=\"submit\" value=\"Filter\" />\r\n            </p>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2404, 12, true);
            WriteLiteral("\r\n\r\n        ");
            EndContext();
            BeginContext(2416, 205, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8eb1df7ade2d7c70da2dd116f0fb3d40f3f8e0211370", async() => {
                BeginContext(2468, 146, true);
                WriteLiteral("\r\n            <button type=\"submit\" style=\"color: #8300E9;\" class=\"btn btn-link\"><i class=\"fa fa-times\" aria-hidden=\"true\"></i></button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2621, 27, true);
            WriteLiteral("\r\n    </div>\r\n\r\n    <div>\r\n");
            EndContext();
#line 55 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
         foreach (var contato in Model)
        {

#line default
#line hidden
            BeginContext(2700, 248, true);
            WriteLiteral("            <div id=\"accordion\">\r\n                <div class=\"border mb-2\">\r\n                    <h5 class=\"mb-0\">\r\n                        <button class=\"btn btn-link\" style=\"width:100%; color: #000;\" data-toggle=\"collapse\" data-target=\"#collapse_");
            EndContext();
            BeginContext(2949, 10, false);
#line 60 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
                                                                                                                               Write(contato.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2959, 23, true);
            WriteLiteral("\" aria-expanded=\"false\"");
            EndContext();
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 2982, "\"", 3018, 2);
            WriteAttributeValue("", 2998, "collapse_", 2998, 9, true);
#line 60 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
WriteAttributeValue("", 3007, contato.Id, 3007, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3019, 168, true);
            WriteLiteral(">\r\n                            <i class=\"fa fa-user\" style=\"float: left; padding: 3px;\" aria-hidden=\"true\"></i>\r\n                            <span style=\"float: left;\">");
            EndContext();
            BeginContext(3188, 12, false);
#line 62 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
                                                  Write(contato.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(3200, 212, true);
            WriteLiteral("</span>\r\n                            <i class=\"fa fa-angle-down\" style=\"float: right; padding: 3px;\" aria-hidden=\"true\"></i>\r\n                        </button>\r\n                    </h5>\r\n                    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3412, "\"", 3437, 2);
            WriteAttributeValue("", 3417, "collapse_", 3417, 9, true);
#line 66 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
WriteAttributeValue("", 3426, contato.Id, 3426, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3438, 69, true);
            WriteLiteral(" class=\"collapse\" data-parent=\"#accordion\">\r\n                        ");
            EndContext();
            BeginContext(3507, 1744, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8eb1df7ade2d7c70da2dd116f0fb3d40f3f8e0216222", async() => {
                BeginContext(3535, 224, true);
                WriteLiteral("\r\n                            <div class=\"form-group m-0\" style=\"display: none;\">\r\n                                <input type=\"number\" disabled class=\"form-control\" style=\"background:none; border: none;\" id=\"exampleInputId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3759, "\"", 3778, 1);
#line 69 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
WriteAttributeValue("", 3767, contato.Id, 3767, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3779, 278, true);
                WriteLiteral(@" placeholder=""Id"">
                            </div>
                            <div class=""form-group m-0"" style=""display: none;"">
                                <input type=""text"" disabled class=""form-control"" style=""background:none; border: none;"" id=""exampleInputNome""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4057, "\"", 4078, 1);
#line 72 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
WriteAttributeValue("", 4065, contato.Nome, 4065, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4079, 258, true);
                WriteLiteral(@" placeholder=""Nome"">
                            </div>
                            <div class=""form-group m-0"">
                                <input type=""text"" disabled class=""form-control"" style=""background:none; border: none;"" id=""exampleInputCargo""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4337, "\"", 4359, 1);
#line 75 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
WriteAttributeValue("", 4345, contato.Cargo, 4345, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4360, 259, true);
                WriteLiteral(@" placeholder=""Cargo"">
                            </div>
                            <div class=""form-group m-0"">
                                <input type=""text"" disabled class=""form-control"" style=""background:none; border: none;"" id=""exampleInputEmail""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4619, "\"", 4641, 1);
#line 78 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
WriteAttributeValue("", 4627, contato.Email, 4627, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4642, 262, true);
                WriteLiteral(@" placeholder=""Email"">
                            </div>
                            <div class=""form-group m-0"">
                                <input type=""text"" disabled class=""form-control"" style=""background:none; border: none;"" id=""exampleInputTelefone""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4904, "\"", 4929, 1);
#line 81 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
WriteAttributeValue("", 4912, contato.Telefone, 4912, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4930, 166, true);
                WriteLiteral(" placeholder=\"Telefone\">\r\n                            </div>\r\n                            <a id=\"lnk\" href=\"javascript:;\" class=\"btn btn-link\" style=\"color: #8300E9;\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 5096, "\"", 5206, 15);
                WriteAttributeValue("", 5106, "editarContato(", 5106, 14, true);
#line 83 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
WriteAttributeValue("", 5120, contato.Id, 5120, 11, false);

#line default
#line hidden
                WriteAttributeValue("", 5131, ",", 5131, 1, true);
                WriteAttributeValue(" ", 5132, "\'", 5133, 2, true);
#line 83 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
WriteAttributeValue("", 5134, contato.Nome, 5134, 13, false);

#line default
#line hidden
                WriteAttributeValue("", 5147, "\',", 5147, 2, true);
                WriteAttributeValue(" ", 5149, "\'", 5150, 2, true);
#line 83 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
WriteAttributeValue("", 5151, contato.Cargo, 5151, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 5165, "\',", 5165, 2, true);
                WriteAttributeValue(" ", 5167, "\'", 5168, 2, true);
#line 83 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
WriteAttributeValue("", 5169, contato.Email, 5169, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 5183, "\',", 5183, 2, true);
                WriteAttributeValue(" ", 5185, "\'", 5186, 2, true);
#line 83 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
WriteAttributeValue("", 5187, contato.Telefone, 5187, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 5204, "\')", 5204, 2, true);
                EndWriteAttribute();
                BeginContext(5207, 37, true);
                WriteLiteral(">Editar</a>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3517, "form_", 3517, 5, true);
#line 67 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
AddHtmlAttributeValue("", 3522, contato.Id, 3522, 11, false);

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
            BeginContext(5251, 74, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 88 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Shared\_Contatos.cshtml"
        }

#line default
#line hidden
            BeginContext(5336, 575, true);
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
