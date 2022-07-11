using System;

class Calculo {
    public int soma(params int[] n) {
        
        int s = 0;

        for(int i = 0; i < n.Length; i++) {
            s += n[i];
        }
        return s;
    }                                           //sobrecarga - vários métodos com o mesmo nome só que diferentes paramêtros
    public double soma(params double[] n) {

        double s = 0;

        for(int i = 0; i < n.Length; i++) {        
            s += n[i];
        }
        return s;
    }
    public int fatorial(int n) {
        int res;
        if(n <= 1) {
            res = 1;
            Console.WriteLine("");
        }
        else {
            res = n * fatorial(n - 1);                 //recursividade - uma função chamando ela mesma
        }
        return res;
    }
}

class Aula33 {

    static void Main() {

        Calculo conta = new Calculo();

        var res1 = conta.soma(3, 3, 6, 100, 1);
        var res2 = conta.soma(3.5, 3.8, 6.6, 7.1);
        var res3 = conta.fatorial(10);

        Console.WriteLine("Resultado: " +res1);
        Console.WriteLine("Resultado: " +res2);
        Console.WriteLine("Resultado: " +res3);

    }

}