using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GolovanovDO.Sprint6.Task6.V1.Lib
{
    public class DataService : ISprint6Task6V1
    {
        public string CollectTextFromFile(string path)
        {
            
            string firstWord = "";

            string[] str = File.ReadAllLines(path);




            foreach (string line in str)
            {
                firstWord = firstWord + " " + line.Split(' ').First() ;
                
            }
            firstWord = firstWord.Substring(1);
            return firstWord;

        }
    }
}
