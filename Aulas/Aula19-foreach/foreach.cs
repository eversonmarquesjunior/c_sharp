using System;

class Aula19 {

    static void Main() {
 
        int[] n = new int[3]{5, 50, 55};

        /* for(int i = 0; i < n.Length; i++) {     //atribuir elementos 
            Console.WriteLine(n[i]);
        }
        */

        foreach(int numero in n) {                 //ler elementos de um array
            Console.WriteLine(numero);
        }

    }
}