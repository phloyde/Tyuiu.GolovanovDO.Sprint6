namespace Tyuiu.GolovanovDO.Sprint6.Task0.V22
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonStart = new Button();
            buttonInfo = new Button();
            groupBoxTask = new GroupBox();
            labelTask = new Label();
            pictureBoxTask = new PictureBox();
            groupBoxResult = new GroupBox();
            labelResult = new Label();
            textBoxResult = new TextBox();
            groupBoxValue = new GroupBox();
            labelValue = new Label();
            textBoxValue = new TextBox();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask).BeginInit();
            groupBoxResult.SuspendLayout();
            groupBoxValue.SuspendLayout();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(665, 379);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(110, 73);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Выполнить";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.FlatStyle = FlatStyle.Flat;
            buttonInfo.Location = new Point(581, 389);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(78, 59);
            buttonInfo.TabIndex = 1;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Controls.Add(pictureBoxTask);
            groupBoxTask.Location = new Point(12, 8);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(557, 273);
            groupBoxTask.TabIndex = 2;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(15, 28);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(257, 20);
            labelTask.TabIndex = 4;
            labelTask.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxTask
            // 
            pictureBoxTask.Image = (Image)resources.GetObject("pictureBoxTask.Image");
            pictureBoxTask.Location = new Point(278, 14);
            pictureBoxTask.Name = "pictureBoxTask";
            pictureBoxTask.Size = new Size(273, 62);
            pictureBoxTask.TabIndex = 3;
            pictureBoxTask.TabStop = false;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(labelResult);
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(608, 173);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(167, 200);
            groupBoxResult.TabIndex = 4;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных";
            groupBoxResult.Enter += groupBoxResult_Enter;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(14, 37);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(75, 20);
            labelResult.TabIndex = 1;
            labelResult.Text = "Результат";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 76);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(155, 27);
            textBoxResult.TabIndex = 0;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // groupBoxValue
            // 
            groupBoxValue.Controls.Add(labelValue);
            groupBoxValue.Controls.Add(textBoxValue);
            groupBoxValue.Location = new Point(12, 299);
            groupBoxValue.Name = "groupBoxValue";
            groupBoxValue.Size = new Size(336, 127);
            groupBoxValue.TabIndex = 6;
            groupBoxValue.TabStop = false;
            groupBoxValue.Text = "Ввод данных";
            groupBoxValue.Enter += groupBox1_Enter;
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Location = new Point(106, 23);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(111, 20);
            labelValue.TabIndex = 1;
            labelValue.Text = "Переменная X";
            labelValue.Click += labelValue_Click;
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(106, 56);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(125, 27);
            textBoxValue.TabIndex = 0;
            textBoxValue.TextChanged += textBox2_TextChanged;
            textBoxValue.KeyPress += TextBoxValue;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxValue);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxTask);
            Controls.Add(buttonInfo);
            Controls.Add(buttonStart);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 22 | Голованов Д.О.";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask).EndInit();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            groupBoxValue.ResumeLayout(false);
            groupBoxValue.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStart;
        private Button buttonInfo;
        private GroupBox groupBoxTask;
        private PictureBox pictureBoxTask;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
        private GroupBox groupBoxValue;
        private TextBox textBoxValue;
        private Label labelTask;
        private Label labelResult;
        private Label labelValue;
    }

}
