namespace Tyuiu.GolovanovDO.Sprint6.Task5.V1
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
            panelTop = new Panel();
            buttonOpen = new Button();
            buttonDone = new Button();
            groupBoxTask = new GroupBox();
            labelTask = new Label();
            panelLeft = new Panel();
            groupBoxResult = new GroupBox();
            dataGridViewResult = new DataGridView();
            panelFill = new Panel();
            chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panelTop.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panelLeft.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonOpen);
            panelTop.Controls.Add(buttonDone);
            panelTop.Controls.Add(groupBoxTask);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1129, 140);
            panelTop.TabIndex = 0;
            // 
            // buttonOpen
            // 
            buttonOpen.BackColor = Color.FromArgb(0, 192, 192);
            buttonOpen.Location = new Point(710, 37);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(111, 82);
            buttonOpen.TabIndex = 2;
            buttonOpen.Text = "Открыть файл";
            buttonOpen.UseVisualStyleBackColor = false;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone.Location = new Point(580, 31);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(107, 88);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(531, 125);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(11, 25);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(513, 60);
            labelTask.TabIndex = 0;
            labelTask.Text = "Прочитать данные из файла InPutFileTask5V1.txt. Вывести в dataGridView.\r\nВывести все положительные числа.\r\nПостроить диаграмму по этим значениям.";
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(groupBoxResult);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 140);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(250, 543);
            panelLeft.TabIndex = 1;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(dataGridViewResult);
            groupBoxResult.Location = new Point(0, 10);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(250, 521);
            groupBoxResult.TabIndex = 0;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.ColumnHeadersVisible = false;
            dataGridViewResult.Location = new Point(3, 26);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.RowHeadersWidth = 51;
            dataGridViewResult.Size = new Size(241, 442);
            dataGridViewResult.TabIndex = 0;
            dataGridViewResult.CellContentClick += dataGridViewResult_CellContentClick;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(chartResult);
            panelFill.Controls.Add(splitter1);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(250, 140);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(879, 543);
            panelFill.TabIndex = 2;
            // 
            // chartResult
            // 
            chartArea1.Name = "ChartArea1";
            chartResult.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartResult.Legends.Add(legend1);
            chartResult.Location = new Point(48, 10);
            chartResult.Name = "chartResult";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult.Series.Add(series1);
            chartResult.Size = new Size(819, 468);
            chartResult.TabIndex = 1;
            chartResult.Click += chartResult_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(23, 543);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 683);
            Controls.Add(panelFill);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            MinimumSize = new Size(1000, 730);
            Name = "FormMain";
            Text = "Спринт 6 Таск 5 Вариант 1 Голованов Д.О.";
            Load += Form1_Load;
            panelTop.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panelLeft.ResumeLayout(false);
            groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private GroupBox groupBoxTask;
        private Label labelTask;
        private Panel panelLeft;
        private GroupBox groupBoxResult;
        private Panel panelFill;
        private Splitter splitter1;
        private Button buttonOpen;
        private Button buttonDone;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
        private DataGridView dataGridViewResult;
    }
}
