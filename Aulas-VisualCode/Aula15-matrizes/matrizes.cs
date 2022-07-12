using System;

class Aula15 {

    static void Main(){

        int[,] n = new int[3,5];                            //linha-coluna
        int[,] num = new int[2,2]{{10,20},{30,40}};         //forma reduzida

        n[0,0] = 00; n[0,1] = 10; n[0,2] = 20; n[0,3] = 30; n[0,4] = 40;

        n[1,0] = 11; n[1,1] = 22; n[1,2] = 33; n[1,3] = 44; n[1,4] = 55;

        n[2,0] = 66; n[2,1] = 77; n[2,2] = 88; n[2,3] = 99; n[2,4] = 1010;

        Console.WriteLine(num[0,0]);
    
    }
}