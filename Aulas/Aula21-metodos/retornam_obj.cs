using System;

class Galinha {
    private string nome;
    private int numovos;
    public Galinha(string nome) {
        this.nome = nome;
        numovos = 0;
    }
    public Ovo botar() {                //método que retorna um objeto(ovo);
        numovos++;
        return new Ovo(numovos, nome);
    }
}
class Ovo {
    private int numovos;
    private string mgalinha;
    public Ovo(int numovos, string mgalinha) {
        this.numovos = numovos;
        this.mgalinha = mgalinha;
        Console.WriteLine("Ovo criado: {0} - {1}", this.numovos, this.mgalinha);
    }
}

class Aula21 {

    static void Main() {

        Galinha g1 = new Galinha("Gertrudes");
        Galinha g2 = new Galinha("Zuleica");
        Galinha g3 = new Galinha("Marilan");

        g1.botar();
        g1.botar();
        g1.botar();

        g2.botar();
        g2.botar();

        g3.botar();

    }

}