#pragma checksum "C:\Users\hus\source\repos\c\c\Calendar\Calendar\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "def2874fface3db639566287ab64dd1e43950223"
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
#line 1 "C:\Users\hus\source\repos\c\c\Calendar\Calendar\Views\_ViewImports.cshtml"
using Calendar.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"def2874fface3db639566287ab64dd1e43950223", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b471b13157512f4d86806ae7e9c335d566a728f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "red", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "blue", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "black", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "green", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 1472, true);
            WriteLiteral(@"<h2>Index</h2>
<div id=""calender""></div>

<div id=""myModal"" class=""modal fade"" role=""dialog"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title""><span id=""eventTitle""></span></h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>
            <div class=""modal-body"">
                <p id=""pDetails""></p>
            </div>
            <div class=""modal-footer"">
                <button id=""btnDelete"" class=""btn btn-default btn-sm pull-right"">
                    <span class=""glyphicon glyphicon-remove""></span> Remove
                </button>
                <button id=""btnEdit"" class=""btn btn-default btn-sm pull-right"" style=""margin-right:5px;"">
                    <span class=""glyphicon glyphicon-pencil""></span> Edit
                </button>
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>");
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<div id=""myModalSave"" class=""modal fade"" role=""dialog"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Save Event</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>
            <div class=""modal-body"">
                ");
            EndContext();
            BeginContext(1472, 2592, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "def2874fface3db639566287ab64dd1e439502236694", async() => {
                BeginContext(1502, 1986, true);
                WriteLiteral(@"
                    <input type=""hidden"" id=""hdEventID"" value=""0"" />
                    <div class=""form-group"">
                        <label>Subject</label>
                        <input type=""text"" id=""txtSubject"" class=""form-control"" />
                    </div>
                    <div class=""form-group"">
                        <label>Start</label>
                        <div class=""input-group date"" id=""dtp1"">
                            <input type=""text"" id=""txtStart"" class=""form-control"" />
                            <span class=""input-group-addon"">
                                <span class=""glyphicon glyphicon-calendar""></span>
                            </span>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <div class=""checkbox"">
                            <label><input type=""checkbox"" id=""chkIsFullDay"" checked=""checked"" />  Is Full Day event</label>
                        </div>
        ");
                WriteLiteral(@"            </div>
                    <div class=""form-group"" id=""divEndDate"" style=""display:none"">
                        <label>End</label>
                        <div class=""input-group date"" id=""dtp2"">
                            <input type=""text"" id=""txtEnd"" class=""form-control"" />
                            <span class=""input-group-addon"">
                                <span class=""glyphicon glyphicon-calendar""></span>
                            </span>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label>Description</label>
                        <textarea id=""txtDescription"" rows=""3"" class=""form-control""></textarea>
                    </div>
                    <div class=""form-group"">
                        <label>Theme Color</label>
                        <select id=""ddThemeColor"" class=""form-control"">
                            ");
                EndContext();
                BeginContext(3488, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "def2874fface3db639566287ab64dd1e439502239173", async() => {
                    BeginContext(3505, 7, true);
                    WriteLiteral("Default");
                    EndContext();
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
                EndContext();
                BeginContext(3521, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(3551, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "def2874fface3db639566287ab64dd1e4395022310667", async() => {
                    BeginContext(3571, 3, true);
                    WriteLiteral("Red");
                    EndContext();
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
                EndContext();
                BeginContext(3583, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(3613, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "def2874fface3db639566287ab64dd1e4395022312158", async() => {
                    BeginContext(3634, 4, true);
                    WriteLiteral("Blue");
                    EndContext();
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
                EndContext();
                BeginContext(3647, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(3677, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "def2874fface3db639566287ab64dd1e4395022313650", async() => {
                    BeginContext(3699, 5, true);
                    WriteLiteral("Black");
                    EndContext();
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
                EndContext();
                BeginContext(3713, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(3743, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "def2874fface3db639566287ab64dd1e4395022315143", async() => {
                    BeginContext(3765, 5, true);
                    WriteLiteral("Green");
                    EndContext();
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
                EndContext();
                BeginContext(3779, 278, true);
                WriteLiteral(@"
                        </select>
                    </div>
                    <button type=""button"" id=""btnSave"" class=""btn btn-success"">Save</button>
                    <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                ");
                EndContext();
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
            EndContext();
            BeginContext(4064, 7708, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<script>
    $(document).ready(function () {
        var events = [];
        var selectedEvent = null;
        FetchEventAndRenderCalendar();

        function FetchEventAndRenderCalendar() {
            events = [];
            $.ajax({
                type: ""GET"",
                url: ""/home/GetEvents"",
                success: function (data) {
                    $.each(data, function (i, v) {
                        events.push({
                            id: v.eventID,
                            title: v.subject,
                            description: v.description,
                            start: moment(v.start),
                            end: v.end != null ? moment(v.end) : null,
                            color: v.themeColor,
                            allDay: v.isFullDay
                        });
                    })
                    GenerateCalender(events);
                },
                er");
            WriteLiteral(@"ror: function (error) {
                    alert('failed');
                }
            })
        }

        function GenerateCalender(events) {
            $('#calender').fullCalendar('destroy');
            $('#calender').fullCalendar({
                contentHeight: 400,
                defaultDate: new Date(),
                timeFormat: 'h(:mm)a',
                header: {
                    left: 'prev,next today',
                    center: 'title',
                    right: 'month,basicWeek,basicDay,agenda'
                },
                //eventLimit: true,
                eventColor: '#378006',
                events: events,
                eventClick: function (calEvent, jsEvent, view) {
                    selectedEvent = calEvent;
                    $('#myModal #eventTitle').text(calEvent.title);
                    var $description = $('<div/>');
                    $description.append($('<p/>').html('<b>Start:</b>' + calEvent.start.format(""DD-MMM-YYYY HH:mm a");
            WriteLiteral(@""")));
                    if (calEvent.end != null) {
                        $description.append($('<p/>').html('<b>End:</b>' + calEvent.end.format(""DD-MMM-YYYY HH:mm a"")));
                    }
                    $description.append($('<p/>').html('<b>Description:</b>' + calEvent.description));
                    $('#myModal #pDetails').empty().html($description);

                    $('#myModal').modal();
                },
                selectable: true,
                select: function (start, end) {
                    selectedEvent = {
                        id: 0,
                        title: '',
                        description: '',
                        start: start,
                        end: end,
                        allDay: false,
                        color: ''
                    };
                    openAddEditForm();
                    $('#calendar').fullCalendar('unselect');
                },
                editable: true,
                eve");
            WriteLiteral(@"ntDrop: function (event) {
                    var data = {
                        EventID: event.id,
                        Subject: event.title,
                        Start: event.start.format('DD/MM/YYYY HH:mm A'),
                        End: event.end != null ? event.end.format('DD/MM/YYYY HH:mm A') : null,
                        Description: event.description,
                        ThemeColor: event.color,
                        IsFullDay: event.allDay
                    };
                    SaveEvent(data);
                }
            })
        }


        $('#btnEdit').click(function () {
            //Open modal dialog for edit event
            openAddEditForm();
        })

        $('#btnDelete').click(function () {
            if (selectedEvent != null && confirm('Are you sure?')) {
                $.ajax({
                    type: ""POST"",
                    url: '/home/DeleteEvent',
                    data: { 'eventID': selectedEvent.id },
            ");
            WriteLiteral(@"        success: function (data) {
                        if (data) {
                            //Refresh the calender
                            FetchEventAndRenderCalendar();
                            $('#myModal').modal('hide');
                        }
                    },
                    error: function () {
                        alert('Failed');
                    }
                })
            }
        })

        //$('#dtp1,#dtp2').datetimepicker({
        //    format: 'DD/MM/YYYY HH:mm A'
        //});

        $('#chkIsFullDay').change(function () {
            if ($(this).is(':checked')) {
                $('#divEndDate').hide();
            }
            else {
                $('#divEndDate').show();
            }
        });

        function openAddEditForm() {
            if (selectedEvent != null) {
                $('#hdEventID').val(selectedEvent.id);
                $('#txtSubject').val(selectedEvent.title);
                $('#txtStart').");
            WriteLiteral(@"val(selectedEvent.start.format('DD/MM/YYYY HH:mm A'));
                $('#chkIsFullDay').prop(""checked"", selectedEvent.allDay || false);
                $('#chkIsFullDay').change();
                $('#txtEnd').val(selectedEvent.end != null ? selectedEvent.end.format('DD/MM/YYYY HH:mm A') : '');
                $('#txtDescription').val(selectedEvent.description);
                $('#ddThemeColor').val(selectedEvent.color);
            }
            $('#myModal').modal('hide');
            $('#myModalSave').modal();
        }

        $('#btnSave').click(function () {
            //Validation/
            if ($('#txtSubject').val().trim() == """") {
                alert('Subject required');
                return;
            }
            if ($('#txtStart').val().trim() == """") {
                alert('Start date required');
                return;
            }
            if ($('#chkIsFullDay').is(':checked') == false && $('#txtEnd').val().trim() == """") {
                alert('End date");
            WriteLiteral(@" required');
                return;
            }
            else {
                var startDate = moment($('#txtStart').val(), ""DD/MM/YYYY HH:mm A"").toDate();
                var endDate = moment($('#txtEnd').val(), ""DD/MM/YYYY HH:mm A"").toDate();
                if (startDate > endDate) {
                    alert('Invalid end date');
                    return;
                }
            }
            var data = {
                EventID: $('#hdEventID').val(),
                Subject: $('#txtSubject').val().trim(),
                Start: $('#txtStart').val().trim(),
                End: $('#chkIsFullDay').is(':checked') ? null : $('#txtEnd').val().trim(),
                Description: $('#txtDescription').val(),
                ThemeColor: $('#ddThemeColor').val(),
                IsFullDay: $('#chkIsFullDay').is(':checked')
            }
            SaveEvent(data);
            // call function for submit data to the server
        })

        function SaveEvent(data) {
    ");
            WriteLiteral(@"        $.ajax({
                type: ""POST"",
                url: '/home/SaveEvent',
                data: data,
                success: function (data) {
                    if (data) {
                        //Refresh the calender
                        FetchEventAndRenderCalendar();
                        $('#myModalSave').modal('hide');
                    }
                },
                error: function () {
                    alert('Failed');
                }
            })
        }
    })
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
