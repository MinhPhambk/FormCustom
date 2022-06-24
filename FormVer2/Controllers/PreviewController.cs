using FormVer2.Models.BL.PreviewBL;
using FormVer2.Models.BL.ItemBL;
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
            previewFormDTO = await _previewService.GetPreview(formId);
            foreach (var c in previewFormDTO.ListComponent)
            {
                c.ContainValue = await _componentService.GetBoolContain(c.Name);
                c.Name = await _componentService.ParseId(c.Name);
            }

            // Sort list components
            if (previewFormDTO.ListComponent != null)
            {
                int n = previewFormDTO.ListComponent.Count();
                PreviewComponentDTO preCo = new PreviewComponentDTO();
                for (int i = 0; i < n; i++)
                {
                    for (int j = i; j < n; j++)
                    {
                        if (previewFormDTO.ListComponent[i].DisplayOrder > previewFormDTO.ListComponent[j].DisplayOrder)
                        {
                            preCo = previewFormDTO.ListComponent[i];
                            previewFormDTO.ListComponent[i] = previewFormDTO.ListComponent[j];
                            previewFormDTO.ListComponent[j] = preCo;
                        }
                    }
                }
            }

            // Sort list items
            foreach (var c in previewFormDTO.ListComponent)
            {
                if (c.ListItem != null)
                {
                    int m = c.ListItem.Count();
                    ItemDTO preCo = new ItemDTO();
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = i; j < m; j++)
                        {
                            if (c.ListItem[i].DisplayOrder > c.ListItem[j].DisplayOrder)
                            {
                                preCo = c.ListItem[i];
                                c.ListItem[i] = c.ListItem[j];
                                c.ListItem[j] = preCo;
                            }
                        }
                    }
                }
            }



            return View(previewFormDTO);
        }
    }
}
