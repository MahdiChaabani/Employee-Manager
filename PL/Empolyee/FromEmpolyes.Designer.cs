namespace WinFormsAppManager.PL.Empolyee
{
    partial class F_Employee
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            Close = new Button();
            date = new DateTimePicker();
            clear = new Button();
            add = new Button();
            ed = new Button();
            del = new Button();
            txtnum = new TextBox();
            txtn = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Affiche_EMP = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            folderManagerToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Affiche_EMP).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Close);
            groupBox1.Controls.Add(date);
            groupBox1.Controls.Add(clear);
            groupBox1.Controls.Add(add);
            groupBox1.Controls.Add(ed);
            groupBox1.Controls.Add(del);
            groupBox1.Controls.Add(txtnum);
            groupBox1.Controls.Add(txtn);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(444, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(612, 283);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // Close
            // 
            Close.BackColor = Color.Maroon;
            Close.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Close.ForeColor = SystemColors.ControlLight;
            Close.Location = new Point(71, 208);
            Close.Name = "Close";
            Close.Size = new Size(458, 43);
            Close.TabIndex = 2;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = false;
            Close.Click += button5_Click;
            // 
            // date
            // 
            date.Location = new Point(226, 105);
            date.Name = "date";
            date.Size = new Size(286, 27);
            date.TabIndex = 1;
            // 
            // clear
            // 
            clear.BackColor = Color.DarkOrange;
            clear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear.ForeColor = SystemColors.Control;
            clear.Location = new Point(296, 155);
            clear.Name = "clear";
            clear.Size = new Size(118, 47);
            clear.TabIndex = 9;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = false;
            clear.Click += ad_Click;
            // 
            // add
            // 
            add.BackColor = Color.Green;
            add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add.ForeColor = SystemColors.Control;
            add.Location = new Point(411, 155);
            add.Name = "add";
            add.Size = new Size(118, 47);
            add.TabIndex = 8;
            add.Text = "Add";
            add.UseVisualStyleBackColor = false;
            add.Click += sav_Click;
            // 
            // ed
            // 
            ed.BackColor = SystemColors.HotTrack;
            ed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ed.ForeColor = SystemColors.Control;
            ed.Location = new Point(187, 155);
            ed.Name = "ed";
            ed.Size = new Size(118, 47);
            ed.TabIndex = 7;
            ed.Text = "Edit";
            ed.UseVisualStyleBackColor = false;
            ed.Click += ed_Click;
            // 
            // del
            // 
            del.BackColor = Color.Red;
            del.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            del.ForeColor = SystemColors.ButtonHighlight;
            del.Location = new Point(71, 155);
            del.Name = "del";
            del.Size = new Size(119, 47);
            del.TabIndex = 6;
            del.Text = "Delete";
            del.UseVisualStyleBackColor = false;
            del.Click += del_Click;
            // 
            // txtnum
            // 
            txtnum.Location = new Point(226, 66);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(286, 27);
            txtnum.TabIndex = 4;
            // 
            // txtn
            // 
            txtn.Location = new Point(226, 29);
            txtn.Name = "txtn";
            txtn.Size = new Size(286, 27);
            txtn.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(74, 105);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 2;
            label3.Text = "Hire Date :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(76, 70);
            label2.Name = "label2";
            label2.Size = new Size(140, 23);
            label2.TabIndex = 1;
            label2.Text = "Number Phone :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 33);
            label1.Name = "label1";
            label1.Size = new Size(67, 23);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // Affiche_EMP
            // 
            Affiche_EMP.AllowUserToAddRows = false;
            Affiche_EMP.BackgroundColor = SystemColors.Control;
            Affiche_EMP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Affiche_EMP.Location = new Point(2, 45);
            Affiche_EMP.Name = "Affiche_EMP";
            Affiche_EMP.RowHeadersWidth = 51;
            Affiche_EMP.Size = new Size(429, 559);
            Affiche_EMP.TabIndex = 1;
            Affiche_EMP.DoubleClick += Affiche_EMP_DoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(128, 128, 255);
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Items.AddRange(new ToolStripItem[] { folderManagerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 9);
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(1068, 36);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // folderManagerToolStripMenuItem
            // 
            folderManagerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1, signOutToolStripMenuItem, toolStripSeparator3, exitToolStripMenuItem });
            folderManagerToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            folderManagerToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            folderManagerToolStripMenuItem.Name = "folderManagerToolStripMenuItem";
            folderManagerToolStripMenuItem.Overflow = ToolStripItemOverflow.AsNeeded;
            folderManagerToolStripMenuItem.Size = new Size(53, 24);
            folderManagerToolStripMenuItem.Text = "Sign";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(153, 6);
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(156, 26);
            signOutToolStripMenuItem.Text = "Sign Out ";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(153, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(156, 26);
            exitToolStripMenuItem.Text = "Exit ";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // F_Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1068, 700);
            Controls.Add(menuStrip1);
            Controls.Add(Affiche_EMP);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "F_Employee";
            Text = "FromEmpolyes";
            Load += F_Employee_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Affiche_EMP).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Button clear;
        private Button add;
        private Button ed;
        private Button del;
        private TextBox txtnum;
        private TextBox txtn;
        private Label label3;
        private DateTimePicker date;
        private DataGridView Affiche_EMP;
        private Button Close;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem folderManagerToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}