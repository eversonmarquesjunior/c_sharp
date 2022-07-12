using System;

class Aula17 {

    static void Main() {

        int i = 0;
        int[] n = new int[10];

        while(i < n.Length) {
            n[i] = i;
            Console.WriteLine(n[i]);
            i++;
        }
            Console.WriteLine("Fim do Loop");

    }

}