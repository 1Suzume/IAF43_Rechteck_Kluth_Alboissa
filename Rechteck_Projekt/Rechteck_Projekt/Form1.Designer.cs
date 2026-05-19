namespace Rechteck_Projekt
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
            tbxBreite = new TextBox();
            lblBreite = new Label();
            lblHoehe = new Label();
            tbxHoehe = new TextBox();
            btnBestaetigen = new Button();
            trbZoom = new TrackBar();
            lblZoom = new Label();
            ((System.ComponentModel.ISupportInitialize)trbZoom).BeginInit();
            SuspendLayout();
            // 
            // tbxBreite
            // 
            tbxBreite.Location = new Point(663, 32);
            tbxBreite.Name = "tbxBreite";
            tbxBreite.Size = new Size(125, 27);
            tbxBreite.TabIndex = 0;
            tbxBreite.TextChanged += tbxBreite_TextChanged;
            // 
            // lblBreite
            // 
            lblBreite.AutoSize = true;
            lblBreite.Location = new Point(663, 9);
            lblBreite.Name = "lblBreite";
            lblBreite.Size = new Size(51, 20);
            lblBreite.TabIndex = 1;
            lblBreite.Text = "Breite:";
            // 
            // lblHoehe
            // 
            lblHoehe.AutoSize = true;
            lblHoehe.Location = new Point(664, 62);
            lblHoehe.Name = "lblHoehe";
            lblHoehe.Size = new Size(48, 20);
            lblHoehe.TabIndex = 2;
            lblHoehe.Text = "Höhe:";
            // 
            // tbxHoehe
            // 
            tbxHoehe.Location = new Point(663, 85);
            tbxHoehe.Name = "tbxHoehe";
            tbxHoehe.Size = new Size(125, 27);
            tbxHoehe.TabIndex = 3;
            tbxHoehe.TextChanged += tbxHoehe_TextChanged;
            // 
            // btnBestaetigen
            // 
            btnBestaetigen.Location = new Point(663, 140);
            btnBestaetigen.Name = "btnBestaetigen";
            btnBestaetigen.Size = new Size(124, 35);
            btnBestaetigen.TabIndex = 4;
            btnBestaetigen.Text = "Bestätigen";
            btnBestaetigen.UseVisualStyleBackColor = true;
            btnBestaetigen.Click += btnBestaetigen_Click;
            // 
            // trbZoom
            // 
            trbZoom.AllowDrop = true;
            trbZoom.Location = new Point(663, 238);
            trbZoom.Minimum = -10;
            trbZoom.Name = "trbZoom";
            trbZoom.Size = new Size(130, 56);
            trbZoom.TabIndex = 5;
            trbZoom.Scroll += trbZoom_Scroll;
            // 
            // lblZoom
            // 
            lblZoom.AutoSize = true;
            lblZoom.Location = new Point(663, 188);
            lblZoom.Name = "lblZoom";
            lblZoom.Size = new Size(75, 20);
            lblZoom.TabIndex = 6;
            lblZoom.Text = "Zoom = 0";
            lblZoom.Click += lblZoom_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblZoom);
            Controls.Add(trbZoom);
            Controls.Add(btnBestaetigen);
            Controls.Add(tbxHoehe);
            Controls.Add(lblHoehe);
            Controls.Add(lblBreite);
            Controls.Add(tbxBreite);
            Name = "Form1";
            Text = "frmRechteck";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trbZoom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxBreite;
        private Label lblBreite;
        private Label lblHoehe;
        private TextBox tbxHoehe;
        private Button btnBestaetigen;
        private TrackBar trbZoom;
        private Label lblZoom;
    }
}
