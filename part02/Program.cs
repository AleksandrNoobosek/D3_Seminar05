
// II. Реализовать следующие функции:

// 1. Функцию, которая вычисляет число a в степени n
double Stepen(double a, double n)
{
double s = 0;
s = Math.Pow((a),n);
return s;
}
// 2. Функцию, которая вычисляет факториал числа n\
int Factorial(int N)
{
int f = 1;
    for(int count=1; count<=N;count++)
        f = count*f;
    return f;
}
// 3. Функцию, которая вычисляет сумму цифр произвольного целого числа n
int SumNum(int X)
{
int num; 
int sum = 0;
    while(X!=0)
        {
            num=X%10;
            sum = sum + num;
            X=X/10; 
        }           
return sum;
}
// 4. Функцию, которая проверяет является ли заданное число n полиндромом
bool Palindrome(string value)
{
    for (int i = 0; i < value.Length / 2; i++)
        if (value[i] != value[value.Length - i - 1]) return false;
return true;
}
//5. Функцию, складывающую два целых числа
int IntSum(int A, int B)
{
int C=0;
if (A % 1 == 0 && B % 1 == 0) 
    C = A + B; return C;
}
//  6. Функцию, определяющую является ли число простым, то есть возвращающую true, если число простое, иначе - false
bool IntegerNum(int numb)
{
    for (int i = 2; i <= numb/2; i++)
        if (numb % i == 0) return false;
return true;
}
//7. Функцию, определяющую является ли число чётным, то есть возвращающую true, если число чётное, иначе - false
bool EvenNum(int num)
{
if (num % 2 == 0) return true;
return false;
}

Console.Clear();

// 1. Функцию, которая вычисляет число a в степени n

Console.WriteLine("Функцию, которая вычисляет число a в степени n: ");
Console.WriteLine();

Console.WriteLine("Введите число а: ");
double a = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Веедите значение степени N: ");
double n = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"{a} в степени {n} равно {Stepen(a,n) } ");

Console.ReadKey();
Console.Clear();

// 2. Функцию, которая вычисляет факториал числа n
Console.WriteLine("Функцию, которая вычисляет факториал числа n: ");
Console.WriteLine();
Console.WriteLine("Введите число для вычисления факториала числа N : ");
int N = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"Факториал числа n равен {Factorial(N)}");

Console.ReadKey();
Console.Clear();

// 3. Функцию, которая вычисляет сумму цифр произвольного целого числа n
Console.WriteLine("Функцию, которая вычисляет сумму цифр произвольного целого числа N: ");

Console.WriteLine();
Console.WriteLine("Введите число N: ");
int X = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"Сумма цифр равна {SumNum(X)}");
Console.ReadKey();
Console.Clear();

// 4. Функцию, которая проверяет является ли заданное число n полиндромом
Console.WriteLine("4. Функцию, которая проверяет является ли заданное число n полиндромом");
Console.WriteLine("Веедите число N: ");
int number = int.Parse(Console.ReadLine() ?? "0");
string value = number.ToString();

Console.WriteLine();
Console.WriteLine($"{Palindrome(value)}");
Console.ReadKey();
Console.Clear();

//5. Функцию, складывающую два целых числа
Console.WriteLine("Функцию, складывающую два целых числа: ");

Console.WriteLine();
Console.WriteLine("Введите Ваше число A: ");
int A = int.Parse(Console.ReadLine() ?? "0"); //Convert.ToInt32 ?

Console.WriteLine();
Console.WriteLine("Введите Ваше число B: ");
int B = int.Parse(Console.ReadLine() ?? "0");//Convert.ToInt32  ?
Console.WriteLine($"Сумма двух чисел A и B равна {IntSum(A,B)}"); 

Console.ReadKey();
Console.Clear();

//6. Функцию, определяющую является ли число простым, то есть возвращающую true, если число простое, иначе - false
Console.WriteLine("task6.- Функцию, определяющую является ли число простым, то есть возвращающую true, если число простое, иначе - false");
Console.WriteLine("Введите число: ");
int numb = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"{IntegerNum(numb)}");

Console.ReadKey();
Console.Clear();

//7. Функцию, определяющую является ли число чётным, то есть возвращающую true, если число чётное, иначе - false
Console.WriteLine("Функцию, определяющую является ли число чётным, то есть возвращающую true, если число чётное, иначе - false ");
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"{EvenNum(num)}");

Console.ReadKey();
Console.Clear();

