namespace NandaMakeup
{
    partial class Frmroduct
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btnlogin
            // 
            this.Btnlogin.BackColor = System.Drawing.Color.MintCream;
            this.Btnlogin.Font = new System.Drawing.Font("Noto Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnlogin.Location = new System.Drawing.Point(237, 495);
            this.Btnlogin.Name = "Btnlogin";
            this.Btnlogin.Size = new System.Drawing.Size(389, 59);
            this.Btnlogin.TabIndex = 0;
            this.Btnlogin.Text = "Clique aqui";
            this.Btnlogin.UseVisualStyleBackColor = false;
            this.Btnlogin.Click += new System.EventHandler(this.Btnlogin_Click);
            // 
            // Frmroduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NandaMakeup.Properties.Resources.Yellow_and_Black_Minimalist_Makeup_Presentation1;
            this.ClientSize = new System.Drawing.Size(864, 654);
            this.Controls.Add(this.Btnlogin);
            this.Name = "Frmroduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro cliente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btnlogin;
    }
}

