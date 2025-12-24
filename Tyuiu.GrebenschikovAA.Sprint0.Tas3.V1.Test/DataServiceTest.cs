using Tyuiu.GrebenschikovAA.Sprint0.Tas3.V1.Lib;

namespace Tyuiu.GrebenschikovAA.Sprint0.Tas3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}