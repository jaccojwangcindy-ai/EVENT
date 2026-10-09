using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            buttonSubmit.Enabled = !string.IsNullOrWhiteSpace(textBoxInput.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonSubmit.Enabled = false;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            bool isValid = int.TryParse(textBoxInput.Text, out int numericResult);

            if (isValid)
            {
                // Success: Show the parsed number
                MessageBox.Show($"Valid numeric input: {numericResult}", "Validation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Failure: Show an error message
                MessageBox.Show("Invalid input! Please enter a numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
