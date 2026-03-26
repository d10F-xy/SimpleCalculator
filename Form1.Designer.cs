namespace SimpleCalculator
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
            Title = new Label();
            CE_BT = new Button();
            C_BT = new Button();
            Del_BT = new Button();
            Div_BT = new Button();
            Mul_BT = new Button();
            Num9_BT = new Button();
            Num8_BT = new Button();
            Num7_BT = new Button();
            Minus_BT = new Button();
            Num6_BT = new Button();
            Num5_BT = new Button();
            Num4_BT = new Button();
            Plus_BT = new Button();
            Num3_BT = new Button();
            Num2_BT = new Button();
            Num1_BT = new Button();
            Equal_BT = new Button();
            Point_BT = new Button();
            Num0_BT = new Button();
            PsM_BT = new Button();
            InputBox = new TextBox();
            OutputBox = new TextBox();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("맑은 고딕", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Title.ForeColor = Color.FromArgb(192, 192, 0);
            Title.Location = new Point(47, 22);
            Title.Name = "Title";
            Title.Size = new Size(295, 45);
            Title.TabIndex = 0;
            Title.Text = "Simple Calculator";
            // 
            // CE_BT
            // 
            CE_BT.Location = new Point(36, 234);
            CE_BT.Name = "CE_BT";
            CE_BT.Size = new Size(75, 38);
            CE_BT.TabIndex = 1;
            CE_BT.Text = "CE";
            CE_BT.UseVisualStyleBackColor = true;
            CE_BT.Click += CE_BT_Click;
            // 
            // C_BT
            // 
            C_BT.Location = new Point(117, 234);
            C_BT.Name = "C_BT";
            C_BT.Size = new Size(75, 38);
            C_BT.TabIndex = 2;
            C_BT.Text = "C";
            C_BT.UseVisualStyleBackColor = true;
            C_BT.Click += C_BT_Click;
            // 
            // Del_BT
            // 
            Del_BT.Location = new Point(198, 234);
            Del_BT.Name = "Del_BT";
            Del_BT.Size = new Size(75, 38);
            Del_BT.TabIndex = 3;
            Del_BT.Text = "DEL";
            Del_BT.UseVisualStyleBackColor = true;
            Del_BT.Click += Del_BT_Click;
            // 
            // Div_BT
            // 
            Div_BT.Location = new Point(279, 234);
            Div_BT.Name = "Div_BT";
            Div_BT.Size = new Size(75, 38);
            Div_BT.TabIndex = 4;
            Div_BT.Text = "÷";
            Div_BT.UseVisualStyleBackColor = true;
            Div_BT.Click += Div_BT_Click;
            // 
            // Mul_BT
            // 
            Mul_BT.Location = new Point(279, 278);
            Mul_BT.Name = "Mul_BT";
            Mul_BT.Size = new Size(75, 38);
            Mul_BT.TabIndex = 5;
            Mul_BT.Text = "X";
            Mul_BT.UseVisualStyleBackColor = true;
            Mul_BT.Click += Mul_BT_Click;
            // 
            // Num9_BT
            // 
            Num9_BT.Location = new Point(198, 278);
            Num9_BT.Name = "Num9_BT";
            Num9_BT.Size = new Size(75, 38);
            Num9_BT.TabIndex = 6;
            Num9_BT.Text = "9";
            Num9_BT.UseVisualStyleBackColor = true;
            Num9_BT.Click += Num9_BT_Click;
            // 
            // Num8_BT
            // 
            Num8_BT.Location = new Point(117, 278);
            Num8_BT.Name = "Num8_BT";
            Num8_BT.Size = new Size(75, 38);
            Num8_BT.TabIndex = 7;
            Num8_BT.Text = "8";
            Num8_BT.UseVisualStyleBackColor = true;
            Num8_BT.Click += Num8_BT_Click;
            // 
            // Num7_BT
            // 
            Num7_BT.Location = new Point(36, 278);
            Num7_BT.Name = "Num7_BT";
            Num7_BT.Size = new Size(75, 38);
            Num7_BT.TabIndex = 8;
            Num7_BT.Text = "7";
            Num7_BT.UseVisualStyleBackColor = true;
            Num7_BT.Click += Num7_BT_Click;
            // 
            // Minus_BT
            // 
            Minus_BT.Location = new Point(279, 322);
            Minus_BT.Name = "Minus_BT";
            Minus_BT.Size = new Size(75, 38);
            Minus_BT.TabIndex = 9;
            Minus_BT.Text = "-";
            Minus_BT.UseVisualStyleBackColor = true;
            Minus_BT.Click += Minus_BT_Click;
            // 
            // Num6_BT
            // 
            Num6_BT.Location = new Point(198, 322);
            Num6_BT.Name = "Num6_BT";
            Num6_BT.Size = new Size(75, 38);
            Num6_BT.TabIndex = 10;
            Num6_BT.Text = "6";
            Num6_BT.UseVisualStyleBackColor = true;
            Num6_BT.Click += Num6_BT_Click;
            // 
            // Num5_BT
            // 
            Num5_BT.Location = new Point(117, 322);
            Num5_BT.Name = "Num5_BT";
            Num5_BT.Size = new Size(75, 38);
            Num5_BT.TabIndex = 11;
            Num5_BT.Text = "5";
            Num5_BT.UseVisualStyleBackColor = true;
            Num5_BT.Click += Num5_BT_Click;
            // 
            // Num4_BT
            // 
            Num4_BT.Location = new Point(36, 322);
            Num4_BT.Name = "Num4_BT";
            Num4_BT.Size = new Size(75, 38);
            Num4_BT.TabIndex = 12;
            Num4_BT.Text = "4";
            Num4_BT.UseVisualStyleBackColor = true;
            Num4_BT.Click += Num4_BT_Click;
            // 
            // Plus_BT
            // 
            Plus_BT.Location = new Point(279, 366);
            Plus_BT.Name = "Plus_BT";
            Plus_BT.Size = new Size(75, 38);
            Plus_BT.TabIndex = 13;
            Plus_BT.Text = "+";
            Plus_BT.UseVisualStyleBackColor = true;
            Plus_BT.Click += Plus_BT_Click;
            // 
            // Num3_BT
            // 
            Num3_BT.Location = new Point(198, 366);
            Num3_BT.Name = "Num3_BT";
            Num3_BT.Size = new Size(75, 38);
            Num3_BT.TabIndex = 14;
            Num3_BT.Text = "3";
            Num3_BT.UseVisualStyleBackColor = true;
            Num3_BT.Click += Num3_BT_Click;
            // 
            // Num2_BT
            // 
            Num2_BT.Location = new Point(117, 366);
            Num2_BT.Name = "Num2_BT";
            Num2_BT.Size = new Size(75, 38);
            Num2_BT.TabIndex = 15;
            Num2_BT.Text = "2";
            Num2_BT.UseVisualStyleBackColor = true;
            Num2_BT.Click += Num2_BT_Click;
            // 
            // Num1_BT
            // 
            Num1_BT.Location = new Point(36, 366);
            Num1_BT.Name = "Num1_BT";
            Num1_BT.Size = new Size(75, 38);
            Num1_BT.TabIndex = 16;
            Num1_BT.Text = "1";
            Num1_BT.UseVisualStyleBackColor = true;
            Num1_BT.Click += Num1_BT_Click;
            // 
            // Equal_BT
            // 
            Equal_BT.Location = new Point(279, 410);
            Equal_BT.Name = "Equal_BT";
            Equal_BT.Size = new Size(75, 38);
            Equal_BT.TabIndex = 17;
            Equal_BT.Text = "=";
            Equal_BT.UseVisualStyleBackColor = true;
            Equal_BT.Click += Equal_BT_Click;
            // 
            // Point_BT
            // 
            Point_BT.Location = new Point(198, 410);
            Point_BT.Name = "Point_BT";
            Point_BT.Size = new Size(75, 38);
            Point_BT.TabIndex = 18;
            Point_BT.Text = ".";
            Point_BT.UseVisualStyleBackColor = true;
            Point_BT.Click += Point_BT_Click;
            // 
            // Num0_BT
            // 
            Num0_BT.Location = new Point(117, 410);
            Num0_BT.Name = "Num0_BT";
            Num0_BT.Size = new Size(75, 38);
            Num0_BT.TabIndex = 19;
            Num0_BT.Text = "0";
            Num0_BT.UseVisualStyleBackColor = true;
            Num0_BT.Click += Num0_BT_Click;
            // 
            // PsM_BT
            // 
            PsM_BT.Location = new Point(36, 410);
            PsM_BT.Name = "PsM_BT";
            PsM_BT.Size = new Size(75, 38);
            PsM_BT.TabIndex = 20;
            PsM_BT.Text = "+/-";
            PsM_BT.UseVisualStyleBackColor = true;
            PsM_BT.Click += PsM_BT_Click;
            // 
            // InputBox
            // 
            InputBox.Font = new Font("맑은 고딕", 20F);
            InputBox.Location = new Point(36, 91);
            InputBox.Name = "InputBox";
            InputBox.Size = new Size(318, 43);
            InputBox.TabIndex = 21;
            // 
            // OutputBox
            // 
            OutputBox.Font = new Font("맑은 고딕", 20F);
            OutputBox.Location = new Point(36, 149);
            OutputBox.Name = "OutputBox";
            OutputBox.Size = new Size(318, 43);
            OutputBox.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 460);
            Controls.Add(OutputBox);
            Controls.Add(InputBox);
            Controls.Add(PsM_BT);
            Controls.Add(Num0_BT);
            Controls.Add(Point_BT);
            Controls.Add(Equal_BT);
            Controls.Add(Num1_BT);
            Controls.Add(Num2_BT);
            Controls.Add(Num3_BT);
            Controls.Add(Plus_BT);
            Controls.Add(Num4_BT);
            Controls.Add(Num5_BT);
            Controls.Add(Num6_BT);
            Controls.Add(Minus_BT);
            Controls.Add(Num7_BT);
            Controls.Add(Num8_BT);
            Controls.Add(Num9_BT);
            Controls.Add(Mul_BT);
            Controls.Add(Div_BT);
            Controls.Add(Del_BT);
            Controls.Add(C_BT);
            Controls.Add(CE_BT);
            Controls.Add(Title);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Button CE_BT;
        private Button C_BT;
        private Button Del_BT;
        private Button Div_BT;
        private Button Mul_BT;
        private Button Num9_BT;
        private Button Num8_BT;
        private Button Num7_BT;
        private Button Minus_BT;
        private Button Num6_BT;
        private Button Num5_BT;
        private Button Num4_BT;
        private Button Plus_BT;
        private Button Num3_BT;
        private Button Num2_BT;
        private Button Num1_BT;
        private Button Equal_BT;
        private Button Point_BT;
        private Button Num0_BT;
        private Button PsM_BT;
        private TextBox InputBox;
        private TextBox OutputBox;
    }
}
