using System;

namespace Calc1 {                                                                            //namespace - elemento de agrupamento de escopos
    class Area {
        public static double Quadrado(double b, double a) {
            if(b == 0 || a == 0) {
                throw new Exception("Base ou altura precisam ser diferentes de 0");         //forçando uma exceção
            }
            return b * a;
    }
  }
}

namespace Calc2 {
    class Area {
        public static double Quadrado(double b, double a) {
            if(b == 0 || a == 0) {
                throw new Exception("Base ou altura precisam ser diferentes de 0");         //forçando uma exceção
            }
            return b * a;
    }
  }
}

class Aula37 {

    static void Main() {

        double area = 0;
        
        try {
            area = Calc1.Area.Quadrado(2, 5);    
            Console.WriteLine("Resultado: " +area);              
        }
        catch(Exception e) {                                     //tratamento de exceções
            Console.WriteLine("ERRO: " +e.Message);
        }
        finally {                                               //executado independente se tiver exceção ou não
            Console.WriteLine("Fim da operação");
        }
    }

}