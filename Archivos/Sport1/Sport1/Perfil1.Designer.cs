namespace Sport1
{
    partial class Perfil1
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblNomPerfil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(72, 511);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(169, 107);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver a inicio";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblNomPerfil
            // 
            this.lblNomPerfil.AutoSize = true;
            this.lblNomPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblNomPerfil.Location = new System.Drawing.Point(45, 47);
            this.lblNomPerfil.Name = "lblNomPerfil";
            this.lblNomPerfil.Size = new System.Drawing.Size(70, 25);
            this.lblNomPerfil.TabIndex = 1;
            this.lblNomPerfil.Text = "label1";
            this.lblNomPerfil.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Perfil1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.lblNomPerfil);
            this.Controls.Add(this.btnVolver);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Perfil1";
            this.Text = "Perfil1";
            this.Load += new System.EventHandler(this.Perfil1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblNomPerfil;
    }
}