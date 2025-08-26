namespace NandaMakeup
{
    partial class Form1
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
            this.BtnAgenda = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAgenda
            // 
            this.BtnAgenda.Font = new System.Drawing.Font("ScriptC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgenda.Location = new System.Drawing.Point(566, 277);
            this.BtnAgenda.Name = "BtnAgenda";
            this.BtnAgenda.Size = new System.Drawing.Size(116, 45);
            this.BtnAgenda.TabIndex = 0;
            this.BtnAgenda.Text = "Agenda";
            this.BtnAgenda.UseVisualStyleBackColor = true;
            this.BtnAgenda.Click += new System.EventHandler(this.BtnAgenda_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("ScriptC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(500, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Novo Agendamento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NandaMakeup.Properties.Resources.Cópia_de_10__1_1;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnAgenda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAgenda;
        private System.Windows.Forms.Button button1;
    }
}