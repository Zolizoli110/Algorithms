namespace Algorithms
{
    class Program
    {
        public static void Main(string[] args) { }

        private static int SeriesCalculation(int[] array, int arrayLength)
        {
            int value = 0;
            for (int i = 0; i < arrayLength; i++)
            {
                value += array[i];
            }
            return value;
        }

        private static bool Decision(int[] array, int number)
        {
            int i = 0;
            while (i <= array.Length && !(array[i] == number) {
                i++;
            }
            return i <= array.Length;
        }

        private static bool DecisionAll(int[] array, int number)
        {
            int i = 0;
            while (i <= array.Length && array[i] == number)
            {
                i++;
            }

            return i > array.Length;
        }

        private static bool PrimeTest(int number)
        {
            int i = 2;
            while (i <= Math.Sqrt(number) && i % 2 != 0)
            {
                i++;
            }
            return i > Math.Sqrt(number);
        }


    }
}