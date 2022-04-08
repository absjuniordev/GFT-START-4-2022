
namespace Atividade_02
{
    class Progan
    {
        static void Main()
        {
            Console.WriteLine("Atividade 2, escola GFT");
       
            Aluno aluno1 = new Aluno("0001", 10, 8, 5, 5);
            Aluno aluno2 = new Aluno("0002", 7.5, 9, 8, 5);
            Aluno aluno3 = new Aluno("0003", 5, 8, 9, 5);
            Aluno aluno4 = new Aluno("0004", 0.5, 8, 5, 5);
            Aluno aluno5 = new Aluno("0005", 0, 8, 7, 5);

            var media1 = aluno1.MediaAluno();
            System.Console.WriteLine(aluno1);
            var media2 = aluno2.MediaAluno();
            System.Console.WriteLine(aluno2);
            var media3 = aluno3.MediaAluno();
            System.Console.WriteLine(aluno3);
            var media4 = aluno4.MediaAluno();
            System.Console.WriteLine(aluno4);
            var media5 = aluno5.MediaAluno();
            System.Console.WriteLine(aluno5);


            System.Console.WriteLine();
            Console.ReadLine();
        }
    }
}