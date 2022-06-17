using FormVer2.Models.DL;
using FormVer2.Models.BL.FormComponentBL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormVer2.Models.BL.FormComponentBL
{
    internal class FormComponentService : IFormComponentService
    {

        private readonly AppDBContext dbContext;

        public FormComponentService(AppDBContext appDbContext)
        {
            dbContext = appDbContext;
        }

        public async Task<string> CreateAsync(FormComponentDTO formComponent)
        {

            string re = "done";
            try
            {
                FormComponent formComponentModel = new FormComponent();
                formComponentModel.Id = formComponent.Id;
                formComponentModel.FormId = formComponent.FormId;
                formComponentModel.ComponentId = formComponent.ComponentId;
                formComponentModel.TextPrompt = formComponent.TextPrompt;
                formComponentModel.IsRequired = formComponent.IsRequired;
                formComponentModel.DisplayOrder = formComponent.DisplayOrder;
                dbContext.FormComponents.Add(formComponentModel);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }

        public async Task<string> UpdateAsync(FormComponentDTO formComponent)
        {
            string re = "done";
            try
            {
                FormComponent formComponentModel = new FormComponent();
                formComponentModel.Id = formComponent.Id;
                formComponentModel.FormId = formComponent.FormId;
                formComponentModel.ComponentId = formComponent.ComponentId;
                formComponentModel.TextPrompt = formComponent.TextPrompt;
                formComponentModel.IsRequired = formComponent.IsRequired;
                formComponentModel.DisplayOrder = formComponent.DisplayOrder;
                dbContext.FormComponents.Update(formComponentModel);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }
        public async Task<string> DeleteAsync(int formComponentId)
        {
            string re = "done";
            try
            {
                var formComponentTmp = await dbContext.FormComponents.FindAsync(formComponentId);
                dbContext.FormComponents.Remove(formComponentTmp);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }
        public async Task<FormComponentDTO> FindbyId(int formComponentId)
        {
            FormComponent formComponentModel = new FormComponent();
            formComponentModel = await dbContext.FormComponents.FirstOrDefaultAsync(m => m.Id == formComponentId);
            FormComponentDTO formComponentDTO = new FormComponentDTO();
            if (formComponentModel != null)
            {
                formComponentDTO = new FormComponentDTO(formComponentModel.Id, formComponentModel.FormId, formComponentModel.ComponentId, formComponentModel.TextPrompt, formComponentModel.IsRequired, formComponentModel.DisplayOrder);
            }
            return formComponentDTO;
        }
        public async Task<List<FormComponentDTO>> GetFormComponents(int formId)
        {
            List<FormComponent> lst = await dbContext.FormComponents.ToListAsync();
            List<FormComponentDTO> lstDTO = new List<FormComponentDTO>();

            if (lst != null)
            {
                foreach (FormComponent formComponent in lst)
                {
                    if (formComponent.FormId == formId)
                        lstDTO.Add(new FormComponentDTO(formComponent.Id, formComponent.FormId, formComponent.ComponentId, formComponent.TextPrompt, formComponent.IsRequired, formComponent.DisplayOrder));
                }
            }

            return lstDTO;
        }
    }
}
