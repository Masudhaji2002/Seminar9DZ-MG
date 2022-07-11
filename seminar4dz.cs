//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число А: ");
int numbera = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberb = Convert.ToInt32(Console.ReadLine());
double vozvedenie = Math.Pow(numbera, numberb);
Console.WriteLine("{0}^{1} = {2}", numbera, numberb, vozvedenie);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int summa = 0;
while ( numbers > 0)
{
    summa += numbers%10;
    numbers /= 10;
}
Console.WriteLine("Сумма цифр числа равно: {0} ", summa);

//Задача 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите кол-во элементов массива: ");
        
        int elementsCount = int.Parse(Console.ReadLine());

        int[] myArray = new int[elementsCount];
        
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write($"Введите элемент массива под индексом {i} ");
            myArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Вывод массива: ");

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine(myArray[i]);
        }
    }


    }











