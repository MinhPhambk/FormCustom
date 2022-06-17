using FormVer2.Models.DL;
using FormVer2.Models.BL.FormBL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormVer2.Models.BL.FormBL
{
    internal class FormService : IFormService
    {

        private readonly AppDBContext dbContext;

        public FormService(AppDBContext appDbContext)
        {
            dbContext = appDbContext;
        }

        public async Task<string> CreateAsync(FormDTO form)
        {

            string re = "done";
            try
            {
                Form formModel = new Form();
                formModel.Id = form.Id;
                formModel.Title = form.Title;
                formModel.ShortDescription = form.ShortDescription;
                formModel.Width = form.Width;
                formModel.Height = form.Height;
                formModel.Published = form.Published;
                dbContext.Forms.Add(formModel);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }

        public async Task<string> UpdateAsync(FormDTO form)
        {
            string re = "done";
            try
            {
                Form formModel = new Form();
                formModel.Id = form.Id;
                formModel.Title = form.Title;
                formModel.ShortDescription = form.ShortDescription;
                formModel.Width = form.Width;
                formModel.Height = form.Height;
                formModel.Published = form.Published;
                dbContext.Forms.Update(formModel);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }
        public async Task<string> DeleteAsync(int formId)
        {
            string re = "done";
            try
            {
                var formTmp = await dbContext.Forms.FindAsync(formId);

                List<FormComponent> ListComponent = new List<FormComponent>();
                ListComponent = await dbContext.FormComponents.ToListAsync();
                foreach (var c in ListComponent)
                {
                    if (c.FormId == formId) 
                        dbContext.FormComponents.Remove(c);
                }

                List<Item> ListItem = new List<Item>();
                ListItem = await dbContext.Items.ToListAsync();
                foreach (var i in ListItem)
                {
                    if (i.FormId == formId)
                        dbContext.Items.Remove(i);
                }

                dbContext.Forms.Remove(formTmp);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                re = ex.Message;
            }
            return re;
        }
        public async Task<FormDTO> FindbyId(int formId)
        {
            Form formModel = new Form();
            formModel = await dbContext.Forms.FirstOrDefaultAsync(m => m.Id == formId);
            FormDTO formDTO = new FormDTO();
            if (formModel != null)
            {
                formDTO = new FormDTO(formModel.Id, formModel.Title, formModel.ShortDescription, formModel.Width, formModel.Height, formModel.Published);
            }
            return formDTO;
        }
        public async Task<List<FormDTO>> GetForms()
        {
            List<Form> lst = await dbContext.Forms.ToListAsync();
            List<FormDTO> lstDTO = new List<FormDTO>();

            if (lst != null)
            {
                foreach (Form form in lst)
                {
                    lstDTO.Add(new FormDTO(form.Id, form.Title, form.ShortDescription, form.Width, form.Height, form.Published));
                }
            }
                
            return lstDTO;
        }
    }
}
