namespace PracticeCalculator
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
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnSubtract = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnAdd = new Button();
            btnEquals = new Button();
            btnDecimal = new Button();
            btn0 = new Button();
            btnClear = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            btnFontSize = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 24F);
            txtDisplay.Location = new Point(20, 20);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(296, 71);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 16F);
            btn7.Location = new Point(20, 110);
            btn7.Name = "btn7";
            btn7.Size = new Size(68, 50);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 16F);
            btn8.Location = new Point(96, 110);
            btn8.Name = "btn8";
            btn8.Size = new Size(68, 50);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 16F);
            btn9.Location = new Point(172, 110);
            btn9.Name = "btn9";
            btn9.Size = new Size(68, 50);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 16F);
            btnDivide.Location = new Point(248, 110);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(68, 50);
            btnDivide.TabIndex = 4;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 16F);
            btnMultiply.Location = new Point(248, 170);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(68, 50);
            btnMultiply.TabIndex = 8;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 16F);
            btn6.Location = new Point(172, 170);
            btn6.Name = "btn6";
            btn6.Size = new Size(68, 50);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 16F);
            btn5.Location = new Point(96, 170);
            btn5.Name = "btn5";
            btn5.Size = new Size(68, 50);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 16F);
            btn4.Location = new Point(20, 170);
            btn4.Name = "btn4";
            btn4.Size = new Size(68, 50);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += button4_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Segoe UI", 16F);
            btnSubtract.Location = new Point(249, 230);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(68, 50);
            btnSubtract.TabIndex = 12;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 16F);
            btn3.Location = new Point(173, 230);
            btn3.Name = "btn3";
            btn3.Size = new Size(68, 50);
            btn3.TabIndex = 11;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 16F);
            btn2.Location = new Point(97, 230);
            btn2.Name = "btn2";
            btn2.Size = new Size(68, 50);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 16F);
            btn1.Location = new Point(21, 230);
            btn1.Name = "btn1";
            btn1.Size = new Size(68, 50);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button5_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 16F);
            btnAdd.Location = new Point(249, 290);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(68, 50);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button3_Click;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Segoe UI", 16F);
            btnEquals.Location = new Point(173, 290);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(68, 50);
            btnEquals.TabIndex = 15;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            // 
            // btnDecimal
            // 
            btnDecimal.Font = new Font("Segoe UI", 16F);
            btnDecimal.Location = new Point(97, 290);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(68, 50);
            btnDecimal.TabIndex = 14;
            btnDecimal.Text = ",";
            btnDecimal.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 16F);
            btn0.Location = new Point(21, 290);
            btn0.Name = "btn0";
            btn0.Size = new Size(68, 50);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += button6_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 16F);
            btnClear.Location = new Point(20, 350);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(296, 50);
            btnClear.TabIndex = 17;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(20, 428);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(144, 40);
            btnSave.TabIndex = 18;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 12F);
            btnLoad.Location = new Point(170, 428);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(144, 40);
            btnLoad.TabIndex = 19;
            btnLoad.Text = "Загрузить";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnFontSize
            // 
            btnFontSize.Font = new Font("Segoe UI", 12F);
            btnFontSize.Location = new Point(20, 478);
            btnFontSize.Name = "btnFontSize";
            btnFontSize.Size = new Size(295, 40);
            btnFontSize.TabIndex = 20;
            btnFontSize.Text = "Размер шрифта";
            btnFontSize.UseVisualStyleBackColor = true;
            btnFontSize.Click += btnFontSize_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 544);
            Controls.Add(btnFontSize);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(btnEquals);
            Controls.Add(btnDecimal);
            Controls.Add(btn0);
            Controls.Add(btnSubtract);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnMultiply);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnDivide);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Калькулятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnSubtract;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnAdd;
        private Button btnEquals;
        private Button btnDecimal;
        private Button btn0;
        private Button btnClear;
        private Button btnSave;
        private Button btnLoad;
        private Button btnFontSize;
    }
}
