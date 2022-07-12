using System;

class Area {
    public static double Quadrado(double b, double a) {
        if(b == 0 || a == 0) {
            throw new Exception("Base ou altura precisam ser diferentes de 0");         //forçando uma exceção
        }
        return b * a;
    }
}

class Aula36 {

    static void Main() {

        double area = 0;
        
        try {
            area = Area.Quadrado(0, 5);    
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