using Tyuiu.GolovanovDO.Sprint6.Task4.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int startValue = -5;
        int stopValuew = 5;

        int len = ds.GetMassFunction(startValue, stopValuew).Length;

        double[] res = ds.GetMassFunction(startValue, stopValuew);

        for (int i = 0; i <= len; i++)
        {
            Console.WriteLine(res[i]);
        }
    }
}