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
        public FrmAgenda()
        {
            InitializeComponent();

            // Associa o evento Load do formulário ao método FrmAgenda_Load
            this.Load += FrmAgenda_Load;
        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            CarregarAgenda(DateTime.Today);
            DestacarDatas();

            // Destaca todas as datas existentes na tabela
            DestacarDatas();

            CarregarAgenda(DateTime.Today);
            DestacarDatas();

            // Adiciona os botões apenas uma vez
            if (!dataGridView1.Columns.Contains("Editar"))
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.HeaderText = "";
                btnEditar.Name = "Editar";
                btnEditar.Text = "Editar";
                btnEditar.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnEditar);
            }

            if (!dataGridView1.Columns.Contains("Excluir"))
            {
                DataGridViewButtonColumn btnExcluir = new DataGridViewButtonColumn();
                btnExcluir.HeaderText = "";
                btnExcluir.Name = "Excluir";
                btnExcluir.Text = "Excluir";
                btnExcluir.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnExcluir);
            }
        }


        private void CarregarAgenda(DateTime datainicial)
        {
            string conexao = "Server=SQLEXPRESS;Database=CJ3027708PR2;User Id=aluno;Password=aluno;";
            string sql = @"SELECT NOMECLI, HOSPEDAGEM, MUMERACAOROUPA, DATAAGENDA, DATACOMEMORATIVA, DATACOMEMORATIVADESCRI, HORARIO, casaco
                   FROM cadcli
                   WHERE DATAAGENDA>= @datainicial
                   ORDER BY DATAAGENDA, HORARIO";

            using (SqlConnection con = new SqlConnection(conexao))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@datainicial", datainicial);


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Passa o primeiro dia do mês selecionado
            DateTime dataSelecionada = new DateTime(e.Start.Year, e.Start.Month, 1);
            CarregarAgenda(dataSelecionada);
        }
        private void DestacarDatas()
        {
            string conexao = @"Server=SQLEXPRESS;Database=CJ3027708PR2;User Id=aluno;Password=aluno;";
            string sql = "SELECT DATAAGENDA FROM cadcli";

            using (SqlConnection con = new SqlConnection(conexao))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<DateTime> datas = new List<DateTime>();

                while (reader.Read())
                {
                    datas.Add(Convert.ToDateTime(reader["DATAAGENDA"]));
                }

                monthCalendar1.BoldedDates = datas.ToArray();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // Voltar para a tela inicial
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignora header

            // Clique no botão EDITAR
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                EditarRegistro(e.RowIndex);
            }

            // Clique no botão EXCLUIR
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Excluir")
            {
                ExcluirRegistro(e.RowIndex);
            }
        }l
    }