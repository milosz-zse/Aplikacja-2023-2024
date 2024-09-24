namespace SimpleCalculatorMauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public int FirstNumberEteryBinding { get; set; }
        public int SecoundNumberEteryBinding { get; set; }

        public string processedMessage;
        public string ProcessedMessage
        {
            get { return processedMessage; }
            set
            {
                processedMessage = value;
                OnPropertyChanged();
            }
        }
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
            if (!int.TryParse(firstNumberEtery.Text, out int firstNumber))
            {
                string errortype = " pierwszy nie działa";
                
                ProcessedMessage = "wunik " + errortype;
                OnPropertyChanged("ProcessedMessage");
                return;
            }
            if (!int.TryParse(secoundNumberEtery.Text, out int secondNumber))
            {
                string errortype = " drugi nie działa";
               
                ProcessedMessage = "wunik " + errortype;
                OnPropertyChanged("ProcessedMessage");
                return;
            }

            int result = 0;
            if (operationAddRadioButton.IsChecked)
            {
                result = firstNumber + secondNumber;
                ProcessedMessage = "wunik " + result;
                OnPropertyChanged("ProcessedMessage");
            }
            else if (operationSubRadioButton.IsChecked)
            {
                result = firstNumber - secondNumber;
                ProcessedMessage = "wunik " + result;
                OnPropertyChanged("ProcessedMessage");
            }
            else if (operationMulRadioButton.IsChecked)
            {
                result = firstNumber * secondNumber;
                ProcessedMessage = "wunik " + result;
                OnPropertyChanged("ProcessedMessage");
            }
            else if (operationDivRadioButton.IsChecked)
            {
                
                result = firstNumber / secondNumber;
                ProcessedMessage = "wunik " + result;
                OnPropertyChanged("ProcessedMessage");
            }
            resultLabel.Text = $"Wynik{result}";
            resultLabel.BackgroundColor = Colors.Green;
        }
    }

}
