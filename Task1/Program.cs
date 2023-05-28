/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
class Program {
    public static void Main (string[] args) {
        Console.Write("Введите 5-значное число: ");
        String stringNumber = Console.ReadLine() ?? "Значение Null";
        int number;
        bool isNumber = int.TryParse(stringNumber, out number);
        if (isNumber && stringNumber.Length == 5 && !stringNumber[0].Equals('0'))
        {
            if (stringNumber[0] == stringNumber[4] && stringNumber[1] == stringNumber[3])
            {
                Console.WriteLine("Число {0} - палиндром", stringNumber);
            }
            else
            {
                Console.WriteLine("Число {0} - не палиндром", stringNumber);
            }
        }
        else
        {
            Console.WriteLine("Invalid string entered");
        }
     }
}

