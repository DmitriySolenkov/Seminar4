int Sum(int num)
{
int result=0;
for (int i = 1; i <= num; i++)
{
    result=result+i;
}
return result;
}


Console.Write("Enter your number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write(Sum(num1));