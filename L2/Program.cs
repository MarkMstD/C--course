{
int value = new Random().Next(10, 1000);
double a = value / 100;
double b = value % 100;
double c = value % 100;
Console.WriteLine(value);

if (a > b)
{
   Console.WriteLine(a);
}
else if (b > c)
{
   Console.WriteLine(b);
}
else
{
   Console.WriteLine(c); 
}
}