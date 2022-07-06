using System;

namespace Aula02 {

    class Padrao {

        static void Main(string[] args){
            Console.WriteLine("Junior");
            if(args.GetLength(0) > 0){
                Console.Write(args.GetValue(0));
            }
            
        }
    
    }

}