namespace CS161_Lab7.Apps
{
    public partial class RockPaperScissors : Form
    {
        public RockPaperScissors()
        {
            InitializeComponent();
        }

        //Method for eahc player choice. Rinse and repeate for each player choice.
        private void rockButton_Click(object sender, EventArgs e)
        {
            playerLabel.Text = "Rock"; // Diplayers Players choice.
            playGame(0); // Starts the game.
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            playerLabel.Text = "Paper";
            playGame(1);
        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            playerLabel.Text = "Scissors";
            playGame(2);
        }

        //Method for the computer to make a choice.
        private int AIPickChoice()
        {
            Random rand = new Random(); // Random object

            return rand.Next(3); // Get a random intergers between 0 and 2 (including 2).
        }

        private void playGame(int playersChoice)
        {
            string[] choices = {"Rock", "Paper", "Scissors" }; // Choices order in an array to cover the computers choice to text.

            int AI_Choice = AIPickChoice(); // Calling the AI pick method.

            aiLabel.Text = choices[AI_Choice]; // Displaying the computers choice.
            
            //Checking for each possible pairs for the game and displaying the winning outcome for said pair.

            if(playersChoice == AI_Choice) { MessageBox.Show("TIE! Play Again!"); } // Checks ties.

            if(playersChoice == 0 && AI_Choice == 2) { MessageBox.Show("YOU WIN!"); }
            if(playersChoice == 0 && AI_Choice == 1) { MessageBox.Show("Computer WINS! Try Again!"); }

            if(playersChoice == 1 && AI_Choice == 0) { MessageBox.Show("YOU WIN!"); }
            if(playersChoice == 1 && AI_Choice == 2) { MessageBox.Show("Computer WINS! Try Again!"); }

            if(playersChoice == 2 && AI_Choice == 0) { MessageBox.Show("Computer WINS! Try Again!"); }
            if(playersChoice == 2 && AI_Choice == 1) { MessageBox.Show("YOU WIN!"); }
        }

        //Exit method and buttton
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
