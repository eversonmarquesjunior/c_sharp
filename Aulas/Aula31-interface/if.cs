using System;

public interface Veiculo {                      //interfaces - implementam protótipos dos métodos
    void ligar();
    void desligar();
    void info();
}

public interface Combate {
    void disparar();
}

class Carro:Veiculo,Combate {                  //um classe pode usar várias interfaces
    public bool ligado;
    private int municao;
    public Carro() {
        setMunicao(100);
    }
    public void setMunicao(int qtde){
        this.municao = qtde;
    }
    public void ligar() {
        this.ligado = true;
    }
    public void desligar() {
        this.ligado = false;
    }
    public void info(){}
    public void disparar(){}
}

class Aula31 {

    static void Main() {

        Carro c1 = new Carro();

    }

}