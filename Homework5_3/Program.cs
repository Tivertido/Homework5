// Задайте массив целых двухзначных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [22, 42, 15, 77, 65] => 77 - 15 = 62**

int[] numbers = { 22, 42, 15, 77, 65 };
        int min = numbers[0];
        int max = numbers[0];

        // Поиск минимального и максимального элементов массива
        foreach (int number in numbers)
        {
            if (number < min)
            {
                min = number;
            }

            if (number > max)
            {
                max = number;
            }
        }

        int difference = max - min;
        Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);
