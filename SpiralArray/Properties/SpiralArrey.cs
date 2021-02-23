using System;
namespace SpiralArray.Properties
{
    public class SpiralArrey
    {
        public SpiralArray()
        {

        }
        public void CreatingArey(char[,] arrey)
        {
            int maxI = arrey.GetUpperBound(0) + 1;
            int maxJ = arrey.Length / maxI;

            for (int i = 0; i < maxI; i++)
            {
                for (int j = 0; j < maxJ; j++)
                {
                    arrey[i, j] = '0';
                    Console.Write("0");
                }
                Console.WriteLine();
            }
        }
    }
}
