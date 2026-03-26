using System;
using System.Linq;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int n1 = 0;
        int n2 = 0;
        string op = "";

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
        private void Plus_BT_Click(object sender, EventArgs e) => SetOperator("+");
        private void Minus_BT_Click(object sender, EventArgs e) => SetOperator("-");
        private void Mul_BT_Click(object sender, EventArgs e) => SetOperator("x");
        private void Div_BT_Click(object sender, EventArgs e) => SetOperator("÷");

        private void SetOperator(string operatorSymbol)
        {
            string[] parts = InputBox.Text.Split(' ');
            if (!int.TryParse(parts[0], out n1))
            {
                MessageBox.Show("먼저 숫자를 입력하세요.");
                return;
            }

            op = operatorSymbol;

            if (parts.Length == 1)
                InputBox.Text += " " + operatorSymbol + " ";
        }

        // ---------------- = 버튼 ----------------
        private void Equal_BT_Click(object sender, EventArgs e)
        {
            string[] parts = InputBox.Text.Split(' ');
            if (parts.Length < 3 || !int.TryParse(parts[2], out n2))
            {
                MessageBox.Show("계산할 숫자를 입력하세요.");
                return;
            }

            int result = 0;
            switch (op)
            {
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
                case "x":
                    result = n1 * n2;
                    break;
                case "÷":
                    if (n2 == 0)
                    {
                        MessageBox.Show("0으로 나눌 수 없습니다.");
                        return;
                    }
                    result = n1 / n2;
                    break;
                default:
                    MessageBox.Show("연산자를 선택하세요.");
                    return;
            }

            // 계산 결과를 InputBox와 OutputBox 모두에 표시
            InputBox.Text += " = " + result;
            OutputBox.Text = result.ToString();
        }

        // ---------------- 초기화 C ----------------
        private void C_BT_Click(object sender, EventArgs e)
        {
            InputBox.Clear();
            OutputBox.Clear();
            n1 = n2 = 0;
            op = "";
        }

        // ---------------- CE 버튼 ----------------
        private void CE_BT_Click(object sender, EventArgs e)
        {
            InputBox.Clear();
        }

        // ---------------- DEL 버튼 ----------------
        private void Del_BT_Click(object sender, EventArgs e)
        {
            if (InputBox.Text.Length > 0)
                InputBox.Text = InputBox.Text.Substring(0, InputBox.Text.Length - 1);
        }

        // ---------------- ± 버튼 ----------------
        private void PsM_BT_Click(object sender, EventArgs e)
        {
            if (int.TryParse(InputBox.Text, out int value))
                InputBox.Text = (-value).ToString();
        }

        // ---------------- . 버튼 ----------------
        private void Point_BT_Click(object sender, EventArgs e)
        {
            if (!InputBox.Text.Contains("."))
                InputBox.Text += ".";
        }
    }
}