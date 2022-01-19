using BlazorApp1.Models;
using BlazorApp1.Services;
using Microsoft.AspNetCore.Components;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Pages
{
    public class FormListBase : ComponentBase
    {
        [Inject]
        public FormInterService FromService { get; set; }

        public IEnumerable<Form> Forms { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Forms = await FromService.GetForms();
        }
    }
}
