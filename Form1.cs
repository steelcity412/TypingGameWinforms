namespace TypingGame
{
    public partial class Form1 : Form
    {
        string[] words = { "internet", "programming", "test", "coding", "sky", "banana" };
        
        Random random = new Random();

        int correct = 0;
        int incorrect = 0;  


        public Form1()
        {
            InitializeComponent();

            lblword.Text = words[random.Next(0, words.Length)];
        }

        private void checkGame(object sender, KeyEventArgs e)
        {
            //if we press the enter key and it is released
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == lblword.Text)
                {
                    correct++;
                    lblword.Text = words[random.Next(0,words.Length)];
                    textBox1.Text = null;
                }
                else
                {
                    incorrect++;
                    lblword.Text = words[random.Next(0, words.Length)];
                    textBox1.Text = null;
                }

                lblright.Text = "Correct: " + correct;
                lblwrong.Text = "Incorrect: " + incorrect;
            }
        }
    }
}