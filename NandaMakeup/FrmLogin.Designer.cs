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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlAcessCli = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(499, 441);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 29);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PnlAcessCli
            // 
            this.PnlAcessCli.BackColor = System.Drawing.Color.Transparent;
            this.PnlAcessCli.Location = new System.Drawing.Point(36, 432);
            this.PnlAcessCli.Name = "PnlAcessCli";
            this.PnlAcessCli.Size = new System.Drawing.Size(310, 37);
            this.PnlAcessCli.TabIndex = 2;
            this.PnlAcessCli.Click += new System.EventHandler(this.PnlAcessCli_Click);
            this.PnlAcessCli.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlAcessCli_Paint);
            // 
            // Frmroduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NandaMakeup.Properties.Resources.nanda_atualizado;
            this.ClientSize = new System.Drawing.Size(864, 600);
            this.Controls.Add(this.PnlAcessCli);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "Frmroduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro cliente";
            this.Load += new System.EventHandler(this.Frmroduct_Load);
            this.Click += new System.EventHandler(this.Frmroduct_Click);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlAcessCli;
    }
}

