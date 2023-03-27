namespace ICA12
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
            this.UI_TBX_IN = new System.Windows.Forms.TextBox();
            this.UI_TBX_OUT = new System.Windows.Forms.TextBox();
            this.UI_GBX = new System.Windows.Forms.GroupBox();
            this.UI_LBL_IN = new System.Windows.Forms.Label();
            this.UI_LBL_OUT = new System.Windows.Forms.Label();
            this.UI_RADIO = new System.Windows.Forms.RadioButton();
            this.UI_RBTN_LOWER = new System.Windows.Forms.RadioButton();
            this.UI_RBTN_FLIP = new System.Windows.Forms.RadioButton();
            this.UI_GBX.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_TBX_IN
            // 
            this.UI_TBX_IN.Location = new System.Drawing.Point(12, 57);
            this.UI_TBX_IN.Name = "UI_TBX_IN";
            this.UI_TBX_IN.Size = new System.Drawing.Size(572, 20);
            this.UI_TBX_IN.TabIndex = 0;
            this.UI_TBX_IN.TextChanged += new System.EventHandler(this.UI_RADIO_CheckedChanged);
            // 
            // UI_TBX_OUT
            // 
            this.UI_TBX_OUT.Location = new System.Drawing.Point(12, 200);
            this.UI_TBX_OUT.Name = "UI_TBX_OUT";
            this.UI_TBX_OUT.ReadOnly = true;
            this.UI_TBX_OUT.Size = new System.Drawing.Size(572, 20);
            this.UI_TBX_OUT.TabIndex = 1;
            // 
            // UI_GBX
            // 
            this.UI_GBX.Controls.Add(this.UI_RBTN_FLIP);
            this.UI_GBX.Controls.Add(this.UI_RBTN_LOWER);
            this.UI_GBX.Controls.Add(this.UI_RADIO);
            this.UI_GBX.Location = new System.Drawing.Point(12, 86);
            this.UI_GBX.Name = "UI_GBX";
            this.UI_GBX.Size = new System.Drawing.Size(572, 82);
            this.UI_GBX.TabIndex = 2;
            this.UI_GBX.TabStop = false;
            this.UI_GBX.Text = "Modification Type:";
            // 
            // UI_LBL_IN
            // 
            this.UI_LBL_IN.AutoSize = true;
            this.UI_LBL_IN.Location = new System.Drawing.Point(13, 41);
            this.UI_LBL_IN.Name = "UI_LBL_IN";
            this.UI_LBL_IN.Size = new System.Drawing.Size(64, 13);
            this.UI_LBL_IN.TabIndex = 3;
            this.UI_LBL_IN.Text = "Input String:";
            // 
            // UI_LBL_OUT
            // 
            this.UI_LBL_OUT.AutoSize = true;
            this.UI_LBL_OUT.Location = new System.Drawing.Point(12, 181);
            this.UI_LBL_OUT.Name = "UI_LBL_OUT";
            this.UI_LBL_OUT.Size = new System.Drawing.Size(72, 13);
            this.UI_LBL_OUT.TabIndex = 4;
            this.UI_LBL_OUT.Text = "Output String:";
            // 
            // UI_RADIO
            // 
            this.UI_RADIO.AutoSize = true;
            this.UI_RADIO.Location = new System.Drawing.Point(26, 33);
            this.UI_RADIO.Name = "UI_RADIO";
            this.UI_RADIO.Size = new System.Drawing.Size(77, 17);
            this.UI_RADIO.TabIndex = 0;
            this.UI_RADIO.Text = "Uppercase";
            this.UI_RADIO.UseVisualStyleBackColor = true;
            this.UI_RADIO.CheckedChanged += new System.EventHandler(this.UI_RADIO_CheckedChanged);
            // 
            // UI_RBTN_LOWER
            // 
            this.UI_RBTN_LOWER.AutoSize = true;
            this.UI_RBTN_LOWER.Location = new System.Drawing.Point(237, 33);
            this.UI_RBTN_LOWER.Name = "UI_RBTN_LOWER";
            this.UI_RBTN_LOWER.Size = new System.Drawing.Size(77, 17);
            this.UI_RBTN_LOWER.TabIndex = 1;
            this.UI_RBTN_LOWER.Text = "Lowercase";
            this.UI_RBTN_LOWER.UseVisualStyleBackColor = true;
            this.UI_RBTN_LOWER.CheckedChanged += new System.EventHandler(this.UI_RADIO_CheckedChanged);
            // 
            // UI_RBTN_FLIP
            // 
            this.UI_RBTN_FLIP.AutoSize = true;
            this.UI_RBTN_FLIP.Checked = true;
            this.UI_RBTN_FLIP.Location = new System.Drawing.Point(463, 33);
            this.UI_RBTN_FLIP.Name = "UI_RBTN_FLIP";
            this.UI_RBTN_FLIP.Size = new System.Drawing.Size(64, 17);
            this.UI_RBTN_FLIP.TabIndex = 2;
            this.UI_RBTN_FLIP.TabStop = true;
            this.UI_RBTN_FLIP.Text = "Flipcase";
            this.UI_RBTN_FLIP.UseVisualStyleBackColor = true;
            this.UI_RBTN_FLIP.CheckedChanged += new System.EventHandler(this.UI_RADIO_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 235);
            this.Controls.Add(this.UI_LBL_OUT);
            this.Controls.Add(this.UI_LBL_IN);
            this.Controls.Add(this.UI_GBX);
            this.Controls.Add(this.UI_TBX_OUT);
            this.Controls.Add(this.UI_TBX_IN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.UI_GBX.ResumeLayout(false);
            this.UI_GBX.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_TBX_IN;
        private System.Windows.Forms.TextBox UI_TBX_OUT;
        private System.Windows.Forms.GroupBox UI_GBX;
        private System.Windows.Forms.RadioButton UI_RBTN_FLIP;
        private System.Windows.Forms.RadioButton UI_RBTN_LOWER;
        private System.Windows.Forms.RadioButton UI_RADIO;
        private System.Windows.Forms.Label UI_LBL_IN;
        private System.Windows.Forms.Label UI_LBL_OUT;
    }
}

