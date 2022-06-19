using System.Collections.Generic;
using System.Threading.Tasks;

namespace FormVer2.Models.BL.FormComponentBL
{
    public interface IFormComponentService
    {
        public Task<List<FormComponentDTO>> GetList();
        public Task<List<FormComponentDTO>> GetFormComponents(int formId);
        public Task<FormComponentDTO> FindbyId(int formComponentId);
        public Task<string> DeleteAsync(int formComponentId);
        public Task<string> CreateAsync(FormComponentDTO formComponent);
        public Task<string> UpdateAsync(FormComponentDTO formComponent);
    }
}