namespace Rechteck_Projekt
{
    public partial class Form1 : Form
    {
        

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
            Rechteck rechteck = new Rechteck();
            rechteck.Breite = Convert.ToDouble(tbxBreite.Text);
            rechteck.Hoehe = Convert.ToDouble(tbxHoehe.Text);
        }
    }
}
