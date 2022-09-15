namespace AccountsServiceApi.Repositories
{
    public class AccountsORMRepository : IAccountsRepository
    {
        DataContexts.AccountsDBContext _context;
        //constructor dependency injection
        public AccountsORMRepository(DataContexts.AccountsDBContext context)
        {
            _context = context;
        }

        public void AddNewIdentity(Models.IdentityModel newUser)
        {
            this._context.Add(newUser);
            _context.SaveChanges();
        }
        //write rest of the crud
        public IEnumerable<Models.IdentityModel> GetAllIdentities()
        {
            return _context.IdentityModels;
        }
    }
}
