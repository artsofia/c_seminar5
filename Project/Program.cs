namespace Project;
class Program
{
    static void Main(string[] args)
    {
        int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        void FillArray(int[] array, int minValue = -9, int maxValue = 9)
        {
            maxValue++;
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(minValue, maxValue);
            }
        }

        void FillArrayDouble(double[] array, int minValue = -9, int maxValue = 9)
        {
            maxValue++;
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.NextDouble();
            }
        }

        void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        void PrintArrayDouble(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        void Task34()
        {
            int size = Input("Введите размер массива: ");
            int[] numbers = new int[size];

            FillArray(numbers, 100, 1000);
            PrintArray(numbers);

            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) count++;
            }
            Console.WriteLine($"Количество четных чисел равно: {count}");
        }

        void Task36()
        {
            int size = Input("Введите размер массива: ");
            int[] numbers = new int[size];

            FillArray(numbers, -9, 100);
            PrintArray(numbers);

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 1) sum += numbers[i];
            }
            Console.WriteLine($"Сумма = {sum}");
        }

        void Task38()
        {
            int size = Input("Введите размер массива: ");
            double[] numbers = new double[size];

            FillArrayDouble(numbers, -100, 100);
            PrintArrayDouble(numbers);

            double max = numbers[0];
            double min = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max) max = numbers[i];
                else if (numbers[i] < min) min = numbers[i];
            }
            Console.WriteLine($"Разница = {max - min}");
        }


        // Проверка кода 
        Console.Clear();
        int task = Input("Введите ноер задачи: ");
        switch (task)
        {
            case 34:
                Task34();
                break;
            case 36:
                Task36();
                break;
            case 38:
                Task38();
                break;
            default:
                Console.WriteLine("Ошибка ввода");
                break;
        }
    }
}
