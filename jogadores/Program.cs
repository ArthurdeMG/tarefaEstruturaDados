using System;
using Struct;

namespace JOGADORES{

    class Program
    {

        static void main(string[] args)
        {

            Jogador jogador1 = new();

            jogador1.nome = "Arthur";
            jogador1.numero = "33";
            jogador1.dataNascimento = "17/05/2005";
            jogador1.time = "Cruzeiro";

            Console.WriteLine(jogador1.imprimir());
        }
    }
}