using ExerciseLibrary;
using System.Collections.ObjectModel;

namespace Exercise2.Test
{
    [TestClass]
    public class FibTest
    {
        //public TestContext TestContext { get; set; }
        //private Fib Fib { get; set; }
        //private List<int> Series { get => Fib.GetFibSeries(); }

        //[TestInitialize]
        //public void setup()
        //{
        //    if (TestContext.TestName.Contains("Range1"))
        //    {
        //        Fib = new Fib(1);
        //    }
        //    else Fib = new Fib(6);
        //}

        [TestMethod]
        public void WhenRange1_Then_SeriesNotEmpty()
        {
            Fib fib = new Fib(1);
            List<int> series = fib.GetFibSeries();
            Assert.AreNotEqual(series.Count, 0);
        }

        [TestMethod]
        public void WhenRange1_Then_SeriesContains0()
        {
            Fib fib = new Fib(1);
            List<int> series = fib.GetFibSeries();
            CollectionAssert.Contains(series, 0);
        }

        [TestMethod]
        public void WhenRange6_Then_SeriesContains3()
        {
            Fib fib = new Fib(6);
            List<int> series = fib.GetFibSeries();
            CollectionAssert.Contains(series, 3);
        }

        [TestMethod]
        public void WhenRange6_Then_SeriesCount6()
        {
            Fib fib = new Fib(6);
            List<int> series = fib.GetFibSeries();
            Assert.AreEqual(series.Count, 6);
        }

        [TestMethod]
        public void WhenRange6_Then_SeriesNotContains4()
        {
            Fib fib = new Fib(6);
            List<int> series = fib.GetFibSeries();
            CollectionAssert.DoesNotContain(series, 4);
        }

        [TestMethod]
        public void WhenRange6_Then_SeriesIs011235()
        {
            Fib fib = new Fib(6);
            List<int> series = fib.GetFibSeries();
            List<int> compare = new List<int>(new int[] { 0, 1, 1, 2, 3, 5 });
            CollectionAssert.IsSubsetOf(compare, series);
        }

        [TestMethod]
        public void WhenRange6_Then_SeriesSortedAscending()
        {
            Fib fib = new Fib(6);
            List<int> series = fib.GetFibSeries();
            List<int> compare = fib.GetFibSeries();
            compare.Sort();
            CollectionAssert.AreEqual(series, compare);
        }
    }
}