using Microsoft.AspNetCore.Http.HttpResults;
using System.Runtime.CompilerServices;

namespace Zeus.Api.Accounts
{
    public static class AccountsEndPoints
    {
        public static async void AddAccountsEndPoints(this IEndpointRouteBuilder app)
        {
            var accountsGroup = app.MapGroup("/accounts");
            accountsGroup.Map("/", GetAllAccountsAsync);
            accountsGroup.MapGet("/test", async () => { await Task.Delay(30000); });
        }

        public static async Task<Ok<List<Account>>> GetAllAccountsAsync()
        {
            var allAccounts = new List<Account>();

            return TypedResults.Ok(allAccounts);
        }
    }
}
