/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами. */

Console.WriteLine("Введите размер исходного массива: ");
int sizeA = Convert.ToInt32(Console.ReadLine());

string[] sourceArrayA = new string[sizeA];

string[] finalArrayF = new string[sizeA];
int shortElementCounter = 0;

for (int i = 0; i < sizeA; i++)
{
    Console.WriteLine($"Введите значение элемента массива A[{i}]: ");
    sourceArrayA[i] = Console.ReadLine();
    if (sourceArrayA[i].Length <= 3)
    {
        finalArrayF[shortElementCounter] = sourceArrayA[i];
        shortElementCounter++;
    }

}

Console.WriteLine($"Исходный массив: [{String.Join("; ", sourceArrayA)}]");

Console.WriteLine($"Итоговый массив: [{String.Join("; ", finalArrayF)}]");