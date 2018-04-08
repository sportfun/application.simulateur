namespace application.simulateur.Components.Forms
{
    partial class LoginForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblLinkID = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnSubmit.Location = new System.Drawing.Point(39, 136);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(427, 40);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Démarrer";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblLinkID
            // 
            this.lblLinkID.AutoSize = true;
            this.lblLinkID.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.lblLinkID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblLinkID.Location = new System.Drawing.Point(35, 58);
            this.lblLinkID.Name = "lblLinkID";
            this.lblLinkID.Size = new System.Drawing.Size(54, 19);
            this.lblLinkID.TabIndex = 1;
            this.lblLinkID.Text = "LinkID";
            // 
            // txtLink
            // 
            this.txtLink.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.txtLink.Location = new System.Drawing.Point(95, 55);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(371, 27);
            this.txtLink.TabIndex = 0;
            // 
            // txtHost
            // 
            this.txtHost.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.txtHost.Location = new System.Drawing.Point(95, 12);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(275, 27);
            this.txtHost.TabIndex = 5;
            this.txtHost.Text = "149.202.41.22";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.lblHost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblHost.Location = new System.Drawing.Point(35, 15);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(46, 19);
            this.lblHost.TabIndex = 6;
            this.lblHost.Text = "Host:";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.txtPort.Location = new System.Drawing.Point(390, 12);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(76, 27);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "8080";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(373, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = ":";
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblError.Location = new System.Drawing.Point(35, 90);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(431, 43);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "lblError";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(500, 188);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.lblLinkID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion au Service SportsFun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblLinkID;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
    }
}