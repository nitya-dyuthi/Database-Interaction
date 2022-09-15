using AccountsServiceApi.Models;

namespace AccountsServiceApi.Repositories
{
    public interface IAccountsRepository
    {
        void AddNewIdentity(IdentityModel newUser);
        IEnumerable<IdentityModel> GetAllIdentities();
    }
}