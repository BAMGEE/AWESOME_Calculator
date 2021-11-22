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
        {0
        }
        private void button8_Click(object sender, EventArgs e)
        {
        }
        private void button9_Click(object sender, EventArgs e)
        {
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
        }
        private void button4_Click(object sender, EventArgs e)
        {
        }
        private void button5_Click(object sender, EventArgs e)
        {
        }
        private void button6_Click(object sender, EventArgs e)
        {
        }
        private void buttonMulti_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
        }
        private void buttonDiv_Click(object sender, EventArgs e)
        {
        }
        private void button0_Click(object sender, EventArgs e)
        {
        }
        private void buttonDot_Click(object sender, EventArgs e)
        {
        }
        private void buttonResult_Click(object sender, EventArgs e)
        {
        }
    }
}