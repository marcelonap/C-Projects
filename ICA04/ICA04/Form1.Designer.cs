namespace ICA04
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UI_RBTN_KMH = new System.Windows.Forms.RadioButton();
            this.UI_RBTN = new System.Windows.Forms.RadioButton();
            this.UI_IN_TXB = new System.Windows.Forms.TextBox();
            this.UI_OUT_TBX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.UI_RBTN_KMH);
            this.groupBox1.Controls.Add(this.UI_RBTN);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Units";
            // 
            // UI_RBTN_KMH
            // 
            this.UI_RBTN_KMH.AutoSize = true;
            this.UI_RBTN_KMH.Checked = true;
            this.UI_RBTN_KMH.Location = new System.Drawing.Point(8, 42);
            this.UI_RBTN_KMH.Name = "UI_RBTN_KMH";
            this.UI_RBTN_KMH.Size = new System.Drawing.Size(144, 17);
            this.UI_RBTN_KMH.TabIndex = 0;
            this.UI_RBTN_KMH.TabStop = true;
            this.UI_RBTN_KMH.Text = "Kilometres per Hour (kph)";
            this.UI_RBTN_KMH.UseVisualStyleBackColor = true;
            this.UI_RBTN_KMH.CheckedChanged += new System.EventHandler(this.UI_RBTN_CheckedChanged);
            // 
            // UI_RBTN
            // 
            this.UI_RBTN.AutoSize = true;
            this.UI_RBTN.Location = new System.Drawing.Point(6, 19);
            this.UI_RBTN.Name = "UI_RBTN";
            this.UI_RBTN.Size = new System.Drawing.Size(123, 17);
            this.UI_RBTN.TabIndex = 0;
            this.UI_RBTN.Text = "Miles Per Hour (mph)";
            this.UI_RBTN.UseVisualStyleBackColor = true;
            this.UI_RBTN.CheckedChanged += new System.EventHandler(this.UI_RBTN_CheckedChanged);
            // 
            // UI_IN_TXB
            // 
            this.UI_IN_TXB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_IN_TXB.Location = new System.Drawing.Point(20, 146);
            this.UI_IN_TXB.Name = "UI_IN_TXB";
            this.UI_IN_TXB.Size = new System.Drawing.Size(225, 20);
            this.UI_IN_TXB.TabIndex = 1;
            this.UI_IN_TXB.Text = "0";
            this.UI_IN_TXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UI_IN_TXB.TextChanged += new System.EventHandler(this.UI_RBTN_CheckedChanged);
            // 
            // UI_OUT_TBX
            // 
            this.UI_OUT_TBX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_OUT_TBX.Location = new System.Drawing.Point(20, 194);
            this.UI_OUT_TBX.Name = "UI_OUT_TBX";
            this.UI_OUT_TBX.Size = new System.Drawing.Size(225, 20);
            this.UI_OUT_TBX.TabIndex = 2;
            this.UI_OUT_TBX.Text = "0";
            this.UI_OUT_TBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Speed: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Output Speed:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 238);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_OUT_TBX);
            this.Controls.Add(this.UI_IN_TXB);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton UI_RBTN_KMH;
        private System.Windows.Forms.RadioButton UI_RBTN;
        private System.Windows.Forms.TextBox UI_IN_TXB;
        private System.Windows.Forms.TextBox UI_OUT_TBX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

