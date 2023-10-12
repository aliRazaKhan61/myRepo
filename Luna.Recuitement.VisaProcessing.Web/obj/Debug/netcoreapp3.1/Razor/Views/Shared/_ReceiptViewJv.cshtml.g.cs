#pragma checksum "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_ReceiptViewJv.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cecf7c281907fe4407db0c75883fc193eeea2e12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ReceiptViewJv), @"mvc.1.0.view", @"/Views/Shared/_ReceiptViewJv.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cecf7c281907fe4407db0c75883fc193eeea2e12", @"/Views/Shared/_ReceiptViewJv.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a398e6794262128d82e49352d048303a2258dff", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ReceiptViewJv : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Luna.Recruitment.VisaProcessing.Data.Models.Receipt>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Cash", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Bank", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("PaymentBankAccoutNoId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control paymentHiddenValue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("receiptCheqNo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<a class=""btn btn-primary float-right"" id=""addRowReceiptA"" style=""cursor:pointer""><i class=""fas fa-plus""></i></a>

<div class=""panel panel-primary"">
    <div class=""panel-body"">
        <table class=""table datatableHideFirstThree"" width=""100%"" id=""tableReceiptList"" style=""border:2px solid black"">
            <thead>
                <tr>
                    <th>Date</th>
                    <th>Type</th>
                    <th>Bank Account No</th>
                    <th>Date</th>
                    <th>Type</th>
                    <th>Account</th>
                    <th>Cheq #</th>
                    <th>Cheq # Date</th>
                    <th>Amount</th>
                    <th>
                        
                    </th>
                </tr>
            </thead>
            <tbody id=""tblReceiptListA"">
                <tr>
                    <td style='width:20%'>
                        <input type='date' required class='form-control' id='ReceiptDate' />
      ");
            WriteLiteral("              </td>\r\n                    <td style=\'width:20%\'>\r\n                        <select style=\'width:100%\' class=\'form-control paymentTypeB\' id=\'PaymetTypeId\'>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cecf7c281907fe4407db0c75883fc193eeea2e127258", async() => {
                WriteLiteral(" Cash");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cecf7c281907fe4407db0c75883fc193eeea2e128381", async() => {
                WriteLiteral("Bank");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</select>\r\n                    </td>\r\n                    <td style=\'width:20%\'>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cecf7c281907fe4407db0c75883fc193eeea2e129648", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 38 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_ReceiptViewJv.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BankAccoutNo);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </td>
                    <td style='width:20%'>
                        <input type='date' required class='form-control' id='ReceiptDate' />
                    </td>
                    <td style='width:20%'>
                        <select style='width:100%' class='form-control paymentTypeB' id='PaymetTypeId'>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cecf7c281907fe4407db0c75883fc193eeea2e1211906", async() => {
                WriteLiteral(" Cash");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cecf7c281907fe4407db0c75883fc193eeea2e1213030", async() => {
                WriteLiteral("Bank");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</select>
                    </td>
                    <td style='width:20%'>
                        <select id=""accountReceipt"" class='form-control'>
                        </select>
                    </td>
                    <td style='width:20%'>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cecf7c281907fe4407db0c75883fc193eeea2e1214474", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 51 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_ReceiptViewJv.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CheqNo);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </td>
                    <td style='width:20%'>
                        <input id='receiptCheqNoDate' type='date' class='form-control paymentHiddenValue' style='display:none' />
                    </td>
                    <td style='width:20%'>
                        <input type='number' id='amountId' class='form-control' value='0' />
                    </td>
                    <td>
                        <a class='removePaymentRow' style='float:right'><i class='fas fa-trash'></i></a>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</div>
<div class=""col-md-6"">
    <div class=""form-group col-md-12"">
        <button class=""btn btn-primary float-right"" id=""btnSaveReceipt"" value=""Save"">Save</button>
    </div>
</div>

<script>
    $(document).ready(function () {
        $('#btnSaveReceipt').click(function () {

            var lstReceiptAmount = [];
            var DateA = [];
            var receiptType = []");
            WriteLiteral(@";
            var CheckNoDate = [];
            var CheckNo = [];
            var Accounts = [];
            $(""#tblReceiptListA tr"").each(function () {
                var row = $(this).closest('tr');
                lstReceiptAmount.push($(row).find('#amountId').val());
                DateA.push($(row).find('#ReceiptDate').val());
                receiptType.push($(row).find('#PaymetTypeId').val());
                CheckNo.push($(row).find('#receiptCheqNo').val());
                CheckNoDate.push($(row).find('#receiptCheqNoDate').val());
                Accounts.push($(row).find('#accountReceipt').val());
            });
            var CheckNostatus = true;
            var CheckNoDateStatus = true;
            $(""#tblReceiptListA tr"").each(function () {
                var row = $(this).closest('tr');
                var receiptTypeA=$(row).find('#PaymetTypeId').val();
                var CheckNoA=$(row).find('#receiptCheqNo').val();
                var CheckNoDateA = $(row).find('#rec");
            WriteLiteral(@"eiptCheqNoDate').val();
                if (receiptTypeA == 'Bank') {
                    if (CheckNoA == '')
                    {
                        CheckNostatus = false
                    }
                }
                if (receiptTypeA == 'Bank') {
                    if (CheckNoDateA == '') {
                        CheckNoDateStatus = false;
                    }
                }

            });
            if (CheckNoDateStatus == false) {
                alert('please enter check No date');
                return false;
            }
            if (CheckNostatus == false) {
                alert('please enter check No');
                return false;
            }
            if (DateA.includes("""")) {
                alert('please enter date')
                return false;
            }
            //if (receiptType.includes(""Bank"")) {
            //    if (CheckNo.includes("""")) {
            //        alert('please enter check No');
            //        ret");
            WriteLiteral(@"urn false;
            //    }
            //}
            //if (receiptType.includes(""Bank"")) {
            //    if (CheckNoDate.includes("""")) {
            //        alert('please enter check No Date');
            //        return false;
            //    }
            //}
            if (lstReceiptAmount.includes(""0"")) {
                alert('please enter amount')
                return false;
            }
            var data = {
                ""lstReceiptAmount"": lstReceiptAmount,
                ""DateA"": DateA,
                ""receiptType"": receiptType,
                ""CheckNoDate"": CheckNoDate,
                ""CheckNo"": CheckNo,
                ""lstReceiptAmount"": lstReceiptAmount,
                ""doctype"": ""Payment Entry"", ""series"": ""ACC-PAY-.YYYY.-"", ""Payment_Type"": ""Receive"",
                ""Company"": ""LUNA CORPORATION"",
                ""Account_Paid_From"": Accounts,
                ""Account_Currency"": ""PKR"",
                ""paid_to"": ""1110 - Cash - LC"",
         ");
            WriteLiteral(@"       ""paid_to_account_currency"": ""PKR"",
                ""Exchange_Rate"": 1.0,
                ""paid_amount"": lstReceiptAmount,
                ""received_amount"": lstReceiptAmount,
                ""target_exchange_rate"": 1.0,
                ""party_type"": ""Customer"",
                ""party"": ""Luan Cust"",
                ""reference_no"": ""0832414324324""
            };
            console.log(data);
            $.ajax({
                type: ""POST"",
                url: '/Receipt/SaveReceiptA',
                data: data,
                dataType: ""json"",
                success: function (data) {
                    console.log(data);
                    if (data == true) {
                        toastr.success('Receipt added successfuly.');
                    }
                    if (data == false) {
                        toastr.error('Receipt not added successfuly.');
                    }

                },
                error: function () {
                    toastr.error");
            WriteLiteral(@"('while occured while saving passport.')
                }
            });
        });
        $('#addRowReceiptA').click(function () {
            $('#tblReceiptListA').append(""<tr><td style='width:20%'><input type='date' required class='form-control' id='ReceiptDate' /></td><td style='width:20%'><select style='width:100%' class='form-control paymentTypeB' id='PaymetTypeId'><option value = 'Cash' > Cash</option ><option value='Bank'>Bank</option></select></td><td style='width:20%'><input asp-for='CheqNo' id='receiptCheqNo' type='number'  class='form-control paymentHiddenValue' style='display:none'/></td><td style='width:20%'><input id ='receiptCheqNoDate' type = 'date' class='form-control paymentHiddenValue' style='display:none' /></td ><td style='width:20%'><input type='number' id='amountId' class='form-control' value='0' /></td><td><a class='removePaymentRow' style='float:right'><i class='fas fa-trash' ></i ></a ></td></tr>"");
        });
        $(document).on('click', '.removeReceiptRow', function");
            WriteLiteral(@" () {
            $(this).closest('tr').remove();
        });
        $(document).on('change', 'select.paymentTypeB', function () {
            var row = $(this).closest('tr');

            if ($(this).val() == ""Bank"") {
                $(row).find('.paymentHiddenValue').show();
                $(row).find('.paymentHiddenValue').show();
            }
            else {
                $(row).find('.paymentHiddenValue').hide();
                $(row).find('.paymentHiddenValue').hide();

            }
        });

        $(document).on('change', 'select.paymentTypeB', function () {
            var row = $(this).closest('tr');

            if ($(this).val() == ""Bank"") {
                $(""#accountReceipt option"").remove();
                option = '<option value=""0"">--select account</option><option value=""ABL - LC"">ABL - LC</option><option value=""ABL 0010001758350040 ZAHID LATIF - LC"">ABL 0010001758350040 ZAHID LATIF - LC</option><option value=""ABL 0010001760700090 LUNA INT. - LC"">ABL 0010");
            WriteLiteral(@"001760700090 LUNA INT. - LC</option><option value=""ABL 2284-6 - LC"">ABL 2284-6 - LC</option><option value=""ABL A/C NO.00002406-8 - LC"">ABL A/C NO.00002406-8 - LC</option><option value=""ABL0010001760700048 SHAHID LATIF - LC"">ABL0010001760700048 SHAHID LATIF - LC</option><option value=""HBL 0001307900847455 SHAHID LATIF - LC"">HBL 0001307900847455 SHAHID LATIF - LC</option><option value=""MCB 9004045991000935 ZAHID LATIF - LC"">MCB 9004045991000935 ZAHID LATIF - LC</option>'
                $('#accountReceipt').append(option);
            }
            else {
                $(""#accountReceipt option"").remove();
                option = '<option value=""0"">--select account</option><option value=""1110 - Cash - LC"">1110 - Cash - LC</option><option value=""1120 - CASH & BANK CONTRA A/C - LC"">1120 - CASH & BANK CONTRA A/C - LC</option><option value=""CASH IN HAND - LC"">CASH IN HAND - LC</option>'
                $('#accountReceipt').append(option);

            }
        });
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
