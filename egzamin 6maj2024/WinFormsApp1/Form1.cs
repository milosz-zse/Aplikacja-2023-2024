
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string password;
        public Form1()
        {
            InitializeComponent();
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void buttonGeneratePass_Click(object sender, EventArgs e)
        {
            string password = "";
            string finalcharacters = "qazwsxedcrfvtgbyhnujmikolp";

            string bigLetterts = "QAZWSXEDCRFVTGBYHNUJMIKOLP";
            string numbers = "1234567890";
            string specialCharts = "!@#$%^&*()_+{}|:;[]\'/.,<>?";
            if (checkBoxSmallAndBigLetters.Checked)
            {
                finalcharacters = finalcharacters + bigLetterts;
            }
            if (checkBoxNumber.Checked)
            {
                finalcharacters = finalcharacters + numbers;
            }
            if (checkBoxSpecialLetters.Checked)
            {
                finalcharacters = finalcharacters + specialCharts;
            }
            for (int i = 0; i < Int32.Parse(textBoxHowManyNumbers.Text); i++)
            {
                Random rand = new Random();
                int randomNumber = rand.Next(0, finalcharacters.Length);
                password = password + finalcharacters[randomNumber];

            }

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string lastName = textBoxLastName.Text;
            string job = comboBoxJob.Text;
            MessageBox.Show = "dane pracownika " + name + lastName + job + password;
        }
    }
}