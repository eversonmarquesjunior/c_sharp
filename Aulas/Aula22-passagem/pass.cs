using System;

class Aula22 {

    static void Main() {
 
        int num = 30;
        dobrar1(num);                        
        Console.WriteLine(num);

    }

    static void dobrar (ref int valor) {            //passagem por referência / altera o valor da memória
        valor *= 2;
    }

    static void dobrar2 (int valor) {              //passagem por valor / cria outra posição na memória
        valor *= 2;
    }

}