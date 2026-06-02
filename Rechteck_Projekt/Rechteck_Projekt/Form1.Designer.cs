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
            btnRecheckt = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
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
            // btnZoomPlus
            // 
            btnZoomPlus.Location = new Point(664, 360);
            btnZoomPlus.Name = "btnZoomPlus";
            btnZoomPlus.Size = new Size(55, 47);
            btnZoomPlus.TabIndex = 5;
            btnZoomPlus.Text = "+";
            btnZoomPlus.UseVisualStyleBackColor = true;
            btnZoomPlus.Click += btnZoomPlus_Click;
            // 
            // btnZoomMinus
            // 
            btnZoomMinus.Location = new Point(733, 360);
            btnZoomMinus.Name = "btnZoomMinus";
            btnZoomMinus.Size = new Size(55, 47);
            btnZoomMinus.TabIndex = 6;
            btnZoomMinus.Text = "-";
            btnZoomMinus.UseVisualStyleBackColor = true;
            btnZoomMinus.Click += btnZoomMinus_Click;
            // 
            // btnRecheckt
            // 
            btnRecheckt.Location = new Point(119, 121);
            btnRecheckt.Name = "btnRecheckt";
            btnRecheckt.Size = new Size(254, 174);
            btnRecheckt.TabIndex = 7;
            btnRecheckt.Text = "Recheck hier";
            btnRecheckt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(664, 152);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 8;
            label1.Text = "Umfang:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(663, 245);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 9;
            label2.Text = "Flächeninhalt:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(663, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(663, 268);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(664, 337);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 12;
            label3.Text = "Zoom:";
            // 
            // button1
            // 
            button1.Location = new Point(664, 437);
            button1.Name = "button1";
            button1.Size = new Size(124, 40);
            button1.TabIndex = 14;
            button1.Text = "Drehen";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnRechteck
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 738);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRecheckt);
            Controls.Add(btnZoomMinus);
            Controls.Add(btnZoomPlus);
            Controls.Add(tbxHoehe);
            Controls.Add(lblHoehe);
            Controls.Add(lblBreite);
            Controls.Add(tbxBreite);
            Name = "btnRechteck";
            Text = "frmRechteck";
            Load += Form1_Load;
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
        private Button btnRecheckt;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
    }
}
