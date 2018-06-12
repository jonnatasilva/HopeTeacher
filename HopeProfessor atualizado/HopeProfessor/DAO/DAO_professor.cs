using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HopeProfessor.DAO
{
    class DAO_professor
    {
        private Helpers.Dbs1 db;
        private MySqlConnection con;
        public void InserirDados(String login, String senha, String nome, String data_nasc, String telefone_1, String telefone_2, String email, String pergunta, String resposta)
        {

            con = new MySqlConnection();
            db = new Helpers.Dbs1();
            con.ConnectionString = db.getConnectionString();
            String query = "INSERT INTO dados (login, senha, nome, data_nasc, telefone_1, telefone_2, email, pergunta_seguranca, resposta) VALUES";
            query += "(?login, ?senha, ?nome, ?data_nasc, ?telefone_1, ?telefone_2, ?email, ?pergunta, ?resposta)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?login", login);
                cmd.Parameters.AddWithValue("?senha", senha);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?data_nasc", data_nasc);
                cmd.Parameters.AddWithValue("?telefone_1", telefone_1);
                cmd.Parameters.AddWithValue("?telefone_2", telefone_2);
                cmd.Parameters.AddWithValue("?email", email);
                cmd.Parameters.AddWithValue("?pergunta", pergunta);
                cmd.Parameters.AddWithValue("?resposta", resposta);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
            public void AtualizarDados(String login, String senha, String nome, String data_nasc, String telefone_1, String telefone_2, String email, String pergunta, String resposta, int id)
        {
            
            con = new MySqlConnection();
            db = new Helpers.Dbs1();
            con.ConnectionString = db.getConnectionString();
            String query = "UPDATE inventario SET nome = ?nome, data_nasc = ?data_nasc, telefone_1 = ?telefone_1, telefone_2 = ?telefone_2, email = ?email, pergunta_seguranca = ?pergunta, resposta = ?resposta, login = ?login, senha = ?senha";
            query += " WHERE ID_dados = ?id";;
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?login", login);
                cmd.Parameters.AddWithValue("?senha", senha);
                cmd.Parameters.AddWithValue("?nome", nome);
                cmd.Parameters.AddWithValue("?data_nasc", data_nasc);
                cmd.Parameters.AddWithValue("?telefone_1", telefone_1);
                cmd.Parameters.AddWithValue("?telefone_2", telefone_2);
                cmd.Parameters.AddWithValue("?email", email);
                cmd.Parameters.AddWithValue("?pergunta", pergunta);
                cmd.Parameters.AddWithValue("?resposta", resposta);
                cmd.Parameters.AddWithValue("?id", id);
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
