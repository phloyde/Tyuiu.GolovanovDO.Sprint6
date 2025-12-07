using Tyuiu.GolovanovDO.Sprint6.Task5.V1.Lib;
namespace Tyuiu.GolovanovDO.Sprint6.Task5.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        string path = @"C:\Sprints_tyuiu\DataSprint6\InPutDataFileTask5V1.txt";

        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewResult.ColumnCount = 2;
            dataGridViewResult.Columns[0].Width = 20;
            dataGridViewResult.Columns[1].Width = 50;

            this.chartResult.ChartAreas[0].AxisX.Title = "Îñü Õ";
            this.chartResult.ChartAreas[0].AxisY.Title = "Îñü Y";

            chartResult.Series[0].Points.Clear();

            double[] numMass = new double[ds.len];

            numMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridViewResult.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartResult.Series[0].Points.AddXY(i, numMass[i]);
            }
        }

        private void chartResult_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
