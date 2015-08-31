using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void Login_RightInfo()
        {
            Login login = new Login();
            Assert.AreEqual(true, login.Verify("Ida123", "123ida"));
        }
        [TestMethod]
        public void Login_WrongInfo()
        {
            Login login = new Login();
            Assert.AreEqual(false, login.Verify("Idw2322a123", "123ida"));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Login_NoInfo()
        {
            Login login = new Login();
            Assert.IsNull(login.Verify(null, null));
        }

    }
}
