#pragma checksum "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dfb6d52c720874bf90e3ca17b70bdf6a24488dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoCiclo3.App.Frontend.Pages.Servicio.Pages_Servicio_Edit), @"mvc.1.0.razor-page", @"/Pages/Servicio/Edit.cshtml")]
namespace ProyectoCiclo3.App.Frontend.Pages.Servicio
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
#line 1 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\_ViewImports.cshtml"
using ProyectoCiclo3.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dfb6d52c720874bf90e3ca17b70bdf6a24488dc", @"/Pages/Servicio/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fac2ae24fef211f78e08fb554a390914631813e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Servicio_Edit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
  
    var Servicio = Model.Servicio;

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n<div class=\"text-center\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dfb6d52c720874bf90e3ca17b70bdf6a24488dc4167", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("  <input type=\"number\" class=\"form-control d-none\" id=\"id\" placeholder=\"Id\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 305, "\"", 325, 1);
#nullable restore
#line 10 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
WriteAttributeValue("", 313, Servicio.id, 313, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> \r\n\r\n    <label for=\"origen\" class=\"form-label\">Origen:</label>\r\n    <select name=\"origen\" class=\"form-control\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dfb6d52c720874bf90e3ca17b70bdf6a24488dc5101", async() => {
                    WriteLiteral("-");
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
                WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
         foreach (var usuario in Model.Usuario)
    {
      

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
       if(Servicio.origen.id == @usuario.id){

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dfb6d52c720874bf90e3ca17b70bdf6a24488dc6863", async() => {
#nullable restore
#line 18 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
                                        Write(usuario.nombre);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
#nullable restore
#line 18 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
                                                        Write(usuario.apellidos);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" - ");
#nullable restore
#line 18 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
                                                                             Write(usuario.ciudad);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
           WriteLiteral(usuario.id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
        }
        else{

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dfb6d52c720874bf90e3ca17b70bdf6a24488dc10025", async() => {
#nullable restore
#line 21 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
                               Write(usuario.nombre);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
                                               Write(usuario.apellidos);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" - ");
#nullable restore
#line 21 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
                                                                    Write(usuario.ciudad);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
           WriteLiteral(usuario.id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
         
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </select>\r\n\r\n  <label for=\"destino\" class=\"form-label\">Destino:</label>\r\n    <select name=\"destino\" class=\"form-control\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dfb6d52c720874bf90e3ca17b70bdf6a24488dc13179", async() => {
                    WriteLiteral("-");
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
                WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
         foreach (var usuario in Model.Usuario)
    {
      

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
       if(Servicio.destino.id == @usuario.id){

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dfb6d52c720874bf90e3ca17b70bdf6a24488dc14943", async() => {
#nullable restore
#line 32 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
                                        Write(usuario.nombre);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
#nullable restore
#line 32 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
                                                        Write(usuario.apellidos);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" - ");
#nullable restore
#line 32 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
                                                                             Write(usuario.ciudad);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
           WriteLiteral(usuario.id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
        }
        else{

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dfb6d52c720874bf90e3ca17b70bdf6a24488dc18106", async() => {
#nullable restore
#line 35 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
                               Write(usuario.nombre);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
#nullable restore
#line 35 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
                                               Write(usuario.apellidos);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" - ");
#nullable restore
#line 35 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
                                                                    Write(usuario.ciudad);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
           WriteLiteral(usuario.id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 36 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
         
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </select>\r\n\r\n  <label for=\"fecha\" class=\"form-label\">Fecha:</label>\r\n  <input type=\"date\" class=\"form-control\" id=\"fecha\" placeholder=\"Fecha\" name=\"fecha\"");
                BeginWriteAttribute("value", " value=\"", 1509, "\"", 1532, 1);
#nullable restore
#line 41 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
WriteAttributeValue("", 1517, Servicio.fecha, 1517, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> \r\n\r\n    <label for=\"hora\" class=\"form-label\">Hora:</label>\r\n  <input type=\"time\" class=\"form-control\" id=\"hora\" placeholder=\"Hora\" name=\"hora\"");
                BeginWriteAttribute("value", " value=\"", 1677, "\"", 1699, 1);
#nullable restore
#line 44 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
WriteAttributeValue("", 1685, Servicio.hora, 1685, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n      <label for=\"encomienda\" class=\"form-label\">Encomienda:</label>\r\n    <select name=\"encomienda\" class=\"form-control\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dfb6d52c720874bf90e3ca17b70bdf6a24488dc22430", async() => {
                    WriteLiteral("-");
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
                WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
         foreach (var encomienda in Model.Encomienda)

    {
      

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
       if(Servicio.encomienda.id == @encomienda.id){

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dfb6d52c720874bf90e3ca17b70bdf6a24488dc24208", async() => {
#nullable restore
#line 53 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
                                           Write(encomienda.descripcion);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
           WriteLiteral(encomienda.id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 54 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
        }
        else{

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dfb6d52c720874bf90e3ca17b70bdf6a24488dc26729", async() => {
#nullable restore
#line 56 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
                                  Write(encomienda.descripcion);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
           WriteLiteral(encomienda.id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 57 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\Sebastian\Documents\ProyectoC3\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Servicio\Edit.cshtml"
         
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </select>\r\n\r\n  <hr>\r\n  \r\n  <button type=\"submit\" class=\"btn btn-success\">Enviar</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoCiclo3.App.Frontend.Pages.EditServicioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoCiclo3.App.Frontend.Pages.EditServicioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoCiclo3.App.Frontend.Pages.EditServicioModel>)PageContext?.ViewData;
        public ProyectoCiclo3.App.Frontend.Pages.EditServicioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
