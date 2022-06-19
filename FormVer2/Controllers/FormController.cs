using FormVer2.Models.BL.FormBL;
using FormVer2.Models.BL.ComponentBL;
using FormVer2.Models.BL.FormComponentBL;
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
    public class FormController : Controller
    {
        private readonly IFormService _formService;
        private readonly IFormComponentService _formComponentService;

        public FormController(IFormService formService, IFormComponentService formComponentService)
        {
            _formService = formService;
            _formComponentService = formComponentService;
        }

        [HttpGet]
        public async Task<ActionResult> CreateForm()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> IndexForm()
        {
            List<FormDTO> ListForm = await _formService.GetForms();
            List<FormComponentDTO> ListFormCo = await _formComponentService.GetList();
            List<ViewFormDTO> model = new List<ViewFormDTO>();
            foreach(var f in ListForm)
            {
                ViewFormDTO view = new ViewFormDTO();
                view.Form = f;
                int num = 0;
                foreach(var fc in ListFormCo)
                {
                    if (fc.FormId == f.Id) num++;
                }
                view.NumOfCo = num;
                model.Add(view);
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateForm(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            FormDTO formDTO;
            formDTO = await _formService.FindbyId(id);
            return View(formDTO);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteForm(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            FormDTO formDTO;
            formDTO = await _formService.FindbyId(id);
            return View(formDTO);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateForm([Bind("Id,Title,ShortDescription,Width,Height")] FormDTO form)
        {
            try
            {
                await _formService.UpdateAsync(form);
                ViewBag.Message = "Form was updated successfully!";
                return View(form);
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
            try
            {
                await _formService.DeleteAsync(id);
                ViewBag.Message = "Form was deleted successfully!";
            }
            catch
            {
                ViewBag.Message = "Value error!";
            }

            return RedirectToAction("IndexForm");
        }

        [HttpPost]
        public async Task<IActionResult> CreateForm([Bind("Title,ShortDescription,Width,Height,Published")] FormDTO formDTO)
        {
            try
            {
                FormDTO formCheck = new FormDTO();
                formCheck = await _formService.FindbyId(formDTO.Id);
                if (formCheck.Id < 1)
                {
                    await _formService.CreateAsync(formDTO);
                }
                ViewBag.Message = "Form was created successfully!";
                return RedirectToAction("IndexForm");
            }
            catch
            {
                ViewBag.Message = "Value error!";
                return View();
            }
        }
    }
}
