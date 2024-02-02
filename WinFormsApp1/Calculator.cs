using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Calculator : Form
    {

        public Calculator()
        {
            InitializeComponent();
            InitializeComponentInput();

        }
        private void currentButtonClicked(Button button)
        {
            button.Size = new System.Drawing.Size(button.Size.Width + 4, button.Size.Height + 4);
            button.BackColor = System.Drawing.Color.Green;
            button.Location = new System.Drawing.Point(button.Location.X - 2, button.Location.Y - 2);
        }
        private void currentButtonNonClicked(Button button)
        {
            if (button != null)
            {
                button.Size = new System.Drawing.Size(button.Size.Width - 4, button.Size.Height - 4);
                button.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
                button.Location = new System.Drawing.Point(button.Location.X + 2, button.Location.Y + 2);
            }
        }
        private Button findNoMoreClickedButton()
        {
            if (plusButtonBool) return plus;
            if (minusButtonBool) return minus;
            if (divideButtonBool) return division;
            if (multipleButtonBool) return multyple;
            return null;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            currentButtonNonClicked(findNoMoreClickedButton());
            currentButtonClicked(plus);
            this.plusButtonBool = true;
            this.minusButtonBool = false;
            this.divideButtonBool = false;
            this.multipleButtonBool = false;
            CalculateProccess();

        }
        private void minus_Click(object sender, EventArgs e)
        {
            currentButtonNonClicked(findNoMoreClickedButton());
            currentButtonClicked(minus);
            this.plusButtonBool = false;
            this.minusButtonBool = true;
            this.divideButtonBool = false;
            this.multipleButtonBool = false;
            CalculateProccess();
        }

        private void multyple_Click(object sender, EventArgs e)
        {
            currentButtonNonClicked(findNoMoreClickedButton());
            currentButtonClicked(multyple);
            this.plusButtonBool = false;
            this.minusButtonBool = false;
            this.divideButtonBool = false;
            this.multipleButtonBool = true;
            CalculateProccess();
        }

        private void division_Click(object sender, EventArgs e)
        {
            currentButtonNonClicked(findNoMoreClickedButton());
            currentButtonClicked(division);
            this.plusButtonBool = false;
            this.minusButtonBool = false;
            this.divideButtonBool = true;
            this.multipleButtonBool = false;
            CalculateProccess();
        }

        private void x_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
