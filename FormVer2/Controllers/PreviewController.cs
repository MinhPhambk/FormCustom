using FormVer2.Models.BL.PreviewBL;
using FormVer2.Models.BL.ComponentBL;
using FormVer2.Models.DL;
using FormVer2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace FormVer2.Controllers
{
    public class PreviewController : Controller
    {
        private readonly IPreviewService _previewService;
        private readonly IComponentService _componentService;

        public PreviewController(IPreviewService previewService, IComponentService componentService)
        {
            _previewService = previewService;
            _componentService = componentService;
        }

        [HttpGet]
        public async Task<ActionResult> IndexPreview(int formId)
        {
            if (formId < 1)
            {
                return NotFound();
            }
            PreviewFormDTO previewFormDTO = new PreviewFormDTO();
            previewFormDTO = await _previewService.GetPreviews(formId);
            foreach (var c in previewFormDTO.ListComponent)
            {
                c.ContainValue = await _componentService.GetBoolContain(c.Name);
                c.Name = await _componentService.ParseId(c.Name);
            }
            return View(previewFormDTO);
        }
    }
}
