// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

Console.WriteLine("Введите число:");
string str = Console.ReadLine()??"";
int size = str.Length;
int [] arr = new int[size];
for (int i = 0; i < size; i++)
if (size < 5 || size > 5)
{
    Console.WriteLine("Введено некорректное число:");
}
if(str[0] == str[4] && str[1] == str[3])
{
    Console.WriteLine("Введенное число палиндром!");
}
else
{
    Console.WriteLine("Введенное число НЕ палиндром!");
}