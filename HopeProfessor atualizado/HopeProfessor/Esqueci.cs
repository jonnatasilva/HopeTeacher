using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HopeProfessor
{
    public partial class Esqueci : Form
    {
        private Helpers.Dbs1 db;
        private VO.VO_Professor cruds;
        public Esqueci()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        private void VerificaPergunta() 
        {
            cruds = new VO.VO_Professor();
            cruds.pergunta = cb_PergEsq.Text;
            cruds.resposta = txt_Resp.Text;
            cruds.Inserir();
        }

        public bool verificaLogin(string pergunta, string resposta)
        {

            int retorno = -1;
            MySqlConnection conn = new MySqlConnection(@"server=localhost;database=hope;Uid=root;Pwd='';");
            string comando = "SELECT COUNT(*) FROM dados WHERE pergunta_seguranca=@pergunta AND resposta=@resposta";
            MySqlCommand cmd = new MySqlCommand(comando, conn);
            cmd.Parameters.AddWithValue("@pergunta", pergunta);
            cmd.Parameters.AddWithValue("@resposta", resposta);
            conn.Open();
            retorno = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return retorno > 0;
        }
        private void btn_enviar_Click(object sender, EventArgs e)
        {
            if (verificaLogin(cb_PergEsq.Text, txt_Resp.Text))
            {
              
                MessageBox.Show("Login OK", "Hope", MessageBoxButtons.OK, MessageBoxIcon.None);
                DadosProfessor dp = new DadosProfessor();
                dp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ops! A pergunta e a resposta não confere", "Hope", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

        }

        private void txt_Perg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
