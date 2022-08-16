Console.Write("Введи какое-нибудь число: ");
int value = Convert.ToInt32(Console.ReadLine());
string valueE = Convert.ToString(value);
   if (valueE.Length > 2)
{
  Console.WriteLine("третья цифра -> " + valueE[2]);
}
   else 
{
  Console.Write("-> третьей цифры нет");
}
