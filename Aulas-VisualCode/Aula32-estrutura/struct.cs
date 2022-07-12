using System;

struct Carro {                      //struct - pode armazenar tipos de dados diferentes
    public string marca;
    public string modelo;
    public string cor;
    public Carro(string marca, string modelo, string cor) {
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }
    public void info() {
        Console.WriteLine("Marca: " +this.marca);
        Console.WriteLine("Modelo: " +this.modelo);
        Console.WriteLine("Cor: " +this.cor);
    }
}

class Aula32 {

    static void Main() {

        Carro c1 = new Carro("Ferrari", "Nova", "Vermelho");

        c1.info();

        Console.WriteLine("-----------------------------");

        Carro c2 = new Carro("VW", "Velho", "Roxa");

        Console.WriteLine("Marca: " +c2.marca);
        Console.WriteLine("Modelo: " +c2.modelo);
        Console.WriteLine("Cor: " +c2.cor);

    }

}               

