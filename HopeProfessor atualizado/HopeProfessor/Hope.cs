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
    public partial class Hope : Form
    {
        private Helpers.Dbs1 db;
        private VO.VO_Professor cruds;
        //Declara duas variáveis do tipo string, 'user' e 'senha'
        string user, senha;

        public Hope()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        //Metodo Limpar
        public void Limpar()
        {
            if(txtUser.Text == "" && txtPass.Text == "")
            {
                MessageBox.Show("Os campos já estão vazios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtUser.Text = "";
                txtPass.Text = "";
            }

            txtUser.Focus();
        }

        //Cria o método 'verificaLogin' do tipo void (não retorna nada) com o modificador de acesso sendo do tipo público
        public bool verificaLogin(string usuario, string senha)
        {
      
            int retorno = -1;
            MySqlConnection conn = new MySqlConnection(@"server=localhost;database=hope;Uid=root;Pwd='';");
            string comando = "SELECT COUNT(*) FROM dados WHERE Login=@Usuario AND Senha=@Senha";
            MySqlCommand cmd = new MySqlCommand(comando, conn);
            cmd.Parameters.AddWithValue("@Usuario", usuario);
            cmd.Parameters.AddWithValue("@Senha", senha);
            conn.Open();
            retorno = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return retorno > 0; 
        }

        private void lblCadastro_Click(object sender, EventArgs e)
        {
            DadosProfessor frm2 = new DadosProfessor(); //Cria uma variável 'frm2' do tipo Form2 e instancia a mesma
            frm2.ShowDialog(); //chama a janela Form2
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (verificaLogin(txtUser.Text, txtPass.Text))
            {
                //retorno o diálogo ok
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Login OK", "Hope", MessageBoxButtons.OK, MessageBoxIcon.None);
                MenuProf fmr1 = new MenuProf();
                fmr1.ShowDialog();

            }
            else
            {
                //Senão retorno o dialogo cancel por exemplo
                this.DialogResult = DialogResult.Cancel;
                MessageBox.Show("Senha ou email incorreto!!", "Hope", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            
        }


        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla ENTER foi pressionada caso a pessoa esteja no campo 'Senha'
            if(e.KeyCode == Keys.Enter)
            {
                verificaLogin(txtUser.Text, txtPass.Text);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void lblEsqueci_Click(object sender, EventArgs e)
        {
            Esqueci esq = new Esqueci();
            esq.ShowDialog();
        }
    }
}
