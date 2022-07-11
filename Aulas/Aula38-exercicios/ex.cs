using System;

class Aluno {
    public string nome;
    public string curso;
    public int semestre;

    public Aluno(string nome, string curso, int semestre) {
        this.nome = nome;
        this.curso = curso;
        this.semestre = semestre;
    }
}

class Boletim:Aluno {
    public int nota1;
    public int nota2;
    public int media;
    public int Boletim(int nota1, int nota2) {
        this.nota1 = nota1;
        this.nota2 = nota2;
    }
}

class Aula38 {

    static void Main() {

        string n, c;
        int s, media;
        int n1, n2;

        Console.Write("Nome do aluno: ");
        n = Console.ReadLine();
        Console.Write("Curso: ");
        c = Console.ReadLine();
        Console.Write("Semestre atual: ");
        s = int.Parse(Console.ReadLine());
        Console.Write("Primeira nota: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Segunda nota: ");
        n2 = int.Parse(Console.ReadLine());

        media = (n1 + n2) / 2;

        if(media >= 6) {
            Console.WriteLine("Aluno aprovado");
        }
        else if (media >= 4 && media < 5) {
            Console.WriteLine("Aluno em recuperação");
        }
        else {
            Console.WriteLine("Aluno reprovado");
        }
        
        Aluno a1 = new Aluno(n, c, s);
        Boletim b1 = new Boletim(n1, n2);

        Console.WriteLine("Aluno {0}. Curso {1}. Semestre {2}", a1.nome, a1.curso, a1.semestre);
        Console.WriteLine("Media: " +b1.media);

    }

}