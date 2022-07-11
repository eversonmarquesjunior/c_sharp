using System;                   

//sealed class Veiculo {}                 //sealed - não podem ser herdadas

class Selada {
    public string sel;
}

class Carro:Selada {
    public Carro(string sel) {
        this.sel = sel;
    }
}

class Aula25 {

    static void Main() {

        Carro c1 = new Carro("Não pode ser herdada");
        Console.WriteLine(c1.sel);

    }

}