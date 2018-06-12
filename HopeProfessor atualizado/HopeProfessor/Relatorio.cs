using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopeProfessor
{
    public partial class Relatorio : Form
    {
        private Helpers.Dbs1 db;
        private VO.VO_relatorio cruds;
        public Relatorio()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        private void Relatorio_Load(object sender, EventArgs e)
        {

        }

        private void txt_relatorio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            cruds = new VO.VO_relatorio();
            cruds.relatorio = txt_relatorio.Text;
            cruds.data = dtp_relatorio.MinDate;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtMAluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void pb_novoAluno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
