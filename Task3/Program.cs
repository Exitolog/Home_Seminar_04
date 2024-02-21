// Напишите программу, которая
//  перевернёт одномерный массив 
//  (первый элемент станет последним, второй – предпоследним и т.д.)

using System.ComponentModel;

void Main ()
{

     int arraySize = ReadInt("Введите количество чисел в массиве: ");
    int[] array = GenerateArray(arraySize, 0, 10);
    PrintArray(array);
    System.Console.WriteLine(" ");
    BackPrintArray(array);

    


}
int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] myArray = new int[size];

    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(leftRange, rightRange + 1); // 0 до 10;
    }

    return myArray;
}

void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        System.Console.Write(arrayForPrint[i] + "\t");
    }
}
void BackPrintArray(int[] backarrayForPrint)
{
    for (int i = backarrayForPrint.Length-1; i>=0; i--)
    {
    
    System.Console.Write(backarrayForPrint[i]+ "\t");
        
    }
}





Main();