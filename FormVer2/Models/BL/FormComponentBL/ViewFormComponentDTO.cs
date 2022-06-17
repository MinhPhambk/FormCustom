using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormVer2.Models.BL.FormComponentBL
{
    public class ViewFormComponentDTO
    {
        public int FormId { get; set; }
        public List<FormComponentDTO> ListFormComponent { get; set; }
    }
}
