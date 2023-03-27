namespace ICA07
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
            this.UI_LBX1 = new System.Windows.Forms.ListBox();
            this.UI_LBX2 = new System.Windows.Forms.ListBox();
            this.UI_TBX = new System.Windows.Forms.TextBox();
            this.UI_LBL = new System.Windows.Forms.Label();
            this.UI_ADD_BTN = new System.Windows.Forms.Button();
            this.UI_SRCH_BTN = new System.Windows.Forms.Button();
            this.UI_LBL_3 = new System.Windows.Forms.Label();
            this.UI_LBL_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_LBX1
            // 
            this.UI_LBX1.FormattingEnabled = true;
            this.UI_LBX1.Location = new System.Drawing.Point(13, 86);
            this.UI_LBX1.Name = "UI_LBX1";
            this.UI_LBX1.Size = new System.Drawing.Size(177, 251);
            this.UI_LBX1.TabIndex = 0;
            // 
            // UI_LBX2
            // 
            this.UI_LBX2.FormattingEnabled = true;
            this.UI_LBX2.Location = new System.Drawing.Point(565, 86);
            this.UI_LBX2.Name = "UI_LBX2";
            this.UI_LBX2.Size = new System.Drawing.Size(197, 251);
            this.UI_LBX2.TabIndex = 1;
            // 
            // UI_TBX
            // 
            this.UI_TBX.Location = new System.Drawing.Point(275, 86);
            this.UI_TBX.Name = "UI_TBX";
            this.UI_TBX.Size = new System.Drawing.Size(238, 20);
            this.UI_TBX.TabIndex = 2;
            // 
            // UI_LBL
            // 
            this.UI_LBL.AutoSize = true;
            this.UI_LBL.Location = new System.Drawing.Point(222, 86);
            this.UI_LBL.Name = "UI_LBL";
            this.UI_LBL.Size = new System.Drawing.Size(38, 13);
            this.UI_LBL.TabIndex = 3;
            this.UI_LBL.Text = "Name:";
            // 
            // UI_ADD_BTN
            // 
            this.UI_ADD_BTN.Location = new System.Drawing.Point(292, 152);
            this.UI_ADD_BTN.Name = "UI_ADD_BTN";
            this.UI_ADD_BTN.Size = new System.Drawing.Size(175, 46);
            this.UI_ADD_BTN.TabIndex = 4;
            this.UI_ADD_BTN.Text = "Add Name";
            this.UI_ADD_BTN.UseVisualStyleBackColor = true;
            this.UI_ADD_BTN.Click += new System.EventHandler(this.UI_ADD_BTN_Click);
            // 
            // UI_SRCH_BTN
            // 
            this.UI_SRCH_BTN.Location = new System.Drawing.Point(292, 222);
            this.UI_SRCH_BTN.Name = "UI_SRCH_BTN";
            this.UI_SRCH_BTN.Size = new System.Drawing.Size(175, 46);
            this.UI_SRCH_BTN.TabIndex = 5;
            this.UI_SRCH_BTN.Text = "Search";
            this.UI_SRCH_BTN.UseVisualStyleBackColor = true;
            this.UI_SRCH_BTN.Click += new System.EventHandler(this.UI_SRCH_BTN_Click);
            // 
            // UI_LBL_3
            // 
            this.UI_LBL_3.AutoSize = true;
            this.UI_LBL_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_LBL_3.Location = new System.Drawing.Point(562, 65);
            this.UI_LBL_3.Name = "UI_LBL_3";
            this.UI_LBL_3.Size = new System.Drawing.Size(180, 18);
            this.UI_LBL_3.TabIndex = 6;
            this.UI_LBL_3.Text = "List of Names (Sorted)";
            // 
            // UI_LBL_2
            // 
            this.UI_LBL_2.AutoSize = true;
            this.UI_LBL_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_LBL_2.Location = new System.Drawing.Point(9, 54);
            this.UI_LBL_2.Name = "UI_LBL_2";
            this.UI_LBL_2.Size = new System.Drawing.Size(237, 18);
            this.UI_LBL_2.TabIndex = 7;
            this.UI_LBL_2.Text = "List of Names (Order of Entry)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_LBL_2);
            this.Controls.Add(this.UI_LBL_3);
            this.Controls.Add(this.UI_SRCH_BTN);
            this.Controls.Add(this.UI_ADD_BTN);
            this.Controls.Add(this.UI_LBL);
            this.Controls.Add(this.UI_TBX);
            this.Controls.Add(this.UI_LBX2);
            this.Controls.Add(this.UI_LBX1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UI_LBX1;
        private System.Windows.Forms.ListBox UI_LBX2;
        private System.Windows.Forms.TextBox UI_TBX;
        private System.Windows.Forms.Label UI_LBL;
        private System.Windows.Forms.Button UI_ADD_BTN;
        private System.Windows.Forms.Button UI_SRCH_BTN;
        private System.Windows.Forms.Label UI_LBL_3;
        private System.Windows.Forms.Label UI_LBL_2;
    }
}

