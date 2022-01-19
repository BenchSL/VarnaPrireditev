using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public interface IFormCardRepository
    {
        Task<IEnumerable<FormCard>> GetFormsCard();
        Task<FormCard> GetFormCard(string Id);
        Task<FormCard> AddFormCard(FormCard form);
        Task<FormCard> UpdateFormCardApp(FormCard form);
        Task<FormCard> UpdateFormCardDenied(FormCard form);

    }
}
