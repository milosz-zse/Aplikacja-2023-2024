namespace SimpleCalculatorMauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            if (!int.TryParse(firstNumberEtery.Text, out int firstNumber))
            {
                resultLabel.Text = " nieprwaidłowy";
                resultLabel.TextColor = new Color(250, 0, 0);
                return;
            }
            if (!int.TryParse(secoundNumberEtery.Text, out int secondNumber))
            {
                resultLabel.Text = " nieprwaidłowy";
                resultLabel.TextColor = new Color(250, 0, 0);
                return;
            }

            int result = 0;
            if (operationAddRadioButton.IsChecked)
            {
                result = firstNumber + secondNumber;
            }
            else if (operationSubRadioButton.IsChecked)
            {
                result = firstNumber - secondNumber;
            }
            else if (operationMulRadioButton.IsChecked)
            {
                result = firstNumber * secondNumber;
            }
            else if (operationDivRadioButton.IsChecked)
            {

                result = firstNumber / secondNumber;
            }
            resultLabel.Text = $"Wynik{result}";
            resultLabel.BackgroundColor = Colors.Green;
        }
    }

}