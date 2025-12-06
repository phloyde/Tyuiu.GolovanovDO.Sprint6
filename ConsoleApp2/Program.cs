using Tyuiu.GolovanovDO.Sprint6.Task2.V18.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int startValue = -5;
        int stopValue = 5;
        int len = ds.GetMassFunction(startValue, stopValue).Length;
        double[] res = new double[len];
        res = ds.GetMassFunction(startValue, stopValue);
        Console.WriteLine("|   X   |    F(x)      |");
        Console.WriteLine("|----------------------|");
        for (int i = 0; i <= len; i++)
        {
            Console.WriteLine("|{0,5:d}  |    {1,7:f2}    |", startValue, res[i]);
            startValue++;
        }
    }
}