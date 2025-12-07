using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GolovanovDO.Sprint6.Task4.V22.Lib
{
    public class DataService : ISprint6Task4V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue + 1);
            double[] valueArray = new double[len];
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(Math.Sin(x) + (Math.Cos(2*x) / 2)  - 1.5 * x, 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
