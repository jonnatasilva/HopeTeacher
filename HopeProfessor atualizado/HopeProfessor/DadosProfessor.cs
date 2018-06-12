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
    public partial class DadosProfessor : Form
    {

        private Helpers.Dbs1 db;
        private VO.VO_Professor cruds;
        OpenFileDialog op = new OpenFileDialog();
        string nome, data, email, tel, tel2, usuario, senha, senha2;

        public DadosProfessor()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        public void Limpar()
        {
            if(txtNome.Text == "" && txtData.Text == "" && txtEmail.Text == "" && txtTel.Text == "" && txtTel2.Text == "" &&
                txtUser.Text == "" && txtSenha.Text == "" && txtConfirm.Text == "" && pictureBox1.Image == null)
            {
                MessageBox.Show("Todos os campos já estão vazios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtNome.Text = "";
                txtData.Text = "";
                txtEmail.Text = "";
                txtTel.Text = "";
                txtTel2.Text = "";
                txtUser.Text = "";
                txtSenha.Text = "";
                txtConfirm.Text = "";
                pictureBox1.Image = null;
                op.FileName = "";
            }

            txtNome.Focus();
        }

        public void verificaCadastro()
        {
            nome = txtNome.Text;
            data = txtData.Text;
            email = txtEmail.Text;
            tel = txtTel.Text;
            tel2 = txtTel2.Text;
            usuario = txtUser.Text;
            senha = txtSenha.Text;
            senha2 = txtConfirm.Text;

            if (nome == "" || data == "" || email == "" || tel == "" || tel2 == "" || usuario == "" || senha == "" || senha2 == "")
            {
                if (nome == "" && data == "" && email == "" && tel == "" && tel2 == "" && usuario == "" && senha == "" && senha2 == "")
                {
                    MessageBox.Show("Você deve preencher todos os campos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNome.Focus();
                }
                else if (nome == "")
                {
                    MessageBox.Show("O campo 'Nome' é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNome.Focus();
                }
                else if (data == "")
                {
                    MessageBox.Show("O campo 'Data de nascimento' é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtData.Focus();
                }
                else if (email == "")
                {
                    MessageBox.Show("O campo 'E-mail' é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                }
                else if (tel == "")
                {
                    MessageBox.Show("O campo 'Telefone' é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTel.Focus();
                }
                else if (tel2 == "")
                {
                    MessageBox.Show("O campo 'Telefone 2' é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTel2.Focus();
                }
                else if (usuario == "")
                {
                    MessageBox.Show("O campo 'Usuário' é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Focus();
                }
                else if (senha == "")
                {
                    MessageBox.Show("O campo 'Senha' é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenha.Focus();
                }
                else if (senha2 == "")
                {
                    MessageBox.Show("O campo 'Confirmar senha' é obrigatório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirm.Focus();
                }
            }
            else
            {
                //Aqui vai ter o método que vai cadastrar as informações no banco de dados
                if (txtSenha.Text == txtConfirm.Text)
                {
                    try
                    {
                        cruds = new VO.VO_Professor();


                        cruds.login = txtUser.Text;
                        cruds.senha = txtSenha.Text;
                        cruds.nome = txtNome.Text;
                        cruds.data_nasc = txtData.Text;
                        cruds.telefone_1 = txtTel.Text;
                        cruds.telefone_2 = txtTel2.Text;
                        cruds.email = txtEmail.Text;
                        //Pesquisar como salvar imagem
                        //cruds.foto = .ImageLocation;
                        cruds.pergunta = cb_Perg.Text;
                        cruds.resposta = txtResp.Text;
                        cruds.Inserir();
                        MessageBox.Show("Cadastro concluído com sucesso!", "Hope", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        MessageBox.Show("Ocorreu um erro ao realizar a operação", "Hope", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

              
                }
                else
                {
                    MessageBox.Show("Senhas não conferem", "Hope", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenha.Text = "";
                    txtConfirm.Text = "";
                }
            }
        }

        public void Foto()
        {
            op.Filter = "jpg | *.jpg | jpeg | *.jpeg | png | *.png";
            op.FileName = "Escolha a foto";

            if(op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(op.FileName);
            }
        }

        private void btnConcluir_Click_1(object sender, EventArgs e)
        {
            verificaCadastro();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnAbrir_Click_1(object sender, EventArgs e)
        {
            Foto();
        }

        private void txtConfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                verificaCadastro();
            }
        }

        private void pb_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DadosProfessor_Load(object sender, EventArgs e)
        {

        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                  
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MenuProf mp = new MenuProf();
            mp.ShowDialog();
        }
    }
}
