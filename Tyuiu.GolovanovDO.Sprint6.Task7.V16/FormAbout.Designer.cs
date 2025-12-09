namespace Tyuiu.GolovanovDO.Sprint6.Task7.V16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            labelAbout = new Label();
            pictureBoxAbout = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout).BeginInit();
            SuspendLayout();
            // 
            // labelAbout
            // 
            labelAbout.AutoSize = true;
            labelAbout.Location = new Point(219, 9);
            labelAbout.Name = "labelAbout";
            labelAbout.Size = new Size(387, 260);
            labelAbout.TabIndex = 0;
            labelAbout.Text = resources.GetString("labelAbout.Text");
            // 
            // pictureBoxAbout
            // 
            pictureBoxAbout.Location = new Point(31, 12);
            pictureBoxAbout.Name = "pictureBoxAbout";
            pictureBoxAbout.Size = new Size(133, 184);
            pictureBoxAbout.TabIndex = 1;
            pictureBoxAbout.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 208);
            Controls.Add(pictureBoxAbout);
            Controls.Add(labelAbout);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAbout;
        private PictureBox pictureBoxAbout;
    }
}