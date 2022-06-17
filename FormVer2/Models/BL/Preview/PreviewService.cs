using FormVer2.Models.DL;
using FormVer2.Models.BL.FormBL;
using FormVer2.Models.BL.ItemBL;
using FormVer2.Models.BL.PreviewBL;
using FormVer2.Models.BL.FormComponentBL;
using FormVer2.Models.BL.ComponentBL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormVer2.Models.BL.PreviewBL
{
    internal class PreviewService : IPreviewService
    {

        private readonly AppDBContext dbContext;

        public PreviewService(AppDBContext appDbContext)
        {
            dbContext = appDbContext;
        }

        public async Task<PreviewFormDTO> GetPreviews(int formId)
        {
            PreviewFormDTO formPreview = new PreviewFormDTO();

            Form form = await dbContext.Forms.FirstOrDefaultAsync(m => m.Id == formId);
            formPreview.Id = form.Id;
            formPreview.Title = form.Title;
            formPreview.ShortDescription = form.ShortDescription;
            formPreview.Width = form.Width;
            formPreview.Height = form.Height;
            formPreview.Published = form.Published;
            formPreview.ListComponent = new List<PreviewComponentDTO>();

            List<Item> lstItem = new List<Item>();
            lstItem = await dbContext.Items.ToListAsync();
            List<FormComponent> lstComponent = new List<FormComponent>();
            lstComponent = await dbContext.FormComponents.ToListAsync();
            foreach(var c in lstComponent)
            {
                if (c.FormId == formId)
                {
                    PreviewComponentDTO pr = new PreviewComponentDTO();
                    pr.DisplayOrder = c.DisplayOrder;
                    pr.Name = c.ComponentId.ToString();
                    pr.Alias = c.TextPrompt;
                    pr.ContainValue = new bool();
                    pr.ListItem = new List<ItemDTO>();

                    foreach(var i in lstItem)
                    {
                        if ((i.FormId == formId) && (i.ComponentId == c.Id))
                        {
                            pr.ListItem.Add(new ItemDTO(i.Id, i.FormId, i.ComponentId, i.Alias, i.IsPreSelected, i.DisplayOrder));
                        }
                    }

                    formPreview.ListComponent.Add(pr);
                }
            }

            return formPreview;
        }
    }
}
