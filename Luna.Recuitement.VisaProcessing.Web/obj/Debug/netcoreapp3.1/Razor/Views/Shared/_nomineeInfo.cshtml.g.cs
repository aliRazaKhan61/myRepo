#pragma checksum "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_nomineeInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "037b327693dd86086676a8a82bdc1f34c1ad1fd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__nomineeInfo), @"mvc.1.0.view", @"/Views/Shared/_nomineeInfo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"037b327693dd86086676a8a82bdc1f34c1ad1fd0", @"/Views/Shared/_nomineeInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a398e6794262128d82e49352d048303a2258dff", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__nomineeInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Luna.Recruitment.VisaProcessing.Data.Models.Nominee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "5", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmNominee"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div>
    <a href=""#!"" class=""btn btn-primary float-right"" data-toggle=""modal"" onclick=""showNominee('N', this);"">Add</a>
    <div class=""modal fade"" id=""nomineeModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""nomineeModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Nominee Detail</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "037b327693dd86086676a8a82bdc1f34c1ad1fd06113", async() => {
                WriteLiteral(@"
                        <div class=""form-group col-md-6"" style=""display:none;"">
                            <label>Id</label>
                            <input type=""hidden"" id=""nomineeId"" class=""form-control"" />
                        </div>
                        <div class=""form-row"">
                            <div class=""form-group col-md-6"">
                                <label>First Name</label>
                                <input type=""text"" id=""nomineeFirstName"" max=""25"" required class=""form-control"" />
                            </div>
                            <div class=""form-group col-md-6"">
                                <label>Last Name</label>
                                <input type=""text"" id=""nomineeLastName"" max=""25"" required class=""form-control"">
                            </div>
                        </div>
                        <div class=""form-group col-md-6"" hidden>
                            <label>Arabic Name</label>
                           ");
                WriteLiteral(@" <input type=""text"" id=""arabicName"" class=""form-control ArabicEntry"" dir=""rtl"" lang=""ar"">
                        </div>
                        <div class=""form-row"">
                            <div class=""form-group col-md-6"">
                                <label>Relationship</label>
                                <select id=""relationship"" class=""form-control"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "037b327693dd86086676a8a82bdc1f34c1ad1fd07892", async() => {
                    WriteLiteral("Spouse");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "037b327693dd86086676a8a82bdc1f34c1ad1fd09474", async() => {
                    WriteLiteral("Father");
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
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "037b327693dd86086676a8a82bdc1f34c1ad1fd010733", async() => {
                    WriteLiteral("Mother");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "037b327693dd86086676a8a82bdc1f34c1ad1fd011993", async() => {
                    WriteLiteral("Brother");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "037b327693dd86086676a8a82bdc1f34c1ad1fd013254", async() => {
                    WriteLiteral("Sister");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </select>
                            </div>
                            <div class=""form-group col-md-6"">
                                <label>Date Of Birth</label>
                                <input type=""date"" required id=""dob"" class=""form-control"" />
                            </div>
                        </div>
                        <div class=""form-row"">
                            <div class=""form-group col-md-6"">
                                <label>CNIC</label>
                                <input type=""text"" id=""cnic"" class=""form-control"" pattern=""^\d{5}-\d{7}-\d{1}$"" required autocomplete=""off"">
                            </div>
                            <div class=""form-group col-md-6"">
                                <label>Gender</label>
                                <select id=""gender"" class=""form-control"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "037b327693dd86086676a8a82bdc1f34c1ad1fd015442", async() => {
                    WriteLiteral("Male");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "037b327693dd86086676a8a82bdc1f34c1ad1fd017023", async() => {
                    WriteLiteral("Female");
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
                WriteLiteral("\r\n                                </select>\r\n                            </div>\r\n                        </div>\r\n                       \r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-success"" id=""btnSave"" onclick=""saveNominee()"">Save</button>
                </div>
                <div id=""show_stored_data"">

                </div>

            </div>
        </div>
    </div>

</div>
<table class=""table"">
    <thead>
        <tr>
            <th style=""display:none;"">Record Id (PK)</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th style=""display:none;"">Arabic Name</th>
            <th>Relationship</th>
            <th>DOB</th>
            <th>CNIC</th>
            <th></th>
        </tr>
    </thead>
    <tbody id=""nomineeDetail"">
");
#nullable restore
#line 93 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_nomineeInfo.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("id", " id=\"", 4709, "\"", 4737, 1);
#nullable restore
#line 95 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_nomineeInfo.cshtml"
WriteAttributeValue("", 4714, "nomineeRow"+item.Id, 4714, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td style=\"display:none;\">");
#nullable restore
#line 96 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_nomineeInfo.cshtml"
                                     Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 97 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_nomineeInfo.cshtml"
               Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 98 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_nomineeInfo.cshtml"
               Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"display:none;\">");
#nullable restore
#line 99 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_nomineeInfo.cshtml"
                                     Write(item.ArabicName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n\r\n                </td>\r\n                <td>");
#nullable restore
#line 103 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_nomineeInfo.cshtml"
               Write(item.Dob.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 104 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_nomineeInfo.cshtml"
               Write(item.Cnic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a href=\"#!\" id=\"showDialogNominee\"><i class=\"fas fa-edit\"></i></a>\r\n                    <a href=\"#!\" id=\"deleteNomineeRow\"><i class=\"fas fa-trash\"></i></a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 110 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\Shared\_nomineeInfo.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </tbody>
</table>

<script type=""text/javascript"">
    $(document).on(""click"", '#showDialogNominee', function () {
        var vaccineId = $(this).closest('tr').find('td').eq(0).html();
        var FirstName = $(this).closest('tr').find('td').eq(1).html();
        var LastName = $(this).closest('tr').find('td').eq(2).html();
        var ArabicName = $(this).closest('tr').find('td').eq(3).html();
        var Relationship = $(this).closest('tr').find('td').eq(4).html();
        var Dob = $(this).closest('tr').find('td').eq(5).html();
        var Cnic = $(this).closest('tr').find('td').eq(6).html();
        $(""#nomineeId"").val(vaccineId);
        $(""#nomineeFirstName"").val(FirstName)
        $(""#nomineeLastName"").val(LastName);
        $(""#arabicName"").val(ArabicName);
        $(""#arabicName"").val(Relationship);
        $(""#relationship"").val();
        document.getElementById(""dob"").valueAsDate = new Date(Dob);
        //$(""#dob"").val(Dob);
        $(""#cnic"").val(Cnic);
        $(""#ge");
            WriteLiteral(@"nder"").val(1)
        $('#nomineeModal').modal('show');
    });
    function showNominee(type, button) {
        debugger;
        if (type == ""U"") {
            $(""#nomineeId"").val($(button).closest('tr').children('td:nth(0)').text());
            $(""#nomineeFirstName"").val($(button).closest('tr').children('td:nth(1)').text());
            $(""#nomineeLastName"").val($(button).closest('tr').children('td:nth(2)').text());
            $(""#arabicName"").val($(button).closest('tr').children('td:nth(3)').text());
            $(""#relationship"").val($(button).closest('tr').children('td:nth(4)').text());
            document.getElementById(""dob"").valueAsDate = new Date($(button).closest('tr').children('td:nth(5)').text());
            $(""#cnic"").val($(button).closest('tr').children('td:nth(6)').text());
        }
        else {
            debugger;
            $(""#nomineeId"").val(0);
            $(""#nomineeFirstName"").val("""")
            $(""#nomineeLastName"").val("""");
            $(""#arabicName"").va");
            WriteLiteral(@"l("""");
            $(""#relationship"").val("""");
            $(""#dob"").val("""")
            $(""#cnic"").val("""")
            $(""#gender"").val(1)
        }
        $('#nomineeModal').modal('show');
    }
    $(document).on(""click"", '#deleteNomineeRow', function () {
        var vaccineId = $(this).closest('tr').find('td').eq(0).html();

        data = { ""id"": vaccineId };
        confirmMassage = confirm(""Are you sure to delete this Nomiee info?"")
        if (confirmMassage) {
            if (!vaccineId || vaccineId == ""0"") {
                //Remove line from table only.
                $(this).closest('tr').remove();
            }
            else {
                $.ajax({
                    type: ""POST"",
                    url: '/CandidateProfile/DeletePassport',
                    data: data,
                    dataType: ""json"",
                    success: function (data) {
                        toastr.success('Nominee info deleted.')

                    },
                 ");
            WriteLiteral(@"   error: function () {
                        toastr.error('while occured while deleting Nominee info.')
                    }
                });
            }

        }
        else {
            return false;
        }
        $(this).closest('tr').remove();
    });
    function saveNominee() {

        debugger;
        var data = {
            ""id"": $(""#nomineeId"").val(),
            ""candidateProfileId"": $('.pkid').val(),
            ""firstName"": $(""#nomineeFirstName"").val(),
            ""lastName"": $(""#nomineeLastName"").val(),
            ""arabicName"": $(""#arabicName"").val(),
            ""relationship"": $(""#relationship"").val(),
            ""dob"": $(""#dob"").val(),
            ""cnic"": $(""#cnic"").val(),
            ""gender"": $(""#gender"").val()
        };
        //if (!$(""#nomineeFirstName"").val()) {
        //    alert(""First name is mandatory."");
        //    $(""#nomineeFirstName"").setCustomValidity(""First name should contian only characters!"");
        //    return fal");
            WriteLiteral(@"se;
        //}
        //if (!$(""#nomineeLastName"").val()) {
        //    alert(""Last name is mandatory."");
        //    $(""#nomineeLastName"").setCustomValidity(""Last name should contian only characters!"");
        //    return false;
        //}
        if (!$(""#cnic"").val()) {
            alert(""CNIC is mandatory."");
            $(""#cnic"").setCustomValidity(""CNIC should be in valid format.!"");
            return false;
        }
        if (!$(""#dob"").val()) {
            alert(""Date of birth is mandatory."");
            $(""#dob"").setCustomValidity(""DOB is mandatory."");
            return false;
        }
        //if (!document.forms['frmNominee'].reportValidity()) {
        //    if ($(""#nomineeLastName"").validity.typeMismatch) {
        //        $(""#nomineeLastName"").setCustomValidity(""Last name should contian only characters!"");
        //    }
        //    return false;
        //}
        $.ajax({
            type: ""POST"",
            url: '/CandidateProfile/UpdateNominee");
            WriteLiteral(@"',
            data: data,
            dataType: ""json"",
            success: function (data) {
                toastr.success('Nominee added successfuly.')
                var html = '<tr id=""nomineeRow' + data.id + '"">' +
                    '<td style=""display:none;"">' + data.id + '</td>' +
                    '<td>' + $('#nomineeFirstName').val() + '</td>' +
                    '<td>' + $('#nomineeLastName').val() + '</td>' +
                    '<td hidden>' + $('#arabicName').val() + '</td>' +
                    '<td>' + $('#relationship').val() + '</td>' +
                    '<td>' + $('#dob').val() + '</td>' +
                    '<td>' + $('#cnic').val() + '</td>' +
                    '<td><a href=""#"" id=""showDialogNominee""><i class=""fas fa-edit""></i></a><a href=""#"" id=""deleteNomineeRow""><i class=""fas fa-trash""></i></a></td>' +
                    '</tr>';
                if ($('#nomineeId').val() == ""0"") {
                    $('#nomineeDetail').append(html);
                } el");
            WriteLiteral(@"se {
                    $(""#nomineeRow"" + $('#nomineeId').val()).children('td:nth(1)').text($('#nomineeFirstName').val());
                    $(""#nomineeRow"" + $('#nomineeId').val()).children('td:nth(2)').text($('#nomineeLastName').val());
                    $(""#nomineeRow"" + $('#nomineeId').val()).children('td:nth(3)').text($('#arabicName').val());
                    $(""#nomineeRow"" + $('#nomineeId').val()).children('td:nth(4)').text($('#relationship').val());
                    $(""#nomineeRow"" + $('#nomineeId').val()).children('td:nth(5)').text($('#dob').val());
                    $(""#nomineeRow"" + $('#nomineeId').val()).children('td:nth(6)').text($('#cnic').val());
                }
            },
            error: function () {
                toastr.error('while occured while saving nominee.')
            }
        });
        $('#nomineeModal').modal('hide');
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Luna.Recruitment.VisaProcessing.Data.Models.Nominee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
