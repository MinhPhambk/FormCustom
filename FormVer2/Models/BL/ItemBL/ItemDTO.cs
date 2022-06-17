namespace FormVer2.Models.BL.ItemBL
{
    public class ItemDTO
    {
        public ItemDTO() { }
        public ItemDTO(int item_id, int item_formid, int item_componentid, string item_alias, bool item_ispreselected, int item_displayorder)
        {
            this.Id = item_id;
            this.FormId = item_formid;
            this.ComponentId = item_componentid;
            this.Alias = item_alias;
            this.IsPreSelected = item_ispreselected;
            this.DisplayOrder = item_displayorder;
        }
        public int Id { get; set; }
        public int FormId { get; set; }
        public int ComponentId { get; set; }
        public string Alias { get; set; }
        public bool IsPreSelected { get; set; }
        public int DisplayOrder { get; set; }
    }
}
