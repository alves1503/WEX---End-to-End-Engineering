using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.models
{
    public class Aluno : Pessoa //Vai herdar a clsse pessoa 
    {

        public Aluno(string nome) : base(nome)
        {
            
        }

        public double Nota { get; set; }


        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} tenho {Idade} anos e sou um aluno nota {Nota}");
        }
        
    }
}