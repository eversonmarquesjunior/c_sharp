using System;

class Aula03 {

    static int num = 1; // variável global
    static void Main(){

        // dentro do método Main = variável local

        byte n1 = 10; // entre 0-255
        int numero = 19;
        char letra = 'A';
        float valor = 2.5f;
        string nome = "Junior";
        var tipo = nome; // define o tipo da variável na compilação
        
        Console.WriteLine("Meu nome é: " +tipo+ " tenho " +numero+ " anos");

    }

}