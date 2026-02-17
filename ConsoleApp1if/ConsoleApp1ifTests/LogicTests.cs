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
            int cop = 199;

            string text = Logic.Convert(cop);

            Assert.AreEqual("1 рубль  99 копеек", text);
        }


        [TestMethod()]
        public void OneCop()
        {
            int cop = 1;

            string text = Logic.Convert(cop);

            Assert.AreEqual("1 копейка", text);
        }

        [TestMethod()]
        public void Onerub()
        {
            int cop = 100;

            string text = Logic.Convert(cop);

            Assert.AreEqual("1 рубль", text);
        }

        [TestMethod()]
        public void fourcop()
        {
            int cop = 4;

            string text = Logic.Convert(cop);

            Assert.AreEqual("4 копейки", text);
        }

        [TestMethod()]
        public void tworub()
        {
            int cop = 200;

            string text = Logic.Convert(cop);

            Assert.AreEqual("2 рубля", text);
        }

        [TestMethod()]
        public void sixrub()
        {
            int cop = 600;

            string text = Logic.Convert(cop);

            Assert.AreEqual("6 рублей", text);
        }
    }
}