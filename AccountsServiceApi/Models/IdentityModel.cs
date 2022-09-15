namespace AccountsServiceApi.Models
{
    public class IdentityModel
    {
        public string Name { get; set; }
        [System.ComponentModel.DataAnnotations.Key]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
