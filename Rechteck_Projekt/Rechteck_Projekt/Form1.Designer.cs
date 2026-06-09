namespace Rechteck_Projekt
{
    partial class btnRechteck
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
            btnRecheckt = new Button();
            btnZoomMinus = new Button();
            label1 = new Label();
            btnZoomPlus = new Button();
            label2 = new Label();
            tbxHoehe = new TextBox();
            textBox1 = new TextBox();
            lblHoehe = new Label();
            textBox2 = new TextBox();
            tbxBreite = new TextBox();
            label3 = new Label();
            lblBreite = new Label();
            btnDrehen = new Button();
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRecheckt
            // 
            btnRecheckt.Location = new Point(275, 126);
            btnRecheckt.Name = "btnRecheckt";
            btnRecheckt.Size = new Size(254, 174);
            btnRecheckt.TabIndex = 7;
            btnRecheckt.Text = "Recheck hier";
            btnRecheckt.UseVisualStyleBackColor = true;
            // 
            // btnZoomMinus
            // 
            btnZoomMinus.Location = new Point(90, 365);
            btnZoomMinus.Name = "btnZoomMinus";
            btnZoomMinus.Size = new Size(55, 47);
            btnZoomMinus.TabIndex = 6;
            btnZoomMinus.Text = "-";
            btnZoomMinus.UseVisualStyleBackColor = true;
            btnZoomMinus.Click += btnZoomMinus_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 157);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 8;
            label1.Text = "Umfang:";
            // 
            // btnZoomPlus
            // 
            btnZoomPlus.Location = new Point(21, 365);
            btnZoomPlus.Name = "btnZoomPlus";
            btnZoomPlus.Size = new Size(55, 47);
            btnZoomPlus.TabIndex = 5;
            btnZoomPlus.Text = "+";
            btnZoomPlus.UseVisualStyleBackColor = true;
            btnZoomPlus.Click += btnZoomPlus_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 250);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 9;
            label2.Text = "Flächeninhalt:";
            // 
            // tbxHoehe
            // 
            tbxHoehe.Location = new Point(20, 90);
            tbxHoehe.Name = "tbxHoehe";
            tbxHoehe.Size = new Size(125, 27);
            tbxHoehe.TabIndex = 3;
            tbxHoehe.TextChanged += tbxHoehe_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 191);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 10;
            // 
            // lblHoehe
            // 
            lblHoehe.AutoSize = true;
            lblHoehe.Location = new Point(21, 67);
            lblHoehe.Name = "lblHoehe";
            lblHoehe.Size = new Size(48, 20);
            lblHoehe.TabIndex = 2;
            lblHoehe.Text = "Höhe:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(20, 273);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 11;
            // 
            // tbxBreite
            // 
            tbxBreite.Location = new Point(20, 37);
            tbxBreite.Name = "tbxBreite";
            tbxBreite.Size = new Size(125, 27);
            tbxBreite.TabIndex = 0;
            tbxBreite.TextChanged += tbxBreite_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 342);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 12;
            label3.Text = "Zoom:";
            // 
            // lblBreite
            // 
            lblBreite.AutoSize = true;
            lblBreite.Location = new Point(20, 14);
            lblBreite.Name = "lblBreite";
            lblBreite.Size = new Size(51, 20);
            lblBreite.TabIndex = 1;
            lblBreite.Text = "Breite:";
            // 
            // btnDrehen
            // 
            btnDrehen.Location = new Point(21, 442);
            btnDrehen.Name = "btnDrehen";
            btnDrehen.Size = new Size(124, 40);
            btnDrehen.TabIndex = 14;
            btnDrehen.Text = "Drehen";
            btnDrehen.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(btnDrehen);
            panel1.Controls.Add(lblBreite);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbxBreite);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(lblHoehe);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(tbxHoehe);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnZoomPlus);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnZoomMinus);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 561);
            panel1.TabIndex = 15;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.ButtonHighlight;
            splitContainer1.Panel2.Controls.Add(btnRecheckt);
            splitContainer1.Size = new Size(1159, 561);
            splitContainer1.SplitterDistance = 210;
            splitContainer1.TabIndex = 16;
            // 
            // btnRechteck
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 561);
            Controls.Add(splitContainer1);
            Name = "btnRechteck";
            Text = "frmRechteck";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnRecheckt;
        private Button btnZoomMinus;
        private Label label1;
        private Button btnZoomPlus;
        private Label label2;
        private TextBox tbxHoehe;
        private TextBox textBox1;
        private Label lblHoehe;
        private TextBox textBox2;
        private TextBox tbxBreite;
        private Label label3;
        private Label lblBreite;
        private Button btnDrehen;
        private Panel panel1;
        private SplitContainer splitContainer1;
    }
}
