namespace CS161_Lab7.Apps
{
    public partial class PrimeList : Form
    {
        public PrimeList()
        {
            InitializeComponent();
        }
        private void onLoad_Event(object sender, EventArgs e) // Load method obv.
        {
 
            // Looping through numbers 1 through 100;
               for(int i = 1; i < 101; i++)
               {
                bool prime = isPrime(i); // Checking if current number is prime

                if (prime)
                {
                    primeListBox.Items.Add(i.ToString()); // Displaying it if it is prime.
                }
               }

        }

        //Our is prime method.
        private bool isPrime(int checkee)
        {

            if (checkee < 2) { return false; } // Returning fasle if less than 2.
            if (checkee == 2 || checkee == 3) { return true; } // Returning true if 2 or 3.

            List<int> factors = new List<int>(); // List to track all factors.

            for (int i = 1; i < checkee+1; i++) // Looping through all possible factors.
            {
                if ((checkee % i) == 0)
                {
                    factors.Add(i); // Adding said factor.
                }
            }

            if (factors.Count > 2)
            {
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
