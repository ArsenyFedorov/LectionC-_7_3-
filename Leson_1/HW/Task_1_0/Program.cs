// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Ввидите первое число:");

int a = int.Parse(Console.ReadLine()!);
 
 Console.WriteLine("Ввидите второе  число:");

int b = int.Parse(Console.ReadLine()!);

if (a > b){
Console.WriteLine("большее число:" + a );
Console.WriteLine("меньшее число" + b);}
 else if (a < b) {
Console.WriteLine("большее число:" + b );
Console.WriteLine("меньшее число" + a);
}
