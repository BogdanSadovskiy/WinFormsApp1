namespace WinFormsApp1
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            calculate = new Button();
            firstNumber = new TextBox();
            secondNumber = new TextBox();
            plus = new Button();
            minus = new Button();
            multyple = new Button();
            division = new Button();
            answerCalcucator = new Label();
            SuspendLayout();
            // 
            // calculate
            // 
            calculate.BackColor = SystemColors.ActiveCaption;
            calculate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            calculate.Location = new Point(336, 232);
            calculate.Name = "calculate";
            calculate.Size = new Size(100, 40);
            calculate.TabIndex = 0;
            calculate.Text = "calculate";
            calculate.UseVisualStyleBackColor = false;
            // 
            // firstNumber
            // 
            firstNumber.BackColor = Color.LightBlue;
            firstNumber.Location = new Point(317, 49);
            firstNumber.Name = "firstNumber";
            firstNumber.Size = new Size(138, 23);
            firstNumber.TabIndex = 1;
            firstNumber.Text = "input number";
            // 
            // secondNumber
            // 
            secondNumber.BackColor = Color.LightBlue;
            secondNumber.Location = new Point(317, 145);
            secondNumber.Name = "secondNumber";
            secondNumber.Size = new Size(138, 23);
            secondNumber.TabIndex = 2;
            secondNumber.Text = "input number";
            secondNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // plus
            // 
            plus.BackColor = Color.FromArgb(128, 128, 255);
            plus.Font = new Font("SF UI Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            plus.Location = new Point(317, 93);
            plus.Name = "plus";
            plus.Size = new Size(30, 30);
            plus.TabIndex = 3;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = false;
            // 
            // minus
            // 
            minus.BackColor = Color.FromArgb(128, 128, 255);
            minus.Font = new Font("SF UI Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minus.Location = new Point(353, 93);
            minus.Name = "minus";
            minus.Size = new Size(30, 30);
            minus.TabIndex = 4;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = false;
            // 
            // multyple
            // 
            multyple.BackColor = Color.FromArgb(128, 128, 255);
            multyple.Font = new Font("SF UI Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            multyple.Location = new Point(389, 93);
            multyple.Name = "multyple";
            multyple.Size = new Size(30, 30);
            multyple.TabIndex = 5;
            multyple.Text = "*";
            multyple.UseVisualStyleBackColor = false;
            // 
            // division
            // 
            division.BackColor = Color.FromArgb(128, 128, 255);
            division.Font = new Font("SF UI Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            division.Location = new Point(425, 93);
            division.Name = "division";
            division.Size = new Size(30, 30);
            division.TabIndex = 6;
            division.Text = "/";
            division.UseVisualStyleBackColor = false;
            // 
            // answerCalcucator
            // 
            answerCalcucator.BackColor = Color.FromArgb(128, 128, 255);
            answerCalcucator.Location = new Point(336, 189);
            answerCalcucator.Name = "answerCalcucator";
            answerCalcucator.Size = new Size(100, 23);
            answerCalcucator.TabIndex = 7;
            answerCalcucator.Text = "answer";
            answerCalcucator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(answerCalcucator);
            Controls.Add(division);
            Controls.Add(multyple);
            Controls.Add(minus);
            Controls.Add(plus);
            Controls.Add(secondNumber);
            Controls.Add(firstNumber);
            Controls.Add(calculate);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }
        private void InitializeComponentFirstNumber()
        {
            firstNumber.Enter += new System.EventHandler(this.FirstNumber_Enter);
        }
        private void FirstNumber_Enter(object sender, EventArgs e)
        {
            firstNumber.Text = "";
        }

        #endregion

        private Button calculate;
        private TextBox firstNumber;
        private TextBox secondNumber;
        private Button plus;
        private Button minus;
        private Button multyple;
        private Button division;
        private Label answerCalcucator;
    }
}