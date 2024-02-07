namespace FirstApp
{
    partial class Converter
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
            inputArea = new TextBox();
            changeButton = new Button();
            changeArea = new Label();
            answer = new Label();
            x = new Button();
            SuspendLayout();
            // 
            // inputArea
            // 
            inputArea.Location = new Point(222, 98);
            inputArea.Name = "inputArea";
            inputArea.Size = new Size(294, 23);
            inputArea.TabIndex = 0;
            inputArea.TextChanged += inputArea_TextChanged;
            inputArea.Enter += inputArea_Enter;
            inputArea.Leave += inputArea_Leave;
            // 
            // changeButton
            // 
            changeButton.BackgroundImage = Properties.Resources._2663482_200;
            changeButton.BackgroundImageLayout = ImageLayout.Zoom;
            changeButton.Cursor = Cursors.Hand;
            changeButton.Location = new Point(222, 139);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(30, 30);
            changeButton.TabIndex = 1;
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += changeButton_Click;
            // 
            // changeArea
            // 
            changeArea.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            changeArea.Location = new Point(258, 139);
            changeArea.Name = "changeArea";
            changeArea.Size = new Size(258, 30);
            changeArea.TabIndex = 2;
            changeArea.Text = "Change Fahrenheit to Celsius";
            changeArea.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // answer
            // 
            answer.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            answer.Location = new Point(222, 187);
            answer.Name = "answer";
            answer.Size = new Size(294, 49);
            answer.TabIndex = 3;
            answer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // x
            // 
            x.BackColor = Color.White;
            x.BackgroundImage = Properties.Resources.free_icon_close_1828665;
            x.BackgroundImageLayout = ImageLayout.Stretch;
            x.Cursor = Cursors.Hand;
            x.FlatAppearance.BorderSize = 0;
            x.FlatStyle = FlatStyle.Flat;
            x.ImageAlign = ContentAlignment.TopCenter;
            x.Location = new Point(552, 42);
            x.Name = "x";
            x.Size = new Size(15, 15);
            x.TabIndex = 9;
            x.UseVisualStyleBackColor = false;
            x.Click += x_Click;
            // 
            // Converter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(x);
            Controls.Add(answer);
            Controls.Add(changeArea);
            Controls.Add(changeButton);
            Controls.Add(inputArea);
            Name = "Converter";
            Text = "Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputArea;
        private Button changeButton;
        private Label changeArea;
        private Label answer;
        private Button x;
    }
}