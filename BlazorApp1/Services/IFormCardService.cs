using BlazorApp1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    public interface IFormCardService
    {
        Task<IEnumerable<FormCard>> GetFormsCard();
        Task<FormCard> GetFormCard(string id);
        Task<FormCard> AddFormCard(FormCard f1);
        Task<FormCard> UpdateFormCardApproved(FormCard form);
        Task<FormCard> UpdateFormCardDenied(FormCard form);
    }
}
