// Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ 
// или при вводе числа, сумма цифр которого чётная.



using System.Xml.XPath;

while (true)
{
int result = ReadInt("Введите целое число: ");
int  SumDigit = 0;
SumDigitFind(result);


    int ReadInt(string msg)
    {
        System.Console.Write(msg);
        return Convert.ToInt32(Console.ReadLine());
    }
   
if (result != 1)
{
   
   SumDigit =  SumDigit + result % 10;
    result = result/10;
}
return SumDigit;
bool SumDigitFind (int number)
{
if (SumDigit %2 == 0)
{
    return true;
}
else
{
    return false;
}
}
}
   






    // int[] GenerateArray(int size, int leftRange, int rightRange)
    // {
    // int[] myArray = new int[size];
    // Random rand = new Random();

    // for (int i = 0; i < size; i++)
    // {
    // myArray[i] = rand.Next(leftRange, rightRange + 1);
    // }

    // return myArray;
    // }





















