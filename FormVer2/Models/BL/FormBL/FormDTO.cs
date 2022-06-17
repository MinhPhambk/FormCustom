namespace FormVer2.Models.BL.FormBL
{
    public class FormDTO
    {
        public FormDTO() { }
        public FormDTO(int form_id, string form_title, string form_description, decimal form_width, decimal form_height, bool form_publishd)
        {
            this.Id = form_id;
            this.Title = form_title;
            this.ShortDescription = form_description;
            this.Width = form_width;
            this.Height = form_height;
            this.Published = form_publishd;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public bool Published { get; set; }
    }
}
