using Demo01Biblioteque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01Bibliotheque.Test
{
    [TestClass]
    public class CalculTest
    {
        [TestMethod]
        public void WhenAdd_10_30_Then_40()
        {
            Calcul calcul = new Calcul();

            double result = calcul.Add(10, 30);

            Assert.IsTrue(result == 40);
        }
    }
}
