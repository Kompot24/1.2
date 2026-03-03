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
        public void randomMarks()
        {
            int[] mass = { 5, 4, 3, 2, 5, 4, 3, 2, 5, 4};
            var message = Logic.CountMarks(mass);
            Assert.AreEqual($"Кол-во 5: 3 4: 3 3: 2 2: 2",message);
        }

        [TestMethod()]
        public void onlyFiveMarks()
        {
            int[] mass = { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5};
            var message = Logic.CountMarks(mass);
            Assert.AreEqual($"Кол-во 5: 10 4: 0 3: 0 2: 0", message);
        }
        [TestMethod()]
        public void onlyFourMarks()
        {
            int[] mass = { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4};
            var message = Logic.CountMarks(mass);
            Assert.AreEqual($"Кол-во 5: 0 4: 10 3: 0 2: 0", message);
        }
        [TestMethod()]
        public void onlyThreeMarks()
        {
            int[] mass = { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3};
            var message = Logic.CountMarks(mass);
            Assert.AreEqual($"Кол-во 5: 0 4: 0 3: 10 2: 0", message);
        }
        [TestMethod()]
        public void onlyTwoMarks()
        {
            int[] mass = { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2};
            var message = Logic.CountMarks(mass);
            Assert.AreEqual($"Кол-во 5: 10 4: 0 3: 0 2: 0", message);
        }

        [TestMethod()]
        public void noneMarks()
        {
            int[] mass = {};
            var message = Logic.CountMarks(mass);
            Assert.AreEqual($"Кол-во 5: 1 4: 1 3: 0 2: 8", message);
        }

        [TestMethod()]
        public void marksInOrdinalNumbers()
        {
            int[] mass = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            var message = Logic.CountMarks(mass);
            Assert.AreEqual($"Кол-во 5: 1 4: 1 3: 1 2: 1", message);
        }
    }
}