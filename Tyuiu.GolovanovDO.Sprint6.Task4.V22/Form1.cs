using Tyuiu.GolovanovDO.Sprint6.Task4.V22.Lib;
namespace Tyuiu.GolovanovDO.Sprint6.Task4.V22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds  = new DataService();
        private void chartResult_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart.Text);
                int stopStep = Convert.ToInt32(textBoxStop.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartResult.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartResult.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult.Text = "";

                chartResult.Series[0].Points.Clear();
                for (int i = 0; i <= len -1; i++)
                {
                    chartResult.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string outPutfile = @"C:\Sprints_tyuiu\DataSprint6\OutPutFileTask4V22.txt";
                File.WriteAllText(outPutfile, textBoxResult.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + outPutfile + "сохранен успешно!\n Открыть его в блокноте ?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = outPutfile;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
