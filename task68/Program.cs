// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



Console.WriteLine("Введите число M: ");
int M=int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число N: ");
int N=int.Parse(Console.ReadLine()!);

Console.Write(Accer(M,N));


int Accer(int M, int N){
while(M!=0){
    if(N==0) N=1;
    else N=Accer(M,N-1);
    M=M-1;
}
return (N+1);
}