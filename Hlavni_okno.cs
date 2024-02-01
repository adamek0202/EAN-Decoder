namespace Decoder_EAN
{
    public partial class Hlavni_okno : Form
    {
        public Hlavni_okno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Prázdnej kód fakt nezpracuju...", "Prázdnej kód", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else if(textBox1.Text.All(char.IsDigit) == false)
            {
                textBox1.Text = "";
                MessageBox.Show("Zadal si nějakou kravinu...", "Blbé zadání", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if(textBox1.Text.Length == 13)
            {   
                Zpracovani.Zpracuj(Convert.ToInt32(textBox1.Text.Substring(0, 3)));
                textBox1.Text = "";
            }

            else if(textBox1.Text.Length < 13)
            {
                textBox1.Text = "";
                MessageBox.Show("Kód je moc krátkej. Musíš zadat takovej, co má 13 čísel.", "Moc krátkéj kód", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                textBox1.Text = "";
                MessageBox.Show("Kód je moc dlouhej. Musíš zadat takovej, co má 13 čísel.", "Moc krátkéj kód", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
