using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;

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
            gTemp += label1.Text + ",гл,";
            cnt++;
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
            gTemp += label1.Text + ",гн,";
            cnt++;
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
            gTemp += label1.Text + ",б┐,";
            cnt++;
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
            gTemp += label1.Text + ",б└,";
            cnt++;
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
            gTemp += label1.Text;
            calculate(gTemp);
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
                    buttonResult_Click(sender, e);
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
        private void calculate(string gTemp)
        {
            int num1 = 0;
            int num2 = 0;

            Dictionary<string, int> dic = new Dictionary<string, int>();
                dic["гл"] = 1;
                dic["гн"] = 1;
                dic["б┐"] = 2;
                dic["б└"] = 2;

            string beforeOp = "";
            string[] arr = gTemp.Split(new string[] {","}, StringSplitOptions.None);

            Queue<string> queue = new Queue<string>();

            Stack<int> stackNum = new Stack<int>();
            Stack<string> stackOp = new Stack<string>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != "гл" && arr[i] != "гн" && arr[i] != "б┐" && arr[i] != "б└")
                {
                    queue.Enqueue(arr[i]);
                }

                else if(beforeOp == "" || dic[beforeOp] <= dic[arr[i]])
                {
                    beforeOp = arr[i];
                    stackOp.Push(arr[i]);
                }
                else
                {
                    while (stackOp.Count > 0)
                    {
                        queue.Enqueue(stackOp.Pop());
                    }
                }
            }
            foreach (var id in stackOp)
            {
                MessageBox.Show(id);
            }
            foreach (var id in queue)
            {
                MessageBox.Show(id);
            }
            for (int i = queue.Count; i > 0; i--)
            {
                string k = queue.Dequeue();
                if (k != "гл" && k != "гн" && k != "б┐" && k != "б└")
                {
                    stackNum.Push(Convert.ToInt32(k));
                }
                else
                {
                    switch (k)
                    {
                        case "гл":
                            num1 = stackNum.Pop();
                            num2 = stackNum.Pop();
                            stackNum.Push(num1 + num2);
                            break;
                        case "гн":
                            num1 = stackNum.Pop();
                            num2 = stackNum.Pop();
                            stackNum.Push(num1 - num2);
                            break;
                        case "б┐":
                            num1 = stackNum.Pop();
                            num2 = stackNum.Pop();
                            stackNum.Push(num1 * num2);
                            break;
                        case "б└":
                            num1 = stackNum.Pop();
                            num2 = stackNum.Pop();
                            stackNum.Push(num2 / num1);
                            break;
                    }
                }
            }

            label1.Text = stackNum.Pop().ToString();

        }
        /*
        private void calculate(char op)
        {
            int result = 0;
            int num = 0;

            switch (op)
            {
                case 'гл':
                    
                    break;
                case 'гн':
                    break;
                case 'б┐':
                    break;
                case 'б└':
                    break;
                case 'г╜':
                    gTemp = label1.Text;
                    
                    break;
            }

            cnt++;
        }
        */

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