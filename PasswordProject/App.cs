using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordProject
{
    public class App
    {
        public List<User> Allusers = new List<User>();

        public App()
        {
            
          

        }

        public void RunApp()
        {
            var NewUser = readInputsandSendaNewUser();
            Allusers.Add(NewUser);
            PutYourInfo(NewUser);

            Console.Clear();
            writeLogIn();

        }

        public User readInputsandSendaNewUser()
        {
            Console.WriteLine("Write a UserName you choose");
            var NewUserUserName = Console.ReadLine();
            Console.WriteLine("Write a Password you choose");
            var NewUserPassword = Console.ReadLine();
            return CreateAUser(NewUserUserName, NewUserPassword);
        }
        public User CreateAUser(string username, string userpassword)
        {
           
            User newUser = new User(username, userpassword);
            return newUser;
        }

       
        public void PutYourInfo(User GivingUserInfo)
        {
            Console.WriteLine("Now that you created a User, fill up you Information");
            Console.WriteLine("Name: ");
            var name = Console.ReadLine();
            GivingUserInfo.setName(name);
            Console.WriteLine("Age: ");
            var age = Convert.ToInt32(Console.ReadLine());
            GivingUserInfo.setAge(age);
            Console.WriteLine("Gender:");
            var gender = Console.ReadLine();
            GivingUserInfo.setGender(gender);
        }

        public void writeLogIn()
        {
            Console.WriteLine("For Login In, write your Username");
            var CheckUserName = Console.ReadLine();
            Console.WriteLine("For Login In, write your Password");
            var CheckPassword = Console.ReadLine();
            CheckLogIn(CheckUserName, CheckPassword);
        }
        public void CheckLogIn(string InputUserName, string inputPassword)
        {
           


            foreach (var user in Allusers)
            {
                if (user.UserName == InputUserName && user.Password == inputPassword)
                {
                    Console.WriteLine($"Welcome! To your Account {user.Name}, you are {user.Age} years old and gender: {user.Gender}");
                    
                }
                else
                {
                    Console.WriteLine("Sorry, password or username were wrong");
                }
            }
        }

        
    }
}
