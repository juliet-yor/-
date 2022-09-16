// Задача №2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.WriteLine("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber > secondNumber)
// {
//     Console.WriteLine($"Максимальное число {firstNumber}");
// }
// else
// {
//     Console.WriteLine($"Максимальное число {secondNumber}");
// }


// Задача №4.  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Console.WriteLine("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите третье число: ");
// int thirdNumber = Convert.ToInt32(Console.ReadLine());

// int max = firstNumber;  // Не уверена насколько это правильный метод кода, тк на семинаре сказали, что на каждое if должен быть else, но на лекции подобную задачу решали так

// if(firstNumber > max) max = firstNumber;
// if(secondNumber > max) max = secondNumber;
// if(thirdNumber > max) max = thirdNumber;

// Console.WriteLine($"Максимальное число {max}");


// Задача №6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine($"{number} четное число");
}
else
{
    Console.WriteLine($"{number} не четное число");
}