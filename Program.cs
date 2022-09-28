Console.WriteLine();

Console.WriteLine("Введите трёхзначное число, далее программа покажет последнюю цифру этого числа:");

int n = int.Parse(Console.ReadLine());

// Проверка на соответсвие требованиям ввода:

if (n > 999 || n < 100)
{
    Console.WriteLine("Вы ввели неверное число");
}
    // Сама процедура обработки и вывода опрерации
     else 
    {
        Console.WriteLine("последняя цифра этого числа:");

        int j = (n - ((n / 10)*10));

        Console.WriteLine(j);
    }