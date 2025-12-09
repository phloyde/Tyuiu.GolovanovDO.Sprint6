namespace Tyuiu.GolovanovDO.Sprint6.Task7.V16
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
            buttonSaveFile = new Button();
            buttonDone = new Button();
            buttonOpenFile = new Button();
            buttonAbout = new Button();
            panelTask = new Panel();
            groupBoxTask = new GroupBox();
            labelTask = new Label();
            panelInt = new Panel();
            dataGridViewInMatrix = new DataGridView();
            panelOut = new Panel();
            dataGridViewOutMatrix = new DataGridView();
            splitter1 = new Splitter();
            openFileDialogTask = new OpenFileDialog();
            toolTipButton = new ToolTip(components);
            saveFileDialogMatrix = new SaveFileDialog();
            panelTop.SuspendLayout();
            panelTask.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panelInt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix).BeginInit();
            panelOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonSaveFile);
            panelTop.Controls.Add(buttonDone);
            panelTop.Controls.Add(buttonOpenFile);
            panelTop.Controls.Add(buttonAbout);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1182, 70);
            panelTop.TabIndex = 0;
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.Enabled = false;
            buttonSaveFile.Image = (Image)resources.GetObject("buttonSaveFile.Image");
            buttonSaveFile.Location = new Point(255, 7);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(94, 60);
            buttonSaveFile.TabIndex = 3;
            buttonSaveFile.UseVisualStyleBackColor = true;
            buttonSaveFile.Click += buttonSaveFile_Click;
            buttonSaveFile.MouseEnter += buttonSaveFile_MouseEnter;
            // 
            // buttonDone
            // 
            buttonDone.Enabled = false;
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(128, 4);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(108, 64);
            buttonDone.TabIndex = 2;
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.FlatStyle = FlatStyle.Flat;
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(3, 3);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(105, 65);
            buttonOpenFile.TabIndex = 1;
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            buttonOpenFile.MouseEnter += buttonOpenFile_MouseEnter;
            // 
            // buttonAbout
            // 
            buttonAbout.FlatStyle = FlatStyle.Flat;
            buttonAbout.Image = (Image)resources.GetObject("buttonAbout.Image");
            buttonAbout.Location = new Point(1085, 1);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(94, 67);
            buttonAbout.TabIndex = 0;
            buttonAbout.UseVisualStyleBackColor = true;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // panelTask
            // 
            panelTask.Controls.Add(groupBoxTask);
            panelTask.Dock = DockStyle.Top;
            panelTask.Location = new Point(0, 70);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(1182, 93);
            panelTask.TabIndex = 1;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Location = new Point(3, 4);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(1179, 86);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(9, 30);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(1162, 40);
            labelTask.TabIndex = 0;
            labelTask.Text = resources.GetString("labelTask.Text");
            // 
            // panelInt
            // 
            panelInt.Controls.Add(dataGridViewInMatrix);
            panelInt.Dock = DockStyle.Left;
            panelInt.Location = new Point(0, 163);
            panelInt.Name = "panelInt";
            panelInt.Size = new Size(592, 460);
            panelInt.TabIndex = 2;
            // 
            // dataGridViewInMatrix
            // 
            dataGridViewInMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInMatrix.Location = new Point(3, 3);
            dataGridViewInMatrix.Name = "dataGridViewInMatrix";
            dataGridViewInMatrix.RowHeadersVisible = false;
            dataGridViewInMatrix.RowHeadersWidth = 51;
            dataGridViewInMatrix.Size = new Size(586, 454);
            dataGridViewInMatrix.TabIndex = 0;
            // 
            // panelOut
            // 
            panelOut.Controls.Add(dataGridViewOutMatrix);
            panelOut.Controls.Add(splitter1);
            panelOut.Dock = DockStyle.Fill;
            panelOut.Location = new Point(592, 163);
            panelOut.Name = "panelOut";
            panelOut.Size = new Size(590, 460);
            panelOut.TabIndex = 3;
            // 
            // dataGridViewOutMatrix
            // 
            dataGridViewOutMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutMatrix.Location = new Point(16, 6);
            dataGridViewOutMatrix.Name = "dataGridViewOutMatrix";
            dataGridViewOutMatrix.RowHeadersVisible = false;
            dataGridViewOutMatrix.RowHeadersWidth = 51;
            dataGridViewOutMatrix.Size = new Size(571, 451);
            dataGridViewOutMatrix.TabIndex = 1;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 460);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 623);
            Controls.Add(panelOut);
            Controls.Add(panelInt);
            Controls.Add(panelTask);
            Controls.Add(panelTop);
            MinimumSize = new Size(1200, 670);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 / Таск 7 / Вариант 16 / Голованов Д.О.";
            Load += FormMain_Load;
            panelTop.ResumeLayout(false);
            panelTask.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panelInt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix).EndInit();
            panelOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelTask;
        private GroupBox groupBoxTask;
        private Panel panelInt;
        private Panel panelOut;
        private Splitter splitter1;
        private Button buttonAbout;
        private Label labelTask;
        private Button buttonOpenFile;
        private Button buttonDone;
        private Button buttonSaveFile;
        private DataGridView dataGridViewInMatrix;
        private DataGridView dataGridViewOutMatrix;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTipButton;
        private SaveFileDialog saveFileDialogMatrix;
    }
}
