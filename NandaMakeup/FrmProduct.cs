using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NandaMakeup
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void LblName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnPróximo_Click(object sender, EventArgs e)
        {
            string nome = TxtNomeCompleto.Text;
            string hospedagem= TxtHospedagem.Text;
            string numeracaoroupa = TxtBoxNumeracaoRoupa.Text;
            string datahorario = DtpDataHorario.Value.ToString("dd/MM/yyyy HH:mm");

            string datacomemorativa = RbSim.Checked ? "Sim" : "Não";
            string ocasiao = RbSim.Checked ? TxtOcasiao.Text : "Nenhuma";

            string mensagem = $"Cadastro realizado com sucesso! \n\n" +
                $"Nome completo: {nome}\n" +
                $"Hospedagem: {hospedagem}\n"+
                $"Numeração de roupa: {numeracaoroupa}\n"+
                $"Data e horário: {datahorario}\n" +
                $"Data Comemorativa: {datacomemorativa}\n"+
                $"Ocasião: {ocasiao}\n";

            MessageBox.Show (mensagem, "Dados cadastrados", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void DtpDataHorario_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
