using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            string connectionString = "Server=SQLEXPRESS;Database=CJ3027708PR2;User Id=aluno;Password=aluno;";


            string nome = TxtNomeCompleto.Text;
            string hospedagem= TxtHospedagem.Text;
            string numeracaoroupa = TxtBoxNumeracaoRoupa.Text;
            DateTime datahorario = DtpDataHorario.Value;
           
            bool datacomemorativa = RbSim.Checked; // true se Sim, false se Não
            string ocasiao = RbSim.Checked ? TxtOcasiao.Text : null;


            string query = @"INSERT INTO CADCLI
             (NOME, HOSPEDAGEM, MUMERACAOROUPA, DATAHORARIO, DATACOMEMORATIVA, DATACOMEMORATIVADESCRI) 
        VALUES (@Nome, @Hospedagem, @Numeracaoroupa, @DataHorario, @DataComemorativa, @Ocasiao);";






            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Hospedagem", hospedagem);
                cmd.Parameters.AddWithValue("@Numeracaoroupa", numeracaoroupa);
                cmd.Parameters.AddWithValue("@DataHorario", datahorario);
                cmd.Parameters.AddWithValue("@DataComemorativa", datacomemorativa);
                cmd.Parameters.AddWithValue("@Ocasiao", (object)ocasiao ?? DBNull.Value);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados salvos com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar dados: " + ex.Message);
                }
            }
        



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
