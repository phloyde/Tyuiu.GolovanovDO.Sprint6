namespace Tyuiu.GolovanovDO.Sprint6.Task6.V1
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelAbout = new Label();
            buttonOK = new Button();
            SuspendLayout();
            // 
            // labelAbout
            // 
            labelAbout.AutoSize = true;
            labelAbout.Location = new Point(12, 9);
            labelAbout.Name = "labelAbout";
            labelAbout.Size = new Size(387, 60);
            labelAbout.TabIndex = 0;
            labelAbout.Text = "Разработчик: Голованов Данила Олегович\r\nГруппа: ПИНб-25-1\r\nПрограмма разработана в рамках изучения языка C#\r\n";
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(356, 124);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 29);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += this.buttonOK_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 162);
            Controls.Add(buttonOK);
            Controls.Add(labelAbout);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAbout;
        private Button buttonOK;
    }
}