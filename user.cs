using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_project
{
    internal class user
    {
       public string Name;
        public string PhoneNumber;
        public string Email;
        public user(string Name,string PhoneNumber,string Email)
        {
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
        }
      
      
    }
}