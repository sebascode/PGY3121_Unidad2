#pragma checksum "C:\Users\Cetecom\source\repos\PGY3121_Unidad2\Veterinaria.Web\Views\Pokemon\Filtrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "040fe94b119fab7cd8fc4cdf801faf1549904ae7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pokemon_Filtrar), @"mvc.1.0.view", @"/Views/Pokemon/Filtrar.cshtml")]
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
#line 1 "C:\Users\Cetecom\source\repos\PGY3121_Unidad2\Veterinaria.Web\Views\_ViewImports.cshtml"
using Pokedex.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cetecom\source\repos\PGY3121_Unidad2\Veterinaria.Web\Views\_ViewImports.cshtml"
using Pokedex.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"040fe94b119fab7cd8fc4cdf801faf1549904ae7", @"/Views/Pokemon/Filtrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"831aaa4fe3034dada86bff7257e5ebc99ab05c33", @"/Views/_ViewImports.cshtml")]
    public class Views_Pokemon_Filtrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Pokemon>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<input class=\"input\" type=\"text\" id=\"txtBuscador\" placeholder=\"Buscador\" />\r\n<button id=\"btnBuscar\" class=\"btn btn-info\" onclick=\"RedirectUri()\">Buscar</button>\r\n\r\n<br /><br />\r\n<h1>Pokemones filtrados</h1>\r\n<br />\r\n<ul class=\"list-group\">\r\n");
#nullable restore
#line 10 "C:\Users\Cetecom\source\repos\PGY3121_Unidad2\Veterinaria.Web\Views\Pokemon\Filtrar.cshtml"
     foreach (Pokemon item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item\">\r\n            ");
#nullable restore
#line 13 "C:\Users\Cetecom\source\repos\PGY3121_Unidad2\Veterinaria.Web\Views\Pokemon\Filtrar.cshtml"
       Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Tipo: ");
#nullable restore
#line 13 "C:\Users\Cetecom\source\repos\PGY3121_Unidad2\Veterinaria.Web\Views\Pokemon\Filtrar.cshtml"
                           Write(item.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Peso: ");
#nullable restore
#line 13 "C:\Users\Cetecom\source\repos\PGY3121_Unidad2\Veterinaria.Web\Views\Pokemon\Filtrar.cshtml"
                                             Write(item.Peso);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 15 "C:\Users\Cetecom\source\repos\PGY3121_Unidad2\Veterinaria.Web\Views\Pokemon\Filtrar.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<script type=\"text/javascript\">\r\n    function RedirectUri() {\r\n        const texto = document.getElementById(\"txtBuscador\").value;\r\n        console.log(texto);\r\n        window.location.href = \"/Pokemon/Filtrar/\" + texto;\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Pokemon>> Html { get; private set; }
    }
}
#pragma warning restore 1591
