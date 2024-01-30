// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
static void Main(string[] args)
{

    int value1;
    int value2;

    Console.WriteLine("input value1 and press enter");

    value1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("input value 2 and press enter");

    value2 = Convert.ToInt32(Console.ReadLine());

    int result = (value1 + value2);

    Console.WriteLine("result");
}