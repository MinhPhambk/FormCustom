using System;
using System.Collections.Generic;

#nullable disable

namespace FormVer2.Models.DL
{
    public partial class Form
    {
        public Form()
        {
            FormComponents = new HashSet<FormComponent>();
            Items = new HashSet<Item>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public bool Published { get; set; }

        public virtual ICollection<FormComponent> FormComponents { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
