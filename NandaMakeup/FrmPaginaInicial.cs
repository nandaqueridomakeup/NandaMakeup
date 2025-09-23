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
    public partial class FrmPaginaInicial : Form
    {
        public FrmPaginaInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmProduct form = new FrmProduct();
            form.ShowDialog();
        }

        private void BtnAgenda_Click(object sender, EventArgs e)
        {

            FrmAgenda form = new FrmAgenda();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
