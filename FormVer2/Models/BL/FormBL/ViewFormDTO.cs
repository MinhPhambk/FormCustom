using System;
using System.Collections.Generic;
using System.Linq;

namespace FormVer2.Models.BL.FormBL
{
    public class ViewFormDTO
    {
        public ViewFormDTO() { }
        public ViewFormDTO(FormDTO form, int num)
        {
            this.Form = form;
            this.NumOfCo = num;
        }
        public FormDTO Form { get; set; }
        public int NumOfCo { get; set; }
    }
}
