// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем

int [] Array (int i)
  {
    int[] myArray = new int[8];
    {
            for (int a = 0; a < i; a++)
            {
                Console.WriteLine("Введите элемент массива");
                 myArray[a] = Convert.ToInt32(Console.ReadLine());
            }
    }
    return myArray;
  } 


void mArray(int[] array)
{
    for(int i = 0; i <array.Length;i++)
    
    Console.Write(array[i] + "  ");

}


int[] newArray = Array(8);
mArray(newArray);