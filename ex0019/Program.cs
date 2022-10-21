// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Программа проверяет, является ли введенное Вами пятизначное число палиндромом. ");
string number = Convert.ToString(Console.ReadLine()!);

void PallNumber(string number)
{
if (number[0] == number[4] && number[1] == number[3])
    {
    Console.WriteLine(number + " является палиндромом!");
    }  
else Console.WriteLine(number + " не является палиндромом!");
}

if(number.Length==5) PallNumber(number);

else
Console.WriteLine("Неверное число!");