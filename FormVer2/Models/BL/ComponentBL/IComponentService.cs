using System.Collections.Generic;
using System.Threading.Tasks;

namespace FormVer2.Models.BL.ComponentBL
{
    public interface IComponentService
    {
        public Task<string> ParseId(int Id);
        public Task<bool> GetBoolContain(int Id);
        public Task<List<ComponentDTO>> GetListComponents();
    }
}