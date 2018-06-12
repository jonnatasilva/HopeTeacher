using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HopeProfessor.DAO
{
    class DAO_aluno
    {
        private Helpers.Dbs1 db;
        private MySqlConnection con;
        public void InserirDados(String nome, String data_nasc, String telefone_1, String telefone_2, String email)
        {
            con = new MySqlConnection();
            db = new Helpers.Dbs1();
            con.ConnectionString = db.getConnectionString();
            String query = "INSERT INTO alunos (nome, data_nasc, telefone_1, telefone_2, email) VALUES";
            query += "(?nome, ?data_nasc, ?telefone_1, ?telefone_2, ?email)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?data_nasc", data_nasc);
                cmd.Parameters.AddWithValue("?telefone_1", telefone_1);
                cmd.Parameters.AddWithValue("?telefone_2", telefone_2);
                cmd.Parameters.AddWithValue("?email", email);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
               con.Close();
            }
        }

        public void RemoverDados(Int32 itemid)
        {
            con = new MySqlConnection();
            db = new Helpers.Dbs1();
            con.ConnectionString = db.getConnectionString();
            String query = "DELETE FROM aluno ";
            query += "WHERE id_aluno = ?id";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
              
                cmd.Parameters.AddWithValue("?id", itemid);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void AtualizarDados(String nome, String data_nasc, String telefone_1, String telefone_2, String email,int id_aluno)
        {

            con = new MySqlConnection();
            db = new Helpers.Dbs1();
            con.ConnectionString = db.getConnectionString();
            String query = "UPDATE inventario SET nome = ?nome, data_nasc = ?data_nasc, telefone_1 = ?telefone_1, telefone_2 = ?telefone_2, email = ?email";
            query += " WHERE ID_aluno = ?id_aluno"; ;
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?data_nasc", data_nasc);
                cmd.Parameters.AddWithValue("?telefone_1", telefone_1);
                cmd.Parameters.AddWithValue("?telefone_2", telefone_2);
                cmd.Parameters.AddWithValue("?email", email);
                cmd.Parameters.AddWithValue("?id_aluno", id_aluno);
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
