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
            lblUmfang = new Label();
            btnZoomPlus = new Button();
            lblFlaecheninhalt = new Label();
            tbxHoehe = new TextBox();
            tbxUmfang = new TextBox();
            lblHoehe = new Label();
            tbxFlaecheninhalt = new TextBox();
            tbxBreite = new TextBox();
            lblZoom = new Label();
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
            btnRecheckt.Text = "Rechteck hier";
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
            // lblUmfang
            // 
            lblUmfang.AutoSize = true;
            lblUmfang.Location = new Point(21, 157);
            lblUmfang.Name = "lblUmfang";
            lblUmfang.Size = new Size(65, 20);
            lblUmfang.TabIndex = 8;
            lblUmfang.Text = "Umfang:";
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
            // lblFlaecheninhalt
            // 
            lblFlaecheninhalt.AutoSize = true;
            lblFlaecheninhalt.Location = new Point(20, 250);
            lblFlaecheninhalt.Name = "lblFlaecheninhalt";
            lblFlaecheninhalt.Size = new Size(99, 20);
            lblFlaecheninhalt.TabIndex = 9;
            lblFlaecheninhalt.Text = "Flächeninhalt:";
            // 
            // tbxHoehe
            // 
            tbxHoehe.Location = new Point(20, 90);
            tbxHoehe.Name = "tbxHoehe";
            tbxHoehe.Size = new Size(125, 27);
            tbxHoehe.TabIndex = 3;
            tbxHoehe.TextChanged += tbxHoehe_TextChanged;
            // 
            // tbxUmfang
            // 
            tbxUmfang.Location = new Point(20, 191);
            tbxUmfang.Name = "tbxUmfang";
            tbxUmfang.Size = new Size(125, 27);
            tbxUmfang.TabIndex = 10;
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
            // tbxFlaecheninhalt
            // 
            tbxFlaecheninhalt.Location = new Point(20, 273);
            tbxFlaecheninhalt.Name = "tbxFlaecheninhalt";
            tbxFlaecheninhalt.Size = new Size(125, 27);
            tbxFlaecheninhalt.TabIndex = 11;
            // 
            // tbxBreite
            // 
            tbxBreite.Location = new Point(20, 37);
            tbxBreite.Name = "tbxBreite";
            tbxBreite.Size = new Size(125, 27);
            tbxBreite.TabIndex = 0;
            tbxBreite.TextChanged += tbxBreite_TextChanged;
            // 
            // lblZoom
            // 
            lblZoom.AutoSize = true;
            lblZoom.Location = new Point(21, 342);
            lblZoom.Name = "lblZoom";
            lblZoom.Size = new Size(52, 20);
            lblZoom.TabIndex = 12;
            lblZoom.Text = "Zoom:";
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
            panel1.Controls.Add(lblZoom);
            panel1.Controls.Add(tbxBreite);
            panel1.Controls.Add(tbxFlaecheninhalt);
            panel1.Controls.Add(lblHoehe);
            panel1.Controls.Add(tbxUmfang);
            panel1.Controls.Add(tbxHoehe);
            panel1.Controls.Add(lblFlaecheninhalt);
            panel1.Controls.Add(btnZoomPlus);
            panel1.Controls.Add(lblUmfang);
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
        private Label lblUmfang;
        private Button btnZoomPlus;
        private Label lblFlaecheninhalt;
        private TextBox tbxHoehe;
        private TextBox tbxUmfang;
        private Label lblHoehe;
        private TextBox tbxFlaecheninhalt;
        private TextBox tbxBreite;
        private Label lblZoom;
        private Label lblBreite;
        private Button btnDrehen;
        private Panel panel1;
        private SplitContainer splitContainer1;
    }
}