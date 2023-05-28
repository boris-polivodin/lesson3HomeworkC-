/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
class Program {
    public static void Main (string[] args) {
        Console.Write("Введите координату X первой точки: ");
        int x1 = 0;
        x1 = int.Parse(Console.ReadLine());
        Console.Write("Введите координату Y первой точки: ");
        int y1 = 0;
        y1 = int.Parse(Console.ReadLine());
        Console.Write("Введите координату Z первой точки: ");
        int z1 = 0;
        z1 = int.Parse(Console.ReadLine());
        Console.Write("Введите координату X второй точки: ");
        int x2 = 0;
        x2 = int.Parse(Console.ReadLine());
        Console.Write("Введите координату Y второй точки: ");
        int y2 = 0;
        y2 = int.Parse(Console.ReadLine());
        Console.Write("Введите координату Z второй точки: ");
        int z2 = 0;
        z2 = int.Parse(Console.ReadLine());

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        Console.WriteLine($"Расстояние между точками X({x1}, {y1}, {z1}) и Y({x2}, {y2}, {z2}) равно {Math.Round(distance, 2)}");
     }
}