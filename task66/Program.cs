// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите число M: ");
int bound=int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число N: ");
int numb=int.Parse(Console.ReadLine()!);

Console.Write(FunctSum(numb,bound));


int FunctSum(int numb, int bound){
if(numb==bound) return bound;
return(numb+FunctSum(numb-1, bound));

}