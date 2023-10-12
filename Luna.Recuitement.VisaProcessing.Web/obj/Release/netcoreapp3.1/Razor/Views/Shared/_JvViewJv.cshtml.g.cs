#pragma checksum "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_JvViewJv.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68cc44a1b8e0844d8f0108416683832721242d29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__JvViewJv), @"mvc.1.0.view", @"/Views/Shared/_JvViewJv.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68cc44a1b8e0844d8f0108416683832721242d29", @"/Views/Shared/_JvViewJv.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a398e6794262128d82e49352d048303a2258dff", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__JvViewJv : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Luna.Recruitment.VisaProcessing.Data.Models.Receipt>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral(@"<a class=""btn btn-primary float-right"" id=""addRowJVA"" style=""cursor:pointer""><i class=""fas fa-plus""></i></a>
<div class=""panel panel-primary"">
    <div class=""panel-body"">
        <table class=""table datatableHideFirstThree"" width=""100%"" id=""tableJVListA"" style=""border:2px solid black"">
            <thead>
                <tr>
                    <th></th>
                    <th></th>
                    <th></th>
                    <th>Date</th>
                    <th>Credit Account</th>
                    <th>Credit Amount</th>
                    <th>Debit Account</th>
                    <th>Debit Amount</th>

                    <th>Remarks</th>
                    <th>
                        
                    </th>
                </tr>
            </thead>
            <tbody id=""tblJVListA"">
                <tr>
                    <td >
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
  ");
            WriteLiteral(@"                  <td style='width:10%'>
                        <input type='date' required id='jVDate' class='form-control' />
                    </td>
                    <td>
                        <select class='form-control JVGetChartAccount' id='CreditAccount'></select>
                    </td>
                    <td style='width:5%'>
                        <input type='number' id='CreditamountId' class='form-control' value='0' />
                    </td>
                    <td>
                        <select class='form-control JVGetChartAccount' id='DebitAccount'></select>
                    </td>
                    <td style='width:5%'>
                        <input class='form-control' type='number' id='DebitamountId' value='0' />
                    </td>
                    <td style='width:20%'>
                        <input type='text' class='form-control' id='userRemarks' />
                    </td>
                    <td>
                        <a class='remo");
            WriteLiteral(@"veJVRow'><i class='fas fa-trash'></i></a>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</div>
<div class=""col-md-6"">
    <div class=""form-group col-md-12"">
        <button class=""btn btn-primary float-right"" id=""btnSaveJV"" value=""Save"">Save</button>
    </div>
</div>

<script>
    $(document).ready(function () {
        getAccount();
        function getAccount() {
            $.getJSON('/Receipt/GetChartOfAccount/', function (data) {
                $('.JVGetChartAccount option').remove();
                $('.JVGetChartAccount').append('<option value=0>--select Account--</option>');
                $.each(data.response.data, function (dataA) {
                    for (var i = 0; i < Object.keys(data).length; i++) {
                        console.log(this.name);
                        var AccountValue = this.name;
                        $('.JVGetChartAccount').append('<option value=' + AccountValue + '>' + this.name + '</option>');");
            WriteLiteral(@"
                    }

                });
                $('#JVGetChartAccount').val();
            }).fail(function (jqXHR, textStatus, errorThrown) {
                alert('Journal entry api is not live!');
            });
        }
        //$(""#btnCallApi"").click(function () {
        //    $.ajax({
        //        method: ""POST"",
        //        url: ""/Receipt/GetChartOfAccount"",
        //        data:null,
        //        success: function (data) {
        //            console.log(data.response);
        //        },
        //        error: function (errormsg) { prompt("""", JSON.stringify(errormsg)) }
        //    });
        //});
        $(""#JVtypeId"").change(function () {
            if ($(this).val() == ""Bank"") {
                $('.BankAccountId').show();
                $('.receiptCheqNo').show();
            }
            else {
                $('.BankAccountId').hide();
                $('.receiptCheqNo').hide();

            }
        });
        $('#");
            WriteLiteral(@"btnSaveJV').click(function () {

            var CreditAccount;
            var CreditAmount;
            var DebitAccount;
            var DebitAmount;
            var JVDate;
            var userRemarks;
            $(""#tblJVListA tr"").each(function () {
                CreditAmount = $(this).find('#CreditamountId').val();
                DebitAmount = $(this).find('#DebitamountId').val();
                userRemarks = $(this).find('#userRemarks').val();
                CreditAccount = $(this).find('#CreditAccount option:selected').text();
                DebitAccount = $(this).find('#DebitAccount option:selected').text();
                JVDate = $(this).find('#jVDate').val();
                console.log('start');
                console.log(CreditAmount);
                console.log(DebitAmount);
                console.log(DebitAccount);
                console.log(CreditAccount);
                console.log('end');
                if (JVDate == """") {
                    alert('plea");
            WriteLiteral(@"se enter Date');
                    return false;
                }
                if (CreditAccount == '--select Account--') {
                    alert('please select CreditAccount');
                    return false;
                }
                if (DebitAccount == '--select Account--') {
                    alert('please select DebitAccount');
                    return false;
                }
                if (CreditAmount == 0) {
                    alert('please enter Credit Amount');
                    return false;
                }
                if (DebitAmount == 0) {
                    alert('please enter Debit Amount');
                    return false;
                }
                if (CreditAmount != DebitAmount) {
                    alert('Credit amount must be equal to Debit Amount');
                    return false;
                }
                if (userRemarks == """") {
                    alert('please enter remarks')
                }
     ");
            WriteLiteral(@"           var data = {
                    ""CreditAmount"": CreditAmount,
                    ""DebitAmount"": DebitAmount,
                    ""CreditAccount"": CreditAccount,
                    ""DebitAccount"": DebitAccount,
                    ""ID"": ""ACC-JV-2022-00003"",
                    ""Entry Type"": ""Journal Entry"",
                    ""Series"": ""ACC-JV-.YYYY.-"",
                    ""company"": ""LUNA CORPORATION"",
                    ""user_remark"": userRemarks,
                    ""posting_date"": JVDate,
                    ""total_debit"": DebitAmount,
                    ""total_credit"": CreditAmount,
                    ""exchange_rate"": 1.0,
                    ""accounts"": [{
                        ""account"": CreditAccount, ""debit"": DebitAmount, ""credit"": 0.00,
                        ""debit_in_account_currency"": DebitAmount,
                        ""credit_in_account_currency"": 0.00
                    },
                    {
                        ""account"": DebitAccount, ""debit"": ");
            WriteLiteral(@"0.00, ""credit"": CreditAmount,
                        ""debit_in_account_currency"": 0.00,
                        ""credit_in_account_currency"": CreditAmount
                    }]
                };
                $.ajax({
                    type: ""POST"",
                    url: '/Receipt/SaveJVA',
                    data: data,
                    dataType: ""json"",
                    success: function (data) {
                        if (data == true) {
                            toastr.success('JV added successfuly.');
                            setTimeout(() => { console.log(""redirecting!""); }, 3000);
                            window.location.href = ""/Receipt/ReceiptVoucher?FileNumber="" + ReceiptFileNo + ""&Reference="" + ReceiptReference;
                        }
                        else {
                            toastr.error('JV Not added successfuly');
                        }
                        console.log(data);

                    },
                    err");
            WriteLiteral(@"or: function () {
                        toastr.error('error');
                    }
                });
            });

        });

        $('#addRowJVA').click(function () {
            $('#tblJVListA').append(""<tr><td style='width:10%'><input type='date' required id='jVDate' class='form-control' /></td><td><select class='form-control JVGetChartAccount' id='CreditAccount'></select></td><td><input type='number' id='CreditamountId' class='form-control' value='0' /></td><td><select class='form-control JVGetChartAccount' id='DebitAccount'></select></td><td><input class='form-control' type='number' id='DebitamountId' value='0' /></td><td style='width:10%'><input type='text' class='form-control' id='userRemarks'/></td><td> <a class='removeJVRow'><i class='fas fa-trash' ></i ></a ></td></tr >"");
            getAccount();
        });
        $(document).on('click', '.removeJVRow', function () {
            $(this).closest('tr').remove();
        });

        //var data = {
        //    ""lstRe");
            WriteLiteral(@"ceipt"": lstCandidateId,
        //    ""lstCreditAmount"": CreditAmount,
        //    ""lstCreditAccount"": CreditAccount,
        //    ""lstDebitAmount"": DebitAmount,
        //    ""lstDebitAccount"": DebitAccount,
        //    ""lstVisaProcessId"": lstVisaProcessId,
        //    ""ID"": ""ACC-JV-2022-00003"",
        //    ""Entry Type"": ""Journal Entry"",
        //    ""Series"": ""ACC-JV-.YYYY.-"",
        //    ""company"": ""LUNA CORPORATION"",
        //    ""posting_date"": ""2022-02-02"",
        //    ""total_debit"": 1.0,
        //    ""total_credit"": 1.0,
        //    ""exchange_rate"": 1.0,
        //    ""accounts"": [{
        //        ""account"": ""1110 - Cash - LC"", ""debit"": 0.0, ""credit"": 1.0,
        //        ""debit_in_account_currency"": 0.0,
        //        ""credit_in_account_currency"": 1.0
        //    },
        //    {
        //        ""account"": ""1770 - Softwares - LC"", ""debit"": 1.0, ""credit"": 0.0,
        //        ""debit_in_account_currency"": 1.0,
        //        ""credit_in_account_");
            WriteLiteral(@"currency"": 0.0
        //    }]
        //};
        //$.ajax({
        //    type: ""POST"",
        //    url: '/Receipt/SaveJV',
        //    data: data,
        //    dataType: ""json"",
        //    success: function (data) {
        //        toastr.success('JV added successfuly.');
        //        setTimeout(() => { console.log(""redirecting!""); }, 3000);
        //        window.location.href = '/Receipt/ReceiptVoucher';
        //    },
        //    error: function () {
        //        toastr.error('while occured while saving passport.')
        //    }
        //});

    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Luna.Recruitment.VisaProcessing.Data.Models.Receipt> Html { get; private set; }
    }
}
#pragma warning restore 1591
