using System;

using System.Collections.Generic;
class Aula39 {

    static void Main() {

        LinkedList<string> animais = new LinkedList<string>();                       //lista duplamente encadeada

        animais.AddFirst("Leão");
        animais.AddFirst("Gato");
        animais.AddFirst("Jacaré");

        animais.AddLast("Cachorro");

        LinkedListNode<string> no;

        no = animais.FindLast("Gato");
        animais.AddAfter(no, "Cobra");
        
        no = animais.FindLast("Jacaré");
        animais.AddBefore(no, "Besouro");

        //animais.Clear();                //remove todos os elementos

        if(animais.Find("Jacaré") == null) {
            Console.WriteLine("Não encontrado");
        }
        else {
            Console.WriteLine("Elemento encontrado");
        }

        animais.Remove("Cachorro");                //remove apenas um elemento

        foreach(string a in animais) {
            Console.WriteLine("Animais: {0}", a);
        }

    }

}