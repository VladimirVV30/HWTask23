// Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


string cubeTable(int num)
{
    string result = $"{num} -> 1";
    for (int i = 2; i <= num; i++)
    {
    result = result + $", {Math.Pow(i, 3)}";
    }
    return result;
}
try
{
    System.Console.Write("Введите число = ");
    int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    System.Console.WriteLine(cubeTable(num));
}
catch
{
    System.Console.WriteLine("Вводите целочисленное значение");
}