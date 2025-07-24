namespace WinFormsAppManager.PL
{
    partial class FormApp
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
            SuspendLayout();
            // 
            // FormApp
            // 
            AutoScaleDimensions = new SizeF(16F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(822, 608);
            Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 3, 7, 3);
            Name = "FormApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manager Application ";
            WindowState = FormWindowState.Maximized;
           
            ResumeLayout(false);
        }

        #endregion
    }
}