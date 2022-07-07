using System;

class Aula16 {

    static void Main() {

        int[] n = new int[10];

        for(int i = 0; i < n.Length; i++) {           //inicio-fim-incremento
            n[i] = i;
            Console.WriteLine("Valor de n na posição " +i+ " : " +n[i]);
        }

    }

}