using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeProfessor.VO
{
    class VO_Professor
    {
        private String _login;
        private String _senha;
         private String _nome, _email, _data_nasc, _telefone_1, _telefone_2, _foto, _pergunta, _resposta;
         int _id;
        private DAO.DAO_professor cdao;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public String login
        {
            get { return _login; }
            set { _login = value; }
        }
        public String senha 
        {
            get { return _senha; }
            set { _senha = value; }
        }
        
        public String nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        
        public String email
        {
            get { return _email; }
            set { _email = value; }
        }
        
        public String data_nasc
        {
            get { return _data_nasc; }
            set { _data_nasc = value; }
        }

        public String telefone_1 
        {
            get { return _telefone_1; }
            set { _telefone_1 = value; }
        }
        
        public String telefone_2
        {
            get { return _telefone_2; }
            set { _telefone_2 = value; }
        }
        
        public String foto
        {
            get { return _foto; }
            set { _foto = value; }
        }
        public String pergunta
        {
            get { return _pergunta; }
            set { _pergunta = value; }
        }
        public String resposta
        {
            get { return _resposta; }
            set { _resposta = value; }
        }
        public void Inserir()
        {
            cdao = new DAO.DAO_professor();
            cdao.InserirDados(login, senha, nome, email, data_nasc, telefone_1, telefone_2, pergunta, resposta);
        }
        public void Atualizar()
        {
            cdao = new DAO.DAO_professor();
            cdao.AtualizarDados(login, senha, nome, email, data_nasc, telefone_1, telefone_2, pergunta, resposta, id);
        }
    }
}
