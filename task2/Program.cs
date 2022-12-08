// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.WriteLine ("Введите чиcло");
string a = Console.ReadLine ();
int i=0,z=0;
for (i=0;i<a.Length;i++)
{
    if (Char.IsDigit(a[i])==false)
    {
        Console.WriteLine("Введено не чиcло");
        Environment.Exit(0);
    }
    else
        z=z+Convert.ToInt32(a[i]-48);
        
    
}
Console.WriteLine(z);