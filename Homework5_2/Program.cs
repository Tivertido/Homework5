// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных ИНДЕКСАХ.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] numbers = new int[4];
        Random random = new Random();

        // Заполнение массива случайными числами
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(-100, 100);
            Console.Write(numbers[i] + " ");
        }

        int sum = 0;

        // Подсчет суммы элементов на нечетных индексах
        for (int i = 1; i < numbers.Length; i += 2)
        {
            sum += numbers[i];
        }

        Console.WriteLine("\nСумма элементов на нечетных индексах: " + sum);
    