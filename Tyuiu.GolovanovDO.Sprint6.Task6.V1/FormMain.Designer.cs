namespace Tyuiu.GolovanovDO.Sprint6.Task6.V1
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop = new Panel();
            buttonOpenFile = new Button();
            buttonDone = new Button();
            buttonAbout = new Button();
            panelTask = new Panel();
            groupBoxTask = new GroupBox();
            labelTask = new Label();
            panelValue = new Panel();
            groupBoxValue = new GroupBox();
            textBoxValue = new TextBox();
            panelResult = new Panel();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            panelTop.SuspendLayout();
            panelTask.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panelValue.SuspendLayout();
            groupBoxValue.SuspendLayout();
            panelResult.SuspendLayout();
            groupBoxResult.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonOpenFile);
            panelTop.Controls.Add(buttonDone);
            panelTop.Controls.Add(buttonAbout);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1143, 75);
            panelTop.TabIndex = 0;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(21, 3);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(94, 66);
            buttonOpenFile.TabIndex = 2;
            toolTip1.SetToolTip(buttonOpenFile, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonDone
            // 
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(140, 3);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(94, 66);
            buttonDone.TabIndex = 1;
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonAbout
            // 
            buttonAbout.Image = (Image)resources.GetObject("buttonAbout.Image");
            buttonAbout.Location = new Point(1037, 12);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(94, 57);
            buttonAbout.TabIndex = 0;
            buttonAbout.UseVisualStyleBackColor = true;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // panelTask
            // 
            panelTask.Controls.Add(groupBoxTask);
            panelTask.Dock = DockStyle.Top;
            panelTask.Location = new Point(0, 75);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(1143, 110);
            panelTask.TabIndex = 1;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Location = new Point(3, 3);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(1128, 101);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(8, 27);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(648, 40);
            labelTask.TabIndex = 0;
            labelTask.Text = "Дан файл InPutFileTask6V1.txt. Загрузить файл в textBoxIn через openFileDialog. \r\nВывести первое слово каждой строки в результирующею строку и вывести ее в textBoxOut.";
            // 
            // panelValue
            // 
            panelValue.Controls.Add(groupBoxValue);
            panelValue.Dock = DockStyle.Left;
            panelValue.Location = new Point(0, 185);
            panelValue.Name = "panelValue";
            panelValue.Size = new Size(578, 435);
            panelValue.TabIndex = 2;
            // 
            // groupBoxValue
            // 
            groupBoxValue.Controls.Add(textBoxValue);
            groupBoxValue.Location = new Point(3, 3);
            groupBoxValue.Name = "groupBoxValue";
            groupBoxValue.Size = new Size(569, 432);
            groupBoxValue.TabIndex = 0;
            groupBoxValue.TabStop = false;
            groupBoxValue.Text = "Ввод";
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(0, 27);
            textBoxValue.Multiline = true;
            textBoxValue.Name = "textBoxValue";
            textBoxValue.ScrollBars = ScrollBars.Vertical;
            textBoxValue.Size = new Size(569, 402);
            textBoxValue.TabIndex = 0;
            // 
            // panelResult
            // 
            panelResult.Controls.Add(groupBoxResult);
            panelResult.Dock = DockStyle.Fill;
            panelResult.Location = new Point(578, 185);
            panelResult.Name = "panelResult";
            panelResult.Size = new Size(565, 435);
            panelResult.TabIndex = 3;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(6, 3);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(547, 432);
            groupBoxResult.TabIndex = 0;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(0, 27);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(547, 402);
            textBoxResult.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 620);
            Controls.Add(panelResult);
            Controls.Add(panelValue);
            Controls.Add(panelTask);
            Controls.Add(panelTop);
            MinimumSize = new Size(800, 600);
            Name = "FormMain";
            Text = "Спринт 6 / Таск 6 / Вариант 1 / Голованов Д.О.";
            Load += Form1_Load;
            panelTop.ResumeLayout(false);
            panelTask.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panelValue.ResumeLayout(false);
            groupBoxValue.ResumeLayout(false);
            groupBoxValue.PerformLayout();
            panelResult.ResumeLayout(false);
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelTask;
        private GroupBox groupBoxTask;
        private Panel panelValue;
        private Panel panelResult;
        private Button buttonAbout;
        private Label labelTask;
        private GroupBox groupBoxValue;
        private TextBox textBoxValue;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
        private Button buttonDone;
        private Button buttonOpenFile;
        private ToolTip toolTip1;
        private OpenFileDialog openFileDialogTask;
    }
}
