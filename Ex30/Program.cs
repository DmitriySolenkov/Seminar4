int[] array= new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random().Next(0,2);
}

for (int k = 0; k < array.Length; k++)
{
    Console.Write(array[k]+ ", ");
}
