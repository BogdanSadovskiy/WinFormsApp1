﻿namespace WinFormsApp1
{
    partial class Start_menu
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
            CalculatorButton = new Button();
            converterButton = new Button();
            SuspendLayout();
            // 
            // CalculatorButton
            // 
            CalculatorButton.BackColor = Color.FromArgb(255, 128, 0);
            CalculatorButton.FlatStyle = FlatStyle.Flat;
            CalculatorButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CalculatorButton.Location = new Point(318, 112);
            CalculatorButton.Name = "CalculatorButton";
            CalculatorButton.Size = new Size(100, 40);
            CalculatorButton.TabIndex = 0;
            CalculatorButton.Text = "Calculator";
            CalculatorButton.UseVisualStyleBackColor = false;
            CalculatorButton.Click += Calculator_Click;
            // 
            // converterButton
            // 
            converterButton.BackColor = Color.FromArgb(255, 128, 0);
            converterButton.FlatStyle = FlatStyle.Flat;
            converterButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            converterButton.Location = new Point(318, 195);
            converterButton.Name = "converterButton";
            converterButton.Size = new Size(100, 40);
            converterButton.TabIndex = 1;
            converterButton.Text = "Converter";
            converterButton.UseVisualStyleBackColor = false;
            // 
            // Start_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(converterButton);
            Controls.Add(CalculatorButton);
            Name = "Start_menu";
            Text = "Start_menu";
            ResumeLayout(false);
        }

        #endregion

        private Button CalculatorButton;
        private Button converterButton;
    }
}