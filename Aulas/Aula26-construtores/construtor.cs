using System;

class Jogador {

    public int numerocamisa;
    public string nome;
    public string time;
    
    public Jogador(int nc, string n, string t) {            //método construtor - instancia um objeto automaticamente
        numerocamisa = nc;          
        nome = n;
        time = t;
    }    

    /*public Jogador (int nc, string n) {                   //sobrecarga - mais de um construtor para a classe com qtde de parâmetros diferentes              
        numerocamisa = nc;          
        nome = n;
        time = "Santos";
    }*/  

    /*public void info() {
        Console.WriteLine("Número camisa: " +numerocamisa);
        Console.WriteLine("Nome: " +nome);
        Console.WriteLine("Time: " +time);
    }*/
                                                   
}

class Aula26 {

    static void Main() {

        string nome1, nome2, time1, time2;
        int nc1, nc2;

        Console.Write("Número camisa Jogador 1: ");
        nc1 = int.Parse(Console.ReadLine());
        Console.Write("Número camisa Jogador 2: ");
        nc2 = int.Parse(Console.ReadLine());

        Console.Write("Jogador 1: ");
        nome1 = Console.ReadLine();
        Console.Write("Jogador 2: ");
        nome2 = Console.ReadLine();

        Console.Write("Time Jogador 1: ");
        time1 = Console.ReadLine();
        Console.Write("Time Jogador 2: ");
        time2 = Console.ReadLine();

        Jogador j1 = new Jogador(nc1, nome1, time1);
        Jogador j2 = new Jogador(nc2, nome2, time2);

        Console.WriteLine("Número camisa Jogador 1: {0}. Nome: {1}. Time: {2}", j1.numerocamisa, j1.nome, j1.time);
        Console.WriteLine("Número camisa Jogador 2: {0}. Nome: {1}. Time: {2}", j2.numerocamisa, j2.nome, j2.time);

    }

}