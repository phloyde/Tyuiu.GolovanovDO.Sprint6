using Tyuiu.GolovanovDO.Sprint6.Task3.V11.Lib;
namespace Tyuiu.GolovanovDO.Sprint6.Task3.V11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { {27, -15, 14, 2, 27 },
                              {-8, 14, -10, 33, 0 },
                              {1, 7, -11, -11, 23 },
                              {-13, -20, 15, -16, 34 },
                              {-3,   1,  -1,   5,   1 } };

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] sortedmtrx = ds.Calculate(mtrx);
            int rows = sortedmtrx.GetUpperBound(0) + 1;
            int cols = sortedmtrx.Length / rows;

            dataGridViewResult.ColumnCount = cols;
            dataGridViewResult.RowCount = rows;

            //Задаем ширину столбцов
            for (int i = 0; i < cols; i++)
            {
                dataGridViewResult.Columns[i].Width = 50;
            }

            // Заполняем сетку данными из массива
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = Convert.ToString(sortedmtrx[i, j]);

                }
            }
        }

        private void dataGridViewResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
