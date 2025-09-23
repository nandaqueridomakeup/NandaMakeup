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
    public partial class Frmroduct : Form
    {
        public Frmroduct()
        {
            InitializeComponent();
        }

    

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void Frmroduct_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {

            FRMSenha product = new FRMSenha();
            product.ShowDialog();
            
        }

        private void Frmroduct_Load(object sender, EventArgs e)
        {
           
        }

        private void PnlAcessCli_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnlAcessCli_Click(object sender, EventArgs e)
        {
            FrmLook look = new FrmLook();
            look.ShowDialog();
        }
    }
}
