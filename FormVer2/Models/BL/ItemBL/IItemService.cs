using System.Collections.Generic;
using System.Threading.Tasks;

namespace FormVer2.Models.BL.ItemBL
{
    public interface IItemService
    {
        public Task<List<ItemDTO>> GetItems(int formId, int displayOrder);
        public Task<ItemDTO> FindbyId(int itemId);
        public Task<string> DeleteAsync(int itemId);
        public Task<string> CreateAsync(ItemDTO item);
        public Task<string> UpdateAsync(ItemDTO item);
    }
}