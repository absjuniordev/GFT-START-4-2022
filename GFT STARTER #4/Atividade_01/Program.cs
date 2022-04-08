
namespace Atividade_01
{
    class Progan
    {
        static void Main()
        {
            int j = 1;
            int[] valor = new int[3];
            Console.WriteLine("Atividade 1, ordenando valores");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Digite o {j}ª valor: ");
                valor[i] = int.Parse(Console.ReadLine());
                j++;
            }
            Console.WriteLine("Os valores em ordem crescente são:");
            int[] valorCrescente = valor.OrderBy(i => i).ToArray();
            foreach (int item in valorCrescente)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Os valores em ordem decrescente são:");
            int[] valorDecrescente = valor.OrderByDescending(i => i).ToArray();
            foreach (int item in valorDecrescente)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}