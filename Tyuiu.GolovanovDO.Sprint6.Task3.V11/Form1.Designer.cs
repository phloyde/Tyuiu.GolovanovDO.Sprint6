namespace Tyuiu.GolovanovDO.Sprint6.Task3.V11
{
    partial class Form1
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
            groupBoxTask = new GroupBox();
            labelTask = new Label();
            groupBoxResult = new GroupBox();
            dataGridViewResult = new DataGridView();
            buttonDone = new Button();
            groupBoxTask.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Location = new Point(13, 8);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(444, 395);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(16, 29);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(422, 140);
            labelTask.TabIndex = 0;
            labelTask.Text = "Дан массив 5 на 5 элементов.\r\nВыполнить сортировку по возрастанию в первом столбце.\r\n  27 -15  14   2  27\r\n  -8  14 -10  33   0\r\n   1   7 -11 -11   23\r\n -13 -20  15 -16  34\r\n   -3   1  -1   5   1";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(dataGridViewResult);
            groupBoxResult.Location = new Point(488, 20);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(460, 383);
            groupBoxResult.TabIndex = 1;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Location = new Point(23, 42);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.RowHeadersWidth = 51;
            dataGridViewResult.Size = new Size(352, 284);
            dataGridViewResult.TabIndex = 0;
            dataGridViewResult.CellContentClick += dataGridViewResult_CellContentClick;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone.Location = new Point(988, 46);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(126, 92);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 450);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxTask);
            Name = "Form1";
            Text = "Спринт 6 | Таск 3 | Вариант 11 | Голованов Д.О. ";
            Load += Form1_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private Label labelTask;
        private GroupBox groupBoxResult;
        private DataGridView dataGridViewResult;
        private Button buttonDone;
    }
}
