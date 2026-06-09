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
            InitializeComponent();

            SplitContainer splitContainer1 = new SplitContainer();
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Orientation = Orientation.Vertical;
            splitContainer1.IsSplitterFixed = false;
            splitContainer1.SplitterDistance = 250;
            splitContainer1.Panel1MinSize = 120;
            splitContainer1.Panel2MinSize = 120;

            Button btn = new Button();
            btn.Text = "Toolbox Button";
            btn.Dock = DockStyle.Top;

            TextBox txt = new TextBox();
            txt.Multiline = true;
            txt.Dock = DockStyle.Fill;

            splitContainer1.Panel1.Controls.Add(btn);
            splitContainer1.Panel2.Controls.Add(txt);

            this.Controls.Add(splitContainer1);
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
