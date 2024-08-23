using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorNovamente
{
    internal class FuncionarioEmpresa
    {
        private int matricula;
        private string nome;
        public FuncionarioEmpresa()
        {
            matricula = 00;
            nome = "Nome";
        }
        public FuncionarioEmpresa(int matricula, string nome)
        {
            this.matricula = matricula;
            this.nome = nome;
        }
        public void setMatricula(int matricula)
        {
            this.matricula = matricula;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public int getMatricula()
        {
            return this.matricula;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void ImprimeValores()
        {
            Console.WriteLine("Nome do Funcionario: " + nome);
            Console.WriteLine("Matricula do Funcionario: " + matricula);
        }
    }
}
