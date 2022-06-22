using System;
using System.Collections.Generic;
using System.Linq;

namespace FormVer2.Models.BL.FormComponentBL
{
    public class ViewFormComponentDTO
    {
        public ViewFormComponentDTO() { }
        public ViewFormComponentDTO(FormComponentDTO formco, int num)
        {
            this.FormComponent = formco;
            this.NumOfItem = num;
        }
        public FormComponentDTO FormComponent { get; set; }
        public int NumOfItem { get; set; }
    }
}
