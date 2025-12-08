using Tyuiu.GolovanovDO.Sprint6.Task6.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
       DataService ds = new DataService();

        string path = @"C:\Sprints_tyuiu\DataSprint6\InPutFileTask6v1.txt";

        string res = ds.CollectTextFromFile(path);
        Console.WriteLine(res);
    }
}