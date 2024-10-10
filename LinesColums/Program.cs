namespace LinesColums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new();
            int minMatrixNumber = 1;
            int maxMatrixNumber = 9;
            int[,] matrix = new int[3,3];
            int lineIndex = 1;
            int columIndex = 0;
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = random.Next(minMatrixNumber, maxMatrixNumber + 1);
                    Console.Write(matrix[i,j]);
                }

                Console.WriteLine();
            }

            int productOfColum = 1;
            int sumOfLine = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                productOfColum *= matrix[i, columIndex];
            }

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                sumOfLine += matrix[lineIndex, i];
            }

            Console.WriteLine();
            Console.WriteLine($"Произведение первого столбца: {productOfColum}");
            Console.WriteLine($"Сумма второй строки: {sumOfLine}");
            Console.ReadKey();
        }
    }
}
