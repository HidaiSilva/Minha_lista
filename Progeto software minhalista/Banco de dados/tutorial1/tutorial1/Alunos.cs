using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tutorial1
{
    class Alunos
    {
        public class Alunos
        {
            private int _alunoID;
            public int AlunoID
            {
                get
                {
                    return _alunoID;
                }
                set
                {
                    _alunoID = value;
                }
            }

            private string _nome;
            public string Nome
            {
                get
                {
                    return _nome;
                }
                set
                {
                    _nome = value;
                }
            }

            private string _endereco;
            public string Endereco
            {
                get
                {
                    return _endereco;
                }
                set
                {
                    _endereco = value;
                }
            }

            private int _idade;
            public int Idade
            {
                get
                {
                    return _idade;
                }
                set
                {
                    _idade = value;
                }
            }

            public Alunos()
            {
            }

            public Alunos(string nome, string endereco, int idade)
            {
                this.Nome = nome;
                this.Endereco = endereco;
                this.Idade = idade;
            }
        }
    }
}
