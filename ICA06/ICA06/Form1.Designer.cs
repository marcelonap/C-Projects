namespace ICA06
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
            this.UI_GEN_BTN = new System.Windows.Forms.Button();
            this.UI_FC_BTN = new System.Windows.Forms.Button();
            this.UI_FILL_BTN = new System.Windows.Forms.Button();
            this.UI_COLOR = new System.Windows.Forms.ColorDialog();
            this.UI_TRACKBAR = new System.Windows.Forms.TrackBar();
            this.UI_TBX = new System.Windows.Forms.TextBox();
            this.UI_LBL4 = new System.Windows.Forms.Label();
            this.UI_LBL3 = new System.Windows.Forms.Label();
            this.UI_LBL1 = new System.Windows.Forms.Label();
            this.UI_LBL2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UI_TRACKBAR)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_GEN_BTN
            // 
            this.UI_GEN_BTN.Location = new System.Drawing.Point(26, 178);
            this.UI_GEN_BTN.Name = "UI_GEN_BTN";
            this.UI_GEN_BTN.Size = new System.Drawing.Size(75, 23);
            this.UI_GEN_BTN.TabIndex = 0;
            this.UI_GEN_BTN.Text = "Generate";
            this.UI_GEN_BTN.UseVisualStyleBackColor = true;
            this.UI_GEN_BTN.Click += new System.EventHandler(this.UI_GEN_BTN_Click);
            // 
            // UI_FC_BTN
            // 
            this.UI_FC_BTN.Location = new System.Drawing.Point(132, 178);
            this.UI_FC_BTN.Name = "UI_FC_BTN";
            this.UI_FC_BTN.Size = new System.Drawing.Size(75, 23);
            this.UI_FC_BTN.TabIndex = 1;
            this.UI_FC_BTN.Text = "Fill Color";
            this.UI_FC_BTN.UseVisualStyleBackColor = true;
            this.UI_FC_BTN.Click += new System.EventHandler(this.UI_FC_BTN_Click);
            // 
            // UI_FILL_BTN
            // 
            this.UI_FILL_BTN.Location = new System.Drawing.Point(235, 178);
            this.UI_FILL_BTN.Name = "UI_FILL_BTN";
            this.UI_FILL_BTN.Size = new System.Drawing.Size(75, 23);
            this.UI_FILL_BTN.TabIndex = 2;
            this.UI_FILL_BTN.Text = "Fill";
            this.UI_FILL_BTN.UseVisualStyleBackColor = true;
            this.UI_FILL_BTN.Click += new System.EventHandler(this.UI_FILL_BTN_Click);
            // 
            // UI_COLOR
            // 
            this.UI_COLOR.Color = System.Drawing.Color.SteelBlue;
            // 
            // UI_TRACKBAR
            // 
            this.UI_TRACKBAR.AllowDrop = true;
            this.UI_TRACKBAR.LargeChange = 100;
            this.UI_TRACKBAR.Location = new System.Drawing.Point(12, 45);
            this.UI_TRACKBAR.Maximum = 3000;
            this.UI_TRACKBAR.Minimum = 100;
            this.UI_TRACKBAR.Name = "UI_TRACKBAR";
            this.UI_TRACKBAR.Size = new System.Drawing.Size(298, 45);
            this.UI_TRACKBAR.TabIndex = 3;
            this.UI_TRACKBAR.TickFrequency = 100;
            this.UI_TRACKBAR.Value = 100;
            // 
            // UI_TBX
            // 
            this.UI_TBX.BackColor = System.Drawing.Color.SteelBlue;
            this.UI_TBX.Enabled = false;
            this.UI_TBX.Location = new System.Drawing.Point(144, 108);
            this.UI_TBX.Multiline = true;
            this.UI_TBX.Name = "UI_TBX";
            this.UI_TBX.ReadOnly = true;
            this.UI_TBX.Size = new System.Drawing.Size(49, 39);
            this.UI_TBX.TabIndex = 4;
            // 
            // UI_LBL4
            // 
            this.UI_LBL4.AutoSize = true;
            this.UI_LBL4.Location = new System.Drawing.Point(92, 121);
            this.UI_LBL4.Name = "UI_LBL4";
            this.UI_LBL4.Size = new System.Drawing.Size(46, 13);
            this.UI_LBL4.TabIndex = 5;
            this.UI_LBL4.Text = "Fill Color";
            // 
            // UI_LBL3
            // 
            this.UI_LBL3.AutoSize = true;
            this.UI_LBL3.Location = new System.Drawing.Point(116, 18);
            this.UI_LBL3.Name = "UI_LBL3";
            this.UI_LBL3.Size = new System.Drawing.Size(91, 13);
            this.UI_LBL3.TabIndex = 6;
            this.UI_LBL3.Text = "Number of Blocks";
            // 
            // UI_LBL1
            // 
            this.UI_LBL1.AutoSize = true;
            this.UI_LBL1.Location = new System.Drawing.Point(12, 77);
            this.UI_LBL1.Name = "UI_LBL1";
            this.UI_LBL1.Size = new System.Drawing.Size(25, 13);
            this.UI_LBL1.TabIndex = 7;
            this.UI_LBL1.Text = "100";
            // 
            // UI_LBL2
            // 
            this.UI_LBL2.AutoSize = true;
            this.UI_LBL2.Location = new System.Drawing.Point(279, 77);
            this.UI_LBL2.Name = "UI_LBL2";
            this.UI_LBL2.Size = new System.Drawing.Size(31, 13);
            this.UI_LBL2.TabIndex = 8;
            this.UI_LBL2.Text = "3000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 220);
            this.Controls.Add(this.UI_LBL2);
            this.Controls.Add(this.UI_LBL1);
            this.Controls.Add(this.UI_LBL3);
            this.Controls.Add(this.UI_LBL4);
            this.Controls.Add(this.UI_TBX);
            this.Controls.Add(this.UI_TRACKBAR);
            this.Controls.Add(this.UI_FILL_BTN);
            this.Controls.Add(this.UI_FC_BTN);
            this.Controls.Add(this.UI_GEN_BTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UI_TRACKBAR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_GEN_BTN;
        private System.Windows.Forms.Button UI_FC_BTN;
        private System.Windows.Forms.Button UI_FILL_BTN;
        private System.Windows.Forms.ColorDialog UI_COLOR;
        private System.Windows.Forms.TrackBar UI_TRACKBAR;
        private System.Windows.Forms.TextBox UI_TBX;
        private System.Windows.Forms.Label UI_LBL4;
        private System.Windows.Forms.Label UI_LBL3;
        private System.Windows.Forms.Label UI_LBL1;
        private System.Windows.Forms.Label UI_LBL2;
    }
}

