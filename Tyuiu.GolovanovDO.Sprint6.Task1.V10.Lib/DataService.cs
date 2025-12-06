using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GolovanovDO.Sprint6.Task1.V10.Lib
{
    public class DataService : ISprint6Task1V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] mass = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double y = Math.Round(Math.Sin(x) + 2 / (3 * x + 0.5) - 2 * Math.Cos(x) * 2*x, 2);
                mass[count] = y;
                count++;
            }
            return mass;
        }
    }
}
