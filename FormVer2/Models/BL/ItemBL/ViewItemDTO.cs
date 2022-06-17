using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormVer2.Models.BL.ItemBL
{
    public class ViewItemDTO
    {
        public int FormId { get; set; }
        public int ComponentId { get; set; }
        public List<ItemDTO> ListItem { get; set; }
    }
}
