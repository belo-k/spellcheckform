using System.Text.RegularExpressions;

namespace spellcheckform
{
    public partial class spellChecker : Form
    {
        public spellChecker()
        {
            InitializeComponent();
        }

        private void spellChecker_Load(object sender, EventArgs e)
        {

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Any(Char.IsWhiteSpace))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Input contains whitespace.", "Error", buttons);
                //return;
            } 
            
            listBox1.BeginUpdate();
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                listBox1.Items.Add(textBox1.Text + " " + random.Next(100).ToString());
            }
            listBox1.EndUpdate();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            listBox1.Items.Clear();
            listBox1.EndUpdate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}