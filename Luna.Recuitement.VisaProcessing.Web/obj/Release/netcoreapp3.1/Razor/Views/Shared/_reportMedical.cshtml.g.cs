#pragma checksum "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportMedical.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e9a05a43a347984194c687b623064449c36c585"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__reportMedical), @"mvc.1.0.view", @"/Views/Shared/_reportMedical.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e9a05a43a347984194c687b623064449c36c585", @"/Views/Shared/_reportMedical.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a398e6794262128d82e49352d048303a2258dff", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__reportMedical : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Luna.Recruitment.VisaProcessing.Data.DTO.ReportDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


    <table class=""table table-responsive-md applyDataTableWithExport6"" width=""100%"" id=""datatableMedical"">
        <thead>
            <tr>
                <th style=""display:none"">id</th>
                <th style=""display:none"">VisaProcessId</th>
                <th>File Number</th>
                <th>Name</th>
                <th>Passport</th>
                <th>Trade</th>
");
            WriteLiteral("                <th>Medical Online Send</th>\r\n\r\n                <th>Medical Online Recv</th>\r\n                <th hidden>Status</th>\r\n                <th>Status</th>\r\n                <th>Remarks</th>\r\n                <th>Action</th>\r\n");
            WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 34 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportMedical.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"CandidateId\" style=\"display:none\">\r\n                    <span>");
#nullable restore
#line 38 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportMedical.cshtml"
                     Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("                </td>\r\n                <td class=\"visaProcessId\" style=\"display:none\">\r\n                    <span>");
#nullable restore
#line 42 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportMedical.cshtml"
                     Write(item.visaProcessId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("                </td>\r\n                <td class=\"FileNumber\">\r\n                    <span>");
#nullable restore
#line 46 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportMedical.cshtml"
                     Write(item.FileNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("                </td>\r\n                <td class=\"Name\">\r\n");
            WriteLiteral("                    <a id=\"updatedInfoMedical\" style=\"cursor:pointer\">");
#nullable restore
#line 51 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportMedical.cshtml"
                                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
            WriteLiteral("                </td>\r\n                <td class=\"Passport\">\r\n                    <span>");
#nullable restore
#line 55 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportMedical.cshtml"
                     Write(item.Passport);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("                </td>\r\n                <td class=\"Trade\">\r\n                    <span>");
#nullable restore
#line 59 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportMedical.cshtml"
                     Write(item.Trade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("                </td>\r\n                <!--<td class=\"ENumber\">\r\n    <span>item.ENumber</span>-->\r\n");
            WriteLiteral("                <!--</td>\r\n    <td class=\"ENumberDate\">\r\n        <span>item.ENumberDate</span>-->\r\n");
            WriteLiteral("                <!--</td>\r\n    <td class=\"BiometricSendingDate\">\r\n        <span>item.BiometricSendingDate</span>-->\r\n");
            WriteLiteral("                <!--</td>\r\n    <td class=\"BiometricReceivingDate\">\r\n        <span>item.BiometricReceivingDate</span>-->\r\n");
            WriteLiteral("                <!--</td>-->\r\n\r\n                <td class=\"MedicalOnlineSendingDate\">\r\n                    <span>");
#nullable restore
#line 80 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportMedical.cshtml"
                     Write(item.MedicalOnlineSendingDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <input type=\"date\" aria-required=\"true\"");
            BeginWriteAttribute("value", " value=\"", 3490, "\"", 3528, 1);
#nullable restore
#line 81 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportMedical.cshtml"
WriteAttributeValue("", 3498, item.MedicalOnlineSendingDate, 3498, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display:none\" />\r\n                </td>\r\n                <td class=\"MedicalOnlineReceivingDate\">\r\n                    <span>");
#nullable restore
#line 84 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportMedical.cshtml"
                     Write(item.MedicalOnlineReceivingDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <input type=\"date\" aria-required=\"true\"");
            BeginWriteAttribute("value", " value=\"", 3761, "\"", 3801, 1);
#nullable restore
#line 85 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportMedical.cshtml"
WriteAttributeValue("", 3769, item.MedicalOnlineReceivingDate, 3769, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display:none\" />\r\n                </td>\r\n                <td hidden id=\"statusId\">\r\n                    ");
#nullable restore
#line 88 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportMedical.cshtml"
               Write(item.StatusId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"ProcessingStartStatus\">\r\n");
            WriteLiteral("                    <select class=\"startStatus\"");
            BeginWriteAttribute("id", " id=\"", 4103, "\"", 4134, 2);
            WriteAttributeValue("", 4108, "startStatus_", 4108, 12, true);
#nullable restore
#line 92 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportMedical.cshtml"
WriteAttributeValue("", 4120, item.StatusId, 4120, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </select>\r\n                </td>\r\n                <td class=\"PassportSubmissionDate\">\r\n                    <textarea id=\"medicalRemarks\">");
#nullable restore
#line 96 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportMedical.cshtml"
                                             Write(item.StatusRemarks);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>
                </td>
                <td>
                    <a class=""btnEdit"" href=""javascript:;"">Edit</a>
                    <a class=""btnUpdateMedical"" href=""javascript:;"" style=""display:none"">Update</a>
                    <a class=""btnCancel"" href=""javascript:;"" style=""display:none"">Cancel</a>
");
            WriteLiteral("                </td>\r\n");
            WriteLiteral("\r\n            </tr>\r\n");
#nullable restore
#line 112 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_reportMedical.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            WriteLiteral(@"
<script type=""text/javascript"">
    $(document).ready(function () {
        var table = $('#datatableMedical').DataTable();

        table.rows().every(function (rowIdx, tableLoop, rowLoop) {
            var row = this.node();
            var statusId2 = $(row).find('td').eq(8).html().trim();
            //var statusId3 = $(row).find('td').eq(9).html();
            var selectElement = $(row).find('select.startStatus');

            // Perform your AJAX request and populate the <select> element
            $.getJSON('/CandidateProfile/GetBVisaStatus/', function (data) {
                // Clear the current options
                selectElement.empty();

                // Add a default option
                selectElement.append('<option value=""0"">-- Select Visa Status --</option>');

                // Add options from the data
                $.each(data, function () {
                    var option = $('<option>', {
                        value: this.id,
                        text");
            WriteLiteral(@": this.name
                    });
                    selectElement.append(option);
                });

                // Set the selected value based on statusId2 or statusId3
                selectElement.val(statusId2); // Change this to select the appropriate value

            }).fail(function (jqXHR, textStatus, errorThrown) {
                alert('Error getting visa trades!');
            });
        });

    });
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
        if (!$('#updatedPlaceOfBirthCityId').val() || $('#updatedPlaceOfBirthCityId').val() =");
            WriteLiteral(@"= 0) {
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

            $("".MedicalOnlineSendingDate"", row).find(""span"").html(MedicalOnlineSendingDate);
            $("".MedicalOnlineSendingDate"", row).find(""input"").val(MedicalOnlineSendingDate);
            $("".MedicalOnlineReceivingDate"", row).find(""span"").html(BiometricReceivingDate);
            $("".MedicalOnlineReceivingDate"", row).find(""input"").val(BiometricReceivingDate);
            debugger;
            row.find("".btnEdit"").show();
            row.find("".btnDelete"").show();
            $(""#datatableMedical"").append(row);
        };

    //Edit event handler.
    $(""body"").on(""click"", ""#datatableMedical .btnEdit"", function () ");
            WriteLiteral(@"{
       // debugger;
        var row = $(this).closest(""tr"");
        $(""td"", row).each(function () {
            if ($(this).find(""input"").length > 0) {
                row.find("".MedicalOnlineSendingDate"").find('input').show();
                row.find("".MedicalOnlineReceivingDate"").find('input').show();
                $(this).find(""span"").hide();
            }
        });
        if (row.find("".MedicalOnlineSendingDate"").find(""span"").html()) {
            row.find("".MedicalOnlineSendingDate"").find('span').show();
            row.find("".MedicalOnlineSendingDate"").find('input').hide();
        }
        else {
            row.find("".MedicalOnlineReceivingDate"").find('span').show();
            row.find("".MedicalOnlineReceivingDate"").find('input').hide();
        }
        row.find("".btnUpdateMedical"").show();
        row.find("".btnCancel"").show();
        row.find("".btnDelete"").hide();
        $(this).hide();
    });

    //Update event handler.
    $(""body"").on(""click"", ""#datatabl");
            WriteLiteral(@"eMedical .btnUpdateMedical"", function () {
        var row = $(this).closest(""tr"");
        //if (row.find("".MedicalOnlineSendingDate"").find(""input"").val().length == 0 ||
        //    row.find("".MedicalOnlineReceivingDate"").find(""input"").val().length == 0 ||
        //    !(row.find(""#medicalRemarks"").val())) {
        //    alert('please fill the field');
        //    return false;
        //}
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
        row.find("".btnDelete"").show();
        row.find("".btnCancel"").hide();
        $(this).hide();
        var row = $(this).closest(""tr"");
        var statusId = $(row).find('select.startStatus').val();
        var Obj = {
            medical");
            WriteLiteral(@"Remarks: row.find(""#medicalRemarks"").val(),
            MedicalOnlineSendingDate: row.find("".MedicalOnlineSendingDate"").find(""span"").html(),
            Id: row.find("".visaProcessId"").find(""span"").html(),
            statusId: statusId,
            MedicalOnlineReceivingDate: row.find("".MedicalOnlineReceivingDate"").find(""span"").html(),
        };
        //if (!patientObj.Id || patientObj.Id <= 0) {
        //    alert(Id);
        //    alert(""Invalid Id!"");
        //    return false;
        //}
        FileNumber = row.find("".FileNumber"").find(""span"").html();
        $.ajax({
            type: ""POST"",
            url: '/Reports/UpdateMedicalTab',
            data: Obj,
            dataType: ""json"",
            success: function (data) {
                toastr.success('Record update successfully.', ""Alert"");
                window.location.href = '/Reports/TabReportForReloading?FileNumber=' + FileNumber;
                //$.ajax({
                //    type: ""GET"",
                // ");
            WriteLiteral(@"   url: '/Reports/TabReport',
                //    data: { FileNumber: row.find("".FileNumber"").find(""span"").html() },
                //    dataType: ""json"",
                //    success: function (data) {
                //        //('#datatable')
                //    },
                //    error: function (errormsg) {
                //        toastr.success('Record update successfully.', ""Alert"");
                //    }
                //});
            },
            error: function (errormsg) {
                alert('Error');
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
        //        alert(e");
            WriteLiteral(@"rrormessage.responseText);
        //    }
        //    error: function (errormsg) {
        //        prompt("""", JSON.stringify(errormsg))
        //    }
        //});
    });

    //Cancel event handler.
    $(""body"").on(""click"", ""#datatableMedical .btnCancel"", function () {
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
        row.find("".btnUpdateMedical"").hide();
        $(this).hide();
    });

        ////Delete event handler.
        //$(""body"").on(""click"", ""#datatable .btnDelete"", function () {
        //    if (confirm(""Do you want to delete this row?"")) {
        //        var row = $(thi");
            WriteLiteral(@"s).closest(""tr"");
        //        var FileNumber = row.find(""span"").html();
        //        $.ajax({
        //            url: ""/Reports/DeletePatient?FileNumber="" + FileNumber,
        //            type: ""POST"",
        //            contentType: ""application/json;charset=UTF-8"",
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