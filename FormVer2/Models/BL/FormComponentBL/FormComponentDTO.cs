namespace FormVer2.Models.BL.FormComponentBL
{
    public class FormComponentDTO
    {
        public FormComponentDTO() { }
        public FormComponentDTO(int formco_id, int formco_formid, int formco_componentid, string formco_textprompt, bool formco_isrequired, int formco_displayorder)
        {
            this.Id = formco_id;
            this.FormId = formco_formid;
            this.ComponentId = formco_componentid;
            this.TextPrompt = formco_textprompt;
            this.IsRequired = formco_isrequired;
            this.DisplayOrder = formco_displayorder;
        }
        public int Id { get; set; }
        public int FormId { get; set; }
        public int ComponentId { get; set; }
        public string TextPrompt { get; set; }
        public bool IsRequired { get; set; }
        public int DisplayOrder { get; set; }
    }
}
