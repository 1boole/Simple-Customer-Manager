
namespace FormUI.Forms
{
    partial class FormUserLogin
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
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.txtUserCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconUser = new FontAwesome.Sharp.IconPictureBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.iconStatus = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.panelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnLogin.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.IconSize = 32;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(144, 297);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(109, 49);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserPass
            // 
            this.txtUserPass.Location = new System.Drawing.Point(135, 229);
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.Size = new System.Drawing.Size(141, 23);
            this.txtUserPass.TabIndex = 15;
            // 
            // txtUserCode
            // 
            this.txtUserCode.Location = new System.Drawing.Point(135, 175);
            this.txtUserCode.Name = "txtUserCode";
            this.txtUserCode.Size = new System.Drawing.Size(141, 23);
            this.txtUserCode.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(12, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "User Pass";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "User Code";
            // 
            // iconUser
            // 
            this.iconUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconUser.IconColor = System.Drawing.Color.Gainsboro;
            this.iconUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUser.IconSize = 140;
            this.iconUser.Location = new System.Drawing.Point(135, 18);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(176, 140);
            this.iconUser.TabIndex = 16;
            this.iconUser.TabStop = false;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.iconUser);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.txtUserPass);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.txtUserCode);
            this.panelLogin.Location = new System.Drawing.Point(12, 12);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(406, 390);
            this.panelLogin.TabIndex = 17;
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.lblStatus);
            this.panelStatus.Controls.Add(this.iconStatus);
            this.panelStatus.Location = new System.Drawing.Point(449, 12);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(453, 390);
            this.panelStatus.TabIndex = 18;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStatus.Location = new System.Drawing.Point(143, 229);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(70, 30);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Status";
            // 
            // iconStatus
            // 
            this.iconStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconStatus.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.iconStatus.IconColor = System.Drawing.Color.Gainsboro;
            this.iconStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconStatus.IconSize = 140;
            this.iconStatus.Location = new System.Drawing.Point(143, 18);
            this.iconStatus.Name = "iconStatus";
            this.iconStatus.Size = new System.Drawing.Size(161, 140);
            this.iconStatus.TabIndex = 17;
            this.iconStatus.TabStop = false;
            // 
            // FormUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(988, 446);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panelLogin);
            this.Name = "FormUserLogin";
            this.Text = "FormUserLogin";
            this.Load += new System.EventHandler(this.FormUserLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnLogin;
        private System.Windows.Forms.TextBox txtUserPass;
        private System.Windows.Forms.TextBox txtUserCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconUser;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStatus;
        private FontAwesome.Sharp.IconPictureBox iconStatus;
        private System.Windows.Forms.Panel panelStatus;
    }
}