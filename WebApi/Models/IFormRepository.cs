using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public interface IFormRepository
    {
        Task<IEnumerable<Form>> GetForms();
        Task<Form> GetForm(string Id);
        Task<Form> AddForm(Form form);
        Task<Form> DeleteForm(string Id);
        Task<Form> UpdateFormApp(Form form);
        Task<Form> UpdateFormDenied(Form form);
    }
}
