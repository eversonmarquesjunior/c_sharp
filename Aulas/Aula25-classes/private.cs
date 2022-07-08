using System;


class Restaurante {
    private string prato;                   //objeto private só pode ser utilizado dentro da classe
    private string preco;

    public Restaurante(string prato, string preco) {
        this.prato = prato;
        this.preco = preco;
    }

    public string obterPrato() {           //método para obter objeto privado
        return prato;
    }

    public string obterPreco() {
        return preco;
    }

    public void conferirPreco(int p) {
        if(p > 0 && p <= 100){
            Console.WriteLine("Preço acessível");
        }
        else if (p > 100){
            Console.WriteLine("Preço elevado");
        }
        else {
            Console.WriteLine("Preço inválido");
        }
    }

}
class Aula25 {

    static void Main() {

        Restaurante p1 = new Restaurante("Lagosta", "R$ 85,00");
        Restaurante p2 = new Restaurante("Costela", "R$ 45,00");
        
        Console.WriteLine("Nome do prato: {0}. Preço: {1}.", p1.obterPrato(), p1.obterPreco());
        Console.WriteLine("Nome do prato: {0}. Preço: {1}.", p2.obterPrato(), p2.obterPreco());
        Console.WriteLine("---------------------------------");

        int conf1, conf2;
        Console.Write("Digite o preço do prato: ");
        conf1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o preço do segundo prato: ");
        conf2 = int.Parse(Console.ReadLine());
        Console.WriteLine("---------------------------------");

        Console.WriteLine("Avaliação Prato 1: ");
        p1.conferirPreco(conf1);
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Avaliação Prato 2: ");
        p2.conferirPreco(conf2);
       
    }

}