Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите знак");
string zn = Console.ReadLine();

int Sum = 0;



if (zn == "*")
{
    Sum = A * B;
}



Console.Write("Ответ: ");
Console.Write(Sum);
