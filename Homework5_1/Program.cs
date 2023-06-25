// // Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] numbers = new int[4];
        Random random = new Random();

        // Заполнение массива случайными числами
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(100, 1000);
            Console.Write(numbers[i] + " ");
        }

        int evenCount = 0;

        // Подсчет количества четных чисел
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                evenCount++;
            }
        }

        Console.WriteLine("\nКоличество чётных чисел: " + evenCount);