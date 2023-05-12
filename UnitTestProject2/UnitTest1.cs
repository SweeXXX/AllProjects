using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using TP=TypoGraph;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestReplaceTsia1()
        {
            Assert.AreEqual("ться", TP.TypoGraph.ReplaceTsia("тся"));
        }
        [TestMethod]
        public void TestReplaceTsia2()
        {
            Assert.AreNotEqual("тся", TP.TypoGraph.ReplaceTsia("ться"));
        }

        [TestMethod]
        public void TestReplaceEllipsis1()
        {
            Assert.AreEqual("…", TP.TypoGraph.ReplaceEllipsis("..."));
        }
        [TestMethod]
        public void TestReplaceEllipsis2()
        {
            Assert.AreNotEqual("…", TP.TypoGraph.ReplaceEllipsis("...."));
        }
        [TestMethod]
        public void TestReplaceEllipsis3()
        {
            Assert.AreNotEqual("…", TP.TypoGraph.ReplaceEllipsis(".."));
        }
        [TestMethod]
        public void TestTry1()
        {
            Assert.AreNotEqual("     ", TP.TypoGraph.Try("    "));
        }
        [TestMethod]
        public void TestTry2()
        {
            Assert.AreEqual(" ", TP.TypoGraph.Try("    "));
        }
        //«»
        [TestMethod]
        public void TestReplaceFirstQuotes1()
        {
            Assert.AreEqual("«тестик тестируем»", TP.TypoGraph.ReplaceFirstQuotes("\"тестик тестируем\""));
        }
        [TestMethod]
        public void TestReplaceFirstQuotes2()
        {
            Assert.AreEqual("\"тестик тестируем\"\"", TP.TypoGraph.ReplaceFirstQuotes("\"тестик тестируем\"\""));
        }
        [TestMethod]
        public void TestDeleteShash1()
        {
            Assert.AreNotEqual("//gbdjrdfct,fkrfvfp)", TP.TypoGraph.DeleteSlash("//gbdjrdfct,fkrfvfp)"));
        }
        [TestMethod]
        public void TestDeleteShash2()
        {
            Assert.AreEqual("gbdjrdfct,fkrfvfp)", TP.TypoGraph.DeleteSlash("//gbdjrdfct,fkrfvfp)"));
        }
        [TestMethod]
        public void TestReplaceAmpersand1()
        {
            Assert.AreEqual("&amp;pivodlikethegod", TP.TypoGraph.ReplaceAmpersand("&pivodlikethegod"));
        }
        [TestMethod]
        public void TestReplaceAmpersand2()
        {
            Assert.AreEqual("&amp;pivodlikethegod", TP.TypoGraph.ReplaceAmpersand("&amp;pivodlikethegod"));
        }
        [TestMethod]
        public void TestReplaceAmpersand3()
        {
            Assert.AreNotEqual("&pivodlikethegod", TP.TypoGraph.ReplaceAmpersand("&amp;pivodlikethegod"));
        }
        [TestMethod]
        public void TestReplaceSecondQuotes1()
        {
            string str = TP.TypoGraph.ReplaceFirstQuotes("\"Его имя — \"Олег!\"\", сказал Олег!");
            Assert.AreEqual("«Его имя — „Олег!“», сказал Олег!", TP.TypoGraph.ReplaceSecondQuotes(str));
        }
        [TestMethod]
        public void TestReplaceSecondQuotes2()
        {

            Assert.AreEqual("«Его имя — „Олег!“», сказал Олег!", TP.TypoGraph.ReplaceSecondQuotes("«Его имя — \"Олег!\"», сказал Олег!"));
        }
    }
}
