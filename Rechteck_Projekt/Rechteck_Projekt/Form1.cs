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

        private void tbxIsEmpty(string tbx, bool isBreite)
        {
            if (!string.IsNullOrEmpty(tbx))
            {
                if (isBreite)
                {
                    rechteck.Breite = Convert.ToDouble(tbx);
                }
                else
                {
                    rechteck.Hoehe = Convert.ToDouble(tbx);
                }
            }
        }

        private void tbxBreite_TextChanged(object sender, EventArgs e)
        {
            tbxIsEmpty(tbxBreite.Text, true);
            if (!string.IsNullOrEmpty(tbxBreite.Text) && !string.IsNullOrEmpty(tbxHoehe.Text))
            {
                tbxUmfang.Text = Convert.ToString(rechteck.Umfang);
                tbxFlaecheninhalt.Text = Convert.ToString(rechteck.Flaeche);
            }
            else
            {
                tbxUmfang.Text = "";
                tbxFlaecheninhalt.Text = "";
            }

        }

        private void tbxHoehe_TextChanged(object sender, EventArgs e)
        {
            tbxIsEmpty(tbxHoehe.Text, false);
            if (!string.IsNullOrEmpty(tbxBreite.Text) && !string.IsNullOrEmpty(tbxHoehe.Text))
            {
                tbxUmfang.Text = Convert.ToString(rechteck.Umfang);
                tbxFlaecheninhalt.Text = Convert.ToString(rechteck.Flaeche);
            }
            else
            {
                tbxUmfang.Text = "";
                tbxFlaecheninhalt.Text = "";
            }
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

        private void btnDrehen_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxBreite.Text) && !string.IsNullOrEmpty(tbxHoehe.Text))
            {
                rechteck.Drehen();
                tbxBreite.Text = Convert.ToString(rechteck.Breite);
                tbxHoehe.Text = Convert.ToString(rechteck.Hoehe);
            }
        }

        private void tbxUmfang_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxFlaecheninhalt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
