// Напишите программу которая выводит массив из 8 элементов 
// заполненный нулями и единицами в случ. порядке.
// [1,0,0,1,1,0,1]

Console.WriteLine("Введите длинну массива ");
int lengthArray = Convert.ToInt32(Console.ReadLine());

int [] arr = CreateArray(lengthArray);
PrintArray(arr);


int[] CreateArray(int size)
{
    int[] array = new int [size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0,2);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");        
    }
}