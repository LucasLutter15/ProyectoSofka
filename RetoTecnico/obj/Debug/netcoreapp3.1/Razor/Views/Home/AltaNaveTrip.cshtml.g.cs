#pragma checksum "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09cb1e745c14d99d381a3b29c2a35ef7b20bf7f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AltaNaveTrip), @"mvc.1.0.view", @"/Views/Home/AltaNaveTrip.cshtml")]
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
#line 1 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
using EntidadesCompartidas.Entidades;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09cb1e745c14d99d381a3b29c2a35ef7b20bf7f4", @"/Views/Home/AltaNaveTrip.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b548c9c998d09b279d304c2701d1ef11d0646d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AltaNaveTrip : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tripulada>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
     using (Html.BeginForm("AltaNaveTrip", "Home", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"d-flex flex-column justify-content-center align-items-stretch col-12 col-md-2\">\r\n            <label>Nombre</label>\r\n            ");
#nullable restore
#line 10 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
       Write(Html.TextBoxFor(N => N.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 11 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
       Write(Html.ValidationMessageFor(N => N.Nombre, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            <label>Objetivo</label>\r\n            ");
#nullable restore
#line 14 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
       Write(Html.TextBoxFor(N => N.Objetivo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 16 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
       Write(Html.ValidationMessageFor(N => N.Objetivo, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            <label>Agencia</label>\r\n            <div class=\"btn-group \">");
#nullable restore
#line 19 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
                               Write(Html.DropDownListFor(N => N.Firma.Nombre, ViewBag.ListAgencia as SelectList, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <br />\r\n            <label>Velocidad</label>\r\n            ");
#nullable restore
#line 22 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
       Write(Html.TextBoxFor(N => N.Velocidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 24 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
       Write(Html.ValidationMessageFor(N => N.Velocidad, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            <label>Potencia</label>\r\n            ");
#nullable restore
#line 27 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
       Write(Html.TextBoxFor(N => N.Potencia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 29 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
       Write(Html.ValidationMessageFor(N => N.Potencia, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            <label>Combustible</label>\r\n            ");
#nullable restore
#line 32 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
       Write(Html.TextBoxFor(N => N.Combustible));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 34 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
       Write(Html.ValidationMessageFor(N => N.Combustible, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            <label>Sistema De Propulsion</label>\r\n            ");
#nullable restore
#line 37 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
       Write(Html.TextBoxFor(N => N.SistemaDePropulsion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 39 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
       Write(Html.ValidationMessageFor(N => N.SistemaDePropulsion, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            <label>Peso</label>\r\n            ");
#nullable restore
#line 42 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
       Write(Html.TextBoxFor(N => N.Peso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 44 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
       Write(Html.ValidationMessageFor(N => N.Peso, "", new { @class = "text-danger", @type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            <label>Mision</label>\r\n            ");
#nullable restore
#line 47 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
       Write(Html.TextBoxFor(N => N.Misiones));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 49 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
       Write(Html.ValidationMessageFor(N => N.Misiones, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            <label>Capacidad</label>\r\n            ");
#nullable restore
#line 52 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
       Write(Html.TextBoxFor(N => N.Capacidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 54 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
       Write(Html.ValidationMessageFor(N => N.Capacidad, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            <label>Personas a bordo</label>\r\n            ");
#nullable restore
#line 57 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
       Write(Html.TextBoxFor(N => N.PersonasABordo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 59 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
       Write(Html.ValidationMessageFor(N => N.PersonasABordo, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            <label>Orbita</label>\r\n            ");
#nullable restore
#line 62 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
       Write(Html.TextBoxFor(N => N.Orbita));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 64 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
       Write(Html.ValidationMessageFor(N => N.Orbita, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <br />\r\n            <label>");
#nullable restore
#line 66 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
              Write(Html.ActionLink("Volver", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </label>\r\n            <br />\r\n            <button type=\"submit\" class=\"btn btn-success\">Alta</button>\r\n        </div>\r\n        <br />\r\n        <img src=\"/css/NaveTripulada.jpg\" class=\"img-fluid\" alt=\"responsive image\" />\r\n");
#nullable restore
#line 72 "C:\Users\lucas\Source\Repos\LucasLutter15\Lucas15\RetoTecnico\Views\Home\AltaNaveTrip.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tripulada> Html { get; private set; }
    }
}
#pragma warning restore 1591