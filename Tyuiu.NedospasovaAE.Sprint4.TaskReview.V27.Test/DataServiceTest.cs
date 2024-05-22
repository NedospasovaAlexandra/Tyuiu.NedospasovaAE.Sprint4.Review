using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NedospasovaAE.Sprint4.TaskReview.V27.Lib;

namespace Tyuiu.NedospasovaAE.Sprint4.TaskReview.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int m = 4;
            int n = 3;
            int[,] matrix = new int[n, m];
            string value = "583197256891";
            int res = ds.Calculate(n, m, value);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
