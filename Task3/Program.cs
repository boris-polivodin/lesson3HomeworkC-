/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
class Program {
    public static void Main (string[] args) {
      Console.Write("Введите число N: ");
      int number = GetNmber();//int.Parse(Console.ReadLine());
      for (int i = 1; i <= number; i++)
        {
            Console.Write(i == number ? Math.Pow(i, 3) : Math.Pow(i, 3) + ", ");
        }
      Console.WriteLine();
    }

    static int GetNmber() {
        String stringNumber = Console.ReadLine() ?? "Значение Null";
        int number;
        bool isNumber = int.TryParse(stringNumber, out number);
        if (isNumber) {
            return number;
        }
        else
        {
            return 0;
        }
     }
}