#pragma checksum "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9a0a71389bef94ce2725ac34cd4aa326efc6333"
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
#line 1 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\_ViewImports.cshtml"
using WebApplicationAuvo;

#line default
#line hidden
#line 2 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\_ViewImports.cshtml"
using WebApplicationAuvo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9a0a71389bef94ce2725ac34cd4aa326efc6333", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdb58cac71faca833866d4ec5604514649f430ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Clientes";

#line default
#line hidden
            BeginContext(62, 435, true);
            WriteLiteral(@"
<div class=""text-center"" style=""font-size: 12px;"">
    <div class=""text-left"">
        <p><span style=""color: rgb(131, 0, 233)""><b>Cadastros</b></span> <span style=""color: gray""> > Clientes > Sigma Sistemas</span></p>
    </div>
    <div class=""row"">
        <div class=""col-3"">
            <div class=""card p-3 text-left"">
                <div style=""text-align: center;width: 100%; height: 120px;"">
                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 497, "\"", 524, 1);
#line 14 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Home\Index.cshtml"
WriteAttributeValue("", 503, Model.Usuario.Imagem, 503, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(525, 244, true);
            WriteLiteral(" />\r\n                </div>\r\n                <div>\r\n                    <span class=\"glyphicon glyphicon-ok\"></span>\r\n                    <p style=\"font-size: 16px\">\r\n                        <i class=\"fa fa-building\" aria-hidden=\"true\"></i> <b>");
            EndContext();
            BeginContext(770, 18, false);
#line 19 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Home\Index.cshtml"
                                                                        Write(Model.Usuario.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(788, 102, true);
            WriteLiteral("</b>\r\n                    </p>\r\n                    <p><i class=\"fa fa-phone\" aria-hidden=\"true\"></i> ");
            EndContext();
            BeginContext(891, 22, false);
#line 21 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Home\Index.cshtml"
                                                                 Write(Model.Usuario.Telefone);

#line default
#line hidden
            EndContext();
            BeginContext(913, 109, true);
            WriteLiteral("</p>\r\n                    <br />\r\n                    <p><i class=\"fa fa-envelope-o\" aria-hidden=\"true\"></i> ");
            EndContext();
            BeginContext(1023, 19, false);
#line 23 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Home\Index.cshtml"
                                                                      Write(Model.Usuario.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1042, 109, true);
            WriteLiteral("</p>\r\n                    <br />\r\n                    <p><i class=\"fa fa-map-marker\" aria-hidden=\"true\"></i> ");
            EndContext();
            BeginContext(1152, 22, false);
#line 25 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Home\Index.cshtml"
                                                                      Write(Model.Usuario.Endereco);

#line default
#line hidden
            EndContext();
            BeginContext(1174, 120, true);
            WriteLiteral("</p>\r\n                    <div id=\"content\">\r\n                        <iframe style=\"width: 100%; border: none;\" name=\"\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1294, "\"", 1326, 1);
#line 27 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Home\Index.cshtml"
WriteAttributeValue("", 1300, Model.Usuario.Localizacao, 1300, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1327, 265, true);
            WriteLiteral(@"></iframe>
                    </div>
                </div>
                <div class=""mt-4"">
                    <p style=""font-size: 13px""><b>Mais Informações</b></p>
                    <span style=""color: #808080"">Segmento</span>
                    <p>");
            EndContext();
            BeginContext(1593, 22, false);
#line 33 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Home\Index.cshtml"
                  Write(Model.Usuario.Segmento);

#line default
#line hidden
            EndContext();
            BeginContext(1615, 95, true);
            WriteLiteral("</p>\r\n                    <span style=\"color: #808080\">CPF/CNPJ</span>\r\n                    <p>");
            EndContext();
            BeginContext(1711, 21, false);
#line 35 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Home\Index.cshtml"
                  Write(Model.Usuario.CnpjCpf);

#line default
#line hidden
            EndContext();
            BeginContext(1732, 104, true);
            WriteLiteral("</p>\r\n                    <span style=\"color: #808080\">Codigo do Sistema</span>\r\n                    <p>");
            EndContext();
            BeginContext(1837, 27, false);
#line 37 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Home\Index.cshtml"
                  Write(Model.Usuario.CodigoSistema);

#line default
#line hidden
            EndContext();
            BeginContext(1864, 101, true);
            WriteLiteral("</p>\r\n                    <span style=\"color: #808080\">Codigo Externo</span>\r\n                    <p>");
            EndContext();
            BeginContext(1966, 27, false);
#line 39 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Home\Index.cshtml"
                  Write(Model.Usuario.CodigoExterno);

#line default
#line hidden
            EndContext();
            BeginContext(1993, 109, true);
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-6\">\r\n            ");
            EndContext();
            BeginContext(2103, 39, false);
#line 45 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Home\Index.cshtml"
       Write(Html.Partial("_Tarefas", Model.Tarefas));

#line default
#line hidden
            EndContext();
            BeginContext(2142, 72, true);
            WriteLiteral(";\r\n        </div>\r\n\r\n        <div class=\"col-3 text-left\">\r\n            ");
            EndContext();
            BeginContext(2215, 41, false);
#line 49 "C:\Users\Isthmus Sistemas\Documents\WebApplicationAuvo\WebApplicationAuvo\Views\Home\Index.cshtml"
       Write(Html.Partial("_Contatos", Model.Contatos));

#line default
#line hidden
            EndContext();
            BeginContext(2256, 39, true);
            WriteLiteral(";\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
