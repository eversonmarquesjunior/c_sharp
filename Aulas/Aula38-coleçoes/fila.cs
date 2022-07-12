using System;

using System.Collections.Generic;

class Aula38 {

    static void Main() {

        Queue<string> frutas = new Queue<string>();

        frutas.Enqueue("Maça");                         //Enqueue - adiciona no final da fila
        frutas.Enqueue("Banana");
        frutas.Enqueue("Morango");

        string f = "Banana";

        if(frutas.Contains(f)) {
            Console.WriteLine("Fruta {0} encontrada", f);
        }
        else {
            Console.WriteLine("Fruta {0} não encontrada", f);
        }

        //frutas.Clear();

        Console.WriteLine("Primeira Fruta: " +frutas.Dequeue());            //Dequeue - retorna o primeiro elemento da fila e depois remove
        Console.WriteLine("Primeira Fruta: " +frutas.Peek());               //Peek - retorna o primeiro elemento mas não remove

        Console.WriteLine("Tamanho fila: " +frutas.Count);                  //Count - retorna um int

    }

}