using Tyuiu.GolovanovDO.Sprint6.Task6.V1.Lib;
namespace Tyuiu.GolovanovDO.Sprint6.Task6.V1
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
        string openFilePath;
        private void buttonDone_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxResult.Text = ds.CollectTextFromFile(openFilePath);
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxValue.Text = File.ReadAllText(openFilePath);
            groupBoxResult.Text = groupBoxResult.Text + " " + openFileDialogTask.FileName;
            buttonDone.Enabled = true;
        }
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
