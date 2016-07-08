using NorthwindContracts.DataContracts;
using NUnit.Framework;

namespace NorthwindTest
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void TestMethod1()
        {
            var category = new Category();
            category.CategoryID = 1;
            Assert.AreEqual(1, category.CategoryID);
        }
    }
}
