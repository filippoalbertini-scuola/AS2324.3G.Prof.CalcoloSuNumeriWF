namespace AS2324._3G.Prof.CalcoloSuNumeriWF
{
    public partial class Form1 : Form
    {
        // definizione della variabile per contenere il numero di numeri
        int nNumeri = 0;
        double somma = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {

            // incremento il numero di numeri inseriti
            nNumeri += 1;

            double numero = Convert.ToDouble(txtNumero.Text);

            // accumulo per la somma
            somma += numero;

            // calcolo media
            double media = somma/(double)nNumeri;

            // visualizzazione informazioni
            lblConteggio.Text = "Conteggio " + nNumeri.ToString();
            lblSomma.Text = "Somma " + somma.ToString();
            lblMedia.Text = $"Media {media}";

            if (nNumeri >= 5)
                lblConteggio.ForeColor = Color.Red;
            else
                lblConteggio.ForeColor = Color.Black;
        }
    }
}
