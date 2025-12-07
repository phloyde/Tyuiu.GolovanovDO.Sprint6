namespace Tyuiu.GolovanovDO.Sprint6.Task4.V22
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxTask = new GroupBox();
            labelTask = new Label();
            groupBoxValue = new GroupBox();
            labelStop = new Label();
            labelStart = new Label();
            textBoxStop = new TextBox();
            textBoxStart = new TextBox();
            groupBoxResult = new GroupBox();
            chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxResult = new TextBox();
            buttonDone = new Button();
            buttonSave = new Button();
            groupBoxTask.SuspendLayout();
            groupBoxValue.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Location = new Point(5, 4);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(382, 123);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(6, 23);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(365, 100);
            labelTask.TabIndex = 0;
            labelTask.Text = "Протабулировать функцию на заданном диапазон\r\nРезультат вывести в textbox, построить график и \r\nсохранить в файл.\r\n\r\n\r\n";
            // 
            // groupBoxValue
            // 
            groupBoxValue.Controls.Add(labelStop);
            groupBoxValue.Controls.Add(labelStart);
            groupBoxValue.Controls.Add(textBoxStop);
            groupBoxValue.Controls.Add(textBoxStart);
            groupBoxValue.Location = new Point(393, 14);
            groupBoxValue.Name = "groupBoxValue";
            groupBoxValue.Size = new Size(241, 113);
            groupBoxValue.TabIndex = 1;
            groupBoxValue.TabStop = false;
            groupBoxValue.Text = "Ввод данных";
            // 
            // labelStop
            // 
            labelStop.AutoSize = true;
            labelStop.Location = new Point(127, 32);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(94, 20);
            labelStop.TabIndex = 3;
            labelStop.Text = "Конец шага:";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(9, 32);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(88, 20);
            labelStart.TabIndex = 2;
            labelStart.Text = "Старт шага:";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(127, 61);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(94, 27);
            textBoxStop.TabIndex = 1;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(9, 61);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(88, 27);
            textBoxStart.TabIndex = 0;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(chartResult);
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(12, 133);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(1125, 403);
            groupBoxResult.TabIndex = 2;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод";
            // 
            // chartResult
            // 
            chartArea3.Name = "ChartArea1";
            chartResult.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartResult.Legends.Add(legend3);
            chartResult.Location = new Point(390, 22);
            chartResult.Name = "chartResult";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartResult.Series.Add(series3);
            chartResult.Size = new Size(727, 375);
            chartResult.TabIndex = 5;
            chartResult.Text = "chart1";
            title3.Name = "Title1";
            title3.Text = "График функции ";
            chartResult.Titles.Add(title3);
            chartResult.Click += chartResult_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(11, 35);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(358, 362);
            textBoxResult.TabIndex = 0;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone.Location = new Point(640, 36);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(100, 79);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Blue;
            buttonSave.Location = new Point(746, 36);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 79);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 653);
            Controls.Add(buttonSave);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxValue);
            Controls.Add(groupBoxTask);
            MinimumSize = new Size(1000, 700);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 / Таск 4 / Вариант 22 / Голованов Д. О.";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxValue.ResumeLayout(false);
            groupBoxValue.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private Label labelTask;
        private GroupBox groupBoxValue;
        private TextBox textBoxStop;
        private TextBox textBoxStart;
        private Label labelStop;
        private Label labelStart;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
        private Button buttonDone;
        private Button buttonSave;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
    }
}
