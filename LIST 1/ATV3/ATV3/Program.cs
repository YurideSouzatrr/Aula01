using System;

namespace ATV3
{
    class Program
    {
        private static object vet1;

        static int Main() {
            {
                int[] vetor1 = new int[10];
                int[] vetor2 = new int[10];
                int i;
                for (i = 0; i < 10; i++) {
                    int v = vetor1[i];
                    Console.WriteLine(" % d ", vetor1[i]);
                }
                for (i = 0; i < 10; i++) {
                    int v = pow(vetor1[i], 2);
                    vetor2[i] = v;
                }
                for (i = 0; i < 10; i++) {
                    Console.WriteLine(" % d % d  n ", vetor1[i], vetor2[i]);
                }
                return 0;
            }
        }
        private static int pow(object p, int v)
        {
            throw new NotImplementedException();
        }
    }
}
