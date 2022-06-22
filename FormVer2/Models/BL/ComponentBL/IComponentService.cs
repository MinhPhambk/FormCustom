using System.Collections.Generic;
using System.Threading.Tasks;

namespace FormVer2.Models.BL.ComponentBL
{
    public interface IComponentService
    {
        public Task<string> ParseId(string Id);
        public Task<string> ParseName(string Name);
        public Task<bool> GetBoolContain(string Id);
        public Task<List<ComponentDTO>> GetListComponents();
    }
}