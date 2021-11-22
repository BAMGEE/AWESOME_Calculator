namespace AWESOME_Calculator
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(0, 0);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 40);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 750);
            this.ControlBox = false;
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }
        private void CreatingNewButtons()
        {
            int horizotal = 0;
            int vertical = 340;
            Button[] buttonArray = new Button[19];

            for (int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i] = new Button();
                if (i == 18)
                {
                    buttonArray[i].Size = new Size(200, 82);
                }
                else
                    buttonArray[i].Size = new Size(100, 82);
                buttonArray[i].Location = new Point(horizotal, vertical);
                if ((i == 3) || (i == 7) || (i == 11) || (i == 15))
                {
                    horizotal = 0;
                    vertical = vertical + 82;
                }
                else
                    horizotal = horizotal + 100;
                this.Controls.Add(buttonArray[i]);
            }

            //
            // buttonDesign
            //
            for(int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i].FlatAppearance.BorderSize = 0;
                buttonArray[i].FlatAppearance.BorderColor = Color.Gainsboro;
                buttonArray[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                if((i == 3)||(i == 7)||(i == 11)||(i == 15))
                {
                    buttonArray[i].BackColor = System.Drawing.Color.PowderBlue;
                }
                else if(i == 18)
                    buttonArray[i].BackColor = System.Drawing.Color.SkyBlue;
                else
                    buttonArray[i].BackColor = System.Drawing.Color.WhiteSmoke;
            }
            //
            // buttonCE
            //
            buttonArray[0].Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonArray[0].Margin = new System.Windows.Forms.Padding(0);
            buttonArray[0].Name = "buttonCE";
            buttonArray[0].TabIndex = 9;
            buttonArray[0].Text = "CE";
            buttonArray[0].UseVisualStyleBackColor = false;
            buttonArray[0].Click += new System.EventHandler(buttonCE_Click);
            //
            // buttonC
            //
            buttonArray[1].Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonArray[1].Margin = new System.Windows.Forms.Padding(0);
            buttonArray[1].Name = "buttonC";
            buttonArray[1].TabIndex = 9;
            buttonArray[1].Text = "C";
            buttonArray[1].UseVisualStyleBackColor = false;
            buttonArray[1].Click += new System.EventHandler(buttonC_Click);
            //
            // buttonPercent
            //
            buttonArray[2].Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonArray[2].Margin = new System.Windows.Forms.Padding(0);
            buttonArray[2].Name = "buttonPercent";
            buttonArray[2].TabIndex = 9;
            buttonArray[2].Text = "%";
            buttonArray[2].UseVisualStyleBackColor = false;
            buttonArray[2].Click += new System.EventHandler(buttonPercent_Click);
            //
            // buttonPlus
            //
            buttonArray[3].Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonArray[3].Margin = new System.Windows.Forms.Padding(0);
            buttonArray[3].Name = "buttonPlus";
            buttonArray[3].TabIndex = 9;
            buttonArray[3].Text = "＋";
            buttonArray[3].UseVisualStyleBackColor = false;
            buttonArray[3].Click += new System.EventHandler(buttonPlus_Click);
            //
            // button7
            //
            buttonArray[4].Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonArray[4].Margin = new System.Windows.Forms.Padding(0);
            buttonArray[4].Name = "button7";
            buttonArray[4].TabIndex = 9;
            buttonArray[4].Text = "7";
            buttonArray[4].UseVisualStyleBackColor = false;
            buttonArray[4].Click += new System.EventHandler(button7_Click);
            //
            // button8
            //
            buttonArray[5].Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonArray[5].Margin = new System.Windows.Forms.Padding(0);
            buttonArray[5].Name = "button8";
            buttonArray[5].TabIndex = 9;
            buttonArray[5].Text = "8";
            buttonArray[5].UseVisualStyleBackColor = false;
            buttonArray[5].Click += new System.EventHandler(button8_Click);
            //
            // button9
            //
            buttonArray[6].Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonArray[6].Margin = new System.Windows.Forms.Padding(0);
            buttonArray[6].Name = "button9";
            buttonArray[6].TabIndex = 9;
            buttonArray[6].Text = "9";
            buttonArray[6].UseVisualStyleBackColor = false;
            buttonArray[6].Click += new System.EventHandler(button9_Click);
            //
            // buttonMinus
            //
            buttonArray[7].Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonArray[7].Margin = new System.Windows.Forms.Padding(0);
            buttonArray[7].Name = "buttonMinus";
            buttonArray[7].TabIndex = 9;
            buttonArray[7].Text = "-";
            buttonArray[7].UseVisualStyleBackColor = false;
            buttonArray[7].Click += new System.EventHandler(buttonMinus_Click);
            //
            // button4
            //
            buttonArray[8].Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonArray[8].Margin = new System.Windows.Forms.Padding(0);
            buttonArray[8].Name = "button4";
            buttonArray[8].TabIndex = 9;
            buttonArray[8].Text = "4";
            buttonArray[8].UseVisualStyleBackColor = false;
            buttonArray[8].Click += new System.EventHandler(button4_Click);
            //
            // button5
            //
            buttonArray[9].Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonArray[9].Margin = new System.Windows.Forms.Padding(0);
            buttonArray[9].Name = "button5";
            buttonArray[9].TabIndex = 9;
            buttonArray[9].Text = "5";
            buttonArray[9].UseVisualStyleBackColor = false;
            buttonArray[9].Click += new System.EventHandler(button5_Click);
            //
            // button6
            //
            buttonArray[10].Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonArray[10].Margin = new System.Windows.Forms.Padding(0);
            buttonArray[10].Name = "button6";
            buttonArray[10].TabIndex = 9;
            buttonArray[10].Text = "6";
            buttonArray[10].UseVisualStyleBackColor = false;
            buttonArray[10].Click += new System.EventHandler(button6_Click);
            //
            // buttonMulti
            //
            buttonArray[11].Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonArray[11].Margin = new System.Windows.Forms.Padding(0);
            buttonArray[11].Name = "buttonMulti";
            buttonArray[11].TabIndex = 9;
            buttonArray[11].Text = "×";
            buttonArray[11].UseVisualStyleBackColor = false;
            buttonArray[11].Click += new System.EventHandler(buttonMulti_Click);
            //
            // button1
            //
            buttonArray[12].Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonArray[12].Margin = new System.Windows.Forms.Padding(0);
            buttonArray[12].Name = "button1";
            buttonArray[12].TabIndex = 9;
            buttonArray[12].Text = "1";
            buttonArray[12].UseVisualStyleBackColor = false;
            buttonArray[12].Click += new System.EventHandler(button1_Click);
            //
            // button2
            //
            buttonArray[13].Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonArray[13].Margin = new System.Windows.Forms.Padding(0);
            buttonArray[13].Name = "button2";
            buttonArray[13].TabIndex = 9;
            buttonArray[13].Text = "2";
            buttonArray[13].UseVisualStyleBackColor = false;
            buttonArray[13].Click += new System.EventHandler(button2_Click);
            //
            // button3
            //
            buttonArray[14].Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonArray[14].Margin = new System.Windows.Forms.Padding(0);
            buttonArray[14].Name = "button3";
            buttonArray[14].TabIndex = 9;
            buttonArray[14].Text = "3";
            buttonArray[14].UseVisualStyleBackColor = false;
            buttonArray[14].Click += new System.EventHandler(button3_Click);
            //
            // buttonDiv
            //
            buttonArray[15].Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonArray[15].Margin = new System.Windows.Forms.Padding(0);
            buttonArray[15].Name = "buttonDiv";
            buttonArray[15].TabIndex = 9;
            buttonArray[15].Text = "÷";
            buttonArray[15].UseVisualStyleBackColor = false;
            buttonArray[15].Click += new System.EventHandler(buttonDiv_Click);
            //
            // button0
            //
            buttonArray[16].Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonArray[16].Margin = new System.Windows.Forms.Padding(0);
            buttonArray[16].Name = "button0";
            buttonArray[16].TabIndex = 9;
            buttonArray[16].Text = "0";
            buttonArray[16].UseVisualStyleBackColor = false;
            buttonArray[16].Click += new System.EventHandler(button0_Click);
            //
            // buttonDot
            //
            buttonArray[17].Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonArray[17].Margin = new System.Windows.Forms.Padding(0);
            buttonArray[17].Name = "buttonDot";
            buttonArray[17].TabIndex = 9;
            buttonArray[17].Text = ".";
            buttonArray[17].UseVisualStyleBackColor = false;
            buttonArray[17].Click += new System.EventHandler(buttonDot_Click);
            //
            // buttonResult
            //
            buttonArray[18].Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonArray[18].Margin = new System.Windows.Forms.Padding(0);
            buttonArray[18].Name = "buttonResult";
            buttonArray[18].TabIndex = 9;
            buttonArray[18].Text = "＝";
            buttonArray[18].UseVisualStyleBackColor = false;
            buttonArray[18].Click += new System.EventHandler(buttonResult_Click);
        }

        #endregion
        private Button buttonExit;

    }
}