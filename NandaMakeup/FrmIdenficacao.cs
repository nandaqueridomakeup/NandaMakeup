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
    public partial class FrmIdenficacao : Form
    {
        List<string> CasacosSelecionados = new List<string>();
        public FrmIdenficacao(List<string> selecionados)
        {
            CasacosSelecionados = selecionados;
            InitializeComponent();
        }

        private void FrmIdenficacao_Load(object sender, EventArgs e)
        {

        }

        private void botton1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=SQLEXPRESS;Database=CJ3027708PR2;User Id=aluno;Password=aluno;";
            string nome = txtNome.Text.Trim();



            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Digite o nome completo.");
                return;
            }

            //// 🧱 Cria lista para armazenar os checkboxes marcados
            //List<string> casacosSelecionados = new List<string>();

            //// 🔁 Percorre todos os checkboxes dentro do painel
            //for (int i = 1; i <= 32; i++)
            //{
            //    string nomeCheckBox = $"checkBox{i}";

            //    // Procura dentro do panel (substitua "panel1" pelo nome real do seu painel)
            //    CheckBox cb = panel1.Controls.Find(nomeCheckBox, true).FirstOrDefault() as CheckBox;

            //    // Se o checkbox existir e estiver marcado, adiciona à lista
            //    if (cb != null && cb.Checked)
            //    {
            //        // 👉 Se quiser salvar o texto visível da checkbox:
            //        casacosSelecionados.Add(cb.Text);

            //        // 👉 Se preferir salvar o nome do controle (ex: "checkBox1"), use:
            //        // casacosSelecionados.Add(nomeCheckBox);
            //    }
            //}

            // 🔗 Cria uma string única separada por ponto e vírgula
            string casacos = string.Join("; ", CasacosSelecionados);

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // 🔍 Verifica se o cliente existe
                    string querySelect = "SELECT COUNT(*) FROM cadcli WHERE NOMECLI = @NOMECLI";
                    using (SqlCommand cmd = new SqlCommand(querySelect, con))
                    {
                        cmd.Parameters.AddWithValue("@NOMECLI", nome);
                        int count = (int)cmd.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("Nome não encontrado no cadastro.");
                            return;
                        }
                    }

                    // 💾 Atualiza o campo 'casaco' com a string dos checkboxes selecionados
                    string queryUpdate = "UPDATE cadcli SET casaco = @casaco WHERE NOMECLI = @NOMECLI";
                    using (SqlCommand cm = new SqlCommand(queryUpdate, con))
                    {
                        cm.Parameters.AddWithValue("@casaco", casacos);
                        cm.Parameters.AddWithValue("@NOMECLI", nome);
                        cm.ExecuteNonQuery();
                    }

                    MessageBox.Show("Casacos registrados com sucesso!");
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados:\n" + ex.Message, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
