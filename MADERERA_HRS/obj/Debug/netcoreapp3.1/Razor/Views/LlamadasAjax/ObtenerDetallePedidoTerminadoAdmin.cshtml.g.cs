#pragma checksum "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetallePedidoTerminadoAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b87ddc28b4390a9a9977894bff946b751442747"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LlamadasAjax_ObtenerDetallePedidoTerminadoAdmin), @"mvc.1.0.view", @"/Views/LlamadasAjax/ObtenerDetallePedidoTerminadoAdmin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b87ddc28b4390a9a9977894bff946b751442747", @"/Views/LlamadasAjax/ObtenerDetallePedidoTerminadoAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0567fe31a7291547ba761674eb427d99aa8dfebf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LlamadasAjax_ObtenerDetallePedidoTerminadoAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetallePedidoTerminadoAdmin.cshtml"
  Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetallePedidoTerminadoAdmin.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td><img style=\"width:40px;height:55px\"");
            BeginWriteAttribute("src", " src=\"", 105, "\"", 132, 1);
#nullable restore
#line 5 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetallePedidoTerminadoAdmin.cshtml"
WriteAttributeValue("", 111, item.Producto.Imagen, 111, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\n        <td>");
#nullable restore
#line 6 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetallePedidoTerminadoAdmin.cshtml"
       Write(item.Producto.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 7 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetallePedidoTerminadoAdmin.cshtml"
       Write(item.Producto.Medidas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>\n            ");
#nullable restore
#line 9 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetallePedidoTerminadoAdmin.cshtml"
       Write(item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <a class=\"actualizarcantidaddetallepedido btn btn-warning\" data-idpedido=\"");
#nullable restore
#line 10 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetallePedidoTerminadoAdmin.cshtml"
                                                                                 Write(item.Id_Pedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-iddetallepedido=\"");
#nullable restore
#line 10 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetallePedidoTerminadoAdmin.cshtml"
                                                                                                                        Write(item.Id_Detalle_Pedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"glyphicon glyphicon-refresh\"></span></a>\n        </td>\n        <td>");
#nullable restore
#line 12 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetallePedidoTerminadoAdmin.cshtml"
       Write(item.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 13 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetallePedidoTerminadoAdmin.cshtml"
       Write(item.Sub_Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>\n            <a class=\"eliminaritemdetallepedido btn btn-danger\" data-idpedido=\"");
#nullable restore
#line 15 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetallePedidoTerminadoAdmin.cshtml"
                                                                          Write(item.Id_Pedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-iddetallepedido=\"");
#nullable restore
#line 15 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetallePedidoTerminadoAdmin.cshtml"
                                                                                                                 Write(item.Id_Detalle_Pedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"glyphicon glyphicon-trash\"></span>");
            WriteLiteral("</a>\n        </td>\n    </tr>\n");
#nullable restore
#line 18 "C:\Users\HP\Desktop\JEFRI\CALIDAD\ProyectoCalidad2022-master\ProyectoCalidad2022-master\MADERERA_HRS\Views\LlamadasAjax\ObtenerDetallePedidoTerminadoAdmin.cshtml"
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
