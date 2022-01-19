using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    public interface IFormService
    {
        Task<IEnumerable<Form>> GetForms();
        Task<Form> GetForm(string id);
        Task<Form> AddForm(Form f1);
        Task DeleteForm(string id);
        Task<Form> UpdateFormApproved(Form form);
        Task<Form> UpdateFormDenied(Form form);
    }
}
