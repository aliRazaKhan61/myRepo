#pragma checksum "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d51d35d4c8af795d89f36d1dbc69cb2651ec32a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JobPO_Delete), @"mvc.1.0.view", @"/Views/JobPO/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d51d35d4c8af795d89f36d1dbc69cb2651ec32a4", @"/Views/JobPO/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a398e6794262128d82e49352d048303a2258dff", @"/Views/_ViewImports.cshtml")]
    public class Views_JobPO_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Luna.Recruitment.VisaProcessing.Data.Models.OepvisaDemandPodetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>OepvisaDemandDetail</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MinSalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MinSalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaxSalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaxSalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DurationYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DurationYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n     \r\n     \r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IsAccommodation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IsAccommodation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 47 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AccommodationDetail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AccommodationDetail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 53 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IsMedical));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 56 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IsMedical));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 59 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MedicalDetail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 62 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MedicalDetail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 65 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IsTransport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 68 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IsTransport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 71 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TransportDetail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 74 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TransportDetail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 77 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IsAirTicket));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 80 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IsAirTicket));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 83 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AirTicketDetail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 86 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AirTicketDetail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 89 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IsOverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 92 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IsOverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 95 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OverTimeDetail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 98 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OverTimeDetail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 101 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IsOthers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 104 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IsOthers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 107 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OthersDetail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 110 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OthersDetail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 113 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 116 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayFor(model => model.City.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 119 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 122 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Country.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 125 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.JobTypeEntitySetup));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 128 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayFor(model => model.JobTypeEntitySetup.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 131 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OepvisaDemandPo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 134 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OepvisaDemandPo.BatchNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 137 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 140 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
       Write(Html.DisplayFor(model => model.State.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d51d35d4c8af795d89f36d1dbc69cb2651ec32a419517", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d51d35d4c8af795d89f36d1dbc69cb2651ec32a419784", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 145 "D:\LUNA\Luna20Aug2023\LUNA PROD\Code\Luna.Recuitement.VisaProcessing.Web\Views\JobPO\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d51d35d4c8af795d89f36d1dbc69cb2651ec32a421591", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Luna.Recruitment.VisaProcessing.Data.Models.OepvisaDemandPodetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
