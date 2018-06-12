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
    public partial class MenuProf : Form
    {
        private Helpers.Dbs1 db;
        private VO.VO_aluno cruds;
        public MenuProf()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            carregaDados();

        }
        private void lb_alunos_Click(object sender, EventArgs e)
        {
            PerfilAluno frm1 = new PerfilAluno();
            frm1.ShowDialog();
        }

        private void pb_meuPerfil_Click(object sender, EventArgs e)
        {
            MeuPerfil frm5 = new MeuPerfil();
            frm5.ShowDialog();
        }

        private void lbl_meuPerfil_Click(object sender, EventArgs e)
        {
            MeuPerfil frm5 = new MeuPerfil();
            frm5.ShowDialog();
        }

        private void pb_novoAluno_Click(object sender, EventArgs e)
        {
            DadosAluno frm4 = new DadosAluno();
            frm4.ShowDialog();
        }

        private void lbl_novoAluno_Click(object sender, EventArgs e)
        {
            DadosAluno frm4 = new DadosAluno();
            frm4.ShowDialog();
        }

        private void pb_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_fechar_Click(object sender, EventArgs e)
        {
            Hope frm1 = new Hope();
            frm1.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            cruds = new VO.VO_aluno();
            try
            {

                cruds.id_aluno = Convert.ToInt32(txtId_aluno.Text);
                cruds.Excluir();
                MessageBox.Show("Excluido com sucesso", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a operação", "Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pb_pesquisar_Click(object sender, EventArgs e)
        {
            //Banco de dados
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            //Banco de dados
        }

        private void pb_meuPerfil_Click_1(object sender, EventArgs e)
        {
            MeuPerfil frm5 = new MeuPerfil();
            frm5.ShowDialog();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void carregaDados()
        {

            db = new Helpers.Dbs1();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string connectionString = db.getConnectionString();
            string query = "SELECT * FROM alunos"; //Muda a tabela
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    try
                    {

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            dataGridView1.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4], dataTable.Rows[i][5]); //Colunas de acordo com BD
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }
            }
        }
    }
}
