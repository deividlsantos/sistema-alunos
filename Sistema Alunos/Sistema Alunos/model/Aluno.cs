using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Alunos.model
{
    class Aluno
    {
        private int Alunoid;

        public int Alunoid1 { get => Alunoid; set => Alunoid = value; }

        private string Nome;
        public string Nome1 { get => Nome; set => Nome = value; }

        private string Endereco;
        public string Endereco1 { get => Endereco; set => Endereco = value; }

        private int Idade;
        public int Idade1 { get => Idade; set => Idade = value; }


        public Aluno()
        {

        }

        public Aluno(int id)
        {
            this.Alunoid = id;
        }

        public Aluno(string nome, string endereco, int idade)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Idade = idade;
        }

        public Aluno(int id, string nome, string endereco, int idade)
        {
            this.Alunoid = id;
            this.Nome = nome;
            this.Endereco = endereco;
            this.Idade = idade;
        }
    }
}
