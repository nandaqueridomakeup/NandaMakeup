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
    public partial class FrmAgenda : Form
    {
        string conexao = "Server=SQLEXPRESS;Database=CJ3027708PR2;User Id=aluno;Password=aluno;";
        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
          


            // Carregar agendamentos do dia atual ao abrir a tela
            CarregarAgenda(DateTime.Today);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Quando trocar a data no calendário, recarrega os dados
            CarregarAgenda(e.Start);
        }

        private void CarregarAgenda(DateTime dataSelecionada)
        {
            using (SqlConnection con = new SqlConnection(conexao))
            {
                try
                {
                    con.Open(); // Abrir conexão

                    string query = @"
                        SELECT 
                            NOMECLI,
                            HOSPEDAGEM,
                            MUMERACAOROUPA,
                            DATAAGENDA,
                            DATACOMEMORATIVA,
                            DATACOMEMORATIVADESCRI,
                            HORARIO
                        FROM CADCLI
                        WHERE CAST(DATAAGENDA AS DATE) = @Data
                        ORDER BY HORARIO";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Data", dataSelecionada.Date);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    // Ajustar colunas para ficarem mais legíveis
                    dataGridView1.Columns["NOMECLI"].HeaderText = "Cliente";
                    dataGridView1.Columns["HOSPEDAGEM"].HeaderText = "Hospedagem";
                    dataGridView1.Columns["MUMERACAOROUPA"].HeaderText = "Roupa";
                    dataGridView1.Columns["HORARIO"].HeaderText = "Horário";
                    dataGridView1.Columns["DATACOMEMORATIVA"].HeaderText = "Comemorativa";
                    dataGridView1.Columns["DATACOMEMORATIVADESCRI"].HeaderText = "Descrição";

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar agenda: " + ex.Message);
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // Voltar para a tela inicial
            this.Close();
        }
    }
}