using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GolovanovDO.Sprint6.Task7.V16.Lib
{
    public class DataService : ISprint6Task7V16
    {
        public int[,] GetMatrix(string path)
        {
            char del = ';';
            string[] lines = File.ReadAllLines(path);

            int rows = lines.Length;
            int cols = lines[0].Split(del).Length;

            int[,] mtrx = new int[rows, cols];

            

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(del);
                for (int j = 0; j < cols; j++)
                {
                    if (int.TryParse(values[j], out int number))
                    {
                        mtrx[i,j] = number;
                    }
                }
            }

            for(int j = 0; j < cols; j++)
            { 
                if (mtrx[4, j] % 2 != 0)
                {
                    mtrx[4, j] = -1;
                }
                else
                {
                    continue;
                }
            }
            return mtrx;
        }
    }
}
