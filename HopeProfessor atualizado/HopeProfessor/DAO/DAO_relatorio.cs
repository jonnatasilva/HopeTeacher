using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HopeProfessor.DAO
{
    class DAO_relatorio
    {
        private Helpers.Dbs1 db;
        private MySqlConnection con;

        public void InserirDados(String relatorio, DateTime data, int id_aluno, String nome)
        {
            con = new MySqlConnection();
            db = new Helpers.Dbs1();
            con.ConnectionString = db.getConnectionString();
            String query = "INSERT INTO relatorio (relatorio, data, id_aluno, nome) VALUES";
            query += "(?relatorio, ?data, ?id_aluno, ?nome)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?relatorio", relatorio);
                cmd.Parameters.AddWithValue("?data", data);
                cmd.Parameters.AddWithValue("?id_aluno", id_aluno);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
