using System;

class Aula12 {

    static void Main(){

        int tempo = 0;
        char escolha;

        Console.WriteLine("Paranavaí/PR até Guarulhos/SP");

        Console.WriteLine("Tipo de transporte: [a] Avião, [c] Carro, [o] Ônibus");
        escolha = char.Parse(Console.ReadLine());

        switch(escolha){
            case 'a':
            case 'A':
                tempo = 50;
                break;
            case 'c':
            case 'C':
                tempo = 320;        
                break;
            case 'o':
            case 'O':
                tempo = 410;
                break;
            default:
                tempo = -1;
                break;
        }

        if(tempo < 0) {
            Console.WriteLine("Transporte indisponível");
        }
        else {
            Console.WriteLine("Tempo de Viagem: " +tempo+ " minutos");
        }
        
    }

}