namespace FormVer2.Models.BL.ItemBL
{
    public class ItemDTO
    {
        public ItemDTO() { }
        public ItemDTO(int item_id, int item_formcomponentid, string item_alias, bool item_ispreselected, int item_displayorder)
        {
            this.Id = item_id;
            this.FormComponentId = item_formcomponentid;
            this.Alias = item_alias;
            this.IsPreSelected = item_ispreselected;
            this.DisplayOrder = item_displayorder;
        }
        public int Id { get; set; }
        public int FormId { get; set; }
        public int FormComponentId { get; set; }
        public string Alias { get; set; }
        public bool IsPreSelected { get; set; }
        public int DisplayOrder { get; set; }
    }
}
