using System;

class Aula23 {

    static void Main() {
      
        int divid, divis, quo, rest;
        divid = 10;
        divis = 3;
        quo = divisao(divid, divis, out rest);

        Console.WriteLine("{0} dividido por {1}: quociente {2} e resto {3}", divid, divis, quo, rest);

    }

    static int divisao(int dividendo, int divisor, out int resto) {         //arg out - retorna mais de um valor de saída
        int quociente;
        quociente = dividendo / divisor;
        resto = dividendo % divisor;                 //% - retorna o resto da divisão
        return quociente;                            //um return por método
    }

}