#pragma checksum "C:\Users\ASUS\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\City\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ca65694d912725c700865e5281742c9baa2146e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_City_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/City/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ca65694d912725c700865e5281742c9baa2146e", @"/Areas/Admin/Views/City/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32ec19881daa9c406a3e822741c8d3bb751aacdf", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_City_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\City\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script src=""//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js""></script>
<h2> ??ehir-??lke ????lemleri</h2>
<br />
<button type=""button"" id=""btngetlist"" class=""btn btn-outline-info""> ??ehir Listesi</button>
<button type=""button"" id=""btngetbyid"" class=""btn btn-outline-primary""> ??ehir Getir</button>
<button type=""button"" id=""btngetaddcity"" class=""btn btn-outline-warning""> ??ehir Ekle</button>
<button type=""button"" id=""btngetdeletecity"" class=""btn btn-outline-danger""> ??ehir Sil</button>
<button type=""button"" id=""btngetupdatecity"" class=""btn btn-outline-success""> ??ehir G??ncelle</button>

<br />
<br />

<div id=""citylist"">
    Buraya ??ehir Listesi Gelecek
</div>

<script>
    $(""#btngetlist"").click(function () {
        $.ajax({
            contentType: ""application/json"",
            dataType: ""json"",
            type: ""Get"",
            url: ""/Admin/City/CityList/"",
            //e??er ba??ar??l?? olurssa
            success: function (func) {
                let w = jQuery.parseJSON(f");
            WriteLiteral(@"unc);
                console.log(w);
                let tablehtml = ""<table class= table table-bordered> <tr><th> ??ehir ID</th> <th>??ehir Ad??</th> <th> ??lke Ad?? </th> </tr>"";
                $.each(w, (index, value) => {
                    tablehtml += `<tr><td>${value.CityId}</td> <td>${value.CityName}</td> <td>${value.CityCountry} </td> </tr>`
                });
                tablehtml += ""</table>"";
                $(""#citylist"").html(tablehtml);
            }
        });
    });
</script>");
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
