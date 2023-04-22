// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами (длина массива 5 элементов). Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = new int[5]; // arraySize == 4 - размер (количество)
int sum = 0; 
for (int i = 0; i < array.Length; i++) // заполнение массива
{
    int randomNumber = new Random().Next(100, 1000); // генерируем случайное число
    array[i] = randomNumber; // кладём в массив на место с индексом i
}

for (int i = 0; i < array.Length; i++) // вывод массива в консоль
{
    Console.Write(array[i] + "  ");
}
 Console.WriteLine();

for (int i = 0; i < array.Length; i++) // изменение массива уже после заполнения
{
    if (array[i] % 2 == 0)
    {
        sum += 1;  
    }
}
Console.Write("Четных чисел: " + sum );

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + "  ");
//  }