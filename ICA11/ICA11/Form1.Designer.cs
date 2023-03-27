namespace ICA11
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
            this.UI_LBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_LBL
            // 
            this.UI_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_LBL.AutoEllipsis = true;
            this.UI_LBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UI_LBL.Cursor = System.Windows.Forms.Cursors.Default;
            this.UI_LBL.Font = new System.Drawing.Font("Papyrus", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_LBL.ForeColor = System.Drawing.Color.Blue;
            this.UI_LBL.Location = new System.Drawing.Point(35, 9);
            this.UI_LBL.Name = "UI_LBL";
            this.UI_LBL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UI_LBL.Size = new System.Drawing.Size(414, 379);
            this.UI_LBL.TabIndex = 0;
            this.UI_LBL.Tag = "";
            this.UI_LBL.Text = "This is the selected font!";
            this.UI_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UI_LBL.Click += new System.EventHandler(this.UI_LBL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 394);
            this.Controls.Add(this.UI_LBL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label UI_LBL;
    }
}

