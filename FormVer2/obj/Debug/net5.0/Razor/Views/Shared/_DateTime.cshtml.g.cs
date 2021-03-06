#pragma checksum "D:\HTC-ITC\FormCustom\FormVer2\Views\Shared\_DateTime.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0d42f3b5a92e94df9a3bf76eaa153fccd51e295"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DateTime), @"mvc.1.0.view", @"/Views/Shared/_DateTime.cshtml")]
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
#line 1 "D:\HTC-ITC\FormCustom\FormVer2\Views\_ViewImports.cshtml"
using FormVer2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HTC-ITC\FormCustom\FormVer2\Views\_ViewImports.cshtml"
using FormVer2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\HTC-ITC\FormCustom\FormVer2\Views\Shared\_DateTime.cshtml"
using FormVer2.Models.BL.PreviewBL;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0d42f3b5a92e94df9a3bf76eaa153fccd51e295", @"/Views/Shared/_DateTime.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d123aca4cdd829931954c5d770bbcb49e5e505d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__DateTime : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PreviewComponentDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\HTC-ITC\FormCustom\FormVer2\Views\Shared\_DateTime.cshtml"
  
    string str = Model.Alias;
    if (@Model.IsRequired)
    {
        str = str + "*";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"form-group\">\r\n    <label>");
#nullable restore
#line 12 "D:\HTC-ITC\FormCustom\FormVer2\Views\Shared\_DateTime.cshtml"
      Write(str);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
    <div class=""input-group date"" id=""reservationdatetime"" data-target-input=""nearest"">
        <input type=""text"" class=""form-control datetimepicker-input"" data-target=""#reservationdatetime"" />
        <div class=""input-group-append"" data-target=""#reservationdatetime"" data-toggle=""datetimepicker"">
            <div class=""input-group-text""><i class=""fa fa-calendar""></i></div>
        </div>
    </div>
</div>

<script>
    $(function () {
        //Initialize Select2 Elements
        $('.select2').select2()

        //Initialize Select2 Elements
        $('.select2bs4').select2({
            theme: 'bootstrap4'
        })

        //Datemask dd/mm/yyyy
        $('#datemask').inputmask('dd/mm/yyyy', { 'placeholder': 'dd/mm/yyyy' })
        //Datemask2 mm/dd/yyyy
        $('#datemask2').inputmask('mm/dd/yyyy', { 'placeholder': 'mm/dd/yyyy' })
        //Money Euro
        $('[data-mask]').inputmask()

        //Date picker
        $('#reservationdate').datetimepicker({
       ");
            WriteLiteral(@"     format: 'L'
        });

        //Date and time picker
        $('#reservationdatetime').datetimepicker({ icons: { time: 'far fa-clock' } });

        //Date range picker
        $('#reservation').daterangepicker()
        //Date range picker with time picker
        $('#reservationtime').daterangepicker({
            timePicker: true,
            timePickerIncrement: 30,
            locale: {
                format: 'MM/DD/YYYY hh:mm A'
            }
        })
        //Date range as a button
        $('#daterange-btn').daterangepicker(
            {
                ranges: {
                    'Today': [moment(), moment()],
                    'Yesterday': [moment().subtract(1, 'days'), moment().subtract(1, 'days')],
                    'Last 7 Days': [moment().subtract(6, 'days'), moment()],
                    'Last 30 Days': [moment().subtract(29, 'days'), moment()],
                    'This Month': [moment().startOf('month'), moment().endOf('month')],
                  ");
            WriteLiteral(@"  'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
                },
                startDate: moment().subtract(29, 'days'),
                endDate: moment()
            },
            function (start, end) {
                $('#reportrange span').html(start.format('MMMM D, YYYY') + ' - ' + end.format('MMMM D, YYYY'))
            }
        )

        //Timepicker
        $('#timepicker').datetimepicker({
            format: 'LT'
        })

        //Bootstrap Duallistbox
        $('.duallistbox').bootstrapDualListbox()

        //Colorpicker
        $('.my-colorpicker1').colorpicker()
        //color picker with addon
        $('.my-colorpicker2').colorpicker()

        $('.my-colorpicker2').on('colorpickerChange', function (event) {
            $('.my-colorpicker2 .fa-square').css('color', event.color.toString());
        })

        $(""input[data-bootstrap-switch]"").each(function () {
            $(this).bootstrapSw");
            WriteLiteral(@"itch('state', $(this).prop('checked'));
        })

    })
    // BS-Stepper Init
    document.addEventListener('DOMContentLoaded', function () {
        window.stepper = new Stepper(document.querySelector('.bs-stepper'))
    })

    // DropzoneJS Demo Code Start
    Dropzone.autoDiscover = false

    // Get the template HTML and remove it from the doumenthe template HTML and remove it from the doument
    var previewNode = document.querySelector(""#template"")
    previewNode.id = """"
    var previewTemplate = previewNode.parentNode.innerHTML
    previewNode.parentNode.removeChild(previewNode)

    var myDropzone = new Dropzone(document.body, { // Make the whole body a dropzone
        url: ""/target-url"", // Set the url
        thumbnailWidth: 80,
        thumbnailHeight: 80,
        parallelUploads: 20,
        previewTemplate: previewTemplate,
        autoQueue: false, // Make sure the files aren't queued until manually added
        previewsContainer: ""#previews"", // Define the conta");
            WriteLiteral(@"iner to display the previews
        clickable: "".fileinput-button"" // Define the element that should be used as click trigger to select files.
    })

    myDropzone.on(""addedfile"", function (file) {
        // Hookup the start button
        file.previewElement.querySelector("".start"").onclick = function () { myDropzone.enqueueFile(file) }
    })

    // Update the total progress bar
    myDropzone.on(""totaluploadprogress"", function (progress) {
        document.querySelector(""#total-progress .progress-bar"").style.width = progress + ""%""
    })

    myDropzone.on(""sending"", function (file) {
        // Show the total progress bar when upload starts
        document.querySelector(""#total-progress"").style.opacity = ""1""
        // And disable the start button
        file.previewElement.querySelector("".start"").setAttribute(""disabled"", ""disabled"")
    })

    // Hide the total progress bar when nothing's uploading anymore
    myDropzone.on(""queuecomplete"", function (progress) {
        docu");
            WriteLiteral(@"ment.querySelector(""#total-progress"").style.opacity = ""0""
    })

    // Setup the buttons for all transfers
    // The ""add files"" button doesn't need to be setup because the config
    // `clickable` has already been specified.
    document.querySelector(""#actions .start"").onclick = function () {
        myDropzone.enqueueFiles(myDropzone.getFilesWithStatus(Dropzone.ADDED))
    }
    document.querySelector(""#actions .cancel"").onclick = function () {
        myDropzone.removeAllFiles(true)
    }
  // DropzoneJS Demo Code End
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PreviewComponentDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
