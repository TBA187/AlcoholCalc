using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WpfApplication1;

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
            List<Person> personlist = new List<Person>();
            Person person1 = new Person();
            Person person2 = new Person();

            personlist.Add(person1);
            personlist.Add(person2);

            person1.Username = "Ivan123";
            person1.Password = "123ivan";
            person1.Gender = "Male";
            person1.Weight = 110;

            person2.Username = "Ida123";
            person2.Password = "123ida";
            person2.Gender = "Female";
            person2.Weight = 50;
            Login login = new Login();
            login.SetUserSource(personlist);
            Assert.AreEqual(true, login.Verify("Ida123", "123ida"));
        }
        [TestMethod]
        public void Login_WrongInfo()
        {
            List<Person> personlist = new List<Person>();
            Person person1 = new Person();
            Person person2 = new Person();

            personlist.Add(person1);
            personlist.Add(person2);

            person1.Username = "Ivan123";
            person1.Password = "123ivan";
            person1.Gender = "Male";
            person1.Weight = 110;

            person2.Username = "Ida123";
            person2.Password = "123ida";
            person2.Gender = "Female";
            person2.Weight = 50;
            Login login = new Login();
            login.SetUserSource(personlist);
            Assert.AreEqual(false, login.Verify("Idaadsd123", "123ida"));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Login_NullInfo()
        {
            Login login = new Login();
            Assert.IsNull(login.Verify(null, null));
        }

    }
}
