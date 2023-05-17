namespace Struct;

    public struct Jogador{
        public string nome;
        public string numero;
        public string dataNascimento;
        public string time;

        public Jogador(string nome, string numero, string dataNascimento, string time){
            this.nome = nome;
            this.numero = numero;
            this.dataNascimento = dataNascimento;
            this.time = time;
        }

        public string imprimir(){
            return "\nNome: " + this.nome +
            "\nNumero: " + this.numero +
            "\nData de Nascimento: " + this.dataNascimento +
            "\nTime: " + this.time;
        }

}
