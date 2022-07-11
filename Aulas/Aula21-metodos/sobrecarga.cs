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

        for(int i = 0; i < n.Length; i++) {         //recursividade - uma função chamando ela mesma
            s += n[i];
        }
        return s;
    }
}

class Aula21 {

    static void Main() {

        Calculo conta = new Calculo();

        var res1 = conta.soma(3, 3, 6, 100, 1);
        var res2 = conta.soma(3.5, 3.8, 6.6, 7.1);

        Console.WriteLine("Resultado: " +res1);
        Console.WriteLine("Resultado: " +res2);

    }

}