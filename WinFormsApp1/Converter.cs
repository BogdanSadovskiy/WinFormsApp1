using System.Globalization;
using WinFormsApp1;

namespace FirstApp
{
    public partial class Converter : Form
    {
        bool isUserInput;
        bool isCelsius;
        bool isFahrenheit;

        string initialTextConvertToCelsius = "Change Fahrenheit to Celsius";
        string initialTextConvertToFahrenheit = "Change Celsius to Fahrenheit";
        string initialTextForCelsius = "Input Celsius";
        string initialTextForFahrenheit = "Input Fahrenheit";
        string userInput;
        string convertedValue;
        private void CelsiusToFahrenheit(float celsius)
        {

            convertedValue = (celsius * 9 / 5 + 32).ToString();
        }
        private void FahrenheitToCelsius(float fahrenheit)
        {
            convertedValue = ((fahrenheit - 32) * 5 / 9).ToString();
        }
        private void changeConverting()
        {
            isCelsius = !isCelsius;
            isFahrenheit = !isFahrenheit;
        }


        private void changeAreaText()
        {
            if (isCelsius) this.changeArea.Text = initialTextConvertToCelsius;
            if (isFahrenheit) this.changeArea.Text = initialTextConvertToFahrenheit;
        }

        private void caclulate()
        {
            if (userInput != null && userInput != "" && !NewCalculator.isCharMinusAlone(userInput))
            {
                if (isCelsius) CelsiusToFahrenheit(float.Parse(userInput, CultureInfo.InvariantCulture));
                if (isFahrenheit) FahrenheitToCelsius(float.Parse(userInput, CultureInfo.InvariantCulture));
                output();
            }

        }
        private void output()
        {
            string temp = "", temp2 = "";
            if (isCelsius)
            {
                temp = "℃";
                temp2 = "℉";
            }
            if (isFahrenheit)
            {
                temp = "℉";
                temp2 = "℃";
            }
            this.answer.Text = $"{userInput}{temp} = {convertedValue}{temp2}";
        }
        public Converter()
        {
            InitializeComponent();
            isUserInput = false;
            isCelsius = true;
            isFahrenheit = false;
            inputArea.Text = initialTextForCelsius;

        }

        private string initialTextConstructor()
        {
            if (isCelsius) return initialTextForCelsius;
            return initialTextForFahrenheit;

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            changeConverting();
            changeAreaText();
            inputArea.Text = initialTextConstructor();

        }

        private void inputArea_TextChanged(object sender, EventArgs e)
        {

            if (isUserInput)
            {
                inputArea.TextChanged -= inputArea_TextChanged;
                if (!RegexExpr.calculatorRegexNumber(inputArea.Text))
                    inputArea.Text = NewCalculator.removeOneChar(inputArea.Text);
                inputArea.SelectionStart = inputArea.Text.Length;
                userInput = inputArea.Text;
                caclulate();
                inputArea.TextChanged += inputArea_TextChanged;
            }
        }

        private void inputArea_Enter(object sender, EventArgs e)
        {
            isUserInput = true;
            if (inputArea.Text == initialTextForCelsius || inputArea.Text == initialTextForFahrenheit)
                inputArea.Text = "";
        }

        private void inputArea_Leave(object sender, EventArgs e)
        {
            isUserInput = false;
            if (inputArea.Text == "")
                inputArea.Text = initialTextConstructor();

        }

        private void x_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
