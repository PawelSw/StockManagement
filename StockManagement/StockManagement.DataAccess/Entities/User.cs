using System.ComponentModel.DataAnnotations;

namespace StockManagement.DataAccess.Entities
{
    public class User : EntityBase
    {
        public string FirstName { get; set; }  
        public string LastName { get; set; }   
        public string UserName { get; set; }
        public string Password { get; set; }
       

    }
}
