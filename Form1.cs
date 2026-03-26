using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ---------------- 숫자 버튼 ----------------
        private void Num0_BT_Click(object sender, EventArgs e) => AddNumber(sender);
        private void Num1_BT_Click(object sender, EventArgs e) => AddNumber(sender);
        private void Num2_BT_Click(object sender, EventArgs e) => AddNumber(sender);
        private void Num3_BT_Click(object sender, EventArgs e) => AddNumber(sender);
        private void Num4_BT_Click(object sender, EventArgs e) => AddNumber(sender);
        private void Num5_BT_Click(object sender, EventArgs e) => AddNumber(sender);
        private void Num6_BT_Click(object sender, EventArgs e) => AddNumber(sender);
        private void Num7_BT_Click(object sender, EventArgs e) => AddNumber(sender);
        private void Num8_BT_Click(object sender, EventArgs e) => AddNumber(sender);
        private void Num9_BT_Click(object sender, EventArgs e) => AddNumber(sender);

        private void AddNumber(object sender)
        {
            Button btn = (Button)sender;
            InputBox.Text += btn.Text;
        }

        // ---------------- 연산자 버튼 ----------------
        private void Plus_BT_Click(object sender, EventArgs e) => InputBox.Text += " + ";
        private void Minus_BT_Click(object sender, EventArgs e) => InputBox.Text += " - ";
        private void Mul_BT_Click(object sender, EventArgs e) => InputBox.Text += " x ";
        private void Div_BT_Click(object sender, EventArgs e) => InputBox.Text += " ÷ ";

        // ---------------- 괄호 ----------------
        private void ParentLeft_BT_Click(object sender, EventArgs e) => InputBox.Text += "(";
        private void ParentRight_BT_Click(object sender, EventArgs e) => InputBox.Text += ")";

        // ---------------- = ----------------
        private void Equal_BT_Click(object sender, EventArgs e)
        {
            try
            {
                string expr = InputBox.Text
                    .Replace(" ", "")
                    .Replace("x", "*")
                    .Replace("÷", "/");

                double result = EvaluateExpression(expr);

                InputBox.Text += " = " + result;
                OutputBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("계산 오류: " + ex.Message);
            }
        }

        // ---------------- 초기화 ----------------
        private void C_BT_Click(object sender, EventArgs e)
        {
            InputBox.Clear();
            OutputBox.Clear();
        }

        private void CE_BT_Click(object sender, EventArgs e)
        {
            string[] parts = InputBox.Text.Split(' ');
            if (parts.Length > 0)
                InputBox.Text = string.Join(" ", parts.Take(parts.Length - 1));
        }

        private void Del_BT_Click(object sender, EventArgs e)
        {
            if (InputBox.Text.Length > 0)
                InputBox.Text = InputBox.Text.Substring(0, InputBox.Text.Length - 1);
        }

        // ---------------- ± ----------------
        private void PsM_BT_Click(object sender, EventArgs e)
        {
            if (double.TryParse(InputBox.Text, out double value))
                InputBox.Text = (-value).ToString();
        }

        // ---------------- 소수점 ----------------
        private void Point_BT_Click(object sender, EventArgs e)
        {
            InputBox.Text += ".";
        }

        // ---------------- 진법 변환 ----------------
        private void Bin_BT_Click(object sender, EventArgs e) => ConvertBase(2);
        private void Oct_BT_Click(object sender, EventArgs e) => ConvertBase(8);
        private void Hex_BT_Click(object sender, EventArgs e) => ConvertBase(16);

        private void ConvertBase(int radix)
        {
            if (double.TryParse(OutputBox.Text, out double value))
            {
                int intValue = (int)value;
                string converted = Convert.ToString(intValue, radix).ToUpper();
                InputBox.Text += " → " + converted;
                OutputBox.Text = converted;
            }
            else
            {
                MessageBox.Show("변환할 숫자가 없습니다.");
            }
        }

        // ---------------- 계산 엔진 ----------------
        private double EvaluateExpression(string expr)
        {
            List<string> tokens = Tokenize(expr);
            List<string> postfix = InfixToPostfix(tokens);
            return EvaluatePostfix(postfix);
        }

        // 🔥 토큰화 (암시적 곱셈 포함)
        private List<string> Tokenize(string expr)
        {
            List<string> tokens = new List<string>();
            string number = "";
            char prevChar = '\0';

            foreach (char c in expr)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    number += c;
                }
                else
                {
                    if (number != "")
                    {
                        tokens.Add(number);
                        number = "";
                    }

                    // 숫자 뒤에 '(' → 곱셈
                    if (c == '(' && (char.IsDigit(prevChar) || prevChar == ')'))
                    {
                        tokens.Add("*");
                    }

                    tokens.Add(c.ToString());
                }

                prevChar = c;
            }

            if (number != "")
                tokens.Add(number);

            return tokens;
        }

        // 🔥 중위 → 후위 변환
        private List<string> InfixToPostfix(List<string> tokens)
        {
            List<string> output = new List<string>();
            Stack<string> stack = new Stack<string>();

            Dictionary<string, int> precedence = new Dictionary<string, int>
            {
                { "+", 1 }, { "-", 1 }, { "*", 2 }, { "/", 2 }
            };

            foreach (var token in tokens)
            {
                if (double.TryParse(token, out _))
                {
                    output.Add(token);
                }
                else if (token == "(")
                {
                    stack.Push(token);
                }
                else if (token == ")")
                {
                    while (stack.Count > 0 && stack.Peek() != "(")
                        output.Add(stack.Pop());

                    if (stack.Count > 0) stack.Pop();
                }
                else
                {
                    while (stack.Count > 0 && stack.Peek() != "(" &&
                           precedence.ContainsKey(stack.Peek()) &&
                           precedence.ContainsKey(token) &&
                           precedence[stack.Peek()] >= precedence[token])
                    {
                        output.Add(stack.Pop());
                    }

                    stack.Push(token);
                }
            }

            while (stack.Count > 0)
                output.Add(stack.Pop());

            return output;
        }

        // 🔥 후위 계산
        private double EvaluatePostfix(List<string> postfix)
        {
            Stack<double> stack = new Stack<double>();

            foreach (var token in postfix)
            {
                if (double.TryParse(token, out double num))
                {
                    stack.Push(num);
                }
                else
                {
                    double b = stack.Pop();
                    double a = stack.Pop();

                    switch (token)
                    {
                        case "+": stack.Push(a + b); break;
                        case "-": stack.Push(a - b); break;
                        case "*": stack.Push(a * b); break;
                        case "/":
                            if (b == 0) throw new DivideByZeroException();
                            stack.Push(a / b);
                            break;
                    }
                }
            }

            return stack.Pop();
        }
    }
}