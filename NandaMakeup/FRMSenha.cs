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
    public partial class FRMSenha : Form
    {
        public FRMSenha()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;

            // Validação básica
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Digite o usuário e a senha.");
                return;
            }

            // String de conexão (ajuste conforme seu servidor e banco)
            string connectionString = "Server=SQLEXPRESS;Database=CJ3027708PR2;User Id=aluno;Password=aluno;";
            // Ou com SQL Login: "Server=SEU_SERVIDOR;Database=SEU_BANCO;User Id=SEU_USUARIO;Password=SUA_SENHA;"

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Usuarios WHERE NomeUsuario = @usuario AND Senha = @senha";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@senha", senha); // ⚠️ Em produção, use hash!

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                           
                            MessageBox.Show("Login bem-sucedido!");
                            txtUsuario.Clear();
                            txtSenha.Clear();
                            FrmPaginaInicial area = new FrmPaginaInicial();
                            this.Visible= false;
                            area.ShowDialog();
                            this.Visible= true;
                            
                           
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha inválidos.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar: " + ex.Message);
                }
            }
        }
    }
}