using System;
using Struct;

namespace EQUIPE{

    class Program
    {

        static void main(string[] args)
        {

            team team1 = new();

            team1.nome = "Dark Storm";
            team1.qtdJogadores = "12";
            team1.dataFundacao = "18/06/2017";
            team1.titulos = "7";

            Console.WriteLine(team1.imprimir());
        }
    }
}