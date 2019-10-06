namespace Liczby
{
    public class Calculator : ICalculator
    {
        public int SumEvenNumbers(int number)
        {
            int sum = 0;

            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }

            return sum;
        }

        public int SumOddNumbers(int number)
        {
            int sum = 0;

            for (int i = 0; i <= number; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                }
            }

            return sum;
        }
        public int MultiEvenNumbers(int number)
        {
            int sum = 1;

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum * i;
                }
            }

            return sum;
        }
        public int MultiOddNumbers(int number)
        {
            int sum = 1;

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum * i;
                }
            }

            return sum;
        }
        public int DivOddNumbers(int number)
        {
            int div = 0;

            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    div = div - i;
                }
            }

            return div;
        }
        public int DivEvenNumbers(int number)
        {
            int sum = 0;

            for (int i = 0; i <= number; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum - i;
                }
            }

            return sum;
        }
    }
}
