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
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }

        public virtual ICollection<FormComponent> FormComponents { get; set; }
    }
}
