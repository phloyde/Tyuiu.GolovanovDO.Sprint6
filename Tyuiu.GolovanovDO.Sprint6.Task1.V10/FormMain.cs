using Tyuiu.GolovanovDO.Sprint6.Task1.V10.Lib;
namespace Tyuiu.GolovanovDO.Sprint6.Task1.V10_
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonMoreInfo_Click(object sender, EventArgs e)
        {
            // Например, открывать MessageBox
            MessageBox.Show("Таск 1 выполнил студент группы ПИНб-25-1 Голованов Данила Олегович");
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart.Text);
                int stopValue = Convert.ToInt32(textBoxStop.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult.Text = "";
                textBoxResult.AppendText("+--------+----------+" + Environment.NewLine);
                textBoxResult.AppendText("|   X    |    F(x)  |" + Environment.NewLine);
                textBoxResult.AppendText("+--------+----------+" + Environment.NewLine);


                for (int i = 0; i <= len -1; i++)
                {
                    strLine = String.Format("|{0,6} | {1,8:F2}  |", startValue, valueArray[i]);

                    textBoxResult.AppendText(strLine + Environment.NewLine);
                    startValue++;

                }
                textBoxResult.AppendText("+----------+--------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        


    }
}
