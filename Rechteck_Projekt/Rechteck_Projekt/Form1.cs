namespace Rechteck_Projekt
{
    public partial class Form1 : Form
    {
        Rechteck rechteck = new Rechteck();
        double zoomFaktor;

        public Form1()
        {
            InitializeComponent();
        }

        private void tbxBreite_TextChanged(object sender, EventArgs e)
        {
            rechteck.Breite = Convert.ToDouble(tbxBreite.Text);
        }

        private void tbxHoehe_TextChanged(object sender, EventArgs e)
        {
            rechteck.Hoehe = Convert.ToDouble(tbxHoehe.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBestaetigen_Click(object sender, EventArgs e)
        {



            if (tbxBreite.ReadOnly == true)
            {
                rechteck.Breite = Convert.ToDouble(tbxBreite.Text);
                rechteck.Hoehe = Convert.ToDouble(tbxHoehe.Text);
                tbxBreite.ReadOnly = false;
                tbxHoehe.ReadOnly = false;
                btnBestaetigen.Text = "Bestätigen";
            }
            else
            {
                rechteck.Breite = Convert.ToDouble(tbxBreite.Text);
                rechteck.Hoehe = Convert.ToDouble(tbxHoehe.Text);
                tbxBreite.ReadOnly = true;
                tbxHoehe.ReadOnly = true;
                btnBestaetigen.Text = "Abbrechen";
            }
        }

        private void trbZoom_Scroll(object sender, EventArgs e)
        {

        }

        private void lblZoom_Click(object sender, EventArgs e)
        {

        }

        private void btnZoomMinus_Click(object sender, EventArgs e)
        {
            rechteck.zoom(true);
            tbxBreite.Text = rechteck.Breite.ToString();
            tbxHoehe.Text = rechteck.Hoehe.ToString();
        }

        private void btnZoomPlus_Click(object sender, EventArgs e)
        {
            rechteck.zoom(false);
            tbxBreite.Text = rechteck.Breite.ToString();
            tbxHoehe.Text = rechteck.Hoehe.ToString();
        }
    }
}
