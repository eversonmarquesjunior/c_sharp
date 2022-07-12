using System;

class Jogador {                                //classe
    public int energia = 100;                  //objetos
    public bool vivo = true;

}

class Aula25 {

    static void Main() {                      //método

        Jogador j1 = new Jogador();           //objeto instanciado da classe Jogador  
        Jogador j2 = new Jogador(); 

        j1.energia = 50;
        Console.WriteLine("Energia Jogador 1: " +j1.energia);
        Console.WriteLine("Energia Jogador 2: " +j2.energia);
        Console.WriteLine("Jogador 1 está vivo: " +j1.vivo);

    }

    /*

    Modificador da Classe: define a visibilidade da classe
        public: pública, sem restrição de visualização;
        abstract: classe base para outras classes, não podem ser instanciados objetos;
        sealed: não pode ser herdada;
        static: não permite a instanciação de objetos e seus membros devem ser static;

    Especificador de Acesso: onde um membro da classe pode ser acessado
        public: sem restrição de acesso;
        private: só podem ser acessado pela própria classe;
        protected: podem ser acessados na prória classe e nas classes derivadas;
        abstract: os métodos não tem implementação, somente cabeçalhos;
        sealed: o método não pode ser redefinido;
        virtual: o método pode ser redefinido em uma classe derivada;
        static: o método pode ser chamado mesmo sem a instanciação de um objeto;

    */

}