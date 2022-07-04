Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = 0;
int min = 0;

   if(a < b)
   {
    max = b;
    min = a;
   }
   else if(b < a)
   {
    max = a;
    min = b;
   }

Console.WriteLine("Максимальное " + max);
Console.WriteLine("Минимальное " + min);
