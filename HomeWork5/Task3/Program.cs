using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix matrix = new MyMatrix(2, 10);
            matrix.ChangeMatrixSise(2, 5);
            matrix[0, 0] = 5;
            matrix[0, 1] = 10;
            matrix.ShowMatrix();
            matrix.ChangeMatrixSise(2, 5);
            matrix.CreateRandomValuesInMatrix(0, 50);
            matrix.ShowMatrix();

            Console.ReadKey();
        }
    }
}
