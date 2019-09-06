namespace D365Selfie
{
    partial class Settings
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxAuthType = new System.Windows.Forms.TextBox();
            this.textBoxServerUrl = new System.Windows.Forms.TextBox();
            this.textBoxDomain = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelAuthType = new System.Windows.Forms.Label();
            this.labelServerUrl = new System.Windows.Forms.Label();
            this.labelDomain = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(19, 195);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // textBoxAuthType
            // 
            this.textBoxAuthType.Location = new System.Drawing.Point(100, 48);
            this.textBoxAuthType.Name = "textBoxAuthType";
            this.textBoxAuthType.Size = new System.Drawing.Size(317, 20);
            this.textBoxAuthType.TabIndex = 1;
            this.textBoxAuthType.Text = "AuthType";
            // 
            // textBoxServerUrl
            // 
            this.textBoxServerUrl.Location = new System.Drawing.Point(100, 74);
            this.textBoxServerUrl.Name = "textBoxServerUrl";
            this.textBoxServerUrl.Size = new System.Drawing.Size(317, 20);
            this.textBoxServerUrl.TabIndex = 2;
            this.textBoxServerUrl.Text = "ServerUrl";
            // 
            // textBoxDomain
            // 
            this.textBoxDomain.Location = new System.Drawing.Point(100, 100);
            this.textBoxDomain.Name = "textBoxDomain";
            this.textBoxDomain.Size = new System.Drawing.Size(317, 20);
            this.textBoxDomain.TabIndex = 3;
            this.textBoxDomain.Text = "Domain";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(100, 126);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(317, 20);
            this.textBoxUserName.TabIndex = 4;
            this.textBoxUserName.Text = "UserName";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(100, 152);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(317, 20);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.Text = "Password";
            // 
            // labelAuthType
            // 
            this.labelAuthType.AutoSize = true;
            this.labelAuthType.Location = new System.Drawing.Point(16, 48);
            this.labelAuthType.Name = "labelAuthType";
            this.labelAuthType.Size = new System.Drawing.Size(53, 13);
            this.labelAuthType.TabIndex = 6;
            this.labelAuthType.Text = "AuthType";
            // 
            // labelServerUrl
            // 
            this.labelServerUrl.AutoSize = true;
            this.labelServerUrl.Location = new System.Drawing.Point(16, 74);
            this.labelServerUrl.Name = "labelServerUrl";
            this.labelServerUrl.Size = new System.Drawing.Size(54, 13);
            this.labelServerUrl.TabIndex = 7;
            this.labelServerUrl.Text = "Server Url";
            // 
            // labelDomain
            // 
            this.labelDomain.AutoSize = true;
            this.labelDomain.Location = new System.Drawing.Point(16, 100);
            this.labelDomain.Name = "labelDomain";
            this.labelDomain.Size = new System.Drawing.Size(43, 13);
            this.labelDomain.TabIndex = 8;
            this.labelDomain.Text = "Domain";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(16, 126);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(60, 13);
            this.labelUserName.TabIndex = 9;
            this.labelUserName.Text = "User Name";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(16, 152);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 10;
            this.labelPassword.Text = "Password";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(19, 13);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(189, 24);
            this.labelHeader.TabIndex = 11;
            this.labelHeader.Text = "D365Selfie Settings";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 243);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelDomain);
            this.Controls.Add(this.labelServerUrl);
            this.Controls.Add(this.labelAuthType);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.textBoxDomain);
            this.Controls.Add(this.textBoxServerUrl);
            this.Controls.Add(this.textBoxAuthType);
            this.Controls.Add(this.buttonExit);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxAuthType;
        private System.Windows.Forms.TextBox textBoxServerUrl;
        private System.Windows.Forms.TextBox textBoxDomain;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelAuthType;
        private System.Windows.Forms.Label labelServerUrl;
        private System.Windows.Forms.Label labelDomain;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelHeader;
    }
}