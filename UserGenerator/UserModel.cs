using System;
using System.Collections.Generic;
using System.Text;

namespace UserGenerator
{
    public class UserModel
    {
        public UserModel()
        {
        }

        public UserModel(string email, string firstName, string lastName, string password)
        {
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
        }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }
    }
}
