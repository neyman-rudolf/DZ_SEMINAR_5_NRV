// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] array = new int[4]; 
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100,1000);
// }
// Console.WriteLine($"Array: [{String.Join("; ", array)}]");
// int evenNumber = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i]%2==0) evenNumber++;
// }

// Console.WriteLine($"Колличество чётных чисел в массиве = {evenNumber}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] array = new int[4]; 
// for (int i = 0; i < array.Length; i++)
// {
//      array[i] = new Random().Next(-99,100);
// }
// Console.WriteLine($"Array: [{String.Join("; ", array)}]");
// int sumNumbers = 0;

//  for (int i = 0; i < array.Length; i++)
//   {
//      if (i%2==0) 
//      sumNumbers = sumNumbers + array[i];
//   }

// Console.WriteLine($"Cумма элементов стоящих на нечётных позициях = {sumNumbers}");

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] array = new int[4]; 
for (int i = 0; i < array.Length; i++)
{
     array[i] = new Random().Next(0,100);
}
Console.WriteLine($"Array: [{String.Join("; ", array)}]");
int min=array[0];
int max=array[0];
for (int i = 0; i < array.Length; i++)
  {
    if (array[i]<=min) min = array[i];
    if (array[i]>=max) max = array[i];
  }
Console.WriteLine($"Максимальный элемент = {max}" );
Console.WriteLine($"Минимальный элемент= {min}" );
Console.WriteLine($"Разница между максимальным и минимальным элементами = {max-min}" );