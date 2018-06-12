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
    public partial class DadosAluno : Form
    {
        private Helpers.Dbs1 db;
        private VO.VO_aluno cruds;
        //Avisar o Luis que os icones são desnecessarios
         
         
        OpenFileDialog op = new OpenFileDialog();
        string nome,data ,email, tel, tel2;
       
        public DadosAluno()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        public void Limpar()
        {
            if (txtNome.Text == "" && txtData.Text == "" && txtEmail.Text == "" && txtTel.Text == "" && txtTel2.Text == "" &&
                 pictureBox1.Image == null)
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
                pictureBox5.Image = null;
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


            if (nome == "" || data == "" || email == "" || tel == "" || tel2 == "")
            {
                if (nome == "" && data == "" && email == "" && tel == "" && tel2 == "")
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
            }
            else
            {
                try
                {
                    
                    cruds = new VO.VO_aluno();
                    cruds.nome = txtNome.Text;
                    cruds.data_nasc = txtData.Text;
                    cruds.telefone_1 = txtTel.Text;
                    cruds.telefone_2 = txtTel2.Text;
                    cruds.email = txtEmail.Text;
                    
                    
                    //Pesquisar como salvar imagem
                    //cruds.foto = pictureBox5.ImageLocation;
                    cruds.Inserir();
                    MessageBox.Show("Cadastro concluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    MessageBox.Show("Ocorreu um erro ao realizar a operação", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Foto()
        {
            op.Filter = "jpg | *.jpg | jpeg | *.jpeg | png | *.png";
            op.FileName = "Escolha a foto";

            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox5.Load(op.FileName);
            }
        }




        private void txtConfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                verificaCadastro();
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Foto();
        }

        private void pb_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            verificaCadastro();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MenuProf mp = new MenuProf();
            mp.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            			
        }
    }
}
