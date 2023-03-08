//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Ввидет число");
int a = int.Parse(Console.ReadLine()!);
int b = 2 ;
 while (a > b ){
if (b%2 == 0){
Console.WriteLine(b); 
b ++ ;} 
else  b = b + 1 ;
}
