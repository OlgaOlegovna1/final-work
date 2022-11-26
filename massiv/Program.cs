/*Написать программу которая из имеющегося массива строк, формирует массив из строк, 
длина которых меньше или равна 3 символам. */

string[] arr = new string[5] {"кот", "152", "мама", "фестиваль", "Ре"};
string[] array = new string[arr.Length];
void Array(string[] arr, string[] array)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
    if(arr[i].Length <= 3)
        {
        array[count] = arr[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Array(arr, array);
PrintArray(array);