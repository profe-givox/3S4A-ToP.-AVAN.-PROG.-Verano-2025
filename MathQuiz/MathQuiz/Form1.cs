namespace MathQuiz
{
    public partial class Form1 : Form
    {
        // Create a Random object called randomizer 
        // to generate random numbers.
        Random randomizer = new Random();


        public Form1()
        {
            InitializeComponent();
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
    }
}
