using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormVer2.Models.BL.FormComponentBL
{
    public class ViewListFormComponentDTO
    {
        public int FormId { get; set; }
        public string FormName { get; set; }
        public List<ViewFormComponentDTO> ListFormComponent { get; set; }
    }
}
