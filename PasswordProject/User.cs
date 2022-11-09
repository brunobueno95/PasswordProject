using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordProject
{
   public class User
    {
        public string Name { get;  set; }

        public int Age { get;  set; }

        public string Gender { get; set; }


        public string UserName { get; set; }

        public string Password { get; set; }

        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
           
        }

        public void setName(string NameChosen)
        {
            Name = NameChosen;
        }
        public void setAge(int AgeChosen)
        {
            Age = AgeChosen;
        }
        public void setGender(string GenderChosen)
        {
            Gender = GenderChosen;
        }






    }
}
