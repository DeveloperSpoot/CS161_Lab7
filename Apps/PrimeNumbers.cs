namespace CS161_Lab7.Apps
{
    public partial class PrimeNumbers : Form
    {
        public PrimeNumbers()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try // Catching any incompetence
            {
                int toCheck = int.Parse(inputTextBox.Text); // Getting the input.

                bool prime = isPrime(toCheck); // Calling our isPRime method to chekc if the input is prime or not.

                if (prime) { MessageBox.Show("This number is prime."); } else { MessageBox.Show("This number us NOT prime."); } // Displaying said results.

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message); // Displaying any errors.
            }
        }

        //Our is prime method.
        private bool isPrime(int checkee)
        {
           
            if(checkee < 2) { return false; } // Returning fasle if less than 2.
            if(checkee == 2 || checkee == 3) { return true; } // Returning true if 2 or 3.

            List<int> factors = new List<int>(); // List to track all factors.

            factors.Add(1); // Adding 1 by default.

            for(int i = 3; i < checkee+1; i++) // Looping through all possible factors.
            {
                if((checkee % i) == 0) {
                    factors.Add(i); // Adding said factor.
                }
            }

            if (factors.Count > 2) {
                return false; // Return false if there more than 2 factors.
            }

            return true; // Returning true if there are only 2 factors.

        }

        //Exit button method.
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
