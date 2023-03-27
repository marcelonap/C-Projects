namespace ICA13
{
    partial class myForm
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
            this.UI_Tbar_G = new System.Windows.Forms.TrackBar();
            this.UI_Tbar_R = new System.Windows.Forms.TrackBar();
            this.UI_Tbar_B = new System.Windows.Forms.TrackBar();
            this.UI_Tbar_A = new System.Windows.Forms.TrackBar();
            this.UI_Col_Grbx = new System.Windows.Forms.GroupBox();
            this.UI_Op_Grbx = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Tbar_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Tbar_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Tbar_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Tbar_A)).BeginInit();
            this.UI_Col_Grbx.SuspendLayout();
            this.UI_Op_Grbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_Tbar_G
            // 
            this.UI_Tbar_G.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UI_Tbar_G.LargeChange = 15;
            this.UI_Tbar_G.Location = new System.Drawing.Point(6, 58);
            this.UI_Tbar_G.Maximum = 255;
            this.UI_Tbar_G.Name = "UI_Tbar_G";
            this.UI_Tbar_G.Size = new System.Drawing.Size(519, 45);
            this.UI_Tbar_G.TabIndex = 0;
            this.UI_Tbar_G.TickFrequency = 10;
            this.UI_Tbar_G.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.UI_Tbar_G.ValueChanged += new System.EventHandler(this.UI_Tbar_R_ValueChanged);
            // 
            // UI_Tbar_R
            // 
            this.UI_Tbar_R.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.UI_Tbar_R.LargeChange = 15;
            this.UI_Tbar_R.Location = new System.Drawing.Point(6, 16);
            this.UI_Tbar_R.Maximum = 255;
            this.UI_Tbar_R.Name = "UI_Tbar_R";
            this.UI_Tbar_R.Size = new System.Drawing.Size(519, 45);
            this.UI_Tbar_R.TabIndex = 1;
            this.UI_Tbar_R.TickFrequency = 10;
            this.UI_Tbar_R.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.UI_Tbar_R.ValueChanged += new System.EventHandler(this.UI_Tbar_R_ValueChanged);
            // 
            // UI_Tbar_B
            // 
            this.UI_Tbar_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UI_Tbar_B.Location = new System.Drawing.Point(6, 109);
            this.UI_Tbar_B.Maximum = 255;
            this.UI_Tbar_B.Name = "UI_Tbar_B";
            this.UI_Tbar_B.Size = new System.Drawing.Size(519, 45);
            this.UI_Tbar_B.TabIndex = 2;
            this.UI_Tbar_B.TickFrequency = 10;
            this.UI_Tbar_B.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.UI_Tbar_B.ValueChanged += new System.EventHandler(this.UI_Tbar_R_ValueChanged);
            // 
            // UI_Tbar_A
            // 
            this.UI_Tbar_A.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.UI_Tbar_A.Location = new System.Drawing.Point(6, 19);
            this.UI_Tbar_A.Maximum = 100;
            this.UI_Tbar_A.Name = "UI_Tbar_A";
            this.UI_Tbar_A.Size = new System.Drawing.Size(519, 45);
            this.UI_Tbar_A.TabIndex = 3;
            this.UI_Tbar_A.TickFrequency = 100;
            this.UI_Tbar_A.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.UI_Tbar_A.ValueChanged += new System.EventHandler(this.UI_Tbar_R_ValueChanged);
            // 
            // UI_Col_Grbx
            // 
            this.UI_Col_Grbx.Controls.Add(this.UI_Tbar_G);
            this.UI_Col_Grbx.Controls.Add(this.UI_Tbar_R);
            this.UI_Col_Grbx.Controls.Add(this.UI_Tbar_B);
            this.UI_Col_Grbx.Location = new System.Drawing.Point(12, 13);
            this.UI_Col_Grbx.Name = "UI_Col_Grbx";
            this.UI_Col_Grbx.Size = new System.Drawing.Size(531, 160);
            this.UI_Col_Grbx.TabIndex = 4;
            this.UI_Col_Grbx.TabStop = false;
            this.UI_Col_Grbx.Text = "Colour";
            // 
            // UI_Op_Grbx
            // 
            this.UI_Op_Grbx.Controls.Add(this.UI_Tbar_A);
            this.UI_Op_Grbx.Location = new System.Drawing.Point(12, 189);
            this.UI_Op_Grbx.Name = "UI_Op_Grbx";
            this.UI_Op_Grbx.Size = new System.Drawing.Size(531, 74);
            this.UI_Op_Grbx.TabIndex = 5;
            this.UI_Op_Grbx.TabStop = false;
            this.UI_Op_Grbx.Text = "Opacity";
            // 
            // myForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 266);
            this.Controls.Add(this.UI_Op_Grbx);
            this.Controls.Add(this.UI_Col_Grbx);
            this.MaximumSize = new System.Drawing.Size(571, 305);
            this.MinimumSize = new System.Drawing.Size(571, 305);
            this.Name = "myForm";
            this.Text = "ModelessDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.myForm_FormClosing);
            this.Load += new System.EventHandler(this.ModelessDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UI_Tbar_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Tbar_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Tbar_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_Tbar_A)).EndInit();
            this.UI_Col_Grbx.ResumeLayout(false);
            this.UI_Col_Grbx.PerformLayout();
            this.UI_Op_Grbx.ResumeLayout(false);
            this.UI_Op_Grbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar UI_Tbar_G;
        private System.Windows.Forms.TrackBar UI_Tbar_R;
        private System.Windows.Forms.TrackBar UI_Tbar_B;
        private System.Windows.Forms.TrackBar UI_Tbar_A;
        private System.Windows.Forms.GroupBox UI_Col_Grbx;
        private System.Windows.Forms.GroupBox UI_Op_Grbx;
    }
}