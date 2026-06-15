namespace Rechteck_Projekt
{
    partial class Second_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Second_Form));
            btnRechteckV = new Button();
            SuspendLayout();
            // 
            // btnRechteckV
            // 
            btnRechteckV.BackColor = SystemColors.HotTrack;
            btnRechteckV.ForeColor = SystemColors.HotTrack;
            btnRechteckV.Location = new Point(288, 156);
            btnRechteckV.Name = "btnRechteckV";
            btnRechteckV.Size = new Size(209, 87);
            btnRechteckV.TabIndex = 0;
            btnRechteckV.Text = "Rechteck";
            btnRechteckV.UseVisualStyleBackColor = false;
            // 
            // Second_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRechteckV);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Second_Form";
            Text = "Rechteck";
            ResumeLayout(false);
        }

        #endregion

        public Button btnRechteckV;
    }
}