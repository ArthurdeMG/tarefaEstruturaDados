namespace Struct;

    public struct team{
        public string nome;
        public string qtdJogadores;
        public string dataFundacao;
        public string titulos;

        public team(string nome, string qtdJogadores, string dataFundacao, string titulos){
            this.nome = nome;
            this.qtdJogadores = qtdJogadores;
            this.dataFundacao = dataFundacao;
            this.titulos = titulos;
        }

        public string imprimir(){
            return "\nNome: " + this.nome +
            "\nQuantidade de Jogadores: " + this.qtdJogadores +
            "\nData de Fundação: " + this.dataFundacao +
            "\nTitulos: " + this.titulos;
        }

}
