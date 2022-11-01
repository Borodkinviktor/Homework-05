/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int [] massiv = new int [6];
RandomArray(massiv);
Console.WriteLine("Массив вещественных чисел");
PrintArray(massiv);
Console.WriteLine();
int min = Int32.MaxValue;
int max = Int32.MinValue;
 
    for (int i = 0; i < massiv.Length; i++)
{  
        if(massiv[i] > max) 
        {
            max = massiv[i];
        }
        if(massiv[i] < min) 
        {
            min = massiv[i];
        }
}

Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void RandomArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(new Random().Next(100,1000)) / 100;
    }
}
void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}