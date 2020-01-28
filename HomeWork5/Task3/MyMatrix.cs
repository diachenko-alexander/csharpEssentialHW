using System;

namespace Task3
{
    class MyMatrix
    {
        int[][] matrix;

        public MyMatrix(int row, int col)
        {
            matrix = new int[row][];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[col];
            }
        }

        public int this[int index1, int index2]
        {
            get
            {
                if (index1 >= 0 && index1 < matrix.Length && index2 >= 0 && index2 < matrix[0].Length)
                    return matrix[index1][index2];
                else
                {
                    Console.WriteLine("Попытка обращения за пределы массива.");
                    return 0;
                }


            }

            set
            {
                if (index1 >= 0 && index1 < matrix.Length && index2 >= 0 && index2 < matrix[0].Length)
                    matrix[index1][index2] = value;
                else
                {
                    Console.WriteLine("Попытка обращения за пределы массива.");
                }
            }
        }

        public void ChangeMatrixSise(int row, int col)
        {
            if (row == 0 || col == 0)
            {
                Console.WriteLine("0 is not allowed for matrix sise");
                return;
            }

            int[][] newMatrix = new int[row][];
            for (int i = 0; i < newMatrix.Length; i++)
            {
                newMatrix[i] = new int[col];
            }

            matrix = newMatrix;
        }

        public void ShowMatrix()
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");

                }
                Console.WriteLine();
            }
        }

        public void CreateRandomValuesInMatrix(int minValue, int maxValue)
        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = rnd.Next(minValue, maxValue);
                }
            }

        }
    }
}
