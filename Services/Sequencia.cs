namespace Exercicio2.Services
{
    public static class Sequencia
    {
        public static int SequenciaFibonacci(int n)
        {
            if(n < 2)
            {
                return n;
            }

            else
            {
                return SequenciaFibonacci(n - 1) + SequenciaFibonacci(n - 2);
            }
        }

    }
}