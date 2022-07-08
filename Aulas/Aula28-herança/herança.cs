using System;

    class Veiculo {   //classe base          //a classe derivada herda propriedades da classe base, mesmo tendo seus próprias propriedades          
        public int vmaxima;
        public bool ligado;
        public int rodas;
        public void ligar() {
            ligado = true;
        }
        public void desligar() {
            ligado = false;
        }
        
    }

    class Carro:Veiculo {       //classe derivada
        public string marca;
        public string cor;
        public Carro(string marca, string cor) {
            ligar();
            rodas = 4;
            vmaxima = 160;
            this.marca = marca;
            this.cor = cor;
        }
    }

    class Aula28 {

        static void Main() {

            string m, c;

            Console.Write("Marca do Veículo: ");
            m = Console.ReadLine();
            Console.Write("Cor do Veículo: ");
            c = Console.ReadLine();

            Carro c1 = new Carro(m, c);

            Console.WriteLine("Marca: {0}. Cor: {1} ", m, c);
            Console.WriteLine("Rodas: {0}. Velocidade Máxima: {1} ", c1.rodas, c1.vmaxima);
            Console.WriteLine("Ligado: " +c1.ligado);
    }

}