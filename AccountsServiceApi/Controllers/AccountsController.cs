using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AccountsServiceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        //static List<Models.IdentityModel> identityModels = new List<Models.IdentityModel>();
        Repositories.IAccountsRepository _repository;        
        public AccountsController(Repositories.IAccountsRepository repository) 
        { 
            _repository = repository;
        }


        // GET: api/accounts
        [HttpGet]
        public IEnumerable<Models.IdentityModel> Get()
        {
            return this._repository.GetAllIdentities();
        }

        // GET api/accounts/tom
        [HttpGet("{name}")]
        public string Get(string name)
        {
            var identityModels = this._repository.GetAllIdentities().ToList();
            for (int i = 0; i < identityModels.Count; i++)
            {
                string current_name = identityModels[i].Name;
                if (current_name == name)
                {
                    return identityModels[i].Name;
                }
            }
            return null;
        }

        // POST api/accounts
        [HttpPost]
        public void Post([FromBody] Models.IdentityModel value)
        {
            //identityModels.Add(value);
            this._repository.AddNewIdentity(value);
        }

        // PUT api/accounts/tom
        //[HttpPut("{name}")]
        //public void Put(string  name, [FromBody] Models.IdentityModel value)
        //{
        //    //update
        //    for (int i = 0; i < identityModels.Count; i++)
        //    {
        //        string current_name = identityModels[i].Name;
        //        if (current_name == name)
        //        {
        //            //identityModels[i].Equals(value);
        //            identityModels[i].Name = value.Name;
        //            identityModels[i].Password = value.Password;
        //            identityModels[i].Email = value.Email;
        //        }
        //    }

        //    //identityModels.Add(value);
        //}

        // DELETE api/accounts/tom
        //[HttpDelete("{name}")]
        //public void Delete(string  name)
        //{
        //    //remove from the list
        //    for (int i = 0; i < identityModels.Count; i++)
        //    {
        //        identityModels.Remove(identityModels.Where(item => item.Name == name).Single());
        //    }
        //}
    }
}
