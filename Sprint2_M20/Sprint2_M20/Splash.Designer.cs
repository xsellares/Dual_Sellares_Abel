
namespace Sprint2_M20
{
    partial class ProgressBarSplash
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pgbSplash = new System.Windows.Forms.ProgressBar();
            this.lblProgressBar = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelGIthub = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgbSplash
            // 
            this.pgbSplash.Location = new System.Drawing.Point(150, 194);
            this.pgbSplash.Maximum = 101;
            this.pgbSplash.Name = "pgbSplash";
            this.pgbSplash.Size = new System.Drawing.Size(482, 37);
            this.pgbSplash.TabIndex = 0;
            // 
            // lblProgressBar
            // 
            this.lblProgressBar.AutoSize = true;
            this.lblProgressBar.Location = new System.Drawing.Point(366, 250);
            this.lblProgressBar.Name = "lblProgressBar";
            this.lblProgressBar.Size = new System.Drawing.Size(28, 17);
            this.lblProgressBar.TabIndex = 1;
            this.lblProgressBar.Text = "0%";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelGIthub
            // 
            this.labelGIthub.AutoSize = true;
            this.labelGIthub.Location = new System.Drawing.Point(260, 85);
            this.labelGIthub.Name = "labelGIthub";
            this.labelGIthub.Size = new System.Drawing.Size(46, 17);
            this.labelGIthub.TabIndex = 2;
            this.labelGIthub.Text = "label1";
            // 
            // ProgressBarSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelGIthub);
            this.Controls.Add(this.lblProgressBar);
            this.Controls.Add(this.pgbSplash);
            this.Name = "ProgressBarSplash";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Splash_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbSplash;
        private System.Windows.Forms.Label lblProgressBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelGIthub;
    }
}

