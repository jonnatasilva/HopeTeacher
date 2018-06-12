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
    public partial class CriandoRelatorio : Form
    {
        public CriandoRelatorio()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.MinimizeBox = false;
        }

        private void pb_novoAluno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_histRelatorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExibeRelatorio frm1 = new ExibeRelatorio();
            frm1.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MenuProf mp = new MenuProf();
            mp.ShowDialog();
        }
    }
}
