/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N используя рекурсию.
   M = 1; N = 15 -> 120
   M = 4; N = 8 -> 30 */

int M = Promt("\nВведите значение  числа M: ");
int N = Promt("Введите значение числа N: ");
Console.Write($"\nСумма натуральных элементов в промежутке [{M}, {N}] => "); 
while (M <= 0) M +=1;
System.Console.WriteLine(SumNaturalRow(M, N));


int Promt(String message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int SumNaturalRow (int M, int N)
{
    if (M == N ) return M;
    return M + SumNaturalRow(M + 1, N);
}
