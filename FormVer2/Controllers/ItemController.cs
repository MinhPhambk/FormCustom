using FormVer2.Models.BL.ItemBL;
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
    public class ItemController : Controller
    {
        private readonly IItemService _itemService;
        private readonly IFormService _formService;
        private readonly IComponentService _componentService;
        private readonly IFormComponentService _formComponentService;

        public ItemController(IItemService itemService, IComponentService componentService, IFormComponentService formComponentService, IFormService formService)
        {
            _formService = formService;
            _itemService = itemService;
            _componentService = componentService;
            _formComponentService = formComponentService;
        }

        [HttpGet]
        public async Task<ActionResult> CreateItem(int formcomponentId)
        {
            List<string> lstCoView = new List<string>();
            List<ComponentDTO> ListCo = await _componentService.GetListComponents();
            foreach (var co in ListCo)
            {
                lstCoView.Add(co.Name);
            }
            ViewBag.ListCo = lstCoView;

            if (formcomponentId < 1)
            {
                return NotFound();
            }


            FormComponentDTO foco = new FormComponentDTO();
            foco = await _formComponentService.FindbyId(formcomponentId);
            ItemDTO model = new ItemDTO();
            model.FormComponentId = foco.Id;
            model.FormId = foco.FormId;
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> IndexItem(int formcomponentId)
        {
            if (formcomponentId < 1)
            {
                return NotFound();
            }
            List<ItemDTO> ListItem = new List<ItemDTO>();
            ListItem = await _itemService.GetItems(formcomponentId);
            FormComponentDTO foco = new FormComponentDTO();
            foco = await _formComponentService.FindbyId(formcomponentId);
            FormDTO form = new FormDTO();
            form = await _formService.FindbyId(foco.FormId);
            ViewListItemDTO model = new ViewListItemDTO();
            model.ListItem = ListItem;
            model.FormId = foco.FormId;
            model.FormComponentId = formcomponentId;
            model.ComponentName = await _componentService.ParseId(foco.ComponentId);
            model.FormName = form.Title;
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateItem(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            ItemDTO itemDTO;
            itemDTO = await _itemService.FindbyId(id);
            return View(itemDTO);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteItem(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            ItemDTO itemDTO;
            itemDTO = await _itemService.FindbyId(id);
            return View(itemDTO);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateItem([Bind("Id,FormComponentId,Alias,IsPreSelected,DisplayOrder")] ItemDTO item)
        {
            try
            {
                await _itemService.UpdateAsync(item);
                ViewBag.Message = "Item was updated successfully!";
                return View(item);
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
            ItemDTO model = await _itemService.FindbyId(id);
            try
            {
                await _itemService.DeleteAsync(id);
                ViewBag.Message = "Item was deleted successfully!";
            }
            catch
            {
                ViewBag.Message = "Value error!";
            }
            return RedirectToAction("IndexItem", "Item", new { @formcomponentId = model.FormComponentId });
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem([Bind("FormComponentId,Alias,IsPreSelected,DisplayOrder")] ItemDTO itemDTO)
        {
            List<string> lstCoView = new List<string>();
            List<ComponentDTO> ListCo = await _componentService.GetListComponents();
            foreach (var co in ListCo)
            {
                lstCoView.Add(co.Name);
            }
            ViewBag.ListCo = lstCoView;
            //
            try
            {
                ItemDTO itemCheck = new ItemDTO();
                itemCheck = await _itemService.FindbyId(itemDTO.Id);
                if (itemCheck.Id < 1)
                {
                    await _itemService.CreateAsync(itemDTO);
                }
                ViewBag.Message = "Item was created successfully!";
            }
            catch
            {
                ViewBag.Message = "Value error!";
            }
            return RedirectToAction("IndexItem", "Item", new { @formcomponentId = itemDTO.FormComponentId });
        }
    }
}
