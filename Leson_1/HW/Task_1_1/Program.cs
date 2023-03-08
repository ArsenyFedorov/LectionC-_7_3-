//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write.Line("Ввидите первое число"!);
int z = int.Parse(Console.ReadLine());
Console.Write.Line("Ввидите второе  число"!);
int x = int.Parse(Console.ReadLine());
Console.Write.Line("Ввидите третье число"!);
int c = int.Parse(Console.ReadLine());
if (z > x ){
     if (z > c)
    Console.WriteLine(z);
    }
    else if (c > z)
    Console.WriteLine(c);

else if (z < x){
    if (x > c)
    Console.WriteLine(x);
    }
    else if (c > x)
    Console.Write.Line(c);
