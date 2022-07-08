using System;

class Calculos {
    public int v1;
    public int v2;

    public Calculos(int v1, int v2) {
        this.v1 = v1;                           //this - faz a referência do objeto e não do paramêtro
        this.v2 = v2;
    }

    public int Somar() {
        return v1 + v2;
    }

}

class Aula27 {

    static void Main() {

        Calculos c = new Calculos(4, 10);
        Console.WriteLine(c.Somar());

    }

}