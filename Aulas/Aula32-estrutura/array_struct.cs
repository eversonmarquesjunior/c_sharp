using System;

struct Carro {                      //struct(tipo!=classe) - pode armazenar tipos de dados diferentes
    public string marca;
    public string cor;
    public void info() {
        Console.WriteLine("Marca: " +this.marca);
        Console.WriteLine("Cor: " +this.cor);
        Console.WriteLine("-----------------------------");
    }
}

class Aula32 {

    static void Main() {

        int[] n = new int[10];
        Carro[] carros = new Carro[4];

        carros[0].marca = "Fiat";
        carros[0].cor = "Verde";

        carros[1].marca = "VW";
        carros[1].cor = "Rosa";

        carros[2].marca = "Gol";
        carros[2].cor = "Branco";

        carros[3].marca = "Chev";
        carros[3].cor = "Amarerelo";

        for(int i = 0; i < carros.Length; i++){
            carros[i].info();
        }

    }

}               

