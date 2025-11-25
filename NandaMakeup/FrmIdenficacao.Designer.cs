namespace NandaMakeup
{
    partial class FrmIdenficacao
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
            this.botton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botton1
            // 
            this.botton1.Location = new System.Drawing.Point(836, 396);
            this.botton1.Name = "botton1";
            this.botton1.Size = new System.Drawing.Size(157, 42);
            this.botton1.TabIndex = 0;
            this.botton1.Text = "Próximo";
            this.botton1.UseVisualStyleBackColor = true;
            this.botton1.Click += new System.EventHandler(this.botton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(394, 330);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(366, 20);
            this.txtNome.TabIndex = 2;
            // 
            // FrmIdenficacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NandaMakeup.Properties.Resources._103;
            this.ClientSize = new System.Drawing.Size(1005, 450);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botton1);
            this.Name = "FrmIdenficacao";
            this.Text = "FrmIdenficação";
            this.Load += new System.EventHandler(this.FrmIdenficacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
    }
}