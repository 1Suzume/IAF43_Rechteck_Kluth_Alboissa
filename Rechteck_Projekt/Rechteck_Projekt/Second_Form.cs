using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechteck_Projekt
{
    public partial class Second_Form : Form
    {
        private btnRechteck MainForm;
        public Second_Form()
        {
            InitializeComponent();
            //this.MainForm = MainForm;
        }


        //wenn der benutzer das fenster schließt, soll stattdessen das fenster 
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            //falls der schließen grund von user kommt
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //es wird gecancelt und sattdessen soll der Menu versteckt werden
                e.Cancel = true;
                this.Hide();
            }
        }

    }
}
