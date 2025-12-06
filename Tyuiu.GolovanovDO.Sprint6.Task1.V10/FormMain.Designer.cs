namespace Tyuiu.GolovanovDO.Sprint6.Task1.V10_
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
            groupBoxTask = new GroupBox();
            labelTask = new Label();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            groupBoxValue = new GroupBox();
            textBoxStart = new TextBox();
            textBoxStop = new TextBox();
            labelStart = new Label();
            labelStop = new Label();
            buttonMoreInfo = new Button();
            buttonDone = new Button();
            labelResult = new Label();
            groupBoxTask.SuspendLayout();
            groupBoxResult.SuspendLayout();
            groupBoxValue.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(460, 239);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(21, 39);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(373, 40);
            labelTask.TabIndex = 0;
            labelTask.Text = "Протабулировать функцию на заданном диапазоне\r\nПолученный результат вывести ввиде таблицы.";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(labelResult);
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(538, 12);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(250, 426);
            groupBoxResult.TabIndex = 1;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(0, 55);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(250, 371);
            textBoxResult.TabIndex = 0;
            // 
            // groupBoxValue
            // 
            groupBoxValue.Controls.Add(labelStop);
            groupBoxValue.Controls.Add(labelStart);
            groupBoxValue.Controls.Add(textBoxStop);
            groupBoxValue.Controls.Add(textBoxStart);
            groupBoxValue.Location = new Point(12, 285);
            groupBoxValue.Name = "groupBoxValue";
            groupBoxValue.Size = new Size(346, 125);
            groupBoxValue.TabIndex = 2;
            groupBoxValue.TabStop = false;
            groupBoxValue.Text = "Ввод данных";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 73);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 0;
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(215, 73);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(125, 27);
            textBoxStop.TabIndex = 1;
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(6, 35);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(88, 20);
            labelStart.TabIndex = 2;
            labelStart.Text = "Старт шага:";
            // 
            // labelStop
            // 
            labelStop.AutoSize = true;
            labelStop.Location = new Point(215, 35);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(94, 20);
            labelStop.TabIndex = 3;
            labelStop.Text = "Конец шага:";
            // 
            // buttonMoreInfo
            // 
            buttonMoreInfo.BackColor = Color.Blue;
            buttonMoreInfo.Location = new Point(400, 272);
            buttonMoreInfo.Name = "buttonMoreInfo";
            buttonMoreInfo.Size = new Size(94, 68);
            buttonMoreInfo.TabIndex = 3;
            buttonMoreInfo.Text = "Справка";
            buttonMoreInfo.UseVisualStyleBackColor = false;
            buttonMoreInfo.Click += this.buttonMoreInfo_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.LimeGreen;
            buttonDone.Location = new Point(391, 346);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(113, 80);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += this.buttonDone_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(6, 32);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(78, 20);
            labelResult.TabIndex = 1;
            labelResult.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone);
            Controls.Add(buttonMoreInfo);
            Controls.Add(groupBoxValue);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 10 | Голованов Д.О.";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            groupBoxValue.ResumeLayout(false);
            groupBoxValue.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private Label labelTask;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
        private GroupBox groupBoxValue;
        private Label labelStop;
        private Label labelStart;
        private TextBox textBoxStop;
        private TextBox textBoxStart;
        private Button buttonMoreInfo;
        private Button buttonDone;
        private Label labelResult;
    }
}
