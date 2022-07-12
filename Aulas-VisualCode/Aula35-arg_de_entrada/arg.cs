using System;



class Aula35 {

    static void Main(string[] args) {               //args - array que recebe os argumentos de entrada no terminal

        int res = 0;

        if(args.Length > 0) {
            Console.WriteLine("Quantidades de argumentos: " +args.Length);
            for(int i = 0; i < args.Length; i++) {
                res += int.Parse(args[i]);
            }
            Console.WriteLine("Soma: "+res);
        }
        else {
            Console.WriteLine("Nenhum argumento passado");
        }
    
    }

}