#pragma checksum "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveNoTrip.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f2acf299ba63f07c4b2b92dceb889d14ccde0d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AltaNaveNoTrip), @"mvc.1.0.view", @"/Views/Home/AltaNaveNoTrip.cshtml")]
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
#line 1 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\_ViewImports.cshtml"
using RetoTecnico;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\_ViewImports.cshtml"
using RetoTecnico.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveNoTrip.cshtml"
using EntidadesCompartidas.Entidades;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f2acf299ba63f07c4b2b92dceb889d14ccde0d6", @"/Views/Home/AltaNaveNoTrip.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b548c9c998d09b279d304c2701d1ef11d0646d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AltaNaveNoTrip : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NoTripulada>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveNoTrip.cshtml"
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveNoTrip.cshtml"
     using (Html.BeginForm("AltaNaveNoTrip", "Home", FormMethod.Post))
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"d-flex flex-column justify-content-center align-items-stretch col-12 col-md-2\">\r\n    <label>Nombre</label>\r\n    ");
#nullable restore
#line 12 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveNoTrip.cshtml"
Write(Html.TextBoxFor(N => N.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 13 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveNoTrip.cshtml"
Write(Html.ValidationMessageFor(N => N.Nombre, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <label>Objetivo</label>\r\n    ");
#nullable restore
#line 16 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveNoTrip.cshtml"
Write(Html.TextBoxFor(N => N.Objetivo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 18 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveNoTrip.cshtml"
Write(Html.ValidationMessageFor(N => N.Objetivo, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <label>Agencia</label>\r\n    <div class=\"btn-group\">");
#nullable restore
#line 21 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveNoTrip.cshtml"
                      Write(Html.DropDownListFor(N => N.Firma.Nombre, ViewBag.ListAgencia as SelectList, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <br />\r\n    <label>Velocidad</label>\r\n    ");
#nullable restore
#line 24 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveNoTrip.cshtml"
Write(Html.TextBoxFor(N => N.Velocidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 26 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveNoTrip.cshtml"
Write(Html.ValidationMessageFor(N => N.Velocidad, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <label>Potencia</label>\r\n    ");
#nullable restore
#line 29 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveNoTrip.cshtml"
Write(Html.TextBoxFor(N => N.Potencia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 31 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveNoTrip.cshtml"
Write(Html.ValidationMessageFor(N => N.Potencia, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <label>Empuje</label>\r\n    ");
#nullable restore
#line 34 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveNoTrip.cshtml"
Write(Html.TextBoxFor(N => N.Empuje));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 36 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveNoTrip.cshtml"
Write(Html.ValidationMessageFor(N => N.Empuje, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <label>Combustible</label>\r\n    ");
#nullable restore
#line 39 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveNoTrip.cshtml"
Write(Html.TextBoxFor(N => N.Combustible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 41 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveNoTrip.cshtml"
Write(Html.ValidationMessageFor(N => N.Combustible, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <label>Sistema De Propulsion</label>\r\n    ");
#nullable restore
#line 44 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveNoTrip.cshtml"
Write(Html.TextBoxFor(N => N.SistemaDePropulsion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 46 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveNoTrip.cshtml"
Write(Html.ValidationMessageFor(N => N.SistemaDePropulsion, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <label>Peso</label>\r\n    ");
#nullable restore
#line 49 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveNoTrip.cshtml"
Write(Html.TextBoxFor(N => N.Peso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 51 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveNoTrip.cshtml"
Write(Html.ValidationMessageFor(N => N.Peso, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <label>Aterrizador</label>\r\n    ");
#nullable restore
#line 54 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveNoTrip.cshtml"
Write(Html.TextBoxFor(N => N.Aterrizador));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 56 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveNoTrip.cshtml"
Write(Html.ValidationMessageFor(N => N.Aterrizador, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <label>Codigo de Fabrica Motor</label>\r\n    ");
#nullable restore
#line 59 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveNoTrip.cshtml"
Write(Html.DropDownListFor(N => N.TipoMotor.CodFabrica, ViewBag.ListMotor as SelectList, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <label>Planeta</label>\r\n    <div class=\"btn-group\">");
#nullable restore
#line 62 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveNoTrip.cshtml"
                      Write(Html.DropDownListFor(N => N.LugarDeEstudio.Nombre, ViewBag.ListPlaneta as SelectList, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <br />\r\n    <button type=\"submit\" class=\"btn btn-success\">Alta</button>\r\n</div>\r\n        <br />\r\n        <img src=\"/css/NaveNoTripuladaIMG.jpg\" />\r\n");
#nullable restore
#line 68 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveNoTrip.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NoTripulada> Html { get; private set; }
    }
}
#pragma warning restore 1591