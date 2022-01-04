using System.Threading.Tasks;
using FromAntDesignTemplateWithLess.Models;
using FromAntDesignTemplateWithLess.Services;
using Microsoft.AspNetCore.Components;

namespace FromAntDesignTemplateWithLess.Pages.Account.Settings
{
    public partial class BaseView
    {
        private CurrentUser _currentUser = new CurrentUser();

        [Inject] protected IUserService UserService { get; set; }

        private void HandleFinish()
        {
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            _currentUser = await UserService.GetCurrentUserAsync();
        }
    }
}