using Tyuiu.GolovanovDO.Sprint6.Task7.V16.Lib;
namespace Tyuiu.GolovanovDO.Sprint6.Task7.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInMatrix.ColumnCount = 50;
            dataGridViewOutMatrix.ColumnCount = 50;

            dataGridViewInMatrix.RowCount = 50;
            dataGridViewOutMatrix.RowCount = 50;
        }
        static int rows;
        static int cols;
        static string openFilePath;

        DataService ds = new DataService();

        //Метод чтения данных из файла
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            //Разделение на строки
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            //Определяем кол-во строк и стобцов
            rows = lines.Length;
            cols = lines[0].Split(';').Length;

            //Выделяем массив данных
            int[,] valueArray = new int[rows, cols];

            //Заполняем массив данными
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    valueArray[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return valueArray;

        }
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            //Выделяем массив данных
            int[,] arrayValues = new int[rows, cols];

            arrayValues = LoadFromFileData(openFilePath);


            dataGridViewInMatrix.RowCount = rows;
            dataGridViewInMatrix.ColumnCount = cols;
            dataGridViewOutMatrix.RowCount = rows;
            dataGridViewOutMatrix.ColumnCount = cols;

            //Задаем ширину столбцов
            for (int i = 0; i < cols; i++)
            {
                dataGridViewOutMatrix.Columns[i].Width = 60;
                dataGridViewInMatrix.Columns[i].Width = 60;
            }

            //Добавляем данные в dataGridViewInMatrix
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; (c < cols); c++)
                {
                    dataGridViewInMatrix.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            // выделяем массив данных 
            int[,] arrayValues = new int[rows, cols];
            arrayValues = ds.GetMatrix(openFilePath);

            //Добавляем данные в dataGridViewOutMatrix
            for(int r = 0; r < rows; r++)
            {
                for (int c = 0; ( c < cols); c++)
                {
                    dataGridViewOutMatrix.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile.Enabled = true;
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7V16.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutMatrix.RowCount; //кол-ыо строк
            int cols = dataGridViewOutMatrix.ColumnCount;//кол-во столбцов

            string str = "";
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str = str + dataGridViewOutMatrix.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutMatrix.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Сохранить файл";
        }

        
    }
}
