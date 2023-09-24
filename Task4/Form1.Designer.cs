namespace Task4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextBoxnumber1 = new TextBox();
            TextBoxnumber2 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            Textboxresult = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // TextBoxnumber1
            // 
            TextBoxnumber1.Location = new Point(332, 92);
            TextBoxnumber1.Name = "TextBoxnumber1";
            TextBoxnumber1.Size = new Size(110, 23);
            TextBoxnumber1.TabIndex = 0;
            TextBoxnumber1.Text = "\r\n";
            TextBoxnumber1.TextAlign = HorizontalAlignment.Center;
            TextBoxnumber1.Click += TextBoxnumber1_Click;
            // 
            // TextBoxnumber2
            // 
            TextBoxnumber2.Location = new Point(448, 92);
            TextBoxnumber2.Name = "TextBoxnumber2";
            TextBoxnumber2.Size = new Size(110, 23);
            TextBoxnumber2.TabIndex = 1;
            TextBoxnumber2.TextAlign = HorizontalAlignment.Center;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(230, 159);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(132, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Остаток от деления";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(230, 183);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(143, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Возведение в ступень";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(230, 208);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(103, 19);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "Конкатинация";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(230, 233);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(75, 19);
            radioButton4.TabIndex = 5;
            radioButton4.TabStop = true;
            radioButton4.Text = " Деление";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // Textboxresult
            // 
            Textboxresult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Textboxresult.Location = new Point(391, 121);
            Textboxresult.Name = "Textboxresult";
            Textboxresult.ReadOnly = true;
            Textboxresult.Size = new Size(110, 23);
            Textboxresult.TabIndex = 6;
            Textboxresult.Text = "Получите ответ";
            Textboxresult.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new Point(405, 176);
            button1.Name = "button1";
            button1.Size = new Size(86, 23);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Textboxresult);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(TextBoxnumber2);
            Controls.Add(TextBoxnumber1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxnumber1;
        private TextBox TextBoxnumber2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private TextBox Textboxresult;
        private Button button1;
    }
}