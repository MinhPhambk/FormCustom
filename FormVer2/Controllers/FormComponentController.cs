using FormVer2.Models.BL.FormComponentBL;
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
    public class FormComponentController : Controller
    {
        private readonly IFormComponentService _formComponentService;

        public FormComponentController(IFormComponentService formComponentService)
        {
            _formComponentService = formComponentService;
        }

        [HttpGet]
        public async Task<ActionResult> CreateFormComponent(int formId)
        {
            if (formId < 1)
            {
                return NotFound();
            }
            FormComponentDTO model = new FormComponentDTO();
            model.FormId = formId;
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> IndexFormComponent(int formId)
        {
            if (formId < 1) 
            {
                return NotFound();
            }
            List<FormComponentDTO> ListFormComponent = new List<FormComponentDTO>();
            ListFormComponent = await _formComponentService.GetFormComponents(formId);
            ViewFormComponentDTO model = new ViewFormComponentDTO();
            model.ListFormComponent = ListFormComponent;
            model.FormId = formId;
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateFormComponent(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            FormComponentDTO formComponentDTO;
            formComponentDTO = await _formComponentService.FindbyId(id);
            return View(formComponentDTO);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteFormComponent(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            FormComponentDTO formComponentDTO;
            formComponentDTO = await _formComponentService.FindbyId(id);
            return View(formComponentDTO);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateFormComponent([Bind("Id,FormId,ComponentId,TextPrompt,IsRequired,DisplayOrder")] FormComponentDTO formComponent)
        {
            try
            {
                await _formComponentService.UpdateAsync(formComponent);
                ViewBag.Message = "Form's component was updated successfully!";
                return View(formComponent);
            }
            catch
            {
                ViewBag.Message = "Value error!";
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed([Bind("Id")] int id)
        {
            FormComponentDTO model = await _formComponentService.FindbyId(id);
            int formId = model.FormId;
            try
            {
                await _formComponentService.DeleteAsync(id);
                ViewBag.Message = "Form's component was deleted successfully!";
            }
            catch
            {
                ViewBag.Message = "Value error!";
            }
            return RedirectToAction("IndexFormComponent", "FormComponent", new { @formId = formId });
        }

        [HttpPost]
        public async Task<IActionResult> CreateFormComponent([Bind("FormId,ComponentId,TextPrompt,IsRequired,DisplayOrder")] FormComponentDTO formComponentDTO)
        {
            
            int formId = formComponentDTO.FormId;
            try
            {
                FormComponentDTO formComponentCheck = new FormComponentDTO();
                formComponentCheck = await _formComponentService.FindbyId(formComponentDTO.Id);
                if (formComponentCheck.Id < 1)
                {
                    await _formComponentService.CreateAsync(formComponentDTO);
                }
                ViewBag.Message = "Form's component was created successfully!";
            }
            catch
            {
                ViewBag.Message = "Value error!";
            }
            return RedirectToAction("IndexFormComponent", "FormComponent", new { @formId = formId });
        }
    }
}
