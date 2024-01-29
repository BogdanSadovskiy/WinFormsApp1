using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            calculatorForm = new Calculator();
            calculatorForm.TopLevel = false;
            panel1.Controls.Add(calculatorForm);
        }
        private void InitializeCalculatorForm()
        {
            calculatorForm = new Calculator();
            calculatorForm.TopLevel = false;
            calculatorForm.FormBorderStyle = FormBorderStyle.None;
            calculatorForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(calculatorForm);
        }

        private void Calculator_Click(object sender, EventArgs e)
        {
            CalculatorButton.Hide();
            converterButton.Hide();
            InitializeCalculatorForm();
            calculatorForm.Show();

        }

       
    }


}
