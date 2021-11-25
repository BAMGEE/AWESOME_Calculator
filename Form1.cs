using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AWESOME_Calculator
{
    public partial class Form1 : Form
    {
        public int cnt = 0;
        public string gTemp = "";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public Form1()
        {
            this.KeyPreview = true;
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreatingNewButtons();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonCE_Click(object sender, EventArgs e)
        {
            calFunc('A');
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            calFunc('C');
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            calculate('+');
        }
        private void button7_Click(object sender, EventArgs e)
        {
            print('7');
        }
        private void button8_Click(object sender, EventArgs e)
        {
            print('8');
        }
        private void button9_Click(object sender, EventArgs e)
        {
            print('9');
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            calculate('-');
        }
        private void button4_Click(object sender, EventArgs e)
        {
            print('4');
        }
        private void button5_Click(object sender, EventArgs e)
        {
            print('5');
        }
        private void button6_Click(object sender, EventArgs e)
        {
            print('6');
        }
        private void buttonMulti_Click(object sender, EventArgs e)
        {
            calculate('¡¿');
        }
        private void button1_Click(object sender, EventArgs e)
        {
            print('1');
        }
        private void button2_Click(object sender, EventArgs e)
        {
            print('2');
        }
        private void button3_Click(object sender, EventArgs e)
        {
            print('3');
        }
        private void buttonDiv_Click(object sender, EventArgs e)
        {
            calculate('¡À');
        }
        private void button0_Click(object sender, EventArgs e)
        {
            print('0');
        }
        private void buttonDot_Click(object sender, EventArgs e)
        {
        }
        private void buttonResult_Click(object sender, EventArgs e)
        {
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0 :
                case Keys.D0:
                    print('0');
                    break;
                case Keys.NumPad1 :
                case Keys.D1:
                    print('1');
                    break;
                case Keys.NumPad2 :
                case Keys.D2:
                    print('2');
                    break;
                case Keys.NumPad3 :
                case Keys.D3:
                    print('3');
                    break;
                case Keys.NumPad4 :
                case Keys.D4:
                    print('4');
                    break;
                case Keys.NumPad5:
                case Keys.D5 :
                    print('5');
                    break;
                case Keys.NumPad6 :
                case Keys.D6:
                    print('6');
                    break;
                case Keys.NumPad7 :
                case Keys.D7:
                    print('7');
                    break;
                case Keys.NumPad8 :
                case Keys.D8:
                    print('8');
                    break;
                case Keys.NumPad9 :
                case Keys.D9:
                    print('9');
                    break;
                case Keys.Enter :
                    calculate('£½');
                    break;
            }
        }
        private void print(char k)
        {
            if (cnt != 0)
            {
                calFunc('A');

                if (49 <= k && k <= 57)
                {
                    if (label1.Text == "0")
                    {
                        label1.Text = "";
                    }
                    label1.Text += k.ToString();
                }
                else if (48 == k)
                {
                    if (label1.Text == "" || label1.Text == "0")
                    {
                        label1.Text = "0";
                    }
                    else
                    {
                        label1.Text += k.ToString();
                    }
                }

                cnt = 0;
            }
            else
            {
                if (49 <= k && k <= 57)
                {
                    if (label1.Text == "0")
                    {
                        label1.Text = "";
                    }
                    label1.Text += k.ToString();
                }
                else if (48 == k)
                {
                    if (label1.Text == "" || label1.Text == "0")
                    {
                        label1.Text = "0";
                    }
                    else
                    {
                        label1.Text += k.ToString();
                    }
                }
            }
        }
        private void tempArray(string temp)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
                dic["£«"] = 1;
                dic["£­"] = 1;
                dic["¡¿"] = 2;
                dic["¡À"] = 2;

            string beforeOp = "";
            string[] arr = temp.Split(new string[] {","}, StringSplitOptions.None);

            gTemp = "";

            Stack<int> stackNum = new Stack<int>();
            Stack<string> stackOp = new Stack<string>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (48 <= Convert.ToInt32(arr[i]) && Convert.ToInt32(arr[i]) <= 57)
                {
                    gTemp += arr[i];
                }
                else
                {
                    if (beforeOp == "" || dic[beforeOp] <= dic[arr[i]])
                    {
                        stackOp.Push(arr[i]);
                    }
                    else if (dic[beforeOp] > dic[arr[i]])
                    {
                        while (stackOp.Count > 0)
                        {
                            gTemp += stackOp.Pop();
                        }
                    }
                }
            }


        }
        private void calculate(char op)
        {
            int result = 0;
            int num = 0;

            switch (op)
            {
                case '£«':
                    gTemp = label1.Text + ",";
                    break;
                case '£­':
                    break;
                case '¡¿':
                    break;
                case '¡À':
                    break;
                case '£½':
                    gTemp = label1.Text;
                    tempArray(gTemp);
                    break;
            }

            cnt++;
        }

        private void calFunc(char op)
        {
            switch (op)
            {
                case 'A':
                    label1.Text = "0";
                    break;
                case 'C':
                    label1.Text = "0";
                    break;
            }
        }
        private int calPlus(int num)
        {
            return num;
        }
        private void calMinus()
        {

        }
        private void calMulti()
        {

        }
        private void calDiv()
        {

        }
    }
}