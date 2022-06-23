using System.Collections.Generic;
using System.Threading.Tasks;

namespace FormVer2.Models.BL.PreviewBL
{
    public interface IPreviewService
    {
        public Task<PreviewFormDTO> GetPreview(int formId);
    }
}