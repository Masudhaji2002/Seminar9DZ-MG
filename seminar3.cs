//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
 Console.Write ("Введите пятизначное число: ");
 int number = Convert.ToInt32(Console.ReadLine());
 string numbert = Convert.ToString(number);
 int Num = int.Parse (numbert);

 int n1 = Num / 10000;
 int n5 = Num % 10;
 int n4 = (Num % 100 - Num % 10) / 10;
 int n2 = (Num / 1000) % 10;
  
 if (n1 == n5 && n2 == n4)
     Console.WriteLine ("Число {0} является палиндромом", Num);
 else 
     Console.WriteLine ("Число {0} не является палиндромом", Num);


//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
 Console.WriteLine("Введите х1=");
             int buf = Int32.Parse(Console.ReadLine());
             double x1 = Convert.ToDouble(buf);

             Console.WriteLine("Введите х2=");
             int qwerty = Int32.Parse(Console.ReadLine());
             double x2 = Convert.ToDouble(qwerty);
 
             Console.WriteLine("Введите у1=");
             int asd = Int32.Parse(Console.ReadLine());
             double y1 = Convert.ToDouble(asd);
 
             Console.WriteLine("Введите у2=");
             int a = Int32.Parse(Console.ReadLine());
             double y2 = Convert.ToDouble(a);

             Console.WriteLine("Введите z1=");
             int t = Int32.Parse(Console.ReadLine());
            double z1 = Convert.ToDouble(t);

              Console.WriteLine("Введите z2=");
             int tk = Int32.Parse(Console.ReadLine());
             double z2 = Convert.ToDouble(tk);

            double d = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));

        
            Console.WriteLine("Результат равен = {0}", d);



//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int counter = 1;
while(counter<=number)
{
    Console.WriteLine("{0} -> {1}", counter, Math.Pow(counter,3));
    counter++;


}