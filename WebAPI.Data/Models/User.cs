using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI.Domain
{
   public class User: BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
