#pragma checksum "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccf9410f24a1c287b388d3fbc517b432b0063dd6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LlamadasAjax_ObtenerDetalleCotizacionAdmin), @"mvc.1.0.view", @"/Views/LlamadasAjax/ObtenerDetalleCotizacionAdmin.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\_ViewImports.cshtml"
using MADERERA_HRS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\_ViewImports.cshtml"
using MADERERA_HRS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccf9410f24a1c287b388d3fbc517b432b0063dd6", @"/Views/LlamadasAjax/ObtenerDetalleCotizacionAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0567fe31a7291547ba761674eb427d99aa8dfebf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LlamadasAjax_ObtenerDetalleCotizacionAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
  Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td>\n            <img style=\"width:40px;height:55px\"");
            BeginWriteAttribute("src", " src=\"", 118, "\"", 136, 1);
#nullable restore
#line 6 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
WriteAttributeValue("", 124, item.Imagen, 124, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n            <button type=\"button\" class=\"verimagendeproductoacotizar btn btn-dark fa fa-eye\" data-toggle=\"modal\" data-target=\".bd-example-modal-lg\" data-iddetallecotizacion=\"");
#nullable restore
#line 7 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
                                                                                                                                                                         Write(item.Id_Detalle_Cotizacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></button>\n");
            WriteLiteral("        </td>\n        <td>");
#nullable restore
#line 10 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
       Write(item.Producto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 11 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
       Write(item.Medidas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>\n            ");
#nullable restore
#line 13 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
       Write(item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 14 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
             if (item.Cotizacion.Id_Estado != 5)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"actualizarcantidaddetallecotizacion btn btn-warning\" data-idcotizacion=\"");
#nullable restore
#line 16 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
                                                                                             Write(item.Id_Cotizacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-iddetallecotizacion=\"");
#nullable restore
#line 16 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
                                                                                                                                            Write(item.Id_Detalle_Cotizacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"glyphicon glyphicon-refresh\"></span></a>\n");
#nullable restore
#line 17 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </td>\n");
#nullable restore
#line 19 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
         if (item.Id_Estado != 3)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 21 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
           Write(item.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 22 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
           Write(item.Sub_Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 23 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td class=\"text-danger\">Por cotizar</td>\n            <td class=\"text-danger\">Por cotizar</td>\n");
#nullable restore
#line 28 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>");
#nullable restore
#line 29 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
       Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>\n");
#nullable restore
#line 31 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
             if (item.Cotizacion.Id_Estado == 3 || item.Cotizacion.Id_Estado == 6)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button type=\"button\" class=\"cotizaritemdetallecotizacion btn btn-success fa fa-dollar\" data-idcotizacion=\"");
#nullable restore
#line 33 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
                                                                                                                      Write(item.Id_Cotizacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-iddetallecotizacion=\"");
#nullable restore
#line 33 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
                                                                                                                                                                     Write(item.Id_Detalle_Cotizacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#exampleModalCenter\"> Cotizar</button>\n");
#nullable restore
#line 34 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
             if (item.Cotizacion.Id_Estado != 5)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"eliminaritemdetallecotizacion btn btn-danger\" data-idcotizacion=\"");
#nullable restore
#line 37 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
                                                                                      Write(item.Id_Cotizacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-iddetallecotizacion=\"");
#nullable restore
#line 37 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
                                                                                                                                     Write(item.Id_Detalle_Cotizacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"glyphicon glyphicon-trash\"></span>");
            WriteLiteral("</a>\n");
#nullable restore
#line 38 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
            }
            else {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <label>...</label>");
#nullable restore
#line 39 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </td>\n    </tr>\n");
#nullable restore
#line 42 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetalleCotizacionAdmin.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
