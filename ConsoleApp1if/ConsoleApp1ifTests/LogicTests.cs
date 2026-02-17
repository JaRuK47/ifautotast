using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void MoreCop()
        {
            string text = Logic.Convert(199);
            Assert.AreEqual("1 рубль  99 копеек", text);
        }


        [TestMethod()]
        public void OneCop()
        {
            string text = Logic.Convert(1);
            Assert.AreEqual("1 копейка", text);
        }

        [TestMethod()]
        public void Onerub()
        {
            string text = Logic.Convert(100);
            Assert.AreEqual("1 рубль", text);
        }

        [TestMethod()]
        public void fourcop()
        {
            string text = Logic.Convert(4);
            Assert.AreEqual("4 копейки", text);
        }

        [TestMethod()]
        public void tworub()
        {
            string text = Logic.Convert(200);
            Assert.AreEqual("2 рубля", text);
        }

        [TestMethod()]
        public void sixrub()
        {
            string text = Logic.Convert(600);
            Assert.AreEqual("6 рублей", text);
        }
    }
}