using NUnit.Framework;
using PhaseEnd.Models;

namespace PhaseEnd
{
    [TestFixture]
    public class TestManagement
    {
        DbClass dbcontext;
        [SetUp]
        public void SetUp()
        {
            dbcontext = new DbClass();  
        }
        [Test]
        public void AddUserTest()
        {
            var userInfo = new UserInfo()
            {
                UserId = 105,
                Email="lokesh@gmail.com",
                Password="lokesh@123"
            };
            var adding=dbcontext.AddUser(userInfo);
            Assert.IsNotNull(adding);
            Assert.IsTrue(adding.Equals(userInfo));
        }


    }
}
