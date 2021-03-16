#pragma checksum "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99467c79f358b9e23d69638a988f03b3ca5df6dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation_MyReservations), @"mvc.1.0.view", @"/Views/Reservation/MyReservations.cshtml")]
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
#line 1 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\_ViewImports.cshtml"
using YCReservations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\_ViewImports.cshtml"
using YCReservations.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99467c79f358b9e23d69638a988f03b3ca5df6dc", @"/Views/Reservation/MyReservations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ea929784c3189be693e7d11ebfac85f2b2d25c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservation_MyReservations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Reservations>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reservation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
  
    int counter = 1;
    ViewBag.Title = "My Reservations List";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""my-5 text-left"">
    <h2> My Reservations </h2>
    <hr />
</div>

<div class=""my-5"">
    <table id=""myTable"" class=""table"">
        <thead class=""thead-dark table-hover table-dark"">
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">");
#nullable restore
#line 18 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
                           Write(Html.DisplayNameFor(item => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 19 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
                           Write(Html.DisplayNameFor(item => item.ReservationTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 20 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
                           Write(Html.DisplayNameFor(item => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
            WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
             foreach (Reservations reservation in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
               Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
               Write(reservation.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 30 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
                 if (reservation.ReservationTypeId == 3)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Week-End</td>\r\n");
#nullable restore
#line 33 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
                }
                else if (reservation.ReservationTypeId == 2)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Evening</td>\r\n");
#nullable restore
#line 37 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Day</td>\r\n");
#nullable restore
#line 41 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
                 if (reservation.Status == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"text-muted\">Pending</td>\r\n");
#nullable restore
#line 46 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
                }
                else if (reservation.Status == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"text-success\">Approved</td>\r\n");
#nullable restore
#line 50 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"text-danger\">Declined</td>\r\n");
#nullable restore
#line 54 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 58 "C:\Users\msckt\OneDrive\Bureau\ASP.NET-CORE-RESERVATION\YCReservations\YCReservations\Views\Reservation\MyReservations.cshtml"
                counter++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <div class=\"my-5 text-center\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99467c79f358b9e23d69638a988f03b3ca5df6dc10325", async() => {
                WriteLiteral("Make new reservation");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99467c79f358b9e23d69638a988f03b3ca5df6dc11711", async() => {
                WriteLiteral("Back to Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            DefineSection("DTReservationsList", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'#myTable\').dataTable();\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Reservations>> Html { get; private set; }
    }
}
#pragma warning restore 1591
