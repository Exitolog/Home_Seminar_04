void Main()
{


    int arraySize = ReadInt("Введите количество чисел в массиве: ");
    int[] array = GenerateArray(arraySize, 100, 999);
    PrintArray(array);
    FindCount(array);



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
            myArray[i] = new Random().Next(leftRange, rightRange); //от 100 до 999;
        }

        return myArray;
    }

    void PrintArray(int[] arrayForPrint)
    {
        for (int i = 0; i < arrayForPrint.Length; i++)
        {
            System.Console.Write(arrayForPrint[i] + " ");
        }
    }
    void FindCount(int[] arrayCount)
    {
        int count = 0;
        for (int i = 0; i < arrayCount.Length; i++)
        {
            if (arrayCount[i] % 2 == 0)
            {
                count++;
            }
        }
        System.Console.WriteLine("\n" + count);
    }

}
Main();