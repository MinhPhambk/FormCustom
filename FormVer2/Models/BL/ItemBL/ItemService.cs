using FormVer2.Models.DL;
using FormVer2.Models.BL.ItemBL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormVer2.Models.BL.ItemBL
{
    internal class ItemService : IItemService
    {

        private readonly AppDBContext dbContext;

        public ItemService(AppDBContext appDbContext)
        {
            dbContext = appDbContext;
        }

        public async Task<string> CreateAsync(ItemDTO item)
        {

            string re = "done";
            try
            {
                Item itemModel = new Item();
                itemModel.Id = item.Id;
                itemModel.FormComponentId = item.FormComponentId;
                itemModel.Alias = item.Alias;
                itemModel.IsPreSelected = item.IsPreSelected;
                itemModel.DisplayOrder = item.DisplayOrder;
                dbContext.Items.Add(itemModel);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }

        public async Task<string> UpdateAsync(ItemDTO item)
        {
            string re = "done";
            try
            {
                Item itemModel = new Item();
                itemModel.Id = item.Id;
                itemModel.FormComponentId = item.FormComponentId;
                itemModel.Alias = item.Alias;
                itemModel.IsPreSelected = item.IsPreSelected;
                itemModel.DisplayOrder = item.DisplayOrder;
                dbContext.Items.Update(itemModel);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }
        public async Task<string> DeleteAsync(int itemId)
        {
            string re = "done";
            try
            {
                var itemTmp = await dbContext.Items.FindAsync(itemId);
                dbContext.Items.Remove(itemTmp);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }
        public async Task<ItemDTO> FindbyId(int itemId)
        {
            Item itemModel = new Item();
            itemModel = await dbContext.Items.FirstOrDefaultAsync(m => m.Id == itemId);
            ItemDTO itemDTO = new ItemDTO();
            if (itemModel != null)
            {
                itemDTO = new ItemDTO(itemModel.Id, itemModel.FormComponentId, itemModel.Alias, itemModel.IsPreSelected, itemModel.DisplayOrder);
            }
            return itemDTO;
        }
        public async Task<List<ItemDTO>> GetItems(int formcomponentId)
        {
            List<Item> lst = await dbContext.Items.ToListAsync();
            List<ItemDTO> lstDTO = new List<ItemDTO>();

            if (lst != null)
            {
                foreach (Item item in lst)
                {
                    if (item.FormComponentId == formcomponentId)
                        lstDTO.Add(new ItemDTO(item.Id, item.FormComponentId, item.Alias, item.IsPreSelected, item.DisplayOrder));
                }
            }

            return lstDTO;
        }
    }
}
