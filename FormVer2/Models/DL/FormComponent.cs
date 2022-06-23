using System;
using System.Collections.Generic;

#nullable disable

namespace FormVer2.Models.DL
{
    public partial class FormComponent
    {
        public FormComponent()
        {
            Items = new HashSet<Item>();
        }

        public int Id { get; set; }
        public int FormId { get; set; }
        public int ComponentId { get; set; }
        public string TextPrompt { get; set; }
        public bool IsRequired { get; set; }
        public int DisplayOrder { get; set; }

        public virtual Form Form { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
