using System;

class Carro {
    private int vmax;
    public int vm {
        get{
            return vmax;
        }                               //acessors - propriedade get leitura / set escrita
        set{
            if(value < 0) {
                vmax = 0;
            }
            else if(value > 300) {
                vmax = 300;
            }
            else {
                vmax = value;
            }
        }
    }              
    public Carro() {
        vm = 120;
    }
    
class Aula29 {

    static void Main() {

        Carro c1 = new Carro();

        c1.vm = 200;
        Console.WriteLine("Velocidade: " +c1.vm);

    }

  }

}