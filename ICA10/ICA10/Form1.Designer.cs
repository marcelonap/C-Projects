namespace ICA10
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
            this.components = new System.ComponentModel.Container();
            this.UI_LBL = new System.Windows.Forms.Label();
            this.UI_TIMER = new System.Windows.Forms.Timer(this.components);
            this.UI_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_LBL
            // 
            this.UI_LBL.AutoSize = true;
            this.UI_LBL.Location = new System.Drawing.Point(210, 67);
            this.UI_LBL.Name = "UI_LBL";
            this.UI_LBL.Size = new System.Drawing.Size(35, 13);
            this.UI_LBL.TabIndex = 0;
            this.UI_LBL.Text = "label1";
            // 
            // UI_TIMER
            // 
            this.UI_TIMER.Interval = 50;
            this.UI_TIMER.Tick += new System.EventHandler(this.UI_TIMER_Tick);
            // 
            // UI_BTN
            // 
            this.UI_BTN.BackColor = System.Drawing.Color.Cyan;
            this.UI_BTN.ForeColor = System.Drawing.Color.Black;
            this.UI_BTN.Location = new System.Drawing.Point(189, 119);
            this.UI_BTN.Name = "UI_BTN";
            this.UI_BTN.Size = new System.Drawing.Size(75, 23);
            this.UI_BTN.TabIndex = 1;
            this.UI_BTN.Text = "clear";
            this.UI_BTN.UseVisualStyleBackColor = false;
            this.UI_BTN.Click += new System.EventHandler(this.UI_BTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 154);
            this.Controls.Add(this.UI_BTN);
            this.Controls.Add(this.UI_LBL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_LBL;
        private System.Windows.Forms.Timer UI_TIMER;
        private System.Windows.Forms.Button UI_BTN;
    }
}

