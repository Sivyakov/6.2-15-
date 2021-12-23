using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public static int MaxElementMain(int[,] matrix)
        {
            int max = int.MinValue;
            int n = (int)Math.Sqrt(matrix.Length);
            for (int i = 0; i < n; i++)
            {
                if (matrix[i, i] > max)
                {
                    max = matrix[i, i];
                }
            }
            return max;
        }

        public static void MaxElementSecondary(int[,] matrix, out int max)
        {
            max = int.MinValue;
            int n = (int)Math.Sqrt(matrix.Length);
            for (int i = n - 1; i >= 0; i--)
            {
                if (matrix[n - i - 1, i] > max)
                {
                    max = matrix[n - i - 1, i];
                }
            }
        }
    }
}
