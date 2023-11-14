// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Parallel.For(0, 200000, x => Console.WriteLine($"{x}"));

//for (int i = 0; i < 20; i++)
//{
//    Console.WriteLine($"{i}");
//}
