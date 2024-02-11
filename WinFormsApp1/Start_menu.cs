using FirstApp;

namespace WinFormsApp1
{
    public partial class Start_menu : Form
    {
        private NewCalculator calculatorForm;
        private Converter converterForm;
        private DictionaryApp dictionary;
        private Panel panel1 = new Panel();
        private void InitializePanel()
        {
            panel1.Dock = DockStyle.Fill;
            Controls.Add(panel1);
        }
        public Start_menu()
        {
            InitializeComponent();
            InitializePanel();

        }
        private void InitializeConverterForm()
        {
            converterForm = new Converter();
            converterForm.TopLevel = false;
            converterForm.FormBorderStyle = FormBorderStyle.None;
            converterForm.Dock = DockStyle.Fill;
            converterForm.FormClosed += ConverterForm_FormClosed;
            panel1.Controls.Add(converterForm);
        }



        private void InitializeCalculatorForm()
        {
            calculatorForm = new NewCalculator();
            calculatorForm.TopLevel = false;
            calculatorForm.FormBorderStyle = FormBorderStyle.None;
            calculatorForm.Dock = DockStyle.Fill;
            calculatorForm.FormClosed += CalculatorForm_FormClosed;
            panel1.Controls.Add(calculatorForm);
        }
        private void initializeDictionaryForm()
        {
            dictionary = new DictionaryApp();
            dictionary.TopLevel = false;
            dictionary.FormBorderStyle = FormBorderStyle.None;
            dictionary.Dock = DockStyle.Fill;
            dictionary.FormClosed += Dictionary_FormClosed;
            panel1.Controls.Add(dictionary);
        }

        private void Dictionary_FormClosed(object? sender, FormClosedEventArgs e)
        {
            panel1.Controls.Remove(dictionary);
            showMenu();
        }

        private void hideMenu()
        {
            CalculatorButton.Hide();
            converterButton.Hide();
        }
        private void showMenu()
        {
            CalculatorButton.Show();
            converterButton.Show();
        }
        private void CalculatorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            panel1.Controls.Remove(calculatorForm);
            showMenu();
        }
        private void Calculator_Click(object sender, EventArgs e)
        {
            hideMenu();
            InitializeCalculatorForm();
            calculatorForm.Show();

        }
        private void ConverterForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            panel1.Controls.Remove(converterForm);
            showMenu();
        }
        private void converterButton_Click(object sender, EventArgs e)
        {
            hideMenu();
            InitializeConverterForm();
            converterForm.Show();
        }

        private void translatorButton_Click(object sender, EventArgs e)
        {
            hideMenu();
            initializeDictionaryForm();
            dictionary.Show();  
        }
    }


}
