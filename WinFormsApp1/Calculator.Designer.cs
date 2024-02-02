using FirstApp;
using System.Globalization;

namespace WinFormsApp1
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private string initialText = "input number";
        private string firstInput;
        private string secondInput;
        private bool plusButtonBool;
        private bool minusButtonBool;
        private bool divideButtonBool;
        private bool multipleButtonBool;
        private bool isUserInput;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            firstNumber = new TextBox();
            secondNumber = new TextBox();
            plus = new Button();
            minus = new Button();
            multyple = new Button();
            division = new Button();
            answerCalcucator = new Label();
            x = new Button();
            xTip = new ToolTip(components);
            SuspendLayout();
            // 
            // firstNumber
            // 
            firstNumber.BackColor = Color.LightBlue;
            firstNumber.Location = new Point(285, 105);
            firstNumber.Name = "firstNumber";
            firstNumber.Size = new Size(206, 23);
            firstNumber.TabIndex = 1;
            firstNumber.Text = "input number";
            firstNumber.TextAlign = HorizontalAlignment.Center;
            firstNumber.TextChanged += firstNumber_TextChanged;
            // 
            // secondNumber
            // 
            secondNumber.BackColor = Color.LightBlue;
            secondNumber.Location = new Point(285, 212);
            secondNumber.Name = "secondNumber";
            secondNumber.Size = new Size(206, 23);
            secondNumber.TabIndex = 2;
            secondNumber.Text = "input number";
            secondNumber.TextAlign = HorizontalAlignment.Center;
            secondNumber.TextChanged += secondNumber_TextChanged;
            // 
            // plus
            // 
            plus.BackColor = Color.FromArgb(128, 128, 255);
            plus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            plus.Location = new Point(285, 156);
            plus.Name = "plus";
            plus.Size = new Size(40, 30);
            plus.TabIndex = 3;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = false;
            plus.Click += plus_Click;
            // 
            // minus
            // 
            minus.BackColor = Color.FromArgb(128, 128, 255);
            minus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minus.Location = new Point(341, 156);
            minus.Name = "minus";
            minus.Size = new Size(40, 30);
            minus.TabIndex = 4;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = false;
            minus.Click += minus_Click;
            // 
            // multyple
            // 
            multyple.BackColor = Color.FromArgb(128, 128, 255);
            multyple.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            multyple.Location = new Point(396, 156);
            multyple.Name = "multyple";
            multyple.Size = new Size(40, 30);
            multyple.TabIndex = 5;
            multyple.Text = "*";
            multyple.UseVisualStyleBackColor = false;
            multyple.Click += multyple_Click;
            // 
            // division
            // 
            division.BackColor = Color.FromArgb(128, 128, 255);
            division.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            division.Location = new Point(451, 156);
            division.Name = "division";
            division.Size = new Size(40, 30);
            division.TabIndex = 6;
            division.Text = "/";
            division.UseVisualStyleBackColor = false;
            division.Click += division_Click;
            // 
            // answerCalcucator
            // 
            answerCalcucator.BackColor = Color.FromArgb(224, 224, 224);
            answerCalcucator.FlatStyle = FlatStyle.Popup;
            answerCalcucator.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            answerCalcucator.ForeColor = Color.Black;
            answerCalcucator.Location = new Point(306, 288);
            answerCalcucator.Name = "answerCalcucator";
            answerCalcucator.Size = new Size(170, 38);
            answerCalcucator.TabIndex = 7;
            answerCalcucator.Text = "Here is your answer";
            answerCalcucator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // x
            // 
            x.BackColor = Color.White;
            x.BackgroundImage = FirstApp.Properties.Resources.free_icon_close_1828665;
            x.BackgroundImageLayout = ImageLayout.Stretch;
            x.Cursor = Cursors.Hand;
            x.FlatAppearance.BorderSize = 0;
            x.FlatStyle = FlatStyle.Flat;
            x.ImageAlign = ContentAlignment.TopCenter;
            x.Location = new Point(561, 36);
            x.Name = "x";
            x.Size = new Size(15, 15);
            x.TabIndex = 8;
            xTip.SetToolTip(x, "Exit");
            x.UseVisualStyleBackColor = false;
            x.Click += x_Click;
            // 
            // xTip
            // 
            xTip.ForeColor = Color.Black;
            xTip.ToolTipIcon = ToolTipIcon.Info;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(x);
            Controls.Add(answerCalcucator);
            Controls.Add(division);
            Controls.Add(multyple);
            Controls.Add(minus);
            Controls.Add(plus);
            Controls.Add(secondNumber);
            Controls.Add(firstNumber);
            Cursor = Cursors.Hand;
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        private bool isCharMinusAlone(string str)
        {
            return str == "-";
        }
        private string plusFunction(float a, float b)
        {
            float c = a + b;
            return c.ToString();
        }
        private string minusFunction(float a, float b)
        {
            float c = a - b;
            return c.ToString();
        }
        private string divideFunction(float a, float b)
        {
            if(b!= 0) return (a/b).ToString();
            answerCalcucator.ForeColor = Color.Red;
            return "Can\'t divide to 0";
        }
        private string multypleFunction(float a, float b)
        {
            return (a*b).ToString();
        }
        private bool isFirstNumberExist()
        {
            return (firstInput != "" && firstInput != initialText && 
                firstInput != null && !isCharMinusAlone(firstInput));
        }
        private bool isSecondNumberExist()
        {
            return (secondInput != "" && secondInput != initialText && 
                secondInput != null && !isCharMinusAlone(secondInput));
        }
        private bool isActionButtonTrue()
        {
            return(plusButtonBool || minusButtonBool || multipleButtonBool || divideButtonBool);
        }
        private void CalculateProccess()
        {
            answerCalcucator.ForeColor = Color.Black;
            string answer = "Here is your answer";
            if(isFirstNumberExist() && isSecondNumberExist() && isActionButtonTrue())
            {
                answerCalcucator.ForeColor = Color.Green;
                float firstParsednumber = float.Parse(firstNumber.Text, CultureInfo.InvariantCulture);
                float secondParsednumber = float.Parse(secondNumber.Text, CultureInfo.InvariantCulture);
                if(plusButtonBool) answer = plusFunction(firstParsednumber, secondParsednumber);
                if(minusButtonBool) answer = minusFunction(firstParsednumber,secondParsednumber);
                if (divideButtonBool) answer = divideFunction(firstParsednumber, secondParsednumber);
                if(multipleButtonBool) answer = multypleFunction(firstParsednumber, secondParsednumber);

            }
            
            answerCalcucator.Text = answer;
        }

        private void firstNumber_TextChanged(object sender, EventArgs e)
        {
            if (isUserInput)
            {
                firstNumber.TextChanged -= firstNumber_TextChanged;
                if (!RegexExpr.calculatorRegexNumber(firstNumber.Text))
                    firstNumber.Text = removeOneChar(firstNumber.Text);
                this.firstInput = firstNumber.Text;
                firstNumber.SelectionStart = firstNumber.Text.Length;
                CalculateProccess();
                firstNumber.TextChanged += firstNumber_TextChanged;
                
            }
        }
        int i = 0;
        private void secondNumber_TextChanged(object sender, EventArgs e)
        {
            if (isUserInput)
            {
                secondNumber.TextChanged -= secondNumber_TextChanged;
                if (!RegexExpr.calculatorRegexNumber(secondNumber.Text))
                    secondNumber.Text = removeOneChar(secondNumber.Text);
                this.secondInput = secondNumber.Text;
                secondNumber.SelectionStart = secondNumber.Text.Length;
               
                CalculateProccess();
                secondNumber.TextChanged += secondNumber_TextChanged;
               
            }
        }

        private void InitializeComponentInput()
        {
            firstNumber.Enter += new System.EventHandler(this.FirstNumber_Enter);
            secondNumber.Enter += new System.EventHandler(this.SecondNumber_Enter);
            firstNumber.Leave += FirstNumber_Leave;
            secondNumber.Leave += SecondNumber_Leave;
        }

        private void FirstNumber_Leave(object sender, EventArgs e)
        {
            isUserInput = false;
            if (firstNumber.Text == "")   firstNumber.Text = initialText; 
            
        }
        private void FirstNumber_Enter(object sender, EventArgs e)
        {
            isUserInput = true;
            if(firstNumber.Text == initialText)  firstNumber.Text = "";

        }
        private void SecondNumber_Leave(object sender, EventArgs e)
        {
            isUserInput = false;
            if (secondNumber.Text == "") secondNumber.Text = initialText;
        }
        private void SecondNumber_Enter(Object sender, EventArgs e)
        {
            isUserInput = true;
            if (secondNumber.Text == initialText)  secondNumber.Text = "";

        }

        private string removeOneChar(string str)
        {
            string newString = "";
            for(int i = 0; i< str.Length-1; i++)
            {
                newString+= str[i];
            }
            return newString;
        }

#endregion
        private TextBox firstNumber;
        private TextBox secondNumber;
        private Button plus;
        private Button minus;
        private Button multyple;
        private Button division;
        private Label answerCalcucator;
        private Button x;
        private ToolTip xTip;
    }
}