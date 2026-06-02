namespace Rechteck_Projekt
{
    public partial class btnRechteck : Form
    {
        Rechteck rechteck = new Rechteck();
        double zoomFaktor;

        public btnRechteck()
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
