using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeProfessor.VO
{
    class VO_relatorio
    {
        private Int32 _id_relatorio, _id_aluno;
        private DateTime _data;
        private String _relatorio, _nome;
        private DAO.DAO_relatorio cdao;

        public Int32 id_relatorio 
        {
            get { return _id_relatorio; }
            set { _id_relatorio = value; }
        }
        public Int32 id_aluno
        {
            get { return _id_aluno; }
            set { _id_aluno = value; }
        }
        public DateTime data 
        {
            get { return _data; }
            set { _data = value; }
        }
        public String relatorio
        {
            get { return _relatorio; }
            set { _relatorio = value; }
        }
        public String nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public void Inserir()
        {
            cdao = new DAO.DAO_relatorio();
            cdao.InserirDados(relatorio, data, id_aluno, nome);
        }

    }
}
