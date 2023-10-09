namespace EinAusKnopf
{
    public partial class Knopf : Form
    {
        public Knopf()
        {
            InitializeComponent();
        }

        private void klickButtonClick(object sender, EventArgs e)
        {
            if (zustandLabel.Text == "AUS")
            {

                if (codewortText.Text == "123456")
                {
                    zustandLabel.Text = "EIN";
                    codewortText.Text = "";
                }
                else
                {
                    MessageBox.Show("Codewort falsch");
                    codewortText.Text = "";
                }
            }
            else
            {
                if (codewortText.Text == "123456")
                {
                    zustandLabel.Text = "AUS";
                    codewortText.Text = "";
                }
                else
                {
                    MessageBox.Show("Codewort falsch");
                    codewortText.Text = "";
                }
            }
        }

        private void kreuzClick(object sender, FormClosingEventArgs e)
        {
            if (zustandLabel.Text == "AUS")
            {
                MessageBox.Show("Zustand muss EIN sein");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}