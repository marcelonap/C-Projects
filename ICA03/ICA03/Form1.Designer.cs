namespace ICA03
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
            this.UI_Btn_Stp = new System.Windows.Forms.Button();
            this.UI_Btn_Str = new System.Windows.Forms.Button();
            this.UI_Btn_Rst = new System.Windows.Forms.Button();
            this.UI_Timer = new System.Windows.Forms.Timer(this.components);
            this.UI_SWDisplay = new System.Windows.Forms.Label();
            this.UI_Btn_Spl = new System.Windows.Forms.Button();
            this.UI_List = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // UI_Btn_Stp
            // 
            this.UI_Btn_Stp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Btn_Stp.Location = new System.Drawing.Point(186, 114);
            this.UI_Btn_Stp.Name = "UI_Btn_Stp";
            this.UI_Btn_Stp.Size = new System.Drawing.Size(75, 24);
            this.UI_Btn_Stp.TabIndex = 3;
            this.UI_Btn_Stp.Text = "Stop";
            this.UI_Btn_Stp.UseVisualStyleBackColor = true;
            this.UI_Btn_Stp.Click += new System.EventHandler(this.UI_Btn_Stp_Click);
            // 
            // UI_Btn_Str
            // 
            this.UI_Btn_Str.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Btn_Str.Location = new System.Drawing.Point(186, 84);
            this.UI_Btn_Str.Name = "UI_Btn_Str";
            this.UI_Btn_Str.Size = new System.Drawing.Size(75, 24);
            this.UI_Btn_Str.TabIndex = 1;
            this.UI_Btn_Str.Text = "Start";
            this.UI_Btn_Str.UseVisualStyleBackColor = true;
            this.UI_Btn_Str.Click += new System.EventHandler(this.UI_Btn_Str_Click);
            // 
            // UI_Btn_Rst
            // 
            this.UI_Btn_Rst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Btn_Rst.Location = new System.Drawing.Point(186, 144);
            this.UI_Btn_Rst.Name = "UI_Btn_Rst";
            this.UI_Btn_Rst.Size = new System.Drawing.Size(75, 24);
            this.UI_Btn_Rst.TabIndex = 4;
            this.UI_Btn_Rst.Text = "Reset";
            this.UI_Btn_Rst.UseVisualStyleBackColor = true;
            this.UI_Btn_Rst.Click += new System.EventHandler(this.UI_Btn_Rst_Click);
            // 
            // UI_Timer
            // 
            this.UI_Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UI_SWDisplay
            // 
            this.UI_SWDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_SWDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UI_SWDisplay.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_SWDisplay.Location = new System.Drawing.Point(12, 17);
            this.UI_SWDisplay.Name = "UI_SWDisplay";
            this.UI_SWDisplay.Size = new System.Drawing.Size(249, 65);
            this.UI_SWDisplay.TabIndex = 0;
            this.UI_SWDisplay.Text = "label1";
            this.UI_SWDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_Btn_Spl
            // 
            this.UI_Btn_Spl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Btn_Spl.Location = new System.Drawing.Point(186, 344);
            this.UI_Btn_Spl.Name = "UI_Btn_Spl";
            this.UI_Btn_Spl.Size = new System.Drawing.Size(75, 23);
            this.UI_Btn_Spl.TabIndex = 2;
            this.UI_Btn_Spl.Text = "Split";
            this.UI_Btn_Spl.UseVisualStyleBackColor = true;
            this.UI_Btn_Spl.Click += new System.EventHandler(this.UI_Btn_Spl_Click);
            // 
            // UI_List
            // 
            this.UI_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_List.FormattingEnabled = true;
            this.UI_List.IntegralHeight = false;
            this.UI_List.Location = new System.Drawing.Point(12, 84);
            this.UI_List.Name = "UI_List";
            this.UI_List.Size = new System.Drawing.Size(168, 283);
            this.UI_List.TabIndex = 0;
            this.UI_List.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 387);
            this.Controls.Add(this.UI_List);
            this.Controls.Add(this.UI_Btn_Spl);
            this.Controls.Add(this.UI_SWDisplay);
            this.Controls.Add(this.UI_Btn_Rst);
            this.Controls.Add(this.UI_Btn_Str);
            this.Controls.Add(this.UI_Btn_Stp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UI_Btn_Stp;
        private System.Windows.Forms.Button UI_Btn_Str;
        private System.Windows.Forms.Button UI_Btn_Rst;
        private System.Windows.Forms.Timer UI_Timer;
        private System.Windows.Forms.Label UI_SWDisplay;
        private System.Windows.Forms.Button UI_Btn_Spl;
        private System.Windows.Forms.ListBox UI_List;
    }
}

