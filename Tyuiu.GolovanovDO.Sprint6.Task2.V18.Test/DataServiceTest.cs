using Tyuiu.GolovanovDO.Sprint6.Task2.V18.Lib;
namespace Tyuiu.GolovanovDO.Sprint6.Task2.V18.Test
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

            valueWait[0] = 23.92;
            valueWait[1] = 18.88;
            valueWait[2] = 13.10;
            valueWait[3] = 7.24;
            valueWait[4] = 1.80;
            valueWait[5] = -8.00;
            valueWait[6] = -5.70;
            valueWait[7] = -11.26;
            valueWait[8] = -17.12;
            valueWait[9] = -22.88;
            valueWait[10] = -27.92;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWait, res);

        }
    }
}
