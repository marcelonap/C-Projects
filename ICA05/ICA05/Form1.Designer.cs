namespace ICA05
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UI_FIND_BTN = new System.Windows.Forms.Button();
            this.UI_RADIO = new System.Windows.Forms.RadioButton();
            this.UI_FILE_RBTN = new System.Windows.Forms.RadioButton();
            this.UI_GRBX = new System.Windows.Forms.GroupBox();
            this.UI_T_TBX2 = new System.Windows.Forms.TextBox();
            this.UI_T_TBX1 = new System.Windows.Forms.TextBox();
            this.UI_T_LBL1 = new System.Windows.Forms.Label();
            this.UI_T_LBL2 = new System.Windows.Forms.Label();
            this.UI_F_TBX1 = new System.Windows.Forms.TextBox();
            this.UI_F_TBX2 = new System.Windows.Forms.TextBox();
            this.UI_F_LBL1 = new System.Windows.Forms.Label();
            this.UI_F_LBL2 = new System.Windows.Forms.Label();
            this.UI_LBX = new System.Windows.Forms.ListBox();
            this.UI_LPF_LBL = new System.Windows.Forms.Label();
            this.UI_OFD = new System.Windows.Forms.OpenFileDialog();
            this.UI_GRBX.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_FIND_BTN
            // 
            this.UI_FIND_BTN.Location = new System.Drawing.Point(212, 175);
            this.UI_FIND_BTN.Name = "UI_FIND_BTN";
            this.UI_FIND_BTN.Size = new System.Drawing.Size(168, 43);
            this.UI_FIND_BTN.TabIndex = 3;
            this.UI_FIND_BTN.Text = "Find Palindrome(s)";
            this.UI_FIND_BTN.UseVisualStyleBackColor = true;
            this.UI_FIND_BTN.Click += new System.EventHandler(this.UI_FIND_BTN_Click);
            // 
            // UI_RADIO
            // 
            this.UI_RADIO.AutoSize = true;
            this.UI_RADIO.Checked = true;
            this.UI_RADIO.Location = new System.Drawing.Point(25, 28);
            this.UI_RADIO.Name = "UI_RADIO";
            this.UI_RADIO.Size = new System.Drawing.Size(76, 17);
            this.UI_RADIO.TabIndex = 0;
            this.UI_RADIO.TabStop = true;
            this.UI_RADIO.Text = "Test Value";
            this.UI_RADIO.UseVisualStyleBackColor = true;
            this.UI_RADIO.CheckedChanged += new System.EventHandler(this.UI_RADIO_CheckedChanged);
            // 
            // UI_FILE_RBTN
            // 
            this.UI_FILE_RBTN.AutoSize = true;
            this.UI_FILE_RBTN.Location = new System.Drawing.Point(25, 63);
            this.UI_FILE_RBTN.Name = "UI_FILE_RBTN";
            this.UI_FILE_RBTN.Size = new System.Drawing.Size(41, 17);
            this.UI_FILE_RBTN.TabIndex = 1;
            this.UI_FILE_RBTN.TabStop = true;
            this.UI_FILE_RBTN.Text = "File";
            this.UI_FILE_RBTN.UseVisualStyleBackColor = true;
            this.UI_FILE_RBTN.CheckedChanged += new System.EventHandler(this.UI_RADIO_CheckedChanged);
            // 
            // UI_GRBX
            // 
            this.UI_GRBX.Controls.Add(this.UI_FILE_RBTN);
            this.UI_GRBX.Controls.Add(this.UI_RADIO);
            this.UI_GRBX.Location = new System.Drawing.Point(554, 89);
            this.UI_GRBX.Name = "UI_GRBX";
            this.UI_GRBX.Size = new System.Drawing.Size(180, 107);
            this.UI_GRBX.TabIndex = 2;
            this.UI_GRBX.TabStop = false;
            this.UI_GRBX.Text = "Check Palindrome From";
            // 
            // UI_T_TBX2
            // 
            this.UI_T_TBX2.Location = new System.Drawing.Point(212, 133);
            this.UI_T_TBX2.Name = "UI_T_TBX2";
            this.UI_T_TBX2.ReadOnly = true;
            this.UI_T_TBX2.Size = new System.Drawing.Size(226, 20);
            this.UI_T_TBX2.TabIndex = 0;
            // 
            // UI_T_TBX1
            // 
            this.UI_T_TBX1.Location = new System.Drawing.Point(212, 89);
            this.UI_T_TBX1.Name = "UI_T_TBX1";
            this.UI_T_TBX1.Size = new System.Drawing.Size(225, 20);
            this.UI_T_TBX1.TabIndex = 1;
            // 
            // UI_T_LBL1
            // 
            this.UI_T_LBL1.AutoSize = true;
            this.UI_T_LBL1.Location = new System.Drawing.Point(145, 92);
            this.UI_T_LBL1.Name = "UI_T_LBL1";
            this.UI_T_LBL1.Size = new System.Drawing.Size(61, 13);
            this.UI_T_LBL1.TabIndex = 3;
            this.UI_T_LBL1.Text = "Test Value:";
            // 
            // UI_T_LBL2
            // 
            this.UI_T_LBL2.AutoSize = true;
            this.UI_T_LBL2.Location = new System.Drawing.Point(112, 136);
            this.UI_T_LBL2.Name = "UI_T_LBL2";
            this.UI_T_LBL2.Size = new System.Drawing.Size(94, 13);
            this.UI_T_LBL2.TabIndex = 4;
            this.UI_T_LBL2.Text = "Test Value Result:";
            // 
            // UI_F_TBX1
            // 
            this.UI_F_TBX1.Location = new System.Drawing.Point(174, 304);
            this.UI_F_TBX1.Name = "UI_F_TBX1";
            this.UI_F_TBX1.ReadOnly = true;
            this.UI_F_TBX1.Size = new System.Drawing.Size(226, 20);
            this.UI_F_TBX1.TabIndex = 5;
            // 
            // UI_F_TBX2
            // 
            this.UI_F_TBX2.Location = new System.Drawing.Point(174, 343);
            this.UI_F_TBX2.Name = "UI_F_TBX2";
            this.UI_F_TBX2.ReadOnly = true;
            this.UI_F_TBX2.Size = new System.Drawing.Size(226, 20);
            this.UI_F_TBX2.TabIndex = 6;
            // 
            // UI_F_LBL1
            // 
            this.UI_F_LBL1.AutoSize = true;
            this.UI_F_LBL1.Location = new System.Drawing.Point(30, 307);
            this.UI_F_LBL1.Name = "UI_F_LBL1";
            this.UI_F_LBL1.Size = new System.Drawing.Size(138, 13);
            this.UI_F_LBL1.TabIndex = 7;
            this.UI_F_LBL1.Text = "Palindrome Count From File:";
            // 
            // UI_F_LBL2
            // 
            this.UI_F_LBL2.AutoSize = true;
            this.UI_F_LBL2.Location = new System.Drawing.Point(63, 346);
            this.UI_F_LBL2.Name = "UI_F_LBL2";
            this.UI_F_LBL2.Size = new System.Drawing.Size(105, 13);
            this.UI_F_LBL2.TabIndex = 8;
            this.UI_F_LBL2.Text = "Execution Time (ms):";
            // 
            // UI_LBX
            // 
            this.UI_LBX.FormattingEnabled = true;
            this.UI_LBX.Location = new System.Drawing.Point(494, 247);
            this.UI_LBX.Name = "UI_LBX";
            this.UI_LBX.Size = new System.Drawing.Size(285, 186);
            this.UI_LBX.TabIndex = 9;
            // 
            // UI_LPF_LBL
            // 
            this.UI_LPF_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_LPF_LBL.Location = new System.Drawing.Point(453, 203);
            this.UI_LPF_LBL.Name = "UI_LPF_LBL";
            this.UI_LPF_LBL.Size = new System.Drawing.Size(382, 41);
            this.UI_LPF_LBL.TabIndex = 10;
            this.UI_LPF_LBL.Text = "List of Palindromes From File";
            this.UI_LPF_LBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // UI_OFD
            // 
            this.UI_OFD.FileName = "OFD_FILE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_LPF_LBL);
            this.Controls.Add(this.UI_LBX);
            this.Controls.Add(this.UI_F_LBL2);
            this.Controls.Add(this.UI_F_LBL1);
            this.Controls.Add(this.UI_F_TBX2);
            this.Controls.Add(this.UI_F_TBX1);
            this.Controls.Add(this.UI_T_LBL2);
            this.Controls.Add(this.UI_FIND_BTN);
            this.Controls.Add(this.UI_T_LBL1);
            this.Controls.Add(this.UI_T_TBX1);
            this.Controls.Add(this.UI_GRBX);
            this.Controls.Add(this.UI_T_TBX2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.UI_GRBX.ResumeLayout(false);
            this.UI_GRBX.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button UI_FIND_BTN;
        private System.Windows.Forms.RadioButton UI_RADIO;
        private System.Windows.Forms.RadioButton UI_FILE_RBTN;
        private System.Windows.Forms.GroupBox UI_GRBX;
        private System.Windows.Forms.TextBox UI_T_TBX2;
        private System.Windows.Forms.TextBox UI_T_TBX1;
        private System.Windows.Forms.Label UI_T_LBL1;
        private System.Windows.Forms.Label UI_T_LBL2;
        private System.Windows.Forms.TextBox UI_F_TBX1;
        private System.Windows.Forms.TextBox UI_F_TBX2;
        private System.Windows.Forms.Label UI_F_LBL1;
        private System.Windows.Forms.Label UI_F_LBL2;
        private System.Windows.Forms.ListBox UI_LBX;
        private System.Windows.Forms.Label UI_LPF_LBL;
        private System.Windows.Forms.OpenFileDialog UI_OFD;
    }
}

