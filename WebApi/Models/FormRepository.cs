using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Database;

namespace WebApi.Models
{
    public class FormRepository : IFormRepository
    {
        private readonly FormContext formDbContext;
        private Random rnd = new Random();
        public FormRepository(FormContext formDbContext)
        {
            this.formDbContext = formDbContext;
        }

        public async Task<Form> AddForm(Form form)
        {
            form.SerialNumber = GenerateSerial();
            form.Status = "Pending";
            var result = await formDbContext.Forms.AddAsync(form);
            await formDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Form> DeleteForm(string Id)
        {
            var result = await formDbContext.Forms.FirstOrDefaultAsync(e => e.Id == Id);
            formDbContext.Forms.Remove(result);
            await formDbContext.SaveChangesAsync();
            return result;
        }

        public async Task<Form> GetForm(string Id)
        {
            return await formDbContext.Forms.FirstOrDefaultAsync(e => e.Id == Id);
        }

        public async Task<IEnumerable<Form>> GetForms()
        {
            return await formDbContext.Forms.ToListAsync();
        }

        public async Task<Form> UpdateFormApp(Form form)
        {
            var result = await formDbContext.Forms.FirstOrDefaultAsync(x => x.Id == form.Id);

            if (result != null)
            {
                result.Status = "Accepted";
                await formDbContext.SaveChangesAsync();
                return result;
            }

            return null;
        }

        public async Task<Form> UpdateFormDenied(Form form)
        {
            var result = await formDbContext.Forms.FirstOrDefaultAsync(x => x.Id == form.Id);

            if(result != null)
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
