// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
int Naturaldegree(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }

    return result;
}

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int naturaldegree = Naturaldegree(numberA, numberB);
Console.WriteLine("Ответ: " + naturaldegree);



//========================================================================================================================================================================

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumber(int numberN)
{

    int general = Convert.ToString(numberN).Length;
    int following = 0;
    int result = 0;

    for (int i = 0; i < general; i++)
    {
        following = numberN - numberN % 10;
        result = result + (numberN - following);
        numberN = numberN / 10;
    }
    return result;
}

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);



//========================================================================================================================================================================
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int lenArray = ReadInt("Введите длинну массива: ");  //длину массива можно ввести любую, не только из 8

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1, 9);
    Console.Write(randomArray [i] + ", ");
}

int ReadInt(string message)

{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


