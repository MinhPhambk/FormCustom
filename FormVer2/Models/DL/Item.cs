using System;
using System.Collections.Generic;

#nullable disable

namespace FormVer2.Models.DL
{
    public partial class Item
    {
        public int Id { get; set; }
        public int FormComponentId { get; set; }
        public string Alias { get; set; }
        public bool IsPreSelected { get; set; }
        public int DisplayOrder { get; set; }

        public virtual FormComponent FormComponent { get; set; }
    }
}
