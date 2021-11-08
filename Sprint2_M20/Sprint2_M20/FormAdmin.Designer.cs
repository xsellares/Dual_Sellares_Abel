
namespace Sprint2_M20
{
    partial class FormAdmin
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
            this.btnRegenerar = new System.Windows.Forms.Button();
            this.btnGestioDispo = new System.Windows.Forms.Button();
            this.btnGestioUsu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegenerar
            // 
            this.btnRegenerar.Location = new System.Drawing.Point(365, 93);
            this.btnRegenerar.Name = "btnRegenerar";
            this.btnRegenerar.Size = new System.Drawing.Size(156, 78);
            this.btnRegenerar.TabIndex = 0;
            this.btnRegenerar.Text = "Regenerar Coordenades";
            this.btnRegenerar.UseVisualStyleBackColor = true;
            this.btnRegenerar.Click += new System.EventHandler(this.btnRegenerar_Click);
            // 
            // btnGestioDispo
            // 
            this.btnGestioDispo.Location = new System.Drawing.Point(547, 93);
            this.btnGestioDispo.Name = "btnGestioDispo";
            this.btnGestioDispo.Size = new System.Drawing.Size(156, 78);
            this.btnGestioDispo.TabIndex = 1;
            this.btnGestioDispo.Text = "Gestió de dispositius";
            this.btnGestioDispo.UseVisualStyleBackColor = true;
            // 
            // btnGestioUsu
            // 
            this.btnGestioUsu.Location = new System.Drawing.Point(365, 205);
            this.btnGestioUsu.Name = "btnGestioUsu";
            this.btnGestioUsu.Size = new System.Drawing.Size(156, 78);
            this.btnGestioUsu.TabIndex = 2;
            this.btnGestioUsu.Text = "Gestió d\'usuaris";
            this.btnGestioUsu.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 428);
            this.Controls.Add(this.btnGestioUsu);
            this.Controls.Add(this.btnGestioDispo);
            this.Controls.Add(this.btnRegenerar);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegenerar;
        private System.Windows.Forms.Button btnGestioDispo;
        private System.Windows.Forms.Button btnGestioUsu;
    }
}