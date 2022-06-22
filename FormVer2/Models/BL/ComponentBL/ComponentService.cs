using Microsoft.EntityFrameworkCore;
using System;
using FormVer2.Models.DL;
using FormVer2.Models.BL.ComponentBL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormVer2.Models.BL.ComponentBL
{
    internal class ComponentService : IComponentService
    {
        private readonly AppDBContext dbContext;

        public ComponentService(AppDBContext appDbContext)
        {
            dbContext = appDbContext;
        }

        public async Task<string> ParseId(string Id)
        {
            string Name = "Not found!";
            List<ComponentDTO> lst = await GetListComponents();
            foreach (var c in lst)
            {
                if (c.Id == Id)
                {
                    Name = c.Name;
                    break;
                }
            }
            return Name;
        }
        public async Task<string> ParseName(string Name)
        {
            string Id = "Not found!";
            List<ComponentDTO> lst = await GetListComponents();
            foreach (var c in lst)
            {
                if (c.Name == Name)
                {
                    Id = c.Id;
                    break;
                }
            }
            return Id;
        }
        public async Task<bool> GetBoolContain(string Id)
        {
            bool value = true;
            List<ComponentDTO> lst = await GetListComponents();
            foreach (var c in lst)
            {
                if (c.Id == Id)
                {
                    value = c.ContainValue;
                    break;
                }
            }
            return value;
        }
        public async Task<List<ComponentDTO>> GetListComponents()
        {
            List<Component> lst = await dbContext.Components.ToListAsync();
            List<ComponentDTO> lstDTO = new List<ComponentDTO>();

            if (lst != null)
            {
                foreach (Component co in lst)
                {
                    lstDTO.Add(new ComponentDTO(co.Id.ToString(), co.Name, co.ContainValue));
                }
            }

            return lstDTO;
        }
    }
}
