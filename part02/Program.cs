// II. Реализовать следующие функции:



// 1. Функцию, которая вычисляет число a в степени n
void Stepen(double a, double n)
{
double s = 0;
s = Math.Pow((a),n);
Console.WriteLine($"Число {a} в степени {n} равно {s}");
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
int count = 0;
int num = 0; 
int sum = 0;

if (10<=X)
{
    while(count<X)
        {
            num=X%10;
            sum = sum + num;
            X=X/10;            
        }
        Console.Write("Cуммa цифр произвольного целого числа N: ");
}

else
    {
        sum=X;
        Console.Write($"Подсчет суммы недоступен, введено число:");
    }
return sum;
}
// 4. Функцию, которая проверяет является ли заданное число n полиндромом
bool Palindrome(string value)
{
bool poli=true;
    for (int i = 0; i < value.Length / 2; i++)
        if (value[i] != value[value.Length - i - 1])poli = false;
if (poli == false)
     Console.WriteLine("число не является палиндром!"); 
else
    Console.WriteLine("число является палиндром!");
return poli;
}
//5. Функцию, складывающую два целых числа
void IntSum(int A, int B)
{
int C=0;
if (A % 1 == 0 && B % 1 == 0) 
    C = A + B;

else
{
    Console.WriteLine ($"что то не то!");   
}
Console.WriteLine ($"{C}");     
}
//  6. Функцию, определяющую является ли число простым, то есть возвращающую true, если число простое, иначе - false
bool IntegerNum(int numb)
{
bool I = true;
    for (int i = 2; i <= numb/2; i++)
        if (numb % i == 0) 
        {
            I = false;
            break;
        }
if(I==true)
    Console.WriteLine("число является простым!");
else
    Console.WriteLine("число  не является простым!");
return I;
}
//7. Функцию, определяющую является ли число чётным, то есть возвращающую true, если число чётное, иначе - false
bool EvenNum(int num)
{
bool xу = false;
if (num % 2 == 0) xу = true;
if (xу == true)
Console.WriteLine("число является чётным!");
else 
Console.WriteLine("число не является чётным!");
return xу;
}

Console.Clear();

// 1. Функцию, которая вычисляет число a в степени n

Console.WriteLine("Функцию, которая вычисляет число a в степени n: ");
Console.WriteLine();

Console.WriteLine("Введите число а: ");
double a = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Веедите значение степени N: ");
double n = int.Parse(Console.ReadLine() ?? "0");

Stepen(a,n);

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
Console.WriteLine("Веедите число N: ");
int X = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"{SumNum(X)}");
Console.ReadKey();
Console.Clear();

// 4. Функцию, которая проверяет является ли заданное число n полиндромом
Console.Write("4. Функцию, которая проверяет является ли заданное число n полиндромом");
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
Console.WriteLine("Enter yout value B: ");
int B = int.Parse(Console.ReadLine() ?? "0");//Convert.ToInt32  ?
Console.WriteLine($"Сумма двух чисел A и B равна"); 
IntSum(A,B);

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

