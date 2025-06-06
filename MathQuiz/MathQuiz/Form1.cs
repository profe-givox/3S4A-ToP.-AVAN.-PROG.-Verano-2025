namespace MathQuiz
{
    public partial class Form1 : Form
    {
        // Create a Random object called randomizer 
        // to generate random numbers.
        Random randomizer = new Random();

        // This integer variable keeps track of the 
        // remaining time.
        int timeLeft;

        public Form1()
        {
            InitializeComponent();

            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object? sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer  
                // and show a MessageBox.
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                btnStart.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // If CheckTheAnswer() returns false, keep counting
                // down. Decrease the time left by one second and 
                // display the new time left by updating the 
                // Time Left label.
                timeLeft = timeLeft - 1;
                lblTimer.Text = timeLeft + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                lblTimer.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                nudSumar.Value = addend1 + addend2;
                nudDifference.Value = minuend - subtrahend;
                nudProduct.Value = multiplicand * multiplier;
                nudDivision.Value = dividend / divisor;
                btnStart.Enabled = true;
            }

        }

            // These integer variables store the numbers 
            // for the addition problem. 
            int addend1;
        int addend2;
        public void startTheQuiz()
        {
            //suma
            // Generate two random numbers to add.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            // Convert the numbers to strings and display them in the labels.
            lblPlusLeft.Text = addend1.ToString();
            lblPlusRight.Text = addend2.ToString();
            // Clear the answer textbox.
            nudSumar.Value = 0;
            // Set focus to the answer textbox.
            nudSumar.Focus();

            // Fill in the subtraction problem.
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            lblMinusLeftLabel.Text = minuend.ToString();
            lblMinusRigthLabel.Text = subtrahend.ToString();
            nudDifference.Value = 0;

            // Fill in the multiplication problem.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            lblTimesLeftLabel.Text = multiplicand.ToString();
            lbltimesRigthLabel.Text = multiplier.ToString();
            nudProduct.Value = 0;

            // Fill in the division problem.
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            lblDividedLeftLabel.Text = dividend.ToString();
            lblDividedRigthLabel.Text = divisor.ToString();
            nudDivision.Value = 0;

            // Start the timer.
            timeLeft = 30;
            lblTimer.Text = "30 seconds";
            timer1.Start();

        }

        // These integer variables store the numbers 
        // for the subtraction problem. 
        int minuend;
        int subtrahend;
        // These integer variables store the numbers 
        // for the multiplication problem. 
        int multiplicand;
        int multiplier;
        // These integer variables store the numbers 
        // for the division problem. 
        int dividend;
        int divisor;

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.startTheQuiz();
            btnStart.Enabled = false;
        }

        /// <summary>
        /// Check the answers to see if the user got everything right.
        /// </summary>
        /// <returns>True if the answer's correct, false otherwise.</returns>
        private bool CheckTheAnswer()
        {
            //if ((addend1 + addend2 == nudSumar.Value)
            //    && (minuend - subtrahend == nudDifference.Value)
            //    && (multiplicand * multiplier == nudProduct.Value)
            //    && (dividend / divisor == nudDivision.Value))
            //    return true;
            //else
            //    return false;

            return (addend1 + addend2 == nudSumar.Value)
                && (minuend - subtrahend == nudDifference.Value)
                && (multiplicand * multiplier == nudProduct.Value)
                && (dividend / divisor == nudDivision.Value);
            

        }


    }
}
