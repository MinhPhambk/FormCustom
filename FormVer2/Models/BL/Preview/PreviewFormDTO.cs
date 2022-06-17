using System;
using System.Collections.Generic;
using System.Linq;
using FormVer2.Models.BL.PreviewBL;

namespace FormVer2.Models.BL.PreviewBL
{
    public class PreviewFormDTO
    {
        public PreviewFormDTO() { }
        public PreviewFormDTO(int id, string title, string descrpition, decimal width, decimal height, bool published, List<PreviewComponentDTO> lstcomponent)
        {
            this.Id = id;
            this.Title = title;
            this.ShortDescription = descrpition;
            this.Width = width;
            this.Height = height;
            this.Published = published;
            this.ListComponent = lstcomponent;

        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public bool Published { get; set; }
        public List<PreviewComponentDTO> ListComponent { get; set; }
    }
}
