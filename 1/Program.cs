// Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

Console.Clear();

void inputArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(1, 101);
}

int from20to90(int[] array){
    int count = 0;
    foreach (int element in array){
        if (element >= 20 || element % 7>= 90)
            count++;
    }
    return count;
}

int[] array = new int[10];
inputArray(array);
Console.WriteLine($"Полученный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Числа от 20 до 90: {from20to90(array)}");
