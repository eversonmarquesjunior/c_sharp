using System;

class Aula17 {

    static void Main() {

        string senha = "123";
        string senhausuario;
        int tentativas = 0;

        do{
            Console.Write("Digite sua senha: ");
            senhausuario = Console.ReadLine();
            tentativas++;
            
            if(senhausuario != senha) {
                Console.WriteLine("Senha incorreta");
            }
            else {
                Console.WriteLine("Senha correta");
            }

        }
        while(senha != senhausuario);

        Console.WriteLine("Tentativas: " +tentativas);
    }
}