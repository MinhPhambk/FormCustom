using System.Collections.Generic;
using System.Threading.Tasks;

namespace FormVer2.Models.BL.FormBL
{
    public interface IFormService
    {
        public Task<List<FormDTO>> GetForms();
        public Task<FormDTO> FindbyId(int formId);
        public Task<string> DeleteAsync(int formId);
        public Task<string> CreateAsync(FormDTO form);
        public Task<string> UpdateAsync(FormDTO form);
    }
}