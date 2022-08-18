Console.Write("Введите ваше число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res=1;
while(num>10)
{
num=num/10;
res++;
}

Console.Write($"Количество символов в числе: {res}");