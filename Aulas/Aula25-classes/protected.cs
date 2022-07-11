using System;

class Veiculo {
    public int velatual;
    private int velmax;
    protected bool ligado;              //permite o acesso aos membros pelas classes derivadas

    public Veiculo(int velmax) {
        velatual = 0;
        this.velmax = velmax;
        ligado = false; 
    }
    public bool getLigado() {
        return ligado;
    }
    public int getVelmax() {
        return velmax;
    }
}

class Carro:Veiculo {
    public string nome;
    public Carro(string nome, int vm) :base(vm) {
        this.nome = nome;
        ligado = true;
    }
}

class Aula25 {

    static void Main() {

        Carro c1 = new Carro("Ferrari", 320);

        Console.WriteLine("Nome do carro: " +c1.nome);
        Console.WriteLine("Velocidade Máxima: {0}", c1.getVelmax());
        Console.WriteLine("Ligado: {0}", c1.getLigado());

    }

}