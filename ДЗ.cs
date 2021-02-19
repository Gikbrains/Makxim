using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            Console.WriteLine($"Привет, {Console.ReadLine()}, сегодня {DateTime.Today.ToLongDateString()}");
            Console.WriteLine("Нажмите на любую кнопку для выхода из программы.");
            Console.ReadKey();
        }
}
