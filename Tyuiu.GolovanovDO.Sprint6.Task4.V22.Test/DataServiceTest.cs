using Tyuiu.GolovanovDO.Sprint6.Task4.V22.Lib;
namespace Tyuiu.GolovanovDO.Sprint6.Task4.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int starValue = -5;
            int stopValue = 5;
            int len = ds.GetMassFunction(starValue, stopValue).Length;

            double[] res = new double[len];
            res = ds.GetMassFunction(starValue, stopValue);

            double[] wait = {8.6, 6.43, 3.86, 1.88, 0.93, 0.5, -0.39, -2.3, -4.85, -7.08, -8.32};

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
