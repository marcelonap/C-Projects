namespace ICA14
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
            this.UI_Lf_Btn = new System.Windows.Forms.Button();
            this.UI_Find_Btn = new System.Windows.Forms.Button();
            this.UI_St_Btn = new System.Windows.Forms.Button();
            this.UI_St_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Result_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Ofd = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // UI_Lf_Btn
            // 
            this.UI_Lf_Btn.Location = new System.Drawing.Point(12, 12);
            this.UI_Lf_Btn.Name = "UI_Lf_Btn";
            this.UI_Lf_Btn.Size = new System.Drawing.Size(75, 23);
            this.UI_Lf_Btn.TabIndex = 0;
            this.UI_Lf_Btn.Text = "Load File";
            this.UI_Lf_Btn.UseVisualStyleBackColor = true;
            this.UI_Lf_Btn.Click += new System.EventHandler(this.UI_Lf_Btn_Click);
            // 
            // UI_Find_Btn
            // 
            this.UI_Find_Btn.Enabled = false;
            this.UI_Find_Btn.Location = new System.Drawing.Point(105, 12);
            this.UI_Find_Btn.Name = "UI_Find_Btn";
            this.UI_Find_Btn.Size = new System.Drawing.Size(75, 23);
            this.UI_Find_Btn.TabIndex = 1;
            this.UI_Find_Btn.Text = "Find";
            this.UI_Find_Btn.UseVisualStyleBackColor = true;
            this.UI_Find_Btn.Click += new System.EventHandler(this.UI_Find_Btn_Click);
            // 
            // UI_St_Btn
            // 
            this.UI_St_Btn.Location = new System.Drawing.Point(550, 12);
            this.UI_St_Btn.Name = "UI_St_Btn";
            this.UI_St_Btn.Size = new System.Drawing.Size(75, 23);
            this.UI_St_Btn.TabIndex = 2;
            this.UI_St_Btn.Text = "Simple Test";
            this.UI_St_Btn.UseVisualStyleBackColor = true;
            this.UI_St_Btn.Click += new System.EventHandler(this.UI_St_Btn_Click);
            // 
            // UI_St_Tbx
            // 
            this.UI_St_Tbx.Location = new System.Drawing.Point(374, 14);
            this.UI_St_Tbx.Name = "UI_St_Tbx";
            this.UI_St_Tbx.Size = new System.Drawing.Size(170, 20);
            this.UI_St_Tbx.TabIndex = 3;
            // 
            // UI_Result_Tbx
            // 
            this.UI_Result_Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Result_Tbx.Location = new System.Drawing.Point(13, 42);
            this.UI_Result_Tbx.Multiline = true;
            this.UI_Result_Tbx.Name = "UI_Result_Tbx";
            this.UI_Result_Tbx.ReadOnly = true;
            this.UI_Result_Tbx.Size = new System.Drawing.Size(612, 129);
            this.UI_Result_Tbx.TabIndex = 4;
            // 
            // UI_Ofd
            // 
            this.UI_Ofd.FileName = "UI_Ofd_File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(635, 183);
            this.Controls.Add(this.UI_Result_Tbx);
            this.Controls.Add(this.UI_St_Tbx);
            this.Controls.Add(this.UI_St_Btn);
            this.Controls.Add(this.UI_Find_Btn);
            this.Controls.Add(this.UI_Lf_Btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_Lf_Btn;
        private System.Windows.Forms.Button UI_Find_Btn;
        private System.Windows.Forms.Button UI_St_Btn;
        private System.Windows.Forms.TextBox UI_St_Tbx;
        private System.Windows.Forms.TextBox UI_Result_Tbx;
        private System.Windows.Forms.OpenFileDialog UI_Ofd;
    }
}

