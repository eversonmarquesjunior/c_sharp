using System;

class Base {

    public Base() {
        Console.WriteLine("Construtor Classe Base");                
    }

    virtual public void info() {}                      //metodos virtuais - método sobreescrito com o mesmo nome em classes diferentes


}
class Derivada1:Base {

    public Derivada1() {
        Console.WriteLine("Construtor Classe Derivada 1");
    }

    override public void info() {                      //override - sobreescreve um método da classe base em uma derivada
        Console.WriteLine("Derivada 1");
    }

}
class Derivada2:Derivada1 {

    public Derivada2() {
        Console.WriteLine("Construtor Classe Derivada 2");
    }

    override public void info() {                      
        Console.WriteLine("Derivada 2");
    }

}

class Aula21 {

    static void Main() {

        Base Ref;                           //Ref - faz referência as classes derivadas da classe base                     
        Derivada1 d1 = new Derivada1();
        Derivada2 d2 = new Derivada2();

        Ref = d2;
        Ref.info();

    }

}
