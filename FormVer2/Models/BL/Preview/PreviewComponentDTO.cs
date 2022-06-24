using System;
using System.Collections.Generic;
using System.Linq;
using FormVer2.Models.BL.ItemBL;

namespace FormVer2.Models.BL.PreviewBL
{
    public class PreviewComponentDTO
    {
        public PreviewComponentDTO() { }
        public PreviewComponentDTO(int co_displayorder, string co_name, bool required , string co_alias, bool co_value, List<ItemDTO> co_lstitem)
        {
            this.DisplayOrder = co_displayorder;
            this.Name = co_name;
            this.IsRequired = required;
            this.Alias = co_alias;
            this.ContainValue = co_value;
            this.ListItem = co_lstitem;
        }
        public int DisplayOrder { get; set; }
        public string Name { get; set; }
        public bool IsRequired { get; set; }
        public string Alias { get; set; }
        public bool ContainValue { get; set; }
        public List<ItemDTO> ListItem { get; set; }
    }
}
