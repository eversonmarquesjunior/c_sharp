using System;

delegate int Delegate(int n1, int n2);                //delegate - objeto que pode fazer referência a um método
class Calculos {
    public static int soma(int n1, int n2) {
        return n1 + n2;
    }
    public static int mult(int n1, int n2) {
        return n1 * n2;
    }
    public static int divisao(int n1, int n2) {
        return n1 / n2;
    }
}

class Aula34 {

    static void Main() {

        int res;
        
        Delegate d1 = new Delegate(Calculos.soma);  
        res = d1(4, 4);
        Console.WriteLine("Resultado Soma: " +res); 

        d1 = new Delegate(Calculos.mult);
        res = d1(5, 10);
        Console.WriteLine("Resultado Multiplicação: " +res);  

        d1 = new Delegate(Calculos.divisao);
        res = d1(50, 2);   
        Console.WriteLine("Resultado Divisão: " +res);                                

    }
}