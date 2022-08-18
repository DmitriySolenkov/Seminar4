Console.WriteLine("Введите ваше число: ");
int num = Convert.ToInt32(Console.ReadLine());
int index=1;
int res=1;
while (index<=num)
{
res= res*index;
index++;
}
Console.Write($"Произведение чисел от 1 до вашего числа: {res}");