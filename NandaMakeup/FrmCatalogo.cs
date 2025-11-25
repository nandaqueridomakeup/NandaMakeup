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
    public partial class FrmCatalogo : Form
    {
        public FrmCatalogo()
        {
            InitializeComponent();
        }

        private void FrmCatalogo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selecionados = GetAllCheckBoxes(this)
                .Where(c => c.Checked)
                .Select(c => c.Text)
                .ToList();

            if (selecionados.Count == 0)
            {
                MessageBox.Show("Escolha pelo menos um modelo.");
                return;
            }

            if (selecionados.Count > 3)
            {
                MessageBox.Show("Você só pode escolher até 3 modelos.");
                return;
            }

             var formIdent = new FrmIdenficacao(selecionados);
            formIdent.Show();
           
        }

        // 🔍 Método recursivo para buscar todos os CheckBoxes do formulário
        private IEnumerable<CheckBox> GetAllCheckBoxes(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is CheckBox checkBox)
                    yield return checkBox;

                // se o controle tiver filhos, busca neles também
                foreach (var child in GetAllCheckBoxes(control))
                    yield return child;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
        
    

        
    

