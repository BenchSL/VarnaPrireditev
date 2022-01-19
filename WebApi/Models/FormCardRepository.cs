using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Database;

namespace WebApi.Models
{
    public class FormCardRepository : IFormCardRepository
    {
        private readonly FormContext formDbContext;
        private Random rnd = new Random();
        public FormCardRepository(FormContext formDbContext)
        {
            this.formDbContext = formDbContext;
        }
        public async Task<FormCard> AddFormCard(FormCard form)
        {
            form.SerialNumber = GenerateSerial();
            form.Status = "Pending";
            var result = await formDbContext.FormCard.AddAsync(form);
            await formDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<FormCard> GetFormCard(string Id)
        {
            return await formDbContext.FormCard.FirstOrDefaultAsync(e => e.Id == Id);
        }

        public async Task<IEnumerable<FormCard>> GetFormsCard()
        {
            return await formDbContext.FormCard.ToListAsync();
        }

        public async Task<FormCard> UpdateFormCardApp(FormCard form)
        {
            var result = await formDbContext.FormCard.FirstOrDefaultAsync(x => x.Id == form.Id);

            if (result != null)
            {
                result.Status = "Accepted";
                await formDbContext.SaveChangesAsync();
                return result;
            }

            return null;
        }

        public async Task<FormCard> UpdateFormCardDenied(FormCard form)
        {
            var result = await formDbContext.FormCard.FirstOrDefaultAsync(x => x.Id == form.Id);

            if (result != null)
            {
                result.Status = "Denied";
                await formDbContext.SaveChangesAsync();
                return result;
            }

            return null;
        }

        public string GenerateSerial()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 10)
                .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }
    }
}
