using System;

class Aula23 {

    static void Main() {
    
        soma(5, 5, 2, 14, 7, 22);                                        
    
    }

    static void soma(params int[] n) {              //arg params - permite a entrada de 0 ou mais argumentos pra dentro de um método
        int res = 0;
        if(n.Length == 0) {
            Console.WriteLine("Nenhum valor encontrado");
        }
        else if (n.Length < 2) {
            Console.WriteLine("Valores insuficientes para soma: " +n[0]);
        }
        else {
            for (int i = 0; i < n.Length; i++){
                res += n[i];
            }
            Console.WriteLine("Resultado da soma: " +res);
        }

    }


}
