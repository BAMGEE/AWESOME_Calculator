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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.buttonExit.TabIndex = 4;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(10, 253);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.MaximumSize = new System.Drawing.Size(380, 60);
            this.label1.MinimumSize = new System.Drawing.Size(380, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 60);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SkyBlue;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(20, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.MaximumSize = new System.Drawing.Size(360, 50);
            this.label2.MinimumSize = new System.Drawing.Size(360, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 50);
            this.label2.TabIndex = 2;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SkyBlue;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(20, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.MaximumSize = new System.Drawing.Size(360, 50);
            this.label3.MinimumSize = new System.Drawing.Size(360, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 50);
            this.label3.TabIndex = 1;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SkyBlue;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(20, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.MaximumSize = new System.Drawing.Size(360, 50);
            this.label4.MinimumSize = new System.Drawing.Size(360, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 50);
            this.label4.TabIndex = 0;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 750);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void CreatingNewButtons()
        {
            int horizotal = 0;
            int vertical = 340;
            Button[] buttonArray = new Button[19];

            for (int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i] = new Button();
                buttonArray[i].Location = new Point(horizotal, vertical);
                this.Controls.Add(buttonArray[i]);

                if (i == 18)
                {
                    buttonArray[i].Size = new Size(200, 82);
                }
                else
                    buttonArray[i].Size = new Size(100, 82);

                if ((i == 3) || (i == 7) || (i == 11) || (i == 15))
                {
                    horizotal = 0;
                    vertical += 82;
                }
                else
                    horizotal += 100;
            }            
            //
            // buttonDesign
            //
            for(int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i].FlatAppearance.BorderSize = 0;
                buttonArray[i].FlatAppearance.BorderColor = Color.Gainsboro;
                buttonArray[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                buttonArray[i].Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                buttonArray[i].TabStop = false;
                if ((i == 3)||(i == 7)||(i == 11)||(i == 15))
                {
                    buttonArray[i].BackColor = System.Drawing.Color.PowderBlue;
                    buttonArray[i].Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }
                else if(i == 18)
                {
                    buttonArray[i].BackColor = System.Drawing.Color.SkyBlue;
                    buttonArray[i].Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }                    
                else
                    buttonArray[i].BackColor = System.Drawing.Color.WhiteSmoke;
            }
            //
            // buttonCE
            //
            buttonArray[0].Name = "buttonCE";
            buttonArray[0].Text = "CE";
            buttonArray[0].Click += new System.EventHandler(buttonCE_Click);
            //
            // buttonC
            //
            buttonArray[1].Name = "buttonC";
            buttonArray[1].Text = "C";
            buttonArray[1].Click += new System.EventHandler(buttonC_Click);
            //
            // buttonDel
            //
            buttonArray[2].Name = "buttonDel";
            buttonArray[2].Text = "←";
            buttonArray[2].Click += new System.EventHandler(buttonDel_Click);
            //
            // buttonPlus
            //
            buttonArray[3].Name = "buttonPlus";
            buttonArray[3].Text = "＋";
            buttonArray[3].Click += new System.EventHandler(buttonPlus_Click);
            //
            // button7
            //
            buttonArray[4].Name = "button7";
            buttonArray[4].Text = "7";
            buttonArray[4].Click += new System.EventHandler(button7_Click);
            //
            // button8
            //
            buttonArray[5].Name = "button8";
            buttonArray[5].Text = "8";
            buttonArray[5].Click += new System.EventHandler(button8_Click);
            //
            // button9
            //
            buttonArray[6].Name = "button9";
            buttonArray[6].Text = "9";
            buttonArray[6].Click += new System.EventHandler(button9_Click);
            //
            // buttonMinus
            //
            buttonArray[7].Name = "buttonMinus";
            buttonArray[7].Text = "-";
            buttonArray[7].Click += new System.EventHandler(buttonMinus_Click);
            //
            // button4
            //
            buttonArray[8].Name = "button4";
            buttonArray[8].Text = "4";
            buttonArray[8].Click += new System.EventHandler(button4_Click);
            //
            // button5
            //
            buttonArray[9].Name = "button5";
            buttonArray[9].Text = "5";
            buttonArray[9].Click += new System.EventHandler(button5_Click);
            //
            // button6
            //
            buttonArray[10].Name = "button6";
            buttonArray[10].Text = "6";
            buttonArray[10].Click += new System.EventHandler(button6_Click);
            //
            // buttonMulti
            //
            buttonArray[11].Name = "buttonMulti";
            buttonArray[11].Text = "×";
            buttonArray[11].Click += new System.EventHandler(buttonMulti_Click);
            //
            // button1
            //
            buttonArray[12].Name = "button1";
            buttonArray[12].Text = "1";
            buttonArray[12].Click += new System.EventHandler(button1_Click);
            //
            // button2
            //
            buttonArray[13].Name = "button2";
            buttonArray[13].Text = "2";
            buttonArray[13].Click += new System.EventHandler(button2_Click);
            //
            // button3
            //
            buttonArray[14].Name = "button3";
            buttonArray[14].Text = "3";
            buttonArray[14].Click += new System.EventHandler(button3_Click);
            //
            // buttonDiv
            //
            buttonArray[15].Name = "buttonDiv";
            buttonArray[15].Text = "÷";
            buttonArray[15].Click += new System.EventHandler(buttonDiv_Click);
            //
            // button0
            //
            buttonArray[16].Name = "button0";
            buttonArray[16].Text = "0";
            buttonArray[16].Click += new System.EventHandler(button0_Click);
            //
            // buttonDot
            //
            buttonArray[17].Name = "buttonDot";
            buttonArray[17].Text = ".";
            buttonArray[17].Click += new System.EventHandler(buttonDot_Click);
            //
            // buttonResult
            //
            buttonArray[18].Name = "buttonResult";
            buttonArray[18].Text = "＝";
            buttonArray[18].Click += new System.EventHandler(buttonResult_Click);
        }

        #endregion
        private Button buttonExit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}