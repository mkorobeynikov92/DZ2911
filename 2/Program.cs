// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

Console.Clear();

void inputArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(1, 101);
}

int chetn(int[] array){
    int count = 0;
    foreach (int element in array){
        if (element % 2 == 0)
            count++;
    }
    return count;
}

int[] array = new int[10];
inputArray(array);
Console.WriteLine($"Полученный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Четные числа: {chetn(array)}");