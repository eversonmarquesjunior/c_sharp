using System;

abstract class Veiculo {                //classe abstrata - só serve como herança(protótipo) para classes derivadas/ não instancia objetos / precisam ser implementados
    protected int vmax;
    protected int vatual;
    protected bool ligado;
    public Veiculo() {
        ligado = false;
        vatual = 0;
    }
    public void setLigar(bool ligado) {
        this.ligado = ligado;
    }
    public int getVatual() {
        return vatual;
    }
    abstract public void aceleracao(int mult);
}

class Carro:Veiculo {
    public Carro() {
        vmax = 350;
    }
    override public void aceleracao(int mult) {
        vatual += 10 * mult;
    }
}

class Aula25 {                      

    static void Main() {

        Carro c1 = new Carro();

        c1.aceleracao(1);
        c1.aceleracao(1);
        c1.aceleracao(-1);

        c1.getVatual();
        Console.WriteLine(c1.getVatual());

    }

}