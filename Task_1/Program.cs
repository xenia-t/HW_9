/* Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N используя рекурсию.

   M = 1; N = 5 -> "2, 4"
   M = 4; N = 8 -> "4, 6, 8" */


int M = Promt("\nВведите значение  числа M: ");
int N = Promt("Введите значение числа N: ");
Console.Write($"\nЧетные числа в промежутке [{M}, {N}] => "); 
while (M <= 0) M +=1;
EvenRow(M, N);


   int Promt(String message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

void EvenRow (int M, int N)
{
    if (M > N) return;
    if (M % 2 == 0) Console.Write(M + " ");
    EvenRow(M + 1, N);
}
