using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormVer2.Models.BL.ItemBL
{
    public class ViewListItemDTO
    {
        public int FormId { get; set; }
        public int FormComponentId { get; set; }
        public string FormName { get; set; }
        public string ComponentName { get; set; }
        public List<ItemDTO> ListItem { get; set; }
    }
}
