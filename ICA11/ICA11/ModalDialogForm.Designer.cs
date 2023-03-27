namespace ICA11
{
    partial class ModalDialogForm
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
            this.UI_CD = new System.Windows.Forms.ColorDialog();
            this.UI_FD = new System.Windows.Forms.FontDialog();
            this.UI_BTN_SF = new System.Windows.Forms.Button();
            this.UI_BTN_SC = new System.Windows.Forms.Button();
            this.UI_TBX_F = new System.Windows.Forms.TextBox();
            this.UI_TBX_C = new System.Windows.Forms.TextBox();
            this.UI_BTN_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_BTN_SF
            // 
            this.UI_BTN_SF.Location = new System.Drawing.Point(12, 38);
            this.UI_BTN_SF.Name = "UI_BTN_SF";
            this.UI_BTN_SF.Size = new System.Drawing.Size(75, 23);
            this.UI_BTN_SF.TabIndex = 0;
            this.UI_BTN_SF.Text = "Select Font";
            this.UI_BTN_SF.UseVisualStyleBackColor = true;
            this.UI_BTN_SF.Click += new System.EventHandler(this.UI_BTN_SF_Click);
            // 
            // UI_BTN_SC
            // 
            this.UI_BTN_SC.Location = new System.Drawing.Point(12, 79);
            this.UI_BTN_SC.Name = "UI_BTN_SC";
            this.UI_BTN_SC.Size = new System.Drawing.Size(75, 23);
            this.UI_BTN_SC.TabIndex = 1;
            this.UI_BTN_SC.Text = "Select Color";
            this.UI_BTN_SC.UseVisualStyleBackColor = true;
            this.UI_BTN_SC.Click += new System.EventHandler(this.UI_BTN_SC_Click);
            // 
            // UI_TBX_F
            // 
            this.UI_TBX_F.Location = new System.Drawing.Point(112, 40);
            this.UI_TBX_F.Name = "UI_TBX_F";
            this.UI_TBX_F.ReadOnly = true;
            this.UI_TBX_F.Size = new System.Drawing.Size(346, 20);
            this.UI_TBX_F.TabIndex = 2;
            this.UI_TBX_F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UI_TBX_C
            // 
            this.UI_TBX_C.Location = new System.Drawing.Point(112, 82);
            this.UI_TBX_C.Name = "UI_TBX_C";
            this.UI_TBX_C.ReadOnly = true;
            this.UI_TBX_C.Size = new System.Drawing.Size(346, 20);
            this.UI_TBX_C.TabIndex = 3;
            this.UI_TBX_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UI_BTN_OK
            // 
            this.UI_BTN_OK.Location = new System.Drawing.Point(207, 132);
            this.UI_BTN_OK.Name = "UI_BTN_OK";
            this.UI_BTN_OK.Size = new System.Drawing.Size(75, 23);
            this.UI_BTN_OK.TabIndex = 4;
            this.UI_BTN_OK.Text = "OK";
            this.UI_BTN_OK.UseVisualStyleBackColor = true;
            this.UI_BTN_OK.Click += new System.EventHandler(this.UI_BTN_OK_Click);
            // 
            // ModalDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 167);
            this.Controls.Add(this.UI_BTN_OK);
            this.Controls.Add(this.UI_TBX_C);
            this.Controls.Add(this.UI_TBX_F);
            this.Controls.Add(this.UI_BTN_SC);
            this.Controls.Add(this.UI_BTN_SF);
            this.Name = "ModalDialogForm";
            this.Text = "ModalDialogForm";
            this.Load += new System.EventHandler(this.ModalDialogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button UI_BTN_SF;
        private System.Windows.Forms.Button UI_BTN_SC;
        private System.Windows.Forms.TextBox UI_TBX_F;
        private System.Windows.Forms.TextBox UI_TBX_C;
        private System.Windows.Forms.Button UI_BTN_OK;
        public System.Windows.Forms.ColorDialog UI_CD;
        public System.Windows.Forms.FontDialog UI_FD;
    }
}