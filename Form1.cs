using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AWESOME_Calculator
{
    public partial class Form1 : Form
    {
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
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
        }
        private void buttonPercent_Click(object sender, EventArgs e)
        {
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
        }
        private void button7_Click(object sender, EventArgs e)
        {
            print("7");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            print("8");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            print("9");
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
        }
        private void button4_Click(object sender, EventArgs e)
        {
            print("4");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            print("5");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            print("6");
        }
        private void buttonMulti_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            print("1");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            print("2");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            print("3");
        }
        private void buttonDiv_Click(object sender, EventArgs e)
        {
        }
        private void button0_Click(object sender, EventArgs e)
        {
            print("0");
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
                    print("0");
                    break;
                case Keys.NumPad1 :
                case Keys.D1:
                    print("1");
                    break;
                case Keys.NumPad2 :
                case Keys.D2:
                    print("2");
                    break;
                case Keys.NumPad3 :
                case Keys.D3:
                    print("3");
                    break;
                case Keys.NumPad4 :
                case Keys.D4:
                    print("4");
                    break;
                case Keys.NumPad5:
                case Keys.D5 :
                    print("5");
                    break;
                case Keys.NumPad6 :
                case Keys.D6:
                    print("6");
                    break;
                case Keys.NumPad7 :
                case Keys.D7:
                    print("7");
                    break;
                case Keys.NumPad8 :
                case Keys.D8:
                    print("8");
                    break;
                case Keys.NumPad9 :
                case Keys.D9:
                    print("9");
                    break;                 
            }
        }
        
        private void print(string str)
        {
            if(str != "+" || str != "-" || str != "¡¿" || str != "¡À")
            {
                label1.Text += str;
            }            
        }
    }
}