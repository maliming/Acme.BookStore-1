using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Acme.BookStore.Web.Pages;

public class IndexModel : BookStorePageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
