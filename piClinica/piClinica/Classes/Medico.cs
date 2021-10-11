using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piClinica.Classes
{
    class Medico
    {
        private int id_medico;
        private string nome;
        private int crm;
        private string nascimento;
        private string especialidade;
        private string cpf;
        
        public int Id_medico
        {
            get { return id_medico; }
            set { id_medico = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Crm
        {
            get { return crm; }
            set { crm = value; }
        }
        public string Especialidade
        {
            get { return especialidade; }
            set { especialidade = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Nascimento
        {
            get { return nascimento; }
            set { nascimento = value; }
        }
        public Medico() { }

        public Medico(int id_medico, string nome, int crm, string nascimento, string especialidade, string cpf)
        {
            Id_medico = id_medico;
            Nome = nome;
            Crm = crm;
            Nascimento = nascimento;
            Especialidade = especialidade;
            Cpf = cpf;
            Nascimento = nascimento;
        }
    }
}
