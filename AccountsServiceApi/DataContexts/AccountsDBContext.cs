using AccountsServiceApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AccountsServiceApi.DataContexts
{
    public class AccountsDBContext : DbContext
    {
        public DbSet<Models.IdentityModel> IdentityModels { get; set; }

        public AccountsDBContext(DbContextOptions<AccountsDBContext> options): base(options)
        {
            
        }
    }
}
