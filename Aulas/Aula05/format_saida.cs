using System;

class Aula05 {

    static void Main(){

       /* int n1, n2, n3;
        n1 = 10; n2 = 20; n3 = 30;
        Console.WriteLine("n1: {0}, n2: {1}, n3: {2}", n1, n2, n3); */     //índices

        double vCompra = 12.5;
        double vVenda; 
        double lucro = 0.5;
        string produto = "Bolo";

        vVenda = vCompra + (vCompra * lucro);

        Console.WriteLine("Produto..........: {0,10}", produto);
        Console.WriteLine("Valor compra.....: {0,10:c}", vCompra);       //c = monetário
        Console.WriteLine("Lucro............: {0,10:p}", lucro);         //p = porcentagem
        Console.WriteLine("Valor de venda...: {0,10:c}", vVenda);
                        
        
        

    }

}