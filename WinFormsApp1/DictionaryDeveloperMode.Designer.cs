namespace FirstApp
{
    partial class DictionaryDeveloperMode
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
            newWord = new TextBox();
            translatedWord = new TextBox();
            inputWordLabel = new Label();
            inputTranslatedWordLabel = new Label();
            submitButton = new Button();
            errorNewWordLabel = new Label();
            errorTranslatedLabel = new Label();
            SuspendLayout();
            // 
            // newWord
            // 
            newWord.Location = new Point(295, 71);
            newWord.Name = "newWord";
            newWord.Size = new Size(192, 23);
            newWord.TabIndex = 0;
            newWord.TextChanged += newWord_TextChanged;
            // 
            // translatedWord
            // 
            translatedWord.Location = new Point(295, 212);
            translatedWord.Name = "translatedWord";
            translatedWord.Size = new Size(192, 23);
            translatedWord.TabIndex = 1;
            translatedWord.TextChanged += translatedWord_TextChanged;
            // 
            // inputWordLabel
            // 
            inputWordLabel.BackColor = Color.FromArgb(255, 224, 192);
            inputWordLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            inputWordLabel.Location = new Point(295, 45);
            inputWordLabel.Name = "inputWordLabel";
            inputWordLabel.Size = new Size(192, 23);
            inputWordLabel.TabIndex = 2;
            inputWordLabel.Text = "Input word:";
            inputWordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inputTranslatedWordLabel
            // 
            inputTranslatedWordLabel.BackColor = Color.FromArgb(255, 224, 192);
            inputTranslatedWordLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            inputTranslatedWordLabel.Location = new Point(295, 186);
            inputTranslatedWordLabel.Name = "inputTranslatedWordLabel";
            inputTranslatedWordLabel.Size = new Size(192, 23);
            inputTranslatedWordLabel.TabIndex = 3;
            inputTranslatedWordLabel.Text = "Input translated word:";
            inputTranslatedWordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.FromArgb(255, 128, 0);
            submitButton.FlatStyle = FlatStyle.Popup;
            submitButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            submitButton.Location = new Point(358, 277);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 30);
            submitButton.TabIndex = 4;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // errorNewWordLabel
            // 
            errorNewWordLabel.BackColor = Color.White;
            errorNewWordLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            errorNewWordLabel.ForeColor = Color.Red;
            errorNewWordLabel.Location = new Point(493, 71);
            errorNewWordLabel.Name = "errorNewWordLabel";
            errorNewWordLabel.Size = new Size(100, 23);
            errorNewWordLabel.TabIndex = 5;
            errorNewWordLabel.Text = "Input correctly";
            errorNewWordLabel.TextAlign = ContentAlignment.MiddleCenter;
            errorNewWordLabel.Visible = false;
            // 
            // errorTranslatedLabel
            // 
            errorTranslatedLabel.BackColor = Color.White;
            errorTranslatedLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            errorTranslatedLabel.ForeColor = Color.Red;
            errorTranslatedLabel.Location = new Point(493, 212);
            errorTranslatedLabel.Name = "errorTranslatedLabel";
            errorTranslatedLabel.Size = new Size(100, 23);
            errorTranslatedLabel.TabIndex = 6;
            errorTranslatedLabel.Text = "Input correctly";
            errorTranslatedLabel.TextAlign = ContentAlignment.MiddleCenter;
            errorTranslatedLabel.Visible = false;
            // 
            // DictionaryDeveloperMode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(errorTranslatedLabel);
            Controls.Add(errorNewWordLabel);
            Controls.Add(submitButton);
            Controls.Add(inputTranslatedWordLabel);
            Controls.Add(inputWordLabel);
            Controls.Add(translatedWord);
            Controls.Add(newWord);
            Name = "DictionaryDeveloperMode";
            Text = "DictionaryDeveloperMode";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox newWord;
        private TextBox translatedWord;
        private Label inputWordLabel;
        private Label inputTranslatedWordLabel;
        private Button submitButton;
        private Label errorNewWordLabel;
        private Label errorTranslatedLabel;
    }
}