namespace Matrix;

public class App
{
    public void Run()
    {
        var m1 = new Matrix();
        var m2 = new Matrix();

        m1.self = new int[,]
        {
            { 3,2,4},
            { -1, -3, 5 }
        };

        m2.self = new int[,]
        {
            { 1, -7, 2},
            { 2, -3, 1 },
            { 1, 1, -2 }
        };

        Multiply(m1, m2);
    }

    public void Multiply(Matrix m1, Matrix m2)
    {
        var output = new Matrix();
        output.self = new int[m1.self.GetLength(0), m2.self.GetLength(1)];
        for (int i = 0; i < m1.self.GetLength(0); i++)
        {
            for (int j = 0; j < m2.self.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < m1.self.GetLength(1); k++)
                {
                    sum += m1.self[i, k] * m2.self[k, j];
                    
                }
                output.self[i, j] = sum;
            }
        }
        output.Print();
    }
}