namespace LAB02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UI_PBOX = new System.Windows.Forms.PictureBox();
            this.UI_PRBAR = new System.Windows.Forms.ProgressBar();
            this.UI_BTN_TR = new System.Windows.Forms.Button();
            this.UI_BTN_LP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UI_RBTN_N = new System.Windows.Forms.RadioButton();
            this.UI_RBTN_BW = new System.Windows.Forms.RadioButton();
            this.UI_RBTN_T = new System.Windows.Forms.RadioButton();
            this.UI_RBTN_C = new System.Windows.Forms.RadioButton();
            this.UI_TRB = new System.Windows.Forms.TrackBar();
            this.UI_LBL_LEFT = new System.Windows.Forms.Label();
            this.UI_LBL_MID = new System.Windows.Forms.Label();
            this.UI_LBL_RIGHT = new System.Windows.Forms.Label();
            this.UI_OFD = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.UI_PBOX)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_TRB)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_PBOX
            // 
            this.UI_PBOX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_PBOX.Location = new System.Drawing.Point(12, 21);
            this.UI_PBOX.Name = "UI_PBOX";
            this.UI_PBOX.Size = new System.Drawing.Size(776, 306);
            this.UI_PBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UI_PBOX.TabIndex = 0;
            this.UI_PBOX.TabStop = false;
            // 
            // UI_PRBAR
            // 
            this.UI_PRBAR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_PRBAR.Location = new System.Drawing.Point(12, 334);
            this.UI_PRBAR.Maximum = 500;
            this.UI_PRBAR.Name = "UI_PRBAR";
            this.UI_PRBAR.Size = new System.Drawing.Size(776, 10);
            this.UI_PRBAR.Step = 1;
            this.UI_PRBAR.TabIndex = 1;
            // 
            // UI_BTN_TR
            // 
            this.UI_BTN_TR.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UI_BTN_TR.Enabled = false;
            this.UI_BTN_TR.Location = new System.Drawing.Point(705, 350);
            this.UI_BTN_TR.Name = "UI_BTN_TR";
            this.UI_BTN_TR.Size = new System.Drawing.Size(83, 23);
            this.UI_BTN_TR.TabIndex = 2;
            this.UI_BTN_TR.Text = "Transform!";
            this.UI_BTN_TR.UseVisualStyleBackColor = true;
            this.UI_BTN_TR.Click += new System.EventHandler(this.UI_BTN_TR_Click);
            // 
            // UI_BTN_LP
            // 
            this.UI_BTN_LP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UI_BTN_LP.Location = new System.Drawing.Point(12, 351);
            this.UI_BTN_LP.Name = "UI_BTN_LP";
            this.UI_BTN_LP.Size = new System.Drawing.Size(86, 23);
            this.UI_BTN_LP.TabIndex = 3;
            this.UI_BTN_LP.Text = "Load Picture";
            this.UI_BTN_LP.UseVisualStyleBackColor = true;
            this.UI_BTN_LP.Click += new System.EventHandler(this.UI_BTN_LP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.UI_RBTN_N);
            this.groupBox1.Controls.Add(this.UI_RBTN_BW);
            this.groupBox1.Controls.Add(this.UI_RBTN_T);
            this.groupBox1.Controls.Add(this.UI_RBTN_C);
            this.groupBox1.Location = new System.Drawing.Point(104, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 87);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modification Type";
            // 
            // UI_RBTN_N
            // 
            this.UI_RBTN_N.AutoSize = true;
            this.UI_RBTN_N.Location = new System.Drawing.Point(123, 56);
            this.UI_RBTN_N.Name = "UI_RBTN_N";
            this.UI_RBTN_N.Size = new System.Drawing.Size(52, 17);
            this.UI_RBTN_N.TabIndex = 3;
            this.UI_RBTN_N.Text = "Noise";
            this.UI_RBTN_N.UseVisualStyleBackColor = true;
            this.UI_RBTN_N.CheckedChanged += new System.EventHandler(this.UI_TRB_ValueChanged);
            // 
            // UI_RBTN_BW
            // 
            this.UI_RBTN_BW.AutoSize = true;
            this.UI_RBTN_BW.Location = new System.Drawing.Point(7, 56);
            this.UI_RBTN_BW.Name = "UI_RBTN_BW";
            this.UI_RBTN_BW.Size = new System.Drawing.Size(92, 17);
            this.UI_RBTN_BW.TabIndex = 2;
            this.UI_RBTN_BW.Text = "Black && White";
            this.UI_RBTN_BW.UseVisualStyleBackColor = true;
            this.UI_RBTN_BW.CheckedChanged += new System.EventHandler(this.UI_TRB_ValueChanged);
            // 
            // UI_RBTN_T
            // 
            this.UI_RBTN_T.AutoSize = true;
            this.UI_RBTN_T.Location = new System.Drawing.Point(123, 20);
            this.UI_RBTN_T.Name = "UI_RBTN_T";
            this.UI_RBTN_T.Size = new System.Drawing.Size(43, 17);
            this.UI_RBTN_T.TabIndex = 1;
            this.UI_RBTN_T.Text = "Tint";
            this.UI_RBTN_T.UseVisualStyleBackColor = true;
            this.UI_RBTN_T.CheckedChanged += new System.EventHandler(this.UI_TRB_ValueChanged);
            // 
            // UI_RBTN_C
            // 
            this.UI_RBTN_C.AutoSize = true;
            this.UI_RBTN_C.Checked = true;
            this.UI_RBTN_C.Location = new System.Drawing.Point(7, 20);
            this.UI_RBTN_C.Name = "UI_RBTN_C";
            this.UI_RBTN_C.Size = new System.Drawing.Size(64, 17);
            this.UI_RBTN_C.TabIndex = 0;
            this.UI_RBTN_C.TabStop = true;
            this.UI_RBTN_C.Text = "Contrast";
            this.UI_RBTN_C.UseVisualStyleBackColor = true;
            this.UI_RBTN_C.CheckedChanged += new System.EventHandler(this.UI_TRB_ValueChanged);
            // 
            // UI_TRB
            // 
            this.UI_TRB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UI_TRB.LargeChange = 10;
            this.UI_TRB.Location = new System.Drawing.Point(360, 351);
            this.UI_TRB.Maximum = 100;
            this.UI_TRB.Name = "UI_TRB";
            this.UI_TRB.Size = new System.Drawing.Size(339, 45);
            this.UI_TRB.SmallChange = 5;
            this.UI_TRB.TabIndex = 5;
            this.UI_TRB.TickFrequency = 10;
            this.UI_TRB.Value = 20;
            this.UI_TRB.ValueChanged += new System.EventHandler(this.UI_TRB_ValueChanged);
            // 
            // UI_LBL_LEFT
            // 
            this.UI_LBL_LEFT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UI_LBL_LEFT.AutoSize = true;
            this.UI_LBL_LEFT.Location = new System.Drawing.Point(361, 424);
            this.UI_LBL_LEFT.Name = "UI_LBL_LEFT";
            this.UI_LBL_LEFT.Size = new System.Drawing.Size(29, 13);
            this.UI_LBL_LEFT.TabIndex = 6;
            this.UI_LBL_LEFT.Text = "Less";
            // 
            // UI_LBL_MID
            // 
            this.UI_LBL_MID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UI_LBL_MID.AutoSize = true;
            this.UI_LBL_MID.ForeColor = System.Drawing.Color.Blue;
            this.UI_LBL_MID.Location = new System.Drawing.Point(513, 424);
            this.UI_LBL_MID.Name = "UI_LBL_MID";
            this.UI_LBL_MID.Size = new System.Drawing.Size(0, 13);
            this.UI_LBL_MID.TabIndex = 7;
            // 
            // UI_LBL_RIGHT
            // 
            this.UI_LBL_RIGHT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UI_LBL_RIGHT.AutoSize = true;
            this.UI_LBL_RIGHT.Location = new System.Drawing.Point(663, 424);
            this.UI_LBL_RIGHT.Name = "UI_LBL_RIGHT";
            this.UI_LBL_RIGHT.Size = new System.Drawing.Size(31, 13);
            this.UI_LBL_RIGHT.TabIndex = 8;
            this.UI_LBL_RIGHT.Text = "More";
            // 
            // UI_OFD
            // 
            this.UI_OFD.FileName = "OFD_FILE";
            this.UI_OFD.Filter = resources.GetString("UI_OFD.Filter");
            this.UI_OFD.FilterIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_LBL_RIGHT);
            this.Controls.Add(this.UI_LBL_MID);
            this.Controls.Add(this.UI_LBL_LEFT);
            this.Controls.Add(this.UI_TRB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UI_BTN_LP);
            this.Controls.Add(this.UI_BTN_TR);
            this.Controls.Add(this.UI_PRBAR);
            this.Controls.Add(this.UI_PBOX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.UI_PBOX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_TRB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UI_PBOX;
        private System.Windows.Forms.ProgressBar UI_PRBAR;
        private System.Windows.Forms.Button UI_BTN_TR;
        private System.Windows.Forms.Button UI_BTN_LP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton UI_RBTN_N;
        private System.Windows.Forms.RadioButton UI_RBTN_BW;
        private System.Windows.Forms.RadioButton UI_RBTN_T;
        private System.Windows.Forms.RadioButton UI_RBTN_C;
        private System.Windows.Forms.TrackBar UI_TRB;
        private System.Windows.Forms.Label UI_LBL_LEFT;
        private System.Windows.Forms.Label UI_LBL_MID;
        private System.Windows.Forms.Label UI_LBL_RIGHT;
        private System.Windows.Forms.OpenFileDialog UI_OFD;
    }
}

