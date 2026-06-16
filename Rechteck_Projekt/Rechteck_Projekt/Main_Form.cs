namespace Rechteck_Projekt
{
    public partial class btnRechteck : Form
    {
        //Objekt der klasse secondform erstellen um auch zugriff dadrauf zu kriegen
        private Second_Form SecondForm;

        Rechteck rechteck = new Rechteck();

        public btnRechteck()
        {
            InitializeComponent();

            SecondForm = new Second_Form();
            //Die Sicht von zweiten form wird als false eingesetzt damit man sie mit einem button kontrollieren kann
            SecondForm.Visible = false;
        }

        // Überprüft, ob die Textbox leer ist wenn nicht, wird die Eingabe in die entsprechenden Eigenschaften des Rechtecks umgewandelt
        private void tbxIsEmpty(string tbx, bool isBreite)
        {
            try //try catch block um sicherzustellen, dass die Eingabe eine Zahl ist
            {
                if (!string.IsNullOrEmpty(tbx)) //überprüft ob die Textbox leer ist
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
            catch (Exception ex) //fängt alle Ausnahmen ab, die bei der Umwandlung auftreten können
            {
                MessageBox.Show("Eingabe muss eine Zahl sein!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Aktualisiert die Berechnungen und die Visualisierung des Rechtecks, wenn sich die Breite ändert
        private void tbxBreite_TextChanged(object sender, EventArgs e)
        {
            tbxIsEmpty(tbxBreite.Text, true);
            //überprüft ob beide Textboxen nicht leer sind, bevor die Berechnungen durchgeführt werden
            if (!string.IsNullOrEmpty(tbxBreite.Text) && !string.IsNullOrEmpty(tbxHoehe.Text))
            {
                tbxUmfang.Text = Convert.ToString(rechteck.Umfang);
                tbxFlaecheninhalt.Text = Convert.ToString(rechteck.Flaeche);
                tbxDiagonale.Text = Convert.ToString(rechteck.Diagonale);
                SecondForm.btnRechteckV.Width = Convert.ToInt32(Math.Round(rechteck.Breite * 10, 0));
                SecondForm.btnRechteckV.Height = Convert.ToInt32(Math.Round(rechteck.Hoehe * 10, 0));
            }
            else //wenn eine der Textboxen leer ist, werden die Berechnungen zurückgesetzt
            {
                tbxUmfang.Text = "";
                tbxFlaecheninhalt.Text = "";
                tbxDiagonale.Text = "";
            }

        }

        // Aktualisiert die Berechnungen und die Visualisierung des Rechtecks, wenn sich die Höhe ändert
        private void tbxHoehe_TextChanged(object sender, EventArgs e)
        {
            tbxIsEmpty(tbxHoehe.Text, false);
            //überprüft ob beide Textboxen nicht leer sind, bevor die Berechnungen durchgeführt werden
            if (!string.IsNullOrEmpty(tbxBreite.Text) && !string.IsNullOrEmpty(tbxHoehe.Text))
            {
                tbxUmfang.Text = Convert.ToString(rechteck.Umfang);
                tbxFlaecheninhalt.Text = Convert.ToString(rechteck.Flaeche);
                tbxDiagonale.Text = Convert.ToString(rechteck.Diagonale);
                SecondForm.btnRechteckV.Height = Convert.ToInt32(Math.Round(rechteck.Hoehe * 10, 0));
                SecondForm.btnRechteckV.Width = Convert.ToInt32(Math.Round(rechteck.Breite * 10, 0));
            }
            else //wenn eine der Textboxen leer ist, werden die Berechnungen zurückgesetzt
            {
                tbxUmfang.Text = "";
                tbxFlaecheninhalt.Text = "";
                tbxDiagonale.Text = "";
            }
        }

        // Zoomt das Rechteck, indem die Methode "zoom" aufgerufen wird, und aktualisiert die Textboxen mit den neuen Werten
        private void btnZoomMinus_Click(object sender, EventArgs e)
        {
            try //try catch block um sicherzustellen, dass die Methode "zoom" keine Ausnahmen wirft, wenn die Werte zu klein werden
            {
                rechteck.zoom(true);
                tbxBreite.Text = rechteck.Breite.ToString();
                tbxHoehe.Text = rechteck.Hoehe.ToString();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        // Zoomt das Rechteck, indem die Methode "zoom" aufgerufen wird, und aktualisiert die Textboxen mit den neuen Werten
        private void btnZoomPlus_Click(object sender, EventArgs e)
        {
            try //try catch block um sicherzustellen, dass die Methode "zoom" keine Ausnahmen wirft, wenn die Werte zu groß werden
            {
                rechteck.zoom(false);
                tbxBreite.Text = rechteck.Breite.ToString();
                tbxHoehe.Text = rechteck.Hoehe.ToString();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Dreht das Rechteck, indem die Methode "Drehen" aufgerufen wird, und aktualisiert die Textboxen mit den neuen Werten
        private void btnDrehen_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxBreite.Text) && !string.IsNullOrEmpty(tbxHoehe.Text)) //überprüft ob beide Textboxen nicht leer sind, bevor die Methode "Drehen" aufgerufen wird
            {
                rechteck.Drehen();
                tbxBreite.Text = Convert.ToString(rechteck.Breite);
                tbxHoehe.Text = Convert.ToString(rechteck.Hoehe);
            }
        }

        // Zeigt oder versteckt das zweite Fenster, wenn der Button "Visualisieren" geklickt wird
        private void btnVisual_Click(object sender, EventArgs e)
        {   
           //Der Zustand vom Secondform wird invertiert, damit es durch klicken entweder erscehint oder versteckt wird
          SecondForm.Visible = !SecondForm.Visible; 
        }
    }
}
