using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void firstTest()
        {
            int[] mass = { 5, 4, 3, 2, 5, 4, 3, 2, 5, 4};
            var message = Logic.Compare(mass);
            Assert.AreEqual($"Кол-во 5: 3 4: 3 3: 2 2: 2",message);
        }

        [TestMethod()]
        public void secondTest()
        {
            int[] mass = { 4, 4, 4, 2, 3, 2, 3, 3, 2, 4 };
            var message = Logic.Compare(mass);
            Assert.AreEqual($"Кол-во 5: 0 4: 4 3: 3 2: 3", message);
        }

        [TestMethod()]
        public void thirsrTest()
        {
            int[] mass = { 2, 2, 2, 2, 2, 2, 2, 2, 5, 4 };
            var message = Logic.Compare(mass);
            Assert.AreEqual($"Кол-во 5: 1 4: 1 3: 0 2: 8", message);
        }
    }
}