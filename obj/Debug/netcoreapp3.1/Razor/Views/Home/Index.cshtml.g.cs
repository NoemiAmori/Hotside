#pragma checksum "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 06\Noemi_At_01\projetohotsite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a5332e35de38eeb3801879021101d1a5a0fb103"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 06\Noemi_At_01\projetohotsite\Views\_ViewImports.cshtml"
using Hotsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 06\Noemi_At_01\projetohotsite\Views\_ViewImports.cshtml"
using Hotsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a5332e35de38eeb3801879021101d1a5a0fb103", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bc39314ee689b901092e0940a38afe41bd0f7d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Interesse>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-sm-2 col-form-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Cadastrar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 06\Noemi_At_01\projetohotsite\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Hotsite";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row my-2"">
    <div class=""col-12 col md-12 col-lg-4"">
       <h1 class=""text-center"">Iniciativa Saúde da Cidade</h1>
        <p>
            Texto sobre vida saudável: Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae legendos at vix ad putent delectus delicata usu. Vidit dissentiet eos cu eum an brute copiosae hendrerit.
        </p>
        <p>
            Texto sobre vida iniciativa: Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae legendos at vix ad putent delectus delicata usu. Vidit dissentiet eos cu eum an brute copiosae hendrerit.
        </p>
    </div>

    <div class=""col-12 col-md-12 col-lg-8"">
        <img src=""/imagens/dna.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 780, "\"", 786, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-thumbnail"" style=""max-width: 540px;"">
    </div>

    <div class=""row my-2"">
        <div class=""col-12 col-md-12 col-lg-4 border border-danger rounded py-2 my-2 bg-light"">

            <h2>Entre em contato!:</h2>
            <p>Nos mande uma mensagem e fique por dentro de nossos eventos</p>

            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a5332e35de38eeb3801879021101d1a5a0fb1036777", async() => {
                WriteLiteral("\r\n            <div class=\"form-group row\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a5332e35de38eeb3801879021101d1a5a0fb1037097", async() => {
                    WriteLiteral("Nome:");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 29 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 06\Noemi_At_01\projetohotsite\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Nome);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <div class=\"col-sm-10\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3a5332e35de38eeb3801879021101d1a5a0fb1038798", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 31 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 06\Noemi_At_01\projetohotsite\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Nome);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group row\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a5332e35de38eeb3801879021101d1a5a0fb10310498", async() => {
                    WriteLiteral("Email:");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 36 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 06\Noemi_At_01\projetohotsite\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <div class=\"col-sm-10\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3a5332e35de38eeb3801879021101d1a5a0fb10312202", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 38 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 06\Noemi_At_01\projetohotsite\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a5332e35de38eeb3801879021101d1a5a0fb10313879", async() => {
                    WriteLiteral("Mensagem (opcional):");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 43 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 06\Noemi_At_01\projetohotsite\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Mensagem);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a5332e35de38eeb3801879021101d1a5a0fb10315551", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 44 "C:\Users\noemi\Desktop\SENAC\MODULO II\UC 06\Noemi_At_01\projetohotsite\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Mensagem);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n\r\n            <div>\r\n                <input type=\"submit\" value=\"Enviar\" class=\"btn btn-primary\"/>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>

    <div class=""col-12 col-md-12 col-lg-8 d-flex align-items-center"">
        <div class=""row"">
            <div class=""col-12 col-lg-4 text-center"">
                <a href=""#"">
                    <figure class=""figure"">
                        <img src=""/imagens/agenda.jpg"" alt=""Agenda de Eventos"" class=""img-fluid"">
                        <button type=""button"" class=""btn btn-primary mt-2"" data-bs-toggle=""modal"" data-bs-target=""#modalAgenda"">Agenda</button>
                    </figure>
                </a>
            </div>
            <div class=""col-12 col-lg-4 text-center"">
                <a href=""#"">
                    <figure class=""figure"">
                        <img src=""/imagens/vida.jpg"" alt=""Dicas de Vida Saudável"" class=""img-fluid"">
                        <button type=""button"" class=""btn btn-primary mt-2"" data-bs-toggle=""modal"" data-bs-target=""#modalDica"">Dicas Vida Saudável</button>
                    </figure>
                </a>
            </div>
  ");
            WriteLiteral(@"          <div class=""col-12 col-lg-4 text-center"">
                <a href=""#"">
                    <figure class=""figure"">
                        <img src=""/imagens/apoio.png"" alt=""Apoiadores"" class=""img-fluid"">
                        <button type=""button"" class=""btn btn-primary mt-2"" data-bs-toggle=""modal"" data-bs-target=""#modalApoio"">Apoiadores</button>
                    </figure>
                </a>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""modalAgenda"" tabindex=""-1"" aria-labelledby=""modalAgendaLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header justify-content-center"">
                <h2 class=""modal-title"" id=""exampleModalLabel"">Agenda</h2>
            </div>
            <div class=""modal-body"">
                <h3 class=""text-center"">10/10/10 10:10 - Evento 1</h3>
                <p class=""mb-5"">Lorem ipsum dolor sit amet et delectus accommodare his consul cop");
            WriteLiteral(@"iosae.</p>
                <h3 class=""text-center"">10/10/10 11:10 - Evento 2</h3>
                <p class=""mb-5"">Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae.</p>
                <h3 class=""text-center"">10/10/10 12:10 - Evento 3</h3>
                <p class=""mb-5"">Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae.</p>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""modalDica"" tabindex=""-1"" aria-labelledby=""modalDicaLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header justify-content-center"">
                <h2 class=""modal-title"" id=""exampleModalLabel"">Dicas de vida saudável</h2>
            </div>
            <div class=""modal-body"">
                <p>Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae legendos at vix ad putent delectus delicata usu. Vidit dissentiet eos.</p>

                <p>Lorem ipsum dolo");
            WriteLiteral(@"r sit amet et delectus accommodare his consul copiosae legendos at vix ad putent delectus delicata usu. Vidit dissentiet eos.</p>

                <p>Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae legendos at vix ad putent delectus delicata usu. Vidit dissentiet eos.</p>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""modalApoio"" tabindex=""-1"" aria-labelledby=""modalApoioLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header justify-content-center"">
                <h2 class=""modal-title"" id=""exampleModalLabel"">Apoiadores</h2>
            </div>
            <div class=""modal-body"">
                <div class=""card mb-3 pl-3"" style=""max-width: 340px;"">
                    <div class=""row g-0"">
                        <div class=""col-md-4 m-auto"">
                            <img src=""/imagens/confeitaria.png"" class=""img-fluid rounded-start"" alt=""Logo da Empresa 1");
            WriteLiteral(@""">
                        </div>
                        <div class=""col-md-8"">
                            <div class=""card-body"">
                                <h5 class=""card-title"">Doces Light & Diet</h5>
                                <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. </p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card mb-3 pl-3"" style=""max-width: 340px;"">
                    <div class=""row g-0"">
                        <div class=""col-md-4 m-auto"">
                            <img src=""/imagens/Vegetariano.jpg"" class=""img-fluid rounded-start"" alt=""Logo da Empresa 2"">
                        </div>
                        <div class=""col-md-8"">
                            <div class=""card-body"">
                                <h5 class=""card-title"">Restaurante Vegetariano</h5>
                                <p>Lorem Ipsum is simply dumm");
            WriteLiteral(@"y text of the printing and typesetting industry. </p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card mb-3 pl-3"" style=""max-width: 340px;"">
                    <div class=""row g-0"">
                        <div class=""col-md-4 m-auto"">
                            <img src=""/imagens/Restaurante.jpg"" class=""img-fluid rounded-start"" alt=""Logo da Empresa 3"">
                        </div>
                        <div class=""col-md-8"">
                            <div class=""card-body"">
                                <h5 class=""card-title"">Restaurante</h5>
                                <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. </p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card mb-3 pl-3"" style=""max-width: 340px;"">
                    <div class=""row g-0"">
");
            WriteLiteral(@"                        <div class=""col-md-4 m-auto"">
                            <img src=""/imagens/lanches.jpg"" class=""img-fluid rounded-start"" alt=""Logo da Empresa 4"">
                        </div>
                        <div class=""col-md-8"">
                            <div class=""card-body"">
                                <h5 class=""card-title"">Lanches Naturais</h5>
                                <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. </p>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Interesse> Html { get; private set; }
    }
}
#pragma warning restore 1591
