using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SweeTa;
using SweeTa.Classess;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsValidEmail1()
        {
            bool ok = true;
            bool test = CheckCorrect.IsValidEmail("nikitaloh@mail.ru");
            Assert.AreEqual(ok, test);
        }
        [TestMethod] 
        public void TestIsValidEmail2()
        {
            bool ok = false;
            bool test = CheckCorrect.IsValidEmail("nikitalohmail.ru");
            Assert.AreEqual(ok, test);
        }
        [TestMethod]
        public void TestIsValidEmail3()
        {
            bool ok = false;
            bool test = CheckCorrect.IsValidEmail("nikitaloh@mailru");
            Assert.AreEqual(ok, test);
        }
        [TestMethod]
        public void TestIsValidPassword1()
        {
            bool ok = true;
            bool test = CheckCorrect.IsAlphanumeric("password12");
            Assert.AreEqual(ok, test);
        }
        [TestMethod]
        public void TestIsValidPassword2()
        {
            bool ok = false;
            bool test = CheckCorrect.IsAlphanumeric("ОлегОлег2");
            Assert.AreEqual(ok, test);
        }
        [TestMethod]
        public void TestIsValidPassword3()
        {
            bool ok = false;
            bool test = CheckCorrect.IsAlphanumeric("оле голег");
            Assert.AreEqual(ok, test);
        }
        [TestMethod]
        public void TestIsValidPassword4()
        {
            bool ok = false;
            bool test = CheckCorrect.IsAlphanumeric("ОЛЕГ ОЛЕГ");
            Assert.AreEqual(ok, test);
        }
        [TestMethod]
        public void TestIsValidLoginOrMail1()
        {
            bool ok = false;
            bool test = CheckCorrect.LoginOrMailIsCorrect("");
            Assert.AreEqual(ok, test);
        }
        [TestMethod]
        public void TestIsValidLoginOrMail2()
        {
            bool test = CheckCorrect.LoginOrMailIsCorrect("loginloginlog");
            Assert.IsTrue(test);
        }
        [TestMethod]
        public void TestIsValidLoginOrMail3()
        {
            bool test = CheckCorrect.LoginOrMailIsCorrect("Вилка вилка");
            Assert.IsFalse(test);
        }
        [TestMethod]
        public void TestIsValidLoginOrMail4()
        {
            bool test = CheckCorrect.LoginOrMailIsCorrect("Вилка");
            Assert.IsFalse(test);
        }
        [TestMethod]
        public void TestIsValidLoginOrMail5()
        {
            bool test = false;
            Assert.IsFalse(test);
        }

    }
}
