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
            this.LblName = new System.Windows.Forms.Label();
            this.TxtHospedagem = new System.Windows.Forms.TextBox();
            this.LblHospedagem1 = new System.Windows.Forms.Label();
            this.LblHospedagem = new System.Windows.Forms.Label();
            this.TxtBoxNumeracaoRoupa = new System.Windows.Forms.TextBox();
            this.LblNumeração = new System.Windows.Forms.Label();
            this.LblDataehorário = new System.Windows.Forms.Label();
            this.LblDataehorario2 = new System.Windows.Forms.Label();
            this.RbSim = new System.Windows.Forms.RadioButton();
            this.RbNao = new System.Windows.Forms.RadioButton();
            this.LblDatacomemorativa = new System.Windows.Forms.Label();
            this.TxtOcasiao = new System.Windows.Forms.TextBox();
            this.BtnPróximo = new System.Windows.Forms.Button();
            this.DtpDataHorario = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // TxtNomeCompleto
            // 
            this.TxtNomeCompleto.Location = new System.Drawing.Point(229, 12);
            this.TxtNomeCompleto.Name = "TxtNomeCompleto";
            this.TxtNomeCompleto.Size = new System.Drawing.Size(200, 20);
            this.TxtNomeCompleto.TabIndex = 4;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(20, 1);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(203, 31);
            this.LblName.TabIndex = 3;
            this.LblName.Text = "Nome completo";
            this.LblName.Click += new System.EventHandler(this.LblName_Click);
            // 
            // TxtHospedagem
            // 
            this.TxtHospedagem.Location = new System.Drawing.Point(229, 92);
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
            this.LblHospedagem1.Size = new System.Drawing.Size(182, 31);
            this.LblHospedagem1.TabIndex = 5;
            this.LblHospedagem1.Text = "Hospedagem ";
            this.LblHospedagem1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblHospedagem
            // 
            this.LblHospedagem.AutoSize = true;
            this.LblHospedagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHospedagem.Location = new System.Drawing.Point(36, 120);
            this.LblHospedagem.Name = "LblHospedagem";
            this.LblHospedagem.Size = new System.Drawing.Size(148, 18);
            this.LblHospedagem.TabIndex = 7;
            this.LblHospedagem.Text = "(nome do hotel/local)";
            this.LblHospedagem.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtBoxNumeracaoRoupa
            // 
            this.TxtBoxNumeracaoRoupa.Location = new System.Drawing.Point(258, 186);
            this.TxtBoxNumeracaoRoupa.Name = "TxtBoxNumeracaoRoupa";
            this.TxtBoxNumeracaoRoupa.Size = new System.Drawing.Size(171, 20);
            this.TxtBoxNumeracaoRoupa.TabIndex = 9;
            // 
            // LblNumeração
            // 
            this.LblNumeração.AutoSize = true;
            this.LblNumeração.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeração.Location = new System.Drawing.Point(12, 177);
            this.LblNumeração.Name = "LblNumeração";
            this.LblNumeração.Size = new System.Drawing.Size(240, 29);
            this.LblNumeração.TabIndex = 8;
            this.LblNumeração.Text = "Numeração de roupa";
            // 
            // LblDataehorário
            // 
            this.LblDataehorário.AutoSize = true;
            this.LblDataehorário.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataehorário.Location = new System.Drawing.Point(12, 246);
            this.LblDataehorário.Name = "LblDataehorário";
            this.LblDataehorário.Size = new System.Drawing.Size(185, 31);
            this.LblDataehorário.TabIndex = 10;
            this.LblDataehorário.Text = "Data e horário";
            this.LblDataehorário.Click += new System.EventHandler(this.label3_Click);
            // 
            // LblDataehorario2
            // 
            this.LblDataehorario2.AutoSize = true;
            this.LblDataehorario2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataehorario2.Location = new System.Drawing.Point(36, 291);
            this.LblDataehorario2.Name = "LblDataehorario2";
            this.LblDataehorario2.Size = new System.Drawing.Size(119, 18);
            this.LblDataehorario2.TabIndex = 12;
            this.LblDataehorario2.Text = "do agendamento";
            // 
            // RbSim
            // 
            this.RbSim.AutoSize = true;
            this.RbSim.Location = new System.Drawing.Point(274, 377);
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
            this.RbNao.Location = new System.Drawing.Point(270, 400);
            this.RbNao.Name = "RbNao";
            this.RbNao.Size = new System.Drawing.Size(48, 17);
            this.RbNao.TabIndex = 16;
            this.RbNao.TabStop = true;
            this.RbNao.Text = "NÃO";
            this.RbNao.UseVisualStyleBackColor = true;
            // 
            // LblDatacomemorativa
            // 
            this.LblDatacomemorativa.AutoSize = true;
            this.LblDatacomemorativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatacomemorativa.Location = new System.Drawing.Point(11, 343);
            this.LblDatacomemorativa.Name = "LblDatacomemorativa";
            this.LblDatacomemorativa.Size = new System.Drawing.Size(249, 31);
            this.LblDatacomemorativa.TabIndex = 17;
            this.LblDatacomemorativa.Text = "Data comemorativa";
            // 
            // TxtOcasiao
            // 
            this.TxtOcasiao.Location = new System.Drawing.Point(324, 374);
            this.TxtOcasiao.Name = "TxtOcasiao";
            this.TxtOcasiao.Size = new System.Drawing.Size(128, 20);
            this.TxtOcasiao.TabIndex = 18;
            // 
            // BtnPróximo
            // 
            this.BtnPróximo.Location = new System.Drawing.Point(699, 415);
            this.BtnPróximo.Name = "BtnPróximo";
            this.BtnPróximo.Size = new System.Drawing.Size(75, 23);
            this.BtnPróximo.TabIndex = 19;
            this.BtnPróximo.Text = "Próximo";
            this.BtnPróximo.UseVisualStyleBackColor = true;
            this.BtnPróximo.Click += new System.EventHandler(this.BtnPróximo_Click);
            // 
            // DtpDataHorario
            // 
            this.DtpDataHorario.Location = new System.Drawing.Point(229, 257);
            this.DtpDataHorario.Name = "DtpDataHorario";
            this.DtpDataHorario.Size = new System.Drawing.Size(242, 20);
            this.DtpDataHorario.TabIndex = 20;
            this.DtpDataHorario.ValueChanged += new System.EventHandler(this.DtpDataHorario_ValueChanged);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NandaMakeup.Properties.Resources.nanda3;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DtpDataHorario);
            this.Controls.Add(this.BtnPróximo);
            this.Controls.Add(this.TxtOcasiao);
            this.Controls.Add(this.LblDatacomemorativa);
            this.Controls.Add(this.RbNao);
            this.Controls.Add(this.RbSim);
            this.Controls.Add(this.LblDataehorario2);
            this.Controls.Add(this.LblDataehorário);
            this.Controls.Add(this.TxtBoxNumeracaoRoupa);
            this.Controls.Add(this.LblNumeração);
            this.Controls.Add(this.LblHospedagem);
            this.Controls.Add(this.TxtHospedagem);
            this.Controls.Add(this.LblHospedagem1);
            this.Controls.Add(this.TxtNomeCompleto);
            this.Controls.Add(this.LblName);
            this.Name = "FrmProduct";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNomeCompleto;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtHospedagem;
        private System.Windows.Forms.Label LblHospedagem1;
        private System.Windows.Forms.Label LblHospedagem;
        private System.Windows.Forms.TextBox TxtBoxNumeracaoRoupa;
        private System.Windows.Forms.Label LblNumeração;
        private System.Windows.Forms.Label LblDataehorário;
        private System.Windows.Forms.Label LblDataehorario2;
        private System.Windows.Forms.RadioButton RbSim;
        private System.Windows.Forms.RadioButton RbNao;
        private System.Windows.Forms.Label LblDatacomemorativa;
        private System.Windows.Forms.TextBox TxtOcasiao;
        private System.Windows.Forms.Button BtnPróximo;
        private System.Windows.Forms.DateTimePicker DtpDataHorario;
    }
}