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
            tbxBreite = new TextBox();
            lblBreite = new Label();
            lblHoehe = new Label();
            tbxHoehe = new TextBox();
            btnZoomPlus = new Button();
            btnZoomMinus = new Button();
            lblUmfang = new Label();
            lblFlaecheninhalt = new Label();
            tbxUmfang = new TextBox();
            tbxFlaecheninhalt = new TextBox();
            lblZoom = new Label();
            btnDrehen = new Button();
            btnVisual = new Button();
            SuspendLayout();
            // 
            // tbxBreite
            // 
            tbxBreite.Location = new Point(12, 32);
            tbxBreite.Name = "tbxBreite";
            tbxBreite.Size = new Size(125, 27);
            tbxBreite.TabIndex = 0;
            tbxBreite.TextChanged += tbxBreite_TextChanged;
            // 
            // lblBreite
            // 
            lblBreite.AutoSize = true;
            lblBreite.Location = new Point(12, 9);
            lblBreite.Name = "lblBreite";
            lblBreite.Size = new Size(51, 20);
            lblBreite.TabIndex = 1;
            lblBreite.Text = "Breite:";
            // 
            // lblHoehe
            // 
            lblHoehe.AutoSize = true;
            lblHoehe.Location = new Point(13, 62);
            lblHoehe.Name = "lblHoehe";
            lblHoehe.Size = new Size(48, 20);
            lblHoehe.TabIndex = 2;
            lblHoehe.Text = "Höhe:";
            // 
            // tbxHoehe
            // 
            tbxHoehe.Location = new Point(12, 85);
            tbxHoehe.Name = "tbxHoehe";
            tbxHoehe.Size = new Size(125, 27);
            tbxHoehe.TabIndex = 3;
            tbxHoehe.TextChanged += tbxHoehe_TextChanged;
            // 
            // btnZoomPlus
            // 
            btnZoomPlus.Location = new Point(13, 360);
            btnZoomPlus.Name = "btnZoomPlus";
            btnZoomPlus.Size = new Size(55, 47);
            btnZoomPlus.TabIndex = 5;
            btnZoomPlus.Text = "+";
            btnZoomPlus.UseVisualStyleBackColor = true;
            btnZoomPlus.Click += btnZoomPlus_Click;
            // 
            // btnZoomMinus
            // 
            btnZoomMinus.Location = new Point(82, 360);
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
            lblUmfang.Location = new Point(13, 152);
            lblUmfang.Name = "lblUmfang";
            lblUmfang.Size = new Size(65, 20);
            lblUmfang.TabIndex = 8;
            lblUmfang.Text = "Umfang:";
            // 
            // lblFlaecheninhalt
            // 
            lblFlaecheninhalt.AutoSize = true;
            lblFlaecheninhalt.Location = new Point(12, 245);
            lblFlaecheninhalt.Name = "lblFlaecheninhalt";
            lblFlaecheninhalt.Size = new Size(99, 20);
            lblFlaecheninhalt.TabIndex = 9;
            lblFlaecheninhalt.Text = "Flächeninhalt:";
            // 
            // tbxUmfang
            // 
            tbxUmfang.Location = new Point(12, 186);
            tbxUmfang.Name = "tbxUmfang";
            tbxUmfang.Size = new Size(125, 27);
            tbxUmfang.TabIndex = 10;
            tbxUmfang.TextChanged += tbxUmfang_TextChanged;
            // 
            // tbxFlaecheninhalt
            // 
            tbxFlaecheninhalt.Location = new Point(12, 268);
            tbxFlaecheninhalt.Name = "tbxFlaecheninhalt";
            tbxFlaecheninhalt.Size = new Size(125, 27);
            tbxFlaecheninhalt.TabIndex = 11;
            tbxFlaecheninhalt.TextChanged += tbxFlaecheninhalt_TextChanged;
            // 
            // lblZoom
            // 
            lblZoom.AutoSize = true;
            lblZoom.Location = new Point(13, 337);
            lblZoom.Name = "lblZoom";
            lblZoom.Size = new Size(52, 20);
            lblZoom.TabIndex = 12;
            lblZoom.Text = "Zoom:";
            // 
            // btnDrehen
            // 
            btnDrehen.Location = new Point(13, 437);
            btnDrehen.Name = "btnDrehen";
            btnDrehen.Size = new Size(124, 40);
            btnDrehen.TabIndex = 14;
            btnDrehen.Text = "Drehen";
            btnDrehen.UseVisualStyleBackColor = true;
            btnDrehen.Click += btnDrehen_Click;
            // 
            // btnVisual
            // 
            btnVisual.Location = new Point(12, 493);
            btnVisual.Name = "btnVisual";
            btnVisual.Size = new Size(203, 59);
            btnVisual.TabIndex = 15;
            btnVisual.Text = "Visualisierung";
            btnVisual.UseVisualStyleBackColor = true;
            btnVisual.Click += btnVisual_Click;
            // 
            // btnRechteck
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 555);
            Controls.Add(btnVisual);
            Controls.Add(btnDrehen);
            Controls.Add(lblZoom);
            Controls.Add(tbxFlaecheninhalt);
            Controls.Add(tbxUmfang);
            Controls.Add(lblFlaecheninhalt);
            Controls.Add(lblUmfang);
            Controls.Add(btnZoomMinus);
            Controls.Add(btnZoomPlus);
            Controls.Add(tbxHoehe);
            Controls.Add(lblHoehe);
            Controls.Add(lblBreite);
            Controls.Add(tbxBreite);
            Name = "btnRechteck";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxBreite;
        private Label lblBreite;
        private Label lblHoehe;
        private TextBox tbxHoehe;
        private Button btnZoomPlus;
        private Button btnZoomMinus;
        private Label lblUmfang;
        private Label lblFlaecheninhalt;
        private TextBox tbxUmfang;
        private TextBox tbxFlaecheninhalt;
        private Label lblZoom;
        private Button btnDrehen;
        private Button btnVisual;
    }
}
