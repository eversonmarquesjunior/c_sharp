using System;

using System.Collections.Generic;

class Aula38 {

    static void Main() {

        Dictionary <int, string> veiculos = new Dictionary<int, string>();                   //dictinoary chave/valor - coleção de dados que relaciona valores através de chaves

        veiculos.Add(30, "Carro");
        veiculos.Add(50, "Moto");
        veiculos.Add(100, "Avião");

        Console.WriteLine("Tamanho: {0}", veiculos.Count);

        //veiculos.Remove(50);                                             //Remove - remove um valor ou chave da coleção

        int chave = 50;

        if(veiculos.ContainsKey(chave)) {                                //ContainsKey - verifica se existe ou não uma chave na coleção
            Console.WriteLine("A chave {0} está na coleção", chave);
        }
        else {
            Console.WriteLine("A chave {0} não está na coleção", chave);
        }

        veiculos[100] = "Navio";                                         //substitui um valor/chave da coleção

        string valor = "Navio";

        if(veiculos.ContainsValue(valor)) {                              //ContainsKey - verifica se existe ou não um valor na coleção
            Console.WriteLine("O valor {0} está na coleção", valor);
        }
        else {
            Console.WriteLine("O valor {0} não está na coleção", valor);
        }

        foreach(KeyValuePair<int, string> v in veiculos) {
            Console.WriteLine(v.Key);
        }

    }

}