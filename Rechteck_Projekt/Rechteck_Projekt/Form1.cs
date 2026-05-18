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
            
            //rechteck.Breite = Convert.ToDouble(tbxBreite.Text) * (Convert.ToDouble($"1,{trbZoom.Value}"));
            //rechteck.Hoehe = Convert.ToDouble(tbxHoehe.Text) * (Convert.ToDouble($"1,{trbZoom.Value}"));
            
        }

        private void trbZoom_Scroll(object sender, EventArgs e)
        {
            int count = 0;
            if (count == 0)
            {
                rechteck.Breite = Convert.ToDouble(tbxBreite.Text);
                rechteck.Hoehe = Convert.ToDouble(tbxHoehe.Text);
            }
            
            lblZoom.Text = $"Zoom = {trbZoom.Value.ToString()}";
            zoomFaktor = 1 + (trbZoom.Value / 10.0);
            tbxBreite.Text = Convert.ToString(Convert.ToDouble(tbxBreite.Text) * zoomFaktor);
            tbxHoehe.Text = Convert.ToString(Convert.ToDouble(tbxHoehe.Text) * zoomFaktor);
            count++;
        }

        private void lblZoom_Click(object sender, EventArgs e)
        {

        }
    }
}
