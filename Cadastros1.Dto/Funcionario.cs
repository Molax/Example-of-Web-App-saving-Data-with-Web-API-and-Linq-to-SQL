using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastros1.Dto
{
    public class Funcionario
    {
        private int nldFuncionario;

        public int Id
        {
            get { return nldFuncionario; }
            set { nldFuncionario = value; }
        }

        private string Nome;

        public string sNome
        {
            get { return Nome; }
            set { Nome = value; }
        }

        private DateTime DataNascimento;

        public DateTime sNascimento
        {
            get { return DataNascimento; }
            set { DataNascimento = value; }
        }

        private string CPF;

        public string sCPF
        {
            get { return CPF; }
            set { CPF = value; }
        }

        private string Cargo;

        public string sCargo
        {
            get { return Cargo; }
            set { Cargo = value; }
        }

        private int IdSetor;

        public int nldSetor
        {
            get { return IdSetor; }
            set { IdSetor = value; }
        }

        private string Salario;

        public string sSalario
        {
            get { return Salario; }
            set { Salario = value; }
        }
        
    }
}
