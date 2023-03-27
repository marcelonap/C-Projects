namespace ICA09
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
            this.UI_LBX_UD = new System.Windows.Forms.ListBox();
            this.UI_LBX_SD = new System.Windows.Forms.ListBox();
            this.UI_BTN_DUL = new System.Windows.Forms.Button();
            this.UI_BTN_CUL = new System.Windows.Forms.Button();
            this.UI_BTN_N2 = new System.Windows.Forms.Button();
            this.UI_BTN_QS = new System.Windows.Forms.Button();
            this.UI_BTN_CSL = new System.Windows.Forms.Button();
            this.UI_BTN_LF = new System.Windows.Forms.Button();
            this.UI_RBTN_PL = new System.Windows.Forms.RadioButton();
            this.UI_RBTN_FD = new System.Windows.Forms.RadioButton();
            this.UI_LBL_UNS = new System.Windows.Forms.Label();
            this.UI_LBL_SD = new System.Windows.Forms.Label();
            this.UI_LBL_TT = new System.Windows.Forms.Label();
            this.UI_TBX_TT = new System.Windows.Forms.TextBox();
            this.UI_OFD = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // UI_LBX_UD
            // 
            this.UI_LBX_UD.FormattingEnabled = true;
            this.UI_LBX_UD.Location = new System.Drawing.Point(12, 54);
            this.UI_LBX_UD.Name = "UI_LBX_UD";
            this.UI_LBX_UD.Size = new System.Drawing.Size(236, 355);
            this.UI_LBX_UD.TabIndex = 0;
            // 
            // UI_LBX_SD
            // 
            this.UI_LBX_SD.FormattingEnabled = true;
            this.UI_LBX_SD.Location = new System.Drawing.Point(542, 54);
            this.UI_LBX_SD.Name = "UI_LBX_SD";
            this.UI_LBX_SD.Size = new System.Drawing.Size(236, 355);
            this.UI_LBX_SD.TabIndex = 1;
            // 
            // UI_BTN_DUL
            // 
            this.UI_BTN_DUL.Location = new System.Drawing.Point(322, 54);
            this.UI_BTN_DUL.Name = "UI_BTN_DUL";
            this.UI_BTN_DUL.Size = new System.Drawing.Size(112, 39);
            this.UI_BTN_DUL.TabIndex = 2;
            this.UI_BTN_DUL.Text = "Display Unsorted List";
            this.UI_BTN_DUL.UseVisualStyleBackColor = true;
            this.UI_BTN_DUL.Click += new System.EventHandler(this.UI_BTN_DUL_Click);
            // 
            // UI_BTN_CUL
            // 
            this.UI_BTN_CUL.Location = new System.Drawing.Point(322, 110);
            this.UI_BTN_CUL.Name = "UI_BTN_CUL";
            this.UI_BTN_CUL.Size = new System.Drawing.Size(112, 39);
            this.UI_BTN_CUL.TabIndex = 3;
            this.UI_BTN_CUL.Text = "Clear Unsorted Listbox";
            this.UI_BTN_CUL.UseVisualStyleBackColor = true;
            this.UI_BTN_CUL.Click += new System.EventHandler(this.UI_BTN_CUL_Click);
            // 
            // UI_BTN_N2
            // 
            this.UI_BTN_N2.Location = new System.Drawing.Point(322, 236);
            this.UI_BTN_N2.Name = "UI_BTN_N2";
            this.UI_BTN_N2.Size = new System.Drawing.Size(112, 39);
            this.UI_BTN_N2.TabIndex = 4;
            this.UI_BTN_N2.Text = "N² Sorting";
            this.UI_BTN_N2.UseVisualStyleBackColor = true;
            this.UI_BTN_N2.Click += new System.EventHandler(this.UI_BTN_N2_Click);
            // 
            // UI_BTN_QS
            // 
            this.UI_BTN_QS.Location = new System.Drawing.Point(322, 281);
            this.UI_BTN_QS.Name = "UI_BTN_QS";
            this.UI_BTN_QS.Size = new System.Drawing.Size(112, 39);
            this.UI_BTN_QS.TabIndex = 5;
            this.UI_BTN_QS.Text = "Quick Sort";
            this.UI_BTN_QS.UseVisualStyleBackColor = true;
            this.UI_BTN_QS.Click += new System.EventHandler(this.UI_BTN_QS_Click);
            // 
            // UI_BTN_CSL
            // 
            this.UI_BTN_CSL.Location = new System.Drawing.Point(322, 326);
            this.UI_BTN_CSL.Name = "UI_BTN_CSL";
            this.UI_BTN_CSL.Size = new System.Drawing.Size(112, 39);
            this.UI_BTN_CSL.TabIndex = 6;
            this.UI_BTN_CSL.Text = "Clear Sorted Listbox";
            this.UI_BTN_CSL.UseVisualStyleBackColor = true;
            this.UI_BTN_CSL.Click += new System.EventHandler(this.UI_BTN_CSL_Click);
            // 
            // UI_BTN_LF
            // 
            this.UI_BTN_LF.Location = new System.Drawing.Point(322, 371);
            this.UI_BTN_LF.Name = "UI_BTN_LF";
            this.UI_BTN_LF.Size = new System.Drawing.Size(112, 39);
            this.UI_BTN_LF.TabIndex = 7;
            this.UI_BTN_LF.Text = "Load Files";
            this.UI_BTN_LF.UseVisualStyleBackColor = true;
            this.UI_BTN_LF.Click += new System.EventHandler(this.UI_BTN_LF_Click);
            // 
            // UI_RBTN_PL
            // 
            this.UI_RBTN_PL.AutoSize = true;
            this.UI_RBTN_PL.Checked = true;
            this.UI_RBTN_PL.Location = new System.Drawing.Point(322, 167);
            this.UI_RBTN_PL.Name = "UI_RBTN_PL";
            this.UI_RBTN_PL.Size = new System.Drawing.Size(86, 17);
            this.UI_RBTN_PL.TabIndex = 8;
            this.UI_RBTN_PL.TabStop = true;
            this.UI_RBTN_PL.Text = "Provided List";
            this.UI_RBTN_PL.UseVisualStyleBackColor = true;
            // 
            // UI_RBTN_FD
            // 
            this.UI_RBTN_FD.AutoSize = true;
            this.UI_RBTN_FD.Location = new System.Drawing.Point(322, 199);
            this.UI_RBTN_FD.Name = "UI_RBTN_FD";
            this.UI_RBTN_FD.Size = new System.Drawing.Size(67, 17);
            this.UI_RBTN_FD.TabIndex = 9;
            this.UI_RBTN_FD.TabStop = true;
            this.UI_RBTN_FD.Text = "File Data";
            this.UI_RBTN_FD.UseVisualStyleBackColor = true;
            // 
            // UI_LBL_UNS
            // 
            this.UI_LBL_UNS.AutoSize = true;
            this.UI_LBL_UNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_LBL_UNS.Location = new System.Drawing.Point(66, 33);
            this.UI_LBL_UNS.Name = "UI_LBL_UNS";
            this.UI_LBL_UNS.Size = new System.Drawing.Size(117, 18);
            this.UI_LBL_UNS.TabIndex = 10;
            this.UI_LBL_UNS.Text = "Unsorted Data";
            // 
            // UI_LBL_SD
            // 
            this.UI_LBL_SD.AutoSize = true;
            this.UI_LBL_SD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_LBL_SD.Location = new System.Drawing.Point(610, 33);
            this.UI_LBL_SD.Name = "UI_LBL_SD";
            this.UI_LBL_SD.Size = new System.Drawing.Size(98, 18);
            this.UI_LBL_SD.TabIndex = 11;
            this.UI_LBL_SD.Text = "Sorted Data";
            // 
            // UI_LBL_TT
            // 
            this.UI_LBL_TT.AutoSize = true;
            this.UI_LBL_TT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_LBL_TT.Location = new System.Drawing.Point(502, 442);
            this.UI_LBL_TT.Name = "UI_LBL_TT";
            this.UI_LBL_TT.Size = new System.Drawing.Size(170, 13);
            this.UI_LBL_TT.TabIndex = 12;
            this.UI_LBL_TT.Text = "Time Taken (Elapsed Ticks):";
            // 
            // UI_TBX_TT
            // 
            this.UI_TBX_TT.Location = new System.Drawing.Point(678, 439);
            this.UI_TBX_TT.Name = "UI_TBX_TT";
            this.UI_TBX_TT.ReadOnly = true;
            this.UI_TBX_TT.Size = new System.Drawing.Size(100, 20);
            this.UI_TBX_TT.TabIndex = 13;
            // 
            // UI_OFD
            // 
            this.UI_OFD.FileName = "OFD_File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 464);
            this.Controls.Add(this.UI_TBX_TT);
            this.Controls.Add(this.UI_LBL_TT);
            this.Controls.Add(this.UI_LBL_SD);
            this.Controls.Add(this.UI_LBL_UNS);
            this.Controls.Add(this.UI_RBTN_FD);
            this.Controls.Add(this.UI_RBTN_PL);
            this.Controls.Add(this.UI_BTN_LF);
            this.Controls.Add(this.UI_BTN_CSL);
            this.Controls.Add(this.UI_BTN_QS);
            this.Controls.Add(this.UI_BTN_N2);
            this.Controls.Add(this.UI_BTN_CUL);
            this.Controls.Add(this.UI_BTN_DUL);
            this.Controls.Add(this.UI_LBX_SD);
            this.Controls.Add(this.UI_LBX_UD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UI_LBX_UD;
        private System.Windows.Forms.ListBox UI_LBX_SD;
        private System.Windows.Forms.Button UI_BTN_DUL;
        private System.Windows.Forms.Button UI_BTN_CUL;
        private System.Windows.Forms.Button UI_BTN_N2;
        private System.Windows.Forms.Button UI_BTN_QS;
        private System.Windows.Forms.Button UI_BTN_CSL;
        private System.Windows.Forms.Button UI_BTN_LF;
        private System.Windows.Forms.RadioButton UI_RBTN_PL;
        private System.Windows.Forms.RadioButton UI_RBTN_FD;
        private System.Windows.Forms.Label UI_LBL_UNS;
        private System.Windows.Forms.Label UI_LBL_SD;
        private System.Windows.Forms.Label UI_LBL_TT;
        private System.Windows.Forms.TextBox UI_TBX_TT;
        private System.Windows.Forms.OpenFileDialog UI_OFD;
    }
}

