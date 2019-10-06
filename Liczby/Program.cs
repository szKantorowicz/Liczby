using System;

namespace Liczby
{
    class Program
    {
        private ICalculator _calculatorService;

        public Program()
        {
            _calculatorService = new Calculator();
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            try
            {
                program.Calculate();
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Coś poszło nie tak. {exception.Message}");
            }

            Console.ReadKey();
        }

        void Calculate()
        {
            string number;
            int sum;
            Console.Write("podaj liczbe: ");

            number = Console.ReadLine();
            int c = TryParseNumber(number);

            Console.WriteLine("Podaj typ operacji:");
            string type = Console.ReadLine();
            int typeAsInt = TryParseNumber(type);

            switch (typeAsInt)
            {
                case (int)OperationType.SumEvenNumbers:
                    sum = _calculatorService.SumEvenNumbers(c);
                    break;
                case (int)OperationType.SumOddNumbers:
                    sum = _calculatorService.SumOddNumbers(c);
                    break;
                case (int)OperationType.MultiEvenNumbers:
                    sum = _calculatorService.MultiEvenNumbers(c);
                    break;
                case (int)OperationType.MultiOddNumbers:
                    sum = _calculatorService.MultiOddNumbers(c);
                    break;
                case (int)OperationType.DivEvenNumbers:
                    sum = _calculatorService.DivOddNumbers(c);
                    break;
                case (int)OperationType.DivOddNumbers:
                    sum = _calculatorService.DivOddNumbers(c);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(OperationType));
            }

            if (c == 0)
                return;

            Console.WriteLine($"suma jest równa {sum}");
        }

        private static int TryParseNumber(string number)
        {
            int numberAsInt = 0;

            try
            {
                numberAsInt = int.Parse(number);
                return numberAsInt;
            }
            catch
            {
                Console.WriteLine("Podano zlą wartość.");
            }

            return numberAsInt;
        }

        public enum OperationType
        {
            SumEvenNumbers = 1,
            SumOddNumbers = 2,
            MultiEvenNumbers = 3,
            MultiOddNumbers = 4,
            DivEvenNumbers= 5,
            DivOddNumbers= 6}
    }
}