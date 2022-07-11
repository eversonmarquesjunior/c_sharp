using System;

class Matematica {
    public static double pi = 3.14;
    public static int dobro(int n1) {
        return n1 * 2;
    }
}

class Aula21 {

    static void Main() {

        double valorpi = Matematica.pi;             //membros static não precisam de declaração de objeto
        int valor = 10;

        Console.WriteLine(Matematica.dobro(valor));
        Console.WriteLine(valorpi);

    }

}