namespace NandaMakeup
{
    partial class FrmProduct
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
            this.TxtNomeCompleto = new System.Windows.Forms.TextBox();
            this.TxtHospedagem = new System.Windows.Forms.TextBox();
            this.LblHospedagem1 = new System.Windows.Forms.Label();
            this.TxtBoxNumeracaoRoupa = new System.Windows.Forms.TextBox();
            this.RbSim = new System.Windows.Forms.RadioButton();
            this.RbNao = new System.Windows.Forms.RadioButton();
            this.TxtOcasiao = new System.Windows.Forms.TextBox();
            this.BtnPróximo = new System.Windows.Forms.Button();
            this.DtpDataHorario = new System.Windows.Forms.DateTimePicker();
            this.CmbHorario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TxtNomeCompleto
            // 
            this.TxtNomeCompleto.Location = new System.Drawing.Point(207, 231);
            this.TxtNomeCompleto.Name = "TxtNomeCompleto";
            this.TxtNomeCompleto.Size = new System.Drawing.Size(200, 20);
            this.TxtNomeCompleto.TabIndex = 4;
            // 
            // TxtHospedagem
            // 
            this.TxtHospedagem.Location = new System.Drawing.Point(456, 231);
            this.TxtHospedagem.Name = "TxtHospedagem";
            this.TxtHospedagem.Size = new System.Drawing.Size(200, 20);
            this.TxtHospedagem.TabIndex = 6;
            this.TxtHospedagem.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LblHospedagem1
            // 
            this.LblHospedagem1.AutoSize = true;
            this.LblHospedagem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHospedagem1.Location = new System.Drawing.Point(20, 80);
            this.LblHospedagem1.Name = "LblHospedagem1";
            this.LblHospedagem1.Size = new System.Drawing.Size(0, 31);
            this.LblHospedagem1.TabIndex = 5;
            this.LblHospedagem1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtBoxNumeracaoRoupa
            // 
            this.TxtBoxNumeracaoRoupa.Location = new System.Drawing.Point(725, 231);
            this.TxtBoxNumeracaoRoupa.Name = "TxtBoxNumeracaoRoupa";
            this.TxtBoxNumeracaoRoupa.Size = new System.Drawing.Size(171, 20);
            this.TxtBoxNumeracaoRoupa.TabIndex = 9;
            // 
            // RbSim
            // 
            this.RbSim.AutoSize = true;
            this.RbSim.Location = new System.Drawing.Point(725, 358);
            this.RbSim.Name = "RbSim";
            this.RbSim.Size = new System.Drawing.Size(44, 17);
            this.RbSim.TabIndex = 15;
            this.RbSim.TabStop = true;
            this.RbSim.Text = "SIM";
            this.RbSim.UseVisualStyleBackColor = true;
            this.RbSim.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RbNao
            // 
            this.RbNao.AutoSize = true;
            this.RbNao.Location = new System.Drawing.Point(725, 392);
            this.RbNao.Name = "RbNao";
            this.RbNao.Size = new System.Drawing.Size(48, 17);
            this.RbNao.TabIndex = 16;
            this.RbNao.TabStop = true;
            this.RbNao.Text = "NÃO";
            this.RbNao.UseVisualStyleBackColor = true;
            // 
            // TxtOcasiao
            // 
            this.TxtOcasiao.Location = new System.Drawing.Point(793, 355);
            this.TxtOcasiao.Name = "TxtOcasiao";
            this.TxtOcasiao.Size = new System.Drawing.Size(128, 20);
            this.TxtOcasiao.TabIndex = 18;
            // 
            // BtnPróximo
            // 
            this.BtnPróximo.Location = new System.Drawing.Point(977, 562);
            this.BtnPróximo.Name = "BtnPróximo";
            this.BtnPróximo.Size = new System.Drawing.Size(75, 23);
            this.BtnPróximo.TabIndex = 19;
            this.BtnPróximo.Text = "Próximo";
            this.BtnPróximo.UseVisualStyleBackColor = true;
            this.BtnPróximo.Click += new System.EventHandler(this.BtnPróximo_Click);
            // 
            // DtpDataHorario
            // 
            this.DtpDataHorario.Location = new System.Drawing.Point(197, 351);
            this.DtpDataHorario.Name = "DtpDataHorario";
            this.DtpDataHorario.Size = new System.Drawing.Size(242, 20);
            this.DtpDataHorario.TabIndex = 20;
            this.DtpDataHorario.ValueChanged += new System.EventHandler(this.DtpDataHorario_ValueChanged);
            // 
            // CmbHorario
            // 
            this.CmbHorario.FormattingEnabled = true;
            this.CmbHorario.Items.AddRange(new object[] {
            "4 hrs ",
            "5 hrs",
            "6 hrs ",
            "7 hrs",
            "14 hrs ",
            "15 hrs ",
            "16 hrs",
            "17 hrs ",
            "18 hrs ",
            "19 hrs ",
            "20 hrs "});
            this.CmbHorario.Location = new System.Drawing.Point(499, 350);
            this.CmbHorario.Name = "CmbHorario";
            this.CmbHorario.Size = new System.Drawing.Size(121, 21);
            this.CmbHorario.TabIndex = 21;
            this.CmbHorario.SelectedIndexChanged += new System.EventHandler(this.CmbHorario_SelectedIndexChanged);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NandaMakeup.Properties.Resources._10__1_;
            this.ClientSize = new System.Drawing.Size(1064, 591);
            this.Controls.Add(this.CmbHorario);
            this.Controls.Add(this.DtpDataHorario);
            this.Controls.Add(this.BtnPróximo);
            this.Controls.Add(this.TxtOcasiao);
            this.Controls.Add(this.RbNao);
            this.Controls.Add(this.RbSim);
            this.Controls.Add(this.TxtBoxNumeracaoRoupa);
            this.Controls.Add(this.TxtHospedagem);
            this.Controls.Add(this.LblHospedagem1);
            this.Controls.Add(this.TxtNomeCompleto);
            this.Name = "FrmProduct";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNomeCompleto;
        private System.Windows.Forms.TextBox TxtHospedagem;
        private System.Windows.Forms.Label LblHospedagem1;
        private System.Windows.Forms.TextBox TxtBoxNumeracaoRoupa;
        private System.Windows.Forms.RadioButton RbSim;
        private System.Windows.Forms.RadioButton RbNao;
        private System.Windows.Forms.TextBox TxtOcasiao;
        private System.Windows.Forms.Button BtnPróximo;
        private System.Windows.Forms.DateTimePicker DtpDataHorario;
        private System.Windows.Forms.ComboBox CmbHorario;
    }
}