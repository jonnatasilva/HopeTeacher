using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeProfessor.VO
{
    class VO_aluno
    {
        
        int _id_aluno;
        private String _nome, _email, _data_nasc, _telefone_1, _telefone_2;
        private DAO.DAO_aluno cdao;

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
        public int id_aluno
        {
            get { return _id_aluno; }
            set { _id_aluno = value; }
        }
        public void Inserir()
        {
            cdao = new DAO.DAO_aluno();
            cdao.InserirDados(nome, email, data_nasc, telefone_1, telefone_2);
        }

        public void Excluir()
        {
            cdao = new DAO.DAO_aluno();
            cdao.RemoverDados(id_aluno);
        }
        public void Atualizar()
        {
            cdao = new DAO.DAO_aluno();
            cdao.AtualizarDados(nome, email, data_nasc, telefone_1, telefone_2, id_aluno);
        }
    }
}
