using MySql.Data.MySqlClient;
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
    public partial class MeuPerfil : Form
    {
        private Helpers.Dbs1 db;
        public MeuPerfil()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            carregaDados();
        }
        private void carregaDados()
        {
            
            db = new Helpers.Dbs1();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string connectionString = db.getConnectionString();
            string query = "SELECT * FROM dados"; //Muda a tabela
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
                            dataGridView1.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], dataTable.Rows[i][4], dataTable.Rows[i][5], dataTable.Rows[i][6]); //Colunas de acordo com BD
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                }
            }
        }

        private void lb_dados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pb_foto_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            
        }

        private void pb_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MenuProf mp = new MenuProf();
            mp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
