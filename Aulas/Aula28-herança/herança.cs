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
        public Carro(string marca, string cor, int vmaxima) {
            ligar();
            rodas = 4;
            this.vmaxima = vmaxima;
            this.marca = marca;
            this.cor = cor;
        }
    }

    class Aula28 {

        static void Main() {

            string m, c;
            int vm;

            Console.Write("Marca do Veículo: ");
            m = Console.ReadLine();
            Console.Write("Cor do Veículo: ");
            c = Console.ReadLine();
            Console.Write("Velocidade Máxima do Veículo: ");
            vm = int.Parse(Console.ReadLine());

            Carro c1 = new Carro(m, c, vm);

            Console.WriteLine("Marca: {0}. Cor: {1} ", m, c);
            Console.WriteLine("Rodas: {0}.", c1.rodas);
            Console.WriteLine("Velocidade Máxima: {0} KM/H ", c1.vmaxima);
            Console.WriteLine("Ligado: " +c1.ligado);
    }

}