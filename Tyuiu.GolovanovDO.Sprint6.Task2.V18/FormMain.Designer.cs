namespace Tyuiu.GolovanovDO.Sprint6.Task2.V18
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask = new GroupBox();
            labelTask = new Label();
            groupBoxValue = new GroupBox();
            labelStop = new Label();
            labelStart = new Label();
            textBoxStop = new TextBox();
            textBoxStart = new TextBox();
            groupBoxResult = new GroupBox();
            chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewResult = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            labelResult = new Label();
            buttonDone = new Button();
            buttonMoreInfo = new Button();
            groupBoxTask.SuspendLayout();
            groupBoxValue.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(391, 186);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(14, 24);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(376, 60);
            labelTask.TabIndex = 0;
            labelTask.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести DataGridView\r\nПостроить график функции\r\n";
            // 
            // groupBoxValue
            // 
            groupBoxValue.Controls.Add(labelStop);
            groupBoxValue.Controls.Add(labelStart);
            groupBoxValue.Controls.Add(textBoxStop);
            groupBoxValue.Controls.Add(textBoxStart);
            groupBoxValue.Location = new Point(12, 229);
            groupBoxValue.Name = "groupBoxValue";
            groupBoxValue.Size = new Size(321, 209);
            groupBoxValue.TabIndex = 1;
            groupBoxValue.TabStop = false;
            groupBoxValue.Text = "Ввод данных";
            // 
            // labelStop
            // 
            labelStop.AutoSize = true;
            labelStop.Location = new Point(180, 80);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(94, 20);
            labelStop.TabIndex = 3;
            labelStop.Text = "Конец шага:";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(17, 80);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(102, 20);
            labelStart.TabIndex = 2;
            labelStart.Text = "Начало шага:";
            labelStart.Click += labelStart_Click;
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(180, 132);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(125, 27);
            textBoxStop.TabIndex = 1;
            textBoxStop.TextChanged += textBoxStop_TextChanged;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(17, 132);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 0;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(chartResult);
            groupBoxResult.Controls.Add(dataGridViewResult);
            groupBoxResult.Controls.Add(labelResult);
            groupBoxResult.Location = new Point(432, 12);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(839, 438);
            groupBoxResult.TabIndex = 2;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных";
            // 
            // chartResult
            // 
            chartArea1.Name = "ChartArea1";
            chartResult.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartResult.Legends.Add(legend1);
            chartResult.Location = new Point(260, 60);
            chartResult.Name = "chartResult";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult.Series.Add(series1);
            chartResult.Size = new Size(563, 366);
            chartResult.TabIndex = 2;
            chartResult.Text = "chart1";
            chartResult.Click += chartResult_Click;
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewResult.Location = new Point(20, 60);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.RowHeadersWidth = 51;
            dataGridViewResult.Size = new Size(234, 372);
            dataGridViewResult.TabIndex = 1;
            dataGridViewResult.CellContentClick += dataGridView1_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 125;
            // 
            // Y
            // 
            Y.HeaderText = "F(x)";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.Width = 125;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(6, 23);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(78, 20);
            labelResult.TabIndex = 0;
            labelResult.Text = "Результат:";
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(339, 352);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(87, 86);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonMoreInfo
            // 
            buttonMoreInfo.Location = new Point(339, 240);
            buttonMoreInfo.Name = "buttonMoreInfo";
            buttonMoreInfo.Size = new Size(87, 89);
            buttonMoreInfo.TabIndex = 4;
            buttonMoreInfo.Text = "?";
            buttonMoreInfo.UseVisualStyleBackColor = true;
            buttonMoreInfo.Click += buttonMoreInfo_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 450);
            Controls.Add(buttonMoreInfo);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxValue);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 18 | Голованов Д.О.";
            Load += Form1_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxValue.ResumeLayout(false);
            groupBoxValue.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private GroupBox groupBoxValue;
        private GroupBox groupBoxResult;
        private Button buttonDone;
        private Button buttonMoreInfo;
        private Label labelStop;
        private Label labelStart;
        private TextBox textBoxStop;
        private TextBox textBoxStart;
        private DataGridView dataGridViewResult;
        private Label labelResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private Label labelTask;
    }
}
