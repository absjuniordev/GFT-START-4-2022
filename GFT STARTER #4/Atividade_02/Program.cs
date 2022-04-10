
namespace Atividade_02
{
    class Progan
    {
        static void Main()
        {

            Console.WriteLine("Atividade 2, escola GFT");
            System.Console.WriteLine("");

            Aluno aluno1 = new Aluno("0001", 10, 8, 5, 4);
            Aluno aluno2 = new Aluno("0002", 7.5, 9, 8, 2);
            Aluno aluno3 = new Aluno("0003", 5, 8, 9, 5);
            Aluno aluno4 = new Aluno("0004", 0.5, 8, 5, 2);
            Aluno aluno5 = new Aluno("0005", 0, 8, 7, 5);

            double media1 = aluno1.MediaAluno();
            System.Console.WriteLine(aluno1);
            System.Console.WriteLine("");
            double media2 = aluno2.MediaAluno();
            System.Console.WriteLine(aluno2);
            System.Console.WriteLine("");
            double media3 = aluno3.MediaAluno();
            System.Console.WriteLine(aluno3);
            System.Console.WriteLine("");
            double media4 = aluno4.MediaAluno();
            System.Console.WriteLine(aluno4);
            System.Console.WriteLine("");
            double media5 = aluno5.MediaAluno();
            System.Console.WriteLine(aluno5);
            System.Console.WriteLine("------------------------");
            // ReprovadosPorFrequencia();
            Console.WriteLine($"Quantidades de alunos reprovados por falta: {Aluno.FrequenciaParaAprovacao}");    
            MaiorEmenorNota();
            MediaDaTurma();
            Console.WriteLine($"Quantidade de reprovados: {Aluno.Aprovadocao}");

           
            void MediaDaTurma()
            {
                var mediaDaTurma = (media1 + media2 + media3 + media4 + media5) / 5;
                System.Console.WriteLine($"Media da turma é {mediaDaTurma.ToString("0.0")}");
            }
            void MaiorEmenorNota()
            {
                double maior = 0;
                double menor = 0;
                double[] notas = new double[] { media1, media2, media3, media4, media5 };
                var menorNota = notas.Min();
                Console.WriteLine($"A menor nota é {menorNota.ToString("0.0")}");
                var maiorNota = notas.Max();
                Console.WriteLine($"A maior nota é {maiorNota.ToString("0.0")}");
            }

            Console.ReadLine();

        }
    }
}