using System;

using System.Collections.Generic;

class Aula38 {

    static void Main() {

        List<string> cores = new List<string>();
        string[] cores2 = new string[10];

        cores.Add("Azul");
        cores.Add("Verde");
        cores.Add("Branco");

        //cores2.AddRange(cores);                       //adiciona elementos de uma lista em outra

        //cores.Clear();

        if(cores.Contains("Azul")) {                    //Contains - verifica se existe ou não um elemento na lista
            Console.WriteLine("Elemento encontrado");
        }
        else {
            Console.WriteLine("Não encontrado");
        }

        cores.CopyTo(cores2, 2);                       //copia os elementos de uma lista pra outra a partir de uma posição

        foreach(string c in cores) {
            Console.WriteLine("Cores: " +c);
        }

        string cor = "Branco";
        int posicao = 0;
        posicao = cores.IndexOf(cor);                 //retorna o índice do elemento pesquisado
        Console.WriteLine("Cor {0} está na posição {1}", cor, posicao);

    }

}