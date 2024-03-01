using CS161_Lab7.Apps;

namespace CS161_Lab7
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void primeNumbersButton_Click(object sender, EventArgs e)
        {
            Form form = new PrimeNumbers();
            form.Show();
        }

        private void primeListButton_Click(object sender, EventArgs e)
        {
            Form form = new PrimeList();
            form.Show();
        }

        private void rockPaperButton_Click(object sender, EventArgs e)
        {
            Form form = new RockPaperScissors();
            form.Show();
        }
    }
}