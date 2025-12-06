using Tyuiu.GolovanovDO.Sprint6.Task3.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int[,] mass = { { 8, 3, 3, 3, 5},
                            {6, 7, 3, 3, 7},
                            {4, 5, 4, 6, 6},
                            {5, 5, 8, 8, 7},
                            {4, 6, 6, 7, 7} };
        int rows = 5;
        int cols = 5;
        int[,] res = ds.Calculate(mass);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(res[i, j]);
                
            }
            Console.WriteLine();
        }
        
        
        Console.ReadKey();
    }
}