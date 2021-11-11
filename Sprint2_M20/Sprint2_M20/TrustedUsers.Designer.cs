
namespace Sprint2_M20
{
    partial class TrustedUsers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.txtMAC = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnUser = new System.Windows.Forms.Label();
            this.btnHostname = new System.Windows.Forms.Label();
            this.btnMac = new System.Windows.Forms.Label();
            this.bntCheck = new System.Windows.Forms.Button();
            this.bntRegister = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtHostname);
            this.panel1.Controls.Add(this.txtMAC);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnHostname);
            this.panel1.Controls.Add(this.btnMac);
            this.panel1.Location = new System.Drawing.Point(85, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 180);
            this.panel1.TabIndex = 0;
            // 
            // txtHostname
            // 
            this.txtHostname.Enabled = false;
            this.txtHostname.Location = new System.Drawing.Point(115, 104);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(166, 22);
            this.txtHostname.TabIndex = 5;
            // 
            // txtMAC
            // 
            this.txtMAC.Enabled = false;
            this.txtMAC.Location = new System.Drawing.Point(115, 50);
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.Size = new System.Drawing.Size(166, 22);
            this.txtMAC.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Abel",
            "Xavi"});
            this.comboBox1.Location = new System.Drawing.Point(415, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // btnUser
            // 
            this.btnUser.AutoSize = true;
            this.btnUser.Location = new System.Drawing.Point(351, 51);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(42, 17);
            this.btnUser.TabIndex = 2;
            this.btnUser.Text = "User:";
            // 
            // btnHostname
            // 
            this.btnHostname.AutoSize = true;
            this.btnHostname.Location = new System.Drawing.Point(42, 104);
            this.btnHostname.Name = "btnHostname";
            this.btnHostname.Size = new System.Drawing.Size(72, 17);
            this.btnHostname.TabIndex = 1;
            this.btnHostname.Text = "Hostname";
            // 
            // btnMac
            // 
            this.btnMac.AutoSize = true;
            this.btnMac.Location = new System.Drawing.Point(42, 51);
            this.btnMac.Name = "btnMac";
            this.btnMac.Size = new System.Drawing.Size(45, 17);
            this.btnMac.TabIndex = 0;
            this.btnMac.Text = "M.A.C";
            // 
            // bntCheck
            // 
            this.bntCheck.Location = new System.Drawing.Point(130, 287);
            this.bntCheck.Name = "bntCheck";
            this.bntCheck.Size = new System.Drawing.Size(123, 41);
            this.bntCheck.TabIndex = 1;
            this.bntCheck.Text = "Check";
            this.bntCheck.UseVisualStyleBackColor = true;
            // 
            // bntRegister
            // 
            this.bntRegister.Location = new System.Drawing.Point(272, 287);
            this.bntRegister.Name = "bntRegister";
            this.bntRegister.Size = new System.Drawing.Size(123, 41);
            this.bntRegister.TabIndex = 2;
            this.bntRegister.Text = "Register";
            this.bntRegister.UseVisualStyleBackColor = true;
            this.bntRegister.Click += new System.EventHandler(this.bntRegister_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(413, 287);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 41);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // TrustedUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 413);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.bntRegister);
            this.Controls.Add(this.bntCheck);
            this.Controls.Add(this.panel1);
            this.Name = "TrustedUsers";
            this.Text = "TrustedUsers";
            this.Load += new System.EventHandler(this.TrustedUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.TextBox txtMAC;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label btnUser;
        private System.Windows.Forms.Label btnHostname;
        private System.Windows.Forms.Label btnMac;
        private System.Windows.Forms.Button bntCheck;
        private System.Windows.Forms.Button bntRegister;
        private System.Windows.Forms.Button btnDelete;
    }
}