#pragma checksum "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_TableData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03dd3d7b65be571927ffa7e7141146867549129d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee__TableData), @"mvc.1.0.view", @"/Views/Employee/_TableData.cshtml")]
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
#line 1 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\_ViewImports.cshtml"
using IBJOffice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\_ViewImports.cshtml"
using IBJOffice.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03dd3d7b65be571927ffa7e7141146867549129d", @"/Views/Employee/_TableData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ed072de2d3e8125b11208c54247f9ebaafeb8d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee__TableData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_TableData.cshtml"
  
    List<Employee> EmployeeList = (List<Employee>)ViewData["EmployeesList"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_TableData.cshtml"
 if (EmployeeList.Count > 0)
{
    foreach (var employee in EmployeeList)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"employees-row\" style=\"width: 20%; text-align:center;\">\r\n            <td>");
#nullable restore
#line 10 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_TableData.cshtml"
           Write(employee.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 11 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_TableData.cshtml"
           Write(employee.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 12 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_TableData.cshtml"
           Write(employee.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 13 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_TableData.cshtml"
           Write(employee.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_TableData.cshtml"
           Write(employee.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_TableData.cshtml"
           Write(employee.DateJoined);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_TableData.cshtml"
           Write(employee.LastUpdated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <button type=\"button\" class=\"btn btn-sm btn-dark employee-edit\" data-id=\"");
#nullable restore
#line 18 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_TableData.cshtml"
                                                                                    Write(employee.EmployeeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    <i class=\"fa fa-edit\"></i>\r\n                </button>\r\n                <button type=\"button\" class=\"btn btn-sm btn-danger employee-delete\" data-id=\"");
#nullable restore
#line 21 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_TableData.cshtml"
                                                                                        Write(employee.EmployeeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    <i class=\"fa fa-trash\"></i>\r\n                </button>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 26 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_TableData.cshtml"
    }
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td colspan=\"10\" style=\"text-align: center\">\r\n            <div>\r\n                No Records\r\n            </div>\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 37 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_TableData.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
