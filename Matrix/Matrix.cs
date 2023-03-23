using System.Threading.Channels;

namespace Matrix;

public class Matrix
{
    public int[,] self { get; set; }


    public void Print()
    {
        for (int i = 0; i < self.GetLength(0); i++)
        {
            for (int j = 0; j < self.GetLength(1); j++)
            {
                Console.Write($"{self[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}