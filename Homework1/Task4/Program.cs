Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int a = 0;

while(a < N)
{
    a += 2;
    Console.Write(" " + a);
}