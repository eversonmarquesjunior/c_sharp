using System;

class Base {

    public Base() {
        Console.WriteLine("Construtor Classe Base");                //ordem de execução - base para derivada
    }

}

class Derivada1:Base {

    public Derivada1() {
        Console.WriteLine("Construtor Classe Derivada 1");
    }

}

class Derivada2:Derivada1 {

    public Derivada2() {
        Console.WriteLine("Construtor Classe Derivada 2");
    }

}

class Aula28 {

    static void Main() {

        Derivada2 d2 = new Derivada2();

    }

}