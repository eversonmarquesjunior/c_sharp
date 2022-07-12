using System;

class Carro {
    private int[] vmax = new int[5]{30, 45, 120, 150, 300};
    public int this[int i] {            //indexador - membro que permite aos objetos de uma classe serem arrays
        get{
            return vmax[i];
        }                               //acessors - propriedade get leitura / set escrita
        set{
            if(value < 0) {
                vmax[i] = 0;
            }
            else if(value > 300) {
                vmax[i] = 300;
            }
            else {
                vmax[i] = value;
            }
        }
    }              
    public Carro() {
    }
    
class Aula30 {

    static void Main() {

        Carro c1 = new Carro();

        c1[4] = 200;
        Console.WriteLine("Velocidade: " +c1[4]);

    }

  }

}