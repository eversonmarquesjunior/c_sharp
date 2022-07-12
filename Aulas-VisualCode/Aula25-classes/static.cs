using System;

class Jogador {

    static public int numerocamisa;
    static public string nome;
    static public string time;
    
    static public void iniciar(int nc, string n, string t) {            //classe static - não permite o instanciamento de objetos (new)
        numerocamisa = nc;          
        nome = n;
        time = t;
    }    

    static public void info() {
        Console.WriteLine("Numero camisa: " +numerocamisa);
        Console.WriteLine("Nome: " +nome);
        Console.WriteLine("Time: " +time);
        Console.WriteLine("--------------------------");
    }                                              
}

class Copa {
    public string pais;
    public int ano;

    public Copa(string p, int a) {
        pais = p;
        ano = a;
    }
    public void info() {
        Console.WriteLine("País Sede: " +pais);
        Console.WriteLine("Ano: " +ano);
        Console.WriteLine("--------------------------");
    }
}

class Aula26 {

    static void Main() {

        Jogador.iniciar(10, "Messi", "PSG");
        Jogador.info();

        Copa c1 = new Copa("Brasil", 2014);
        Copa c2 = new Copa("Rússia", 2018);
        c1.info();
        c2.info();

    }

}