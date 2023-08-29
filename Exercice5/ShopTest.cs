using ExerciseLibrary;

namespace Exercice5
{
    [TestClass]
    public class ShopTest
    {
        [TestMethod]
        public void WhenSellIn_Is_0_Then_QualityDecreaseTimes2()
        {
            Product productTest1 = new Product("type", "name", 0, 2);
            Shop shop = new Shop();
            Shop.Update(productTest1);
            Assert.AreEqual(productTest1.GetQuality(), 0);
        }
    }
}