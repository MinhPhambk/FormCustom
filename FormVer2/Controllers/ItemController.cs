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
    public class ItemController : Controller
    {
        private readonly IItemService _itemService;
        private readonly IComponentService _componentService;

        public ItemController(IItemService itemService, IComponentService componentService)
        {
            _itemService = itemService;
            _componentService = componentService;
        }

        [HttpGet]
        public async Task<ActionResult> CreateItem(int formId, string componentId)
        {
            if ((formId < 1) && (componentId == null))
            {
                return NotFound();
            }
            ItemDTO model = new ItemDTO();
            model.FormId = formId;
            model.ComponentId = componentId;
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> IndexItem(int formId, string componentId, int displayorder)
        {
            componentId = await _componentService.ParseName(componentId);
            if ((formId < 1) && (componentId == null))
            {
                return NotFound();
            }
            List<ItemDTO> ListItem = new List<ItemDTO>();
            ListItem = await _itemService.GetItems(formId, displayorder);
            ViewListItemDTO model = new ViewListItemDTO();
            model.ListItem = ListItem;
            model.FormId = formId;
            //model.ComponentId = Int32.Parse(componentId);
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
        public async Task<IActionResult> UpdateItem([Bind("Id,FormId,ComponentId,Alias,IsPreSelected,DisplayOrder")] ItemDTO item)
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
            int formId = model.FormId;
            string componentId = model.ComponentId;
            try
            {
                await _itemService.DeleteAsync(id);
                ViewBag.Message = "Item was deleted successfully!";
            }
            catch
            {
                ViewBag.Message = "Value error!";
            }
            return RedirectToAction("IndexItem", "Item", new { @formId = formId, @componentId = componentId });
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem([Bind("FormId,ComponentId,Alias,IsPreSelected,DisplayOrder")] ItemDTO itemDTO)
        {

            int formId = itemDTO.FormId;
            string componentId = itemDTO.ComponentId;
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
            return RedirectToAction("IndexItem", "Item", new { @formId = formId, @componentId = componentId });
        }
    }
}
