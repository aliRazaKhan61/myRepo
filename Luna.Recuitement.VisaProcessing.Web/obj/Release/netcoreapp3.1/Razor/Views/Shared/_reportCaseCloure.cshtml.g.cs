#pragma checksum "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportCaseCloure.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c2fdb2e8efd7a297f8334e30dba7a77c1d6441b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__reportCaseCloure), @"mvc.1.0.view", @"/Views/Shared/_reportCaseCloure.cshtml")]
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
#line 1 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\_ViewImports.cshtml"
using Luna.Recruitment.VisaProcessing.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\_ViewImports.cshtml"
using Luna.Recruitment.VisaProcessing.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c2fdb2e8efd7a297f8334e30dba7a77c1d6441b", @"/Views/Shared/_reportCaseCloure.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a398e6794262128d82e49352d048303a2258dff", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__reportCaseCloure : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Luna.Recruitment.VisaProcessing.Data.DTO.ReportDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<table width=""100%"" class=""table table-responsive-md applyDataTableWithExport6"" id=""datatable"">
    <thead>
        <tr>
            <th style=""display:none"">Id</th>
            <th style=""display:none"">visaProcessId</th>
            <th>File Number</th>
            <th>Name</th>
            <th>Passport</th>
            <th>Trade</th>
            <th>DocumentHandoverDate</th>
            <th>DateOfCloure</th>
            <th>Action</th>
");
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 27 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportCaseCloure.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"CandidateId\" style=\"display:none\">\r\n                    <span>");
#nullable restore
#line 31 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportCaseCloure.cshtml"
                     Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("                </td>\r\n                <td class=\"visaProcessId\" style=\"display:none\">\r\n                    <span>");
#nullable restore
#line 35 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportCaseCloure.cshtml"
                     Write(item.visaProcessId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("                </td>\r\n                <td class=\"FileNumber\">\r\n                    <span>");
#nullable restore
#line 39 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportCaseCloure.cshtml"
                     Write(item.FileNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("                </td>\r\n                <td class=\"Name\">\r\n                    <span>");
#nullable restore
#line 43 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportCaseCloure.cshtml"
                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("                </td>\r\n                <td class=\"Passport\">\r\n                    <span>");
#nullable restore
#line 47 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportCaseCloure.cshtml"
                     Write(item.Passport);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("                </td>\r\n                <td class=\"Trade\">\r\n                    <span>");
#nullable restore
#line 51 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportCaseCloure.cshtml"
                     Write(item.Trade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("                </td>\r\n                <td class=\"DocumentHandoverDate\">\r\n                    <span>");
#nullable restore
#line 55 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportCaseCloure.cshtml"
                     Write(item.DocumentHandOverDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <input required type=\"date\"");
            BeginWriteAttribute("value", " value=\"", 2348, "\"", 2382, 1);
#nullable restore
#line 56 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportCaseCloure.cshtml"
WriteAttributeValue("", 2356, item.DocumentHandOverDate, 2356, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display:none\" />\r\n                </td>\r\n                <td class=\"DateOfCloure\">\r\n                    <span>");
#nullable restore
#line 59 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportCaseCloure.cshtml"
                     Write(item.DateOfCloure);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <input required type=\"date\"");
            BeginWriteAttribute("value", " value=\"", 2575, "\"", 2601, 1);
#nullable restore
#line 60 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportCaseCloure.cshtml"
WriteAttributeValue("", 2583, item.DateOfCloure, 2583, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""display:none"" />
                </td>
                <td>
                    <a class=""btnEdit"" href=""javascript:;"">Edit</a>
                    <a class=""btnUpdateCloure"" href=""javascript:;"" style=""display:none"">Update</a>
                    <a class=""btnCancel"" href=""javascript:;"" style=""display:none"">Cancel</a>
");
            WriteLiteral("                </td>\r\n");
            WriteLiteral("\r\n            </tr>\r\n");
#nullable restore
#line 75 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportCaseCloure.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>


<script type=""text/javascript"">

    $(""body"").on(""click"", ""#updatedInfoMedical"", function () {
        var row = $(this).closest(""tr"");
        Id = row.find("".CandidateId"").find(""span"").html();
        var Obj = { id: Id };
        updatedCandidateInfo(Obj);
    });
    $('#updateInfoCandidate').click(function () {

        if (!$('#updatedPlaceOfBirthCountryId').val() || $('#updatedPlaceOfBirthCountryId').val() == 0) {
            alert(""Please select a country."");
            return false;
        }
        if (!$('#updatedPlaceOfBirthCityId').val() || $('#updatedPlaceOfBirthCityId').val() == 0) {
            alert(""Please select a city."");
            return false;
        }
        if (!$('#updatedDateOfBirth').val()) {
            alert(""Please enter a date of birth."");
            return false;
        }
        updateCandidateInfo();
    });
    function AppendRowAfterInsertRecord(row, MedicalOnlineReceivingDate, MedicalOnlineReceivingDate) {

   ");
            WriteLiteral(@"     $("".MedicalOnlineSendingDate"", row).find(""span"").html(MedicalOnlineSendingDate);
        $("".MedicalOnlineSendingDate"", row).find(""input"").val(MedicalOnlineSendingDate);
        $("".MedicalOnlineReceivingDate"", row).find(""span"").html(BiometricReceivingDate);
        $("".MedicalOnlineReceivingDate"", row).find(""input"").val(BiometricReceivingDate);
        debugger;
        row.find("".btnEdit"").show();
        row.find("".btnDelete"").show();
        $(""#datatable"").append(row);
    };

    //Edit event handler.
    $(""body"").on(""click"", ""#datatable .btnEdit"", function () {
        //debugger;
        var row = $(this).closest(""tr"");
        $(""td"", row).each(function () {
            if ($(this).find(""input"").length > 0) {
                $(this).find(""input"").show();
                $(this).find(""span"").hide();
            }
        });
        row.find("".btnUpdateCloure"").show();
        row.find("".btnCancel"").show();
        $(this).hide();
    });

    //Update event handler.
  ");
            WriteLiteral(@"  $(""body"").on(""click"", ""#datatable .btnUpdateCloure"", function () {
        var row = $(this).closest(""tr"");
        if (row.find("".DateOfCloure"").find(""input"").val().length == 0 ||
            row.find("".DocumentHandoverDate"").find(""input"").val().length == 0) {
            alert('please fill the field');
            return false;
        }
        $(""td"", row).each(function () {
            if ($(this).find(""input"").length > 0) {
                var span = $(this).find(""span"");
                var input = $(this).find(""input"");
                span.html(input.val());
                span.show();
                input.hide();
            }
        });
        row.find("".btnEdit"").show();
        //row.find("".btnDelete"").show();
        row.find("".btnCancel"").hide();
        $(this).hide();
        var Obj = {
            Id: row.find("".visaProcessId"").find(""span"").html(),
            DateOfCloure: row.find("".DateOfCloure"").find(""span"").html(),
            DocumentHandoverDate: row.find");
            WriteLiteral(@"("".DocumentHandoverDate"").find(""span"").html()
        };
        //if (!patientObj.Id || patientObj.Id <= 0) {
        //    alert(Id);
        //    alert(""Invalid Id!"");
        //    return false;
        //}
        FileNumber = row.find("".FileNumber"").find(""span"").html();
        $.ajax({
            type: ""POST"",
            url: '/Reports/UpdateCaseCloureTab',
            data: Obj,
            dataType: ""json"",
            success: function (data) {
                toastr.success('Record update successfully.', ""Alert"");
                window.location.href = '/Reports/DeploymentForReloading?FileNumber=' + FileNumber;
                //$.ajax({
                //    type: ""GET"",
                //    url: '/Reports/TabReport',
                //    data: { FileNumber: row.find("".FileNumber"").find(""span"").html() },
                //    dataType: ""json"",
                //    success: function (data) {
                //        //('#datatable')
                //    },
          ");
            WriteLiteral(@"      //    error: function (errormsg) {
                //        toastr.success('Record update successfully.', ""Alert"");
                //    }
                //});
            },
            error: function (errormsg) {
                prompt("""", JSON.stringify(errormsg));
            }
        });
        $(this).closest('tr').remove();


        ////$.ajax({
        //    type: ""POST"",
        //    data: JSON.stringify(Obj),
        //    url: '/Reports/UpdateVisaProcess',
        //    contentType: 'application/json',
        //    dataType: 'json',
        //    success: function (result) {
        //        ClearAllInput();
        //    },
        //    error: function (errormessage) {
        //        alert(errormessage.responseText);
        //    }
        //    error: function (errormsg) {
        //        prompt("""", JSON.stringify(errormsg))
        //    }
        //});
    });

    //Cancel event handler.
    $(""body"").on(""click"", ""#datatable .btnCancel"", fu");
            WriteLiteral(@"nction () {
        var row = $(this).closest(""tr"");
        $(""td"", row).each(function () {
            if ($(this).find(""input"").length > 0) {
                var span = $(this).find(""span"");
                var input = $(this).find(""input"");
                input.val(span.html());
                span.show();
                input.hide();
            }
        });
        row.find("".btnEdit"").show();
        row.find("".btnDelete"").show();
        row.find("".btnUpdateTravel"").hide();
        $(this).hide();
    });

        ////Delete event handler.
        //$(""body"").on(""click"", ""#datatable .btnDelete"", function () {
        //    if (confirm(""Do you want to delete this row?"")) {
        //        var row = $(this).closest(""tr"");
        //        var FileNumber = row.find(""span"").html();
        //        $.ajax({
        //            url: ""/Reports/DeletePatient?FileNumber="" + FileNumber,
        //            type: ""POST"",
        //            contentType: ""application/json;c");
            WriteLiteral(@"harset=UTF-8"",
        //            dataType: ""json"",
        //            success: function (response) {
        //                if ($(""#datatable tr"").length > 2) {
        //                    row.remove();
        //                } else {
        //                    row.find("".btnEdit"").hide();
        //                    row.find("".btnDelete"").hide();
        //                    row.find(""span"").html(' ');
        //                }
        //            }
        //        });
        //    }
        //});
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Luna.Recruitment.VisaProcessing.Data.DTO.ReportDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
