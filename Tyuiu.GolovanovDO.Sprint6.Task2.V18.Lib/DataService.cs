using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GolovanovDO.Sprint6.Task2.V18.Lib
{
    public class DataService : ISprint6Task2V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] mass = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double y = Math.Round((3 * Math.Cos(x)) / (4*x-0.5) + Math.Sin(x) - 5*x - 2, 2);
                mass[count] = y;
                count++;
            }
            return mass;
        }
    }
}
