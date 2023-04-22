// Задача 38: Задайте массив вещественных чисел от -100 до 100 (длина массива 5 элементов). Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] array = new int[5] ; // arraySize == 4 - размер (количество)
int sum = 0; 
for (int i = 0; i < array.Length; i++) // заполнение массива
{
    int randomNumber = new Random().Next(-10, 101); // генерируем случайное число
    array[i] = randomNumber; // кладём в массив на место с индексом i
}
int max = array[0];
int min = array[0];
for (int i = 0; i < array.Length; i++) // вывод массива в консоль
{
    Console.Write(array[i] + "  ");
}
 Console.WriteLine();

for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
int diff = max - min;
Console.WriteLine($"Заница между {max} и {min} = "+ diff);