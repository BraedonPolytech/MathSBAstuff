namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixA = new int[4];
            int[] matrixB = new int[4];
            int[] matrixC = new int[4];
            Console.WriteLine("Enter the numbers of the first array in the order of A,B,C,D");
            Console.WriteLine(new string('-', 20));
            for (int i = 0; i < matrixA.Length; i++)
            {
                Console.Write("Enter a number: ");
                matrixA[i] =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine("Enter the numbers of the second array in the order of A,B,C,D");
            Console.WriteLine(new string('-', 20));
            for (int i = 0; i < matrixB.Length; i++)
            {
                Console.Write("Enter a number: ");
                matrixB[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            matrixC[0] = matrixA[0] + matrixB[0];
            matrixC[1] = matrixA[1] + matrixB[1];
            matrixC[2] = matrixA[2] + matrixB[2];
            matrixC[3] = matrixA[3] + matrixB[3];
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Here is the new matrix");
            Console.WriteLine($"{matrixC[0]}\t{matrixC[1]}");
            Console.WriteLine($"{matrixC[2]}\t{matrixC[3]}");
            Console.ReadLine();
        }
    }
}
