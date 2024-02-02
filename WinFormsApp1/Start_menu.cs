namespace WinFormsApp1
{
    public partial class Start_menu : Form
    {
        private Calculator calculatorForm;
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
        private void InitializeCalculatorForm()
        {
            calculatorForm = new Calculator();
            calculatorForm.TopLevel = false;
            calculatorForm.FormBorderStyle = FormBorderStyle.None;
            calculatorForm.Dock = DockStyle.Fill;
            calculatorForm.FormClosed += CalculatorForm_FormClosed;
            panel1.Controls.Add(calculatorForm);
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
            showMenu();
        }
        private void Calculator_Click(object sender, EventArgs e)
        {
            hideMenu();
            InitializeCalculatorForm();
            calculatorForm.Show();

        }


    }


}
