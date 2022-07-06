using System;

class Aula07 {

    static void Main(){

        int n1, n2, soma;
        string nome;

        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.Write("Digite o primeiro número: ");
        n1 = int.Parse(Console.ReadLine());             //converte string em int
        Console.Write("Digite o segundo número: ");
        n2 = int.Parse(Console.ReadLine());

        soma = n1 + n2;

        Console.WriteLine("Nome: " +nome);
        Console.WriteLine("Valor da soma: " +soma);

    }

}