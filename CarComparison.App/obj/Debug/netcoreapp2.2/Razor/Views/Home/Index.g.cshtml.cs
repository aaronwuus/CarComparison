#pragma checksum "F:\source\CarComparison\CarComparison.App\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52586c3b09361cc451f46c1b3314ff28bb748c70"
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
#line 1 "F:\source\CarComparison\CarComparison.App\Views\_ViewImports.cshtml"
using CarComparison.App;

#line default
#line hidden
#line 2 "F:\source\CarComparison\CarComparison.App\Views\_ViewImports.cshtml"
using CarComparison.App.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52586c3b09361cc451f46c1b3314ff28bb748c70", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f5fbb414ab85788f4741a4af95eb2ce91abf81", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarComparison.Core.Entities.Car>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\source\CarComparison\CarComparison.App\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(143, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(146, 48, false);
#line 8 "F:\source\CarComparison\CarComparison.App\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("CarList", model: Model));

#line default
#line hidden
            EndContext();
            BeginContext(194, 1176, true);
            WriteLiteral(@"

    <ul>
        <li>
            <p>A function to calculate newest vehicles in order</p>
            <input name='newest' class=""btn btn-group btn-info"" id=""newest"" type=""button"" value=""Newest"" />
        </li>
        <li>
            <p>A function to calculate alphabetized List of vehicles</p>
            <input name='alphabetized' class=""btn btn-group btn-info"" id=""alphabetized"" type=""button"" value=""Alphabetized"" />
        </li>
        <li>
            <p>function to calculate ordered List of Vehicles by Price</p>
            <input name='price' class=""btn btn-group btn-info"" id=""price"" type=""button"" value=""Price"" />
        </li>
        <li>
            <p>function to calculate the best value</p>
            <input name='bestValue' class=""btn btn-group btn-info"" id=""bestValue"" type=""button"" value=""BestValue"" />
        </li>
        <li>
            <p>function to return a random car from the list</p>
            <input name='random' class=""btn btn-group btn-info"" id=""random"" ty");
            WriteLiteral("pe=\"button\" value=\"Random\" />\r\n        </li>\r\n        <li>\r\n            <p>function to calculate full consumption for a given distance</p>\r\n            ");
            EndContext();
            BeginContext(1371, 72, false);
#line 33 "F:\source\CarComparison\CarComparison.App\Views\Home\Index.cshtml"
       Write(Html.DropDownList("carId", ViewBag.items as IEnumerable<SelectListItem>));

#line default
#line hidden
            EndContext();
            BeginContext(1443, 342, true);
            WriteLiteral(@"
            Distance:
            <input type=""text"" name=""consumption"" id=""consumption"" />
            <input name='consumptionByDistance' class=""btn btn-group btn-info"" id=""consumptionByDistance"" type=""button"" value=""Consumption"" />
        </li>
        <li>
            <p>A function to return average MPG by year</p>
            ");
            EndContext();
            BeginContext(1786, 71, false);
#line 40 "F:\source\CarComparison\CarComparison.App\Views\Home\Index.cshtml"
       Write(Html.DropDownList("year", ViewBag.years as IEnumerable<SelectListItem>));

#line default
#line hidden
            EndContext();
            BeginContext(1857, 164, true);
            WriteLiteral("\r\n            <input name=\'averageMpgByYear\' class=\"btn btn-group btn-info\" id=\"averageMpgByYear\" type=\"button\" value=\"Average Mpg\" />\r\n        </li>\r\n    </ul>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2040, 3406, true);
                WriteLiteral(@"
    <script>
        $(function () {
            $(""#newest"").click(function () {
                GetResult(""GetVehicleByNewest"");
            });
            $(""#alphabetized"").click(function () {
                GetResult(""GetVehicleByAlphabetized"");
            });
            $(""#price"").click(function () {
                GetResult(""GetVehicleByPrice"");
            });
            $(""#bestValue"").click(function () {
                GetResult(""GetVehicleByBestValue"");
            });
            $(""#consumptionByDistance"").click(function () {
                GetCumption(""GetConsumptionByDistance"");
            });
            $(""#random"").click(function () {
                GetResult(""GetVehicleByRandom"");
            });
            $(""#averageMpgByYear"").click(function () {
                GetAverage(""GetAverageMpgByYear"");
            });
        })
        
        function GetResult(action) {
            $.getJSON({
                url: 'api/CarComparison/' + action,
   ");
                WriteLiteral(@"             dataType: 'JSON',
                type: 'GET',
                success: function (result) {
                    $(""#result"").empty();
                    console.log(result);
                    $(""#result"").append(`
                        <table><tr>
                        <th>ID</th>&nbsp
                        <th>Make</th>&nbsp
                        <th>Mode</th>&nbsp
                        <th>Color</th>&nbsp
                        <th>Year</th>&nbsp
                        <th>Price</th>&nbsp
                        <th>Tcc Rating</th>&nbsp
                        <th>hwy Mpg</th>&nbsp<tr>
                    `);
                    $.each(result, function (key, val) {
                        $(""#result"").append(`
                        <tr>
                        <td>${val.id}</td>&nbsp
                        <td>${val.make}</td>&nbsp
                        <td>${val.model}</td>&nbsp
                        <td>${val.color}</td>&nbsp
                      ");
                WriteLiteral(@"  <td>${val.year}</td>&nbsp
                        <td>${val.price}</td>&nbsp
                        <td>${val.tccRating}</td>&nbsp
                        <td>${val.hwyMpg}</td>&nbsp
                        <br/></tr>`
                        );
                    })
                }
            });
        };
        function GetCumption(action) {
            var carid = $(""#carId option:selected"").val();
            var distance = $(""#consumption"").val();
            $.getJSON({
                url: 'api/CarComparison/' + action + '/' + carid + '/' + distance,
                dataType: 'JSON',
                type: 'GET',
                success: function (result) {
                    $(""#result"").empty();
                    console.log(result);
                    $(""#result"").append(result);
                    })
                }
            });
        };
        function GetAverage(action) {
            var year = $(""#year option:selected"").val();
            $.getJSO");
                WriteLiteral(@"N({
                url: 'api/CarComparison/' + action + '/' + year,
                dataType: 'JSON',
                type: 'GET',
                success: function (result) {
                    $(""#result"").empty();
                    $(""#result"").append(result);
                }
            });
        };
</script>
");
                EndContext();
            }
            );
            BeginContext(5449, 74, true);
            WriteLiteral("<h1>Result</h1>\r\n<div class=\"form-text\" name=\"result\" id=\"result\"></div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CarComparison.Core.Entities.Car>> Html { get; private set; }
    }
}
#pragma warning restore 1591