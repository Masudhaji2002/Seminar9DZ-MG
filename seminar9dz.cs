//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
 Console.WriteLine("Введите целое число M: ");
  int M = Int32.Parse(Console.ReadLine());
  Console.WriteLine("Введите целое число N: ");
  int N = Int32.Parse(Console.ReadLine());
  Console.Write($" M = {M}; N = {N}. ->  '' ");
  while (M <= N)
  
   {
      
       Console.Write(M.ToString());
       M++;
    }
Console.Write(" '' ");

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int numberN = int.Parse(Console.ReadLine());

void GapNumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"M = {numberM}; N = {numberN} -> {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    GapNumberSum(numberM, numberN, sum);
}

GapNumberSum(numberM, numberN, 0);


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int number1 = InputNumbers("Введите m: ");
int number2 = InputNumbers("Введите n: ");

int functionAkkerman = A(number1, number2);

Console.Write($"m = {number1}, n = {number2} -> A(m,n)={functionAkkerman} ");

static int A(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return A(m - 1, 1);
    else
      return A(m - 1, A(m, n - 1));
}


int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}