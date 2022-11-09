using PasswordProject;
using System.Reflection.Metadata;

namespace PasswordTest
{
    
    public class Tests
    {
        

        [Test]
        public void TestSetName()
        {
            //arrange
            var user = new User("bb","343");

            //act
            user.setName("bruno");

            //assert
            Assert.AreEqual("bruno",user.Name);
        }

        [Test]
        public void TestCreateNewUser()
        {
            //arrange
            App app = new App();



            //act
           var newUser = app.CreateAUser("bruno", "123");
            var expectedUserName = "bruno";
            var expectedPassword = "123";

            //assert
            Assert.AreEqual(expectedUserName,newUser.UserName);
            Assert.AreEqual(expectedPassword,newUser.Password);
        }
    }
}