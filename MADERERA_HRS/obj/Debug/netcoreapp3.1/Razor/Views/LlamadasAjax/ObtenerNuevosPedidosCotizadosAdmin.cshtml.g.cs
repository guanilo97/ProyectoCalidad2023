#pragma checksum "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerNuevosPedidosCotizadosAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb2c34efb2f63f25433b90b40c0560d1ed85832c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LlamadasAjax_ObtenerNuevosPedidosCotizadosAdmin), @"mvc.1.0.view", @"/Views/LlamadasAjax/ObtenerNuevosPedidosCotizadosAdmin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb2c34efb2f63f25433b90b40c0560d1ed85832c", @"/Views/LlamadasAjax/ObtenerNuevosPedidosCotizadosAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0567fe31a7291547ba761674eb427d99aa8dfebf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LlamadasAjax_ObtenerNuevosPedidosCotizadosAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerNuevosPedidosCotizadosAdmin.cshtml"
   Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerNuevosPedidosCotizadosAdmin.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td>");
#nullable restore
#line 5 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerNuevosPedidosCotizadosAdmin.cshtml"
       Write(item.Usuario.DNI);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 6 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerNuevosPedidosCotizadosAdmin.cshtml"
       Write(item.Usuario.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 7 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerNuevosPedidosCotizadosAdmin.cshtml"
       Write(item.Telefono_Comunicacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 8 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerNuevosPedidosCotizadosAdmin.cshtml"
       Write(item.Fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 9 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerNuevosPedidosCotizadosAdmin.cshtml"
       Write(item.Fecha_Entrega_Solicitada);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 10 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerNuevosPedidosCotizadosAdmin.cshtml"
       Write(item.Direccion_Entrega);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 11 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerNuevosPedidosCotizadosAdmin.cshtml"
       Write(item.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>\n            <button type=\"button\" class=\"verdetallecotizacion btn btn-success\" data-toggle=\"modal\" data-target=\".bd-example-modal-xl\" data-idcotizacion=\"");
#nullable restore
#line 13 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerNuevosPedidosCotizadosAdmin.cshtml"
                                                                                                                                                    Write(item.Id_Cotizacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"fa fa-eye\"></span> ver productos</button>\n");
            WriteLiteral("            <a class=\"iniciarconstruccion btn btn-warning\" data-toggle=\"modal\" data-target=\".modal-dialog modal-xl1\" data-idcotizacion=\"");
#nullable restore
#line 15 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerNuevosPedidosCotizadosAdmin.cshtml"
                                                                                                                                   Write(item.Id_Cotizacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"glyphicon glyphicon-play\"></span> Iniciar construcción</a>\n            <a class=\"eliminarcotizacion btn btn-danger\" data-idcotizacion=\"");
#nullable restore
#line 16 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerNuevosPedidosCotizadosAdmin.cshtml"
                                                                       Write(item.Id_Cotizacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"glyphicon glyphicon-trash\"></span></a>\n        </td>\n    </tr>\n");
#nullable restore
#line 19 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerNuevosPedidosCotizadosAdmin.cshtml"
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
