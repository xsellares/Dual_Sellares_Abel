
namespace Sprint2_M20
{
    partial class TrustedDevices
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
            this.lblMAC = new System.Windows.Forms.Label();
            this.lblHostname = new System.Windows.Forms.Label();
            this.txtMAC = new System.Windows.Forms.TextBox();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMAC
            // 
            this.lblMAC.AutoSize = true;
            this.lblMAC.Location = new System.Drawing.Point(96, 108);
            this.lblMAC.Name = "lblMAC";
            this.lblMAC.Size = new System.Drawing.Size(45, 17);
            this.lblMAC.TabIndex = 0;
            this.lblMAC.Text = "M.A.C";
            // 
            // lblHostname
            // 
            this.lblHostname.AutoSize = true;
            this.lblHostname.Location = new System.Drawing.Point(96, 165);
            this.lblHostname.Name = "lblHostname";
            this.lblHostname.Size = new System.Drawing.Size(72, 17);
            this.lblHostname.TabIndex = 1;
            this.lblHostname.Text = "Hostname";
            // 
            // txtMAC
            // 
            this.txtMAC.Enabled = false;
            this.txtMAC.Location = new System.Drawing.Point(192, 108);
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.Size = new System.Drawing.Size(201, 22);
            this.txtMAC.TabIndex = 2;
            // 
            // txtHostname
            // 
            this.txtHostname.Enabled = false;
            this.txtHostname.Location = new System.Drawing.Point(192, 165);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(201, 22);
            this.txtHostname.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(99, 248);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(229, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 40);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TrustedDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 390);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtHostname);
            this.Controls.Add(this.txtMAC);
            this.Controls.Add(this.lblHostname);
            this.Controls.Add(this.lblMAC);
            this.Name = "TrustedDevices";
            this.Text = "TrustedDevices";
            this.Load += new System.EventHandler(this.TrustedDevices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMAC;
        private System.Windows.Forms.Label lblHostname;
        private System.Windows.Forms.TextBox txtMAC;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}