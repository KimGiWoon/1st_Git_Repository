using System.Security.Cryptography.X509Certificates;

namespace GitStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] answer = new int[] {1, 3, 4, 5, 7, 11, 22, 44, 32 };
            int[] value = new int[answer.Length];
            for (int i = 0; i < answer.Length; i++)
            {

                if (answer[i] % 2 == 1)
                {
                    value[i] = answer[i];
                }
            }
            Array.Sort(value);
            answer = value;
            
            Console.WriteLine(answer);


        }
    }
}
