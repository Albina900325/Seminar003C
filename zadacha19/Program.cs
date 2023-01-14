
Console.WriteLine("Ведите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

   if ( a % 100%10 == a % 10000%1000%100%10 && a / 10000 == a % 10)

        Console.WriteLine("Да");

  else Console.WriteLine("Нет");
//Не очень коректное решение