using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Login.Test
{
    using Login.Core;

    [TestClass]
    public class LoginServiceTest
    {
        [TestMethod]
        public void TestCheckUserWithUserNameEmpty()
        {
            LoginService loginService = new LoginService(new DatabaseStub());
            try
            {
                loginService.CheckUser("", "abc");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual(ex.GetType(), typeof(ArgumentException));
                Assert.AreEqual(ex.Message, "The Username don't allow null or empty");
            }

        }

        [TestMethod]
        public void TestCheckUserSuccessfully()
        {
            LoginService loginService = new LoginService(new DatabaseStub());
            bool result = loginService.CheckUser("abc", "abc");
            Assert.AreEqual(result, true);


        }
    }
}
