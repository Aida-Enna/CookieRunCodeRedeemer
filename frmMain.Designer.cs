namespace CookieRunRedeemer
{
    partial class frmMain
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
            this.btnRedeem = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbResponse = new System.Windows.Forms.RichTextBox();
            this.btnFillCodes = new System.Windows.Forms.Button();
            this.btnRepo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRedeem
            // 
            this.btnRedeem.Location = new System.Drawing.Point(12, 294);
            this.btnRedeem.Name = "btnRedeem";
            this.btnRedeem.Size = new System.Drawing.Size(90, 23);
            this.btnRedeem.TabIndex = 1;
            this.btnRedeem.Text = "Redeem Codes";
            this.btnRedeem.UseVisualStyleBackColor = true;
            this.btnRedeem.Click += new System.EventHandler(this.btnRedeem_ClickAsync);
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(12, 22);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(173, 20);
            this.txtUserID.TabIndex = 0;
            this.txtUserID.Text = "GUEST-";
            this.txtUserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User ID: (Obtainable via Menu -> Settings -> Info, the ID right under \"User Info\"" +
    ")";
            // 
            // txtCodes
            // 
            this.txtCodes.Location = new System.Drawing.Point(12, 59);
            this.txtCodes.Multiline = true;
            this.txtCodes.Name = "txtCodes";
            this.txtCodes.Size = new System.Drawing.Size(173, 235);
            this.txtCodes.TabIndex = 3;
            this.txtCodes.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codes: (Click Fill Codes to populate)";
            // 
            // rtbResponse
            // 
            this.rtbResponse.Location = new System.Drawing.Point(191, 22);
            this.rtbResponse.Name = "rtbResponse";
            this.rtbResponse.ReadOnly = true;
            this.rtbResponse.Size = new System.Drawing.Size(311, 322);
            this.rtbResponse.TabIndex = 5;
            this.rtbResponse.TabStop = false;
            this.rtbResponse.Text = "";
            this.rtbResponse.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbResponse_LinkClicked);
            // 
            // btnFillCodes
            // 
            this.btnFillCodes.Location = new System.Drawing.Point(108, 294);
            this.btnFillCodes.Name = "btnFillCodes";
            this.btnFillCodes.Size = new System.Drawing.Size(77, 23);
            this.btnFillCodes.TabIndex = 2;
            this.btnFillCodes.Text = "Fill Codes";
            this.btnFillCodes.UseVisualStyleBackColor = true;
            this.btnFillCodes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRepo
            // 
            this.btnRepo.Location = new System.Drawing.Point(12, 321);
            this.btnRepo.Name = "btnRepo";
            this.btnRepo.Size = new System.Drawing.Size(173, 23);
            this.btnRepo.TabIndex = 3;
            this.btnRepo.Text = "Github repo/support";
            this.btnRepo.UseVisualStyleBackColor = true;
            this.btnRepo.Click += new System.EventHandler(this.btnRepo_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(514, 348);
            this.Controls.Add(this.btnRepo);
            this.Controls.Add(this.btnFillCodes);
            this.Controls.Add(this.rtbResponse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.btnRedeem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "Cookie Run Code Redeemer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRedeem;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbResponse;
        private System.Windows.Forms.Button btnFillCodes;
        private System.Windows.Forms.Button btnRepo;
    }
}

