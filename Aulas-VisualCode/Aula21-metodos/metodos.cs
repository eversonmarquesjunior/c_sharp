using System;

class Aula21 {

    static void Main() {
        
       int v1, v2;
       Console.Write("Valor 1: ");
       v1 = int.Parse(Console.ReadLine());
       Console.Write("Valor 2: ");
       v2 = int.Parse(Console.ReadLine()); 

       soma(v1, v2);                            //chamar método dentro do método principal / indicar valores nos parâmetros
    }

    static void soma(int n1, int n2){

        int resultado = n1 + n2;
        Console.WriteLine("Resultado da soma: " +resultado);

    }


}