using BlazorApp1.Models;
using BlazorApp1.Database;
using System.Threading.Tasks;
using System.Linq;
using System;
using System.Collections.Generic;

namespace BlazorApp1.Services
{
    public class FormService
    {
        public FormContext DbContext = new FormContext(); //db

        private Random rnd = new Random();

        //public Task PostForm(string fName, string uEduc, string Experience, string EventTyp, int idUs)
        //{
        //    return Task.Run(() =>
        //    {
        //        Form d1 = new Form(fName, uEduc, Experience, EventTyp, idUs);

        //        string serialNumber = GenerateSerial();

        //        d1.SerialNumber = serialNumber;
        //        d1.Status = "Pending";

        //        DbContext.Forms.Add(d1);
        //        DbContext.SaveChanges();
        //    });
        //}

        //public Task<Form> GetForm(string idForm) //get one form
        //{
        //    return (Task<Form>)Task.Run(() =>
        //    {
        //        Form f1 = (Form)DbContext.Forms.Single(x => x.Id == idForm);
        //    });
        //}

        //public Task DeleteForm(string idForm)
        //{
        //    return Task.Run(() =>
        //    {
        //        Form f1 = (Form)DbContext.Forms.Single(x => x.Id == idForm);

        //        DbContext.Remove(f1);
        //        DbContext.SaveChanges();
        //    });
        //}

        public string GenerateSerial()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 10)
                .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }
    }
}
