using Tyuiu.GolovanovDO.Sprint6.Task1.V10.Lib;
namespace Tyuiu.GolovanovDO.Sprint6.Task1.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] valueWait;
            valueWait = new double[len];

            valueWait[0] = 7.13;
            valueWait[1] = -9.20;
            valueWait[2] = -11.52;
            valueWait[3] = -3.74;
            valueWait[4] = 1.82;
            valueWait[5] = 0.50;
            valueWait[6] = -0.82;
            valueWait[7] = 4.74;
            valueWait[8] = 12.52;
            valueWait[9] = 10.20;
            valueWait[10] = -6.13;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue); 
            CollectionAssert.AreEqual(valueWait, res);

        }
    }
}
