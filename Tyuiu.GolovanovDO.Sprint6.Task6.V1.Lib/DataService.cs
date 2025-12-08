using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GolovanovDO.Sprint6.Task6.V1.Lib
{
    public class DataService : ISprint6Task6V1
    {
        public string CollectTextFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            List<string> firstWords = new List<string>();

            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    // Убираем пробелы в начале/конце строки и игнорируем пустые элементы
                    string[] words = line.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    if (words.Length > 0)
                    {
                        firstWords.Add(words[0]);
                    }
                }
            }

            return string.Join(" ", firstWords);
        }
    }
}
