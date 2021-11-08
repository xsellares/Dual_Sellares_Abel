
namespace Sprint2_M20
{
    partial class validacio
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPassAdmin = new System.Windows.Forms.TextBox();
            this.lblCoordenada = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(152, 167);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(344, 298);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "#";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPassAdmin
            // 
            this.txtPassAdmin.Location = new System.Drawing.Point(235, 505);
            this.txtPassAdmin.MaxLength = 4;
            this.txtPassAdmin.Name = "txtPassAdmin";
            this.txtPassAdmin.Size = new System.Drawing.Size(171, 22);
            this.txtPassAdmin.TabIndex = 1;
            this.txtPassAdmin.UseSystemPasswordChar = true;
            // 
            // lblCoordenada
            // 
            this.lblCoordenada.AutoSize = true;
            this.lblCoordenada.Location = new System.Drawing.Point(291, 82);
            this.lblCoordenada.Name = "lblCoordenada";
            this.lblCoordenada.Size = new System.Drawing.Size(46, 17);
            this.lblCoordenada.TabIndex = 2;
            this.lblCoordenada.Text = "label1";
            // 
            // validacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 584);
            this.Controls.Add(this.lblCoordenada);
            this.Controls.Add(this.txtPassAdmin);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "validacio";
            this.Text = "Validacio";
            this.Load += new System.EventHandler(this.Validacio_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPassAdmin;
        private System.Windows.Forms.Label lblCoordenada;
    }
}