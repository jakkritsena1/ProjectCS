namespace ProjectCS
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            mapToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            table1 = new DataGridView();
            table2 = new DataGridView();
            button1 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            button2 = new Button();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)table1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)table2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, mapToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1584, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // mapToolStripMenuItem
            // 
            mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            mapToolStripMenuItem.Size = new Size(48, 20);
            mapToolStripMenuItem.Text = "Maps";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(29, 56);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(87, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Starting VEs";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(122, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(70, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "New VEs";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(215, 56);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(76, 19);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "%Change";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 104);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 8;
            label1.Text = "Front New VEs-TPS vs RPM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(992, 104);
            label2.Name = "label2";
            label2.Size = new Size(144, 15);
            label2.TabIndex = 9;
            label2.Text = "Rear New VEs-TPS vs RPM";
            // 
            // table1
            // 
            table1.AllowUserToAddRows = false;
            table1.AllowUserToDeleteRows = false;
            table1.AllowUserToResizeColumns = false;
            table1.AllowUserToResizeRows = false;
            table1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table1.Location = new Point(42, 122);
            table1.Name = "table1";
            table1.ReadOnly = true;
            table1.RowHeadersWidth = 100;
            table1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            table1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            table1.Size = new Size(700, 550);
            table1.TabIndex = 10;
            // 
            // table2
            // 
            table2.AllowUserToAddRows = false;
            table2.AllowUserToDeleteRows = false;
            table2.AllowUserToResizeColumns = false;
            table2.AllowUserToResizeRows = false;
            table2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table2.Location = new Point(826, 122);
            table2.Name = "table2";
            table2.ReadOnly = true;
            table2.RowHeadersWidth = 100;
            table2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            table2.SelectionMode = DataGridViewSelectionMode.CellSelect;
            table2.Size = new Size(700, 550);
            table2.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(335, 701);
            button1.Name = "button1";
            button1.Size = new Size(102, 29);
            button1.TabIndex = 11;
            button1.Text = "Load Logs";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(452, 701);
            button2.Name = "button2";
            button2.Size = new Size(123, 29);
            button2.TabIndex = 13;
            button2.Text = "Update Starting VEs";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(42, 701);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(273, 29);
            progressBar1.TabIndex = 14;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 761);
            Controls.Add(progressBar1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(table2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(table1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)table1).EndInit();
            ((System.ComponentModel.ISupportInitialize)table2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem mapToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label1;
        private Label label2;
        private DataGridView table1;
        private DataGridView table2;
        private Button button1;
        private SaveFileDialog saveFileDialog1;
        private Button button2;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}
