/* Напишите прграмму вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
   m = 3, n = 2 -> A(m,n) = 29 */

int m = Promt("\nВведите значение  числа m: ");
int n = Promt("Введите значение числа n: ");
if (m < 0 || n < 0) System.Console.WriteLine("В качестве параметров функция принимает только неотрицательные числа");
else System.Console.WriteLine(A(m, n));


int Promt(String message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int A (int m, int n)
{
    if (m == 0 ) return n + 1;
    if (m > 0 && n == 0) return A(m - 1, 1);
    return A(m - 1, A(m, n - 1));
}
