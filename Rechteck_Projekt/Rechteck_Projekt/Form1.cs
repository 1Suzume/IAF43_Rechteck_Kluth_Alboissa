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

        }

        private void tbxHoehe_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBestaetigen_Click(object sender, EventArgs e)
        {
            
            rechteck.Breite = Convert.ToDouble(tbxBreite.Text);
            rechteck.Hoehe = Convert.ToDouble(tbxHoehe.Text);
            if (tbxBreite.ReadOnly == true)
            {
                tbxBreite.ReadOnly = false;
                tbxHoehe.ReadOnly = false;
                btnBestaetigen.Text = "Bestätigen";
            }
            else
            {
                tbxBreite.ReadOnly= true;
                tbxHoehe.ReadOnly= true;
                btnBestaetigen.Text = "Abbrechen";
            }
            
        }

        private void trbZoom_Scroll(object sender, EventArgs e)
        {
            
            
            
            
            lblZoom.Text = $"Zoom = {trbZoom.Value.ToString()}";
            zoomFaktor = 1 + (trbZoom.Value / 10.0);
            tbxBreite.Text = Convert.ToString(rechteck.Breite * zoomFaktor);
            tbxHoehe.Text = Convert.ToString(rechteck.Hoehe * zoomFaktor);
            
        }

        private void lblZoom_Click(object sender, EventArgs e)
        {

        }
    }
}
