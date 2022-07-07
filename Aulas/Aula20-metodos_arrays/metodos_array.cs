using System;

class Aula20 {

    static void Main() {
 
        int[] v1 = new int[3]{10, 20, 30};
        int[] v2 = new int[3]{5, 15, 25};
        int[] v3 = new int[3]{9, 90, 99};
        int[,] matriz = new int[2,3]{{23,14,58},{27,11,44}};

        /*Random random = new Random();
        for(int i = 0; i < v1.Length ; i++) {
            v1[i] = random.Next(50);
        }
        */

        Console.WriteLine("Elementos Vetor 1");
        foreach(int n in v1) {
            Console.WriteLine(n);
        }

        //public static int BinarySearch(array, valor_procurado);                       //retorna a posição do elemento procurado
        Console.WriteLine("BinarySearch");
        int procurado = 90;
        int posicao = Array.BinarySearch(v3, procurado);
        Console.WriteLine("O valor {0} está na posição {1}", procurado, posicao);
        Console.WriteLine("-------------------------");

        //public static void Copy(array_origem, array_destino, qtde_elementos)          //copia os elementos de um array pra outro 
        Console.WriteLine("Copy");
        Array.Copy(v2, v3, v1.Length);     
        foreach(int n in v3) {
            Console.WriteLine(n);
        }
        Console.WriteLine("-------------------------");

        //public static void CopyTo(array_destino, a_partir_desta_posição)              //copia a partir do vetor de origem
        Console.WriteLine("CopyTo");
        v1.CopyTo(v2, 0);
        foreach(int n in v2) {
            Console.WriteLine(n);
        }
        Console.WriteLine("-------------------------");

        //public long GetLongLength(dimensão)                                           //retorna a quantidade de elementos de um array
        Console.WriteLine("GetLongLength");
        long qtdeElementosVetor = v1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos: " +qtdeElementosVetor);
        Console.WriteLine("-------------------------");
                                          

        //public int GetLowerBound(dimensão);                                           //retorna o menor índice de um array/matriz
        Console.WriteLine("GetLowerBound");
        int MenorIndiceVetor = v3.GetLowerBound(0);
        int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1);
        Console.WriteLine("Menor Índice do Vetor 3: " +MenorIndiceVetor);
        Console.WriteLine("-------------------------");

        //public int GetUpperBound(dimensão);                                           //retorna o maior índice de um array/matriz
        Console.WriteLine("GetUpperBound");
        int MaiorIndiceVetor = v3.GetUpperBound(0);
        int MaiorIndiceMatriz_D1 = matriz.GetUpperBound(1);
        Console.WriteLine("Maior Índice do Vetor 3: " +MaiorIndiceVetor);
        Console.WriteLine("-------------------------");

        //public object GetValue(índice)                                                //retorna valor a partir de um índice
        Console.WriteLine("GetValue");
        int valor0 = Convert.ToInt32(v1.GetValue(1));
        int valor1 = Convert.ToInt32(matriz.GetValue(1,2));
        Console.WriteLine("Valor da posição 1 do Vetor 1: " +valor0);
        Console.WriteLine("-------------------------");

        //public static int IndexOf(array, valor_procurado)                            //retorna o índice do valor indicado/primeiro valor encontrado
        Console.WriteLine("IndexOf");
        int indice1 = Array.IndexOf(v1, 20);
        Console.WriteLine("Índice do primeiro valor 20 encontrado: " +indice1);
        Console.WriteLine("-------------------------");

        //public static int LastIndexOf(array, valor_procurado)                        //retorna o índice do valor indicado/último valor encontrado
        Console.WriteLine("IndexOf");
        int indice2 = Array.IndexOf(v1, 10);
        Console.WriteLine("Índice do último valor 10 encontrado: " +indice2);
        Console.WriteLine("-------------------------");

        //public static void Reverse(array)                                           //inverte a ordem dos elementos
        Console.WriteLine("Reverse");
        Array.Reverse(v3);
        foreach(int n in v3) {
            Console.WriteLine(n);
        }
        Console.WriteLine("-------------------------");

        //public void SetValue(valor_a_definir, posição)                             //define um valor em uma posição do array
        Console.WriteLine("SetValue");
        v2.SetValue(15, 1);
        for(int i = 0; i < v2.Length; i++) {
            v2.SetValue(1, i);
        }
        Console.WriteLine("Vetor 2");
        foreach(int n in v2) {
            Console.WriteLine(n);
        }
        Console.WriteLine("-------------------------");

        //public static void Sort(array);                                           //ordenar elementos do array
        Console.WriteLine("Sort");
        Array.Sort(v1);
        Array.Sort(v2);
        Array.Sort(v3);
        Console.WriteLine("Vetor 1");
        foreach(int n in v1) {
            Console.WriteLine(n);
        }
        Console.WriteLine("Vetor 2");
        foreach(int n in v2) {
            Console.WriteLine(n);
        }
        Console.WriteLine("Vetor 3");
        foreach(int n in v3) {
            Console.WriteLine(n);
        }
        Console.WriteLine("-------------------------");

    }
}