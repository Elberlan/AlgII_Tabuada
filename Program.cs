namespace AlgII_Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número para calcular a tabuada: ");
            int n = int.Parse(Console.ReadLine());

            int[] tabuada = new int[11];

            for (int pos = 0; pos <= 10; pos++)
            {
                int x = pos * n;
                tabuada[pos] = x;
            }
            for (int pos = 0; pos < 11; pos++)
            {
                int t = tabuada[pos];
                Console.WriteLine("{0} x {1} = {2}", n, pos, t);
            }

        }
    }
}