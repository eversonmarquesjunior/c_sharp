using System;

class Aula10 {

    static void Main(){

        int n1, n2, media, soma;

        Console.Write("Digite sua primeira nota: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite sua segunda nota: ");
        n2 = int.Parse(Console.ReadLine());

        soma = n1 + n2;
        media = (n1 + n2) / 2;

        Console.WriteLine("Notas somadas: " +soma);
        Console.WriteLine("Sua média é: " +media);

        if (media >= 6){
            Console.Write("Resultado: Aprovado");
        }
        else if (media >= 4 && media < 6){
            Console.Write("Resultado: Recuperação");
        }
        else if (media < 4){
            Console.Write("Resultado: Reprovado");
        }

    }

}