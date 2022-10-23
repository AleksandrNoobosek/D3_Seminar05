//I. Реализовать следующие функции для работы с массивами:
//   Заполнение массива
void FillArray(int[] array,int min,int max)
{
for (int index = 0; index < array.Length; index++)                                            
    array[index] = new Random().Next(min,max);
}
//7. Печать массива на экран
void PrintArray(int[] array)
{
    for(int index = 0 ; index < array.Length; index++)
        Console.Write($"{array[index]} ");
}
//  1. Поиск минимума
int NumMin (int[] array)
{
int min = array[0];
for(int index= 0; index < array.Length; index++)
    {
        if (array[index]<min)
                min =array[index];
    }
    return min;
}
//  2. Поиск максимума
int NumMax (int[] array)
{
int max = array[0];
    for(int index= 0; index < array.Length; index++)
    {
        if (array[index]>max)
            max =array[index];
    }
    return max;
}
//  3. Поиск суммы элементов массива
int NumSum (int[] array)
{
int sum = 0;
    for(int index = 0; index < array.Length; index++)
        sum +=array[index];
    return sum;
}
//  4. Поиск произведения элементов массива
int NumProduct (int[] array)
{
int mult = 1;
    for(int index = 0; index < array.Length; index++)
        mult = mult * array[index];
    return mult;
}
//  5. Поиск индекса заданного элемента в массиве, если такого элемента в массиве нет то возвращать -1
int IndexOf (int[] array, int find)
{
int position = -1;
    for(int index = 0; index < array.Length; index++)
    {
        if(array[index]==find)
        {
            position = index;
            break;
        }
    }
    return position;
}
//  6. Проверка наличия элемента в массиве. Возвращает true, если элемент в массиве есть, false – нет.
bool ElementTrueFalse(int[] array, int element)
{
for(int index = 0; index < array.Length;index++)
    if(array[index]==element) return true;
return false;
}
//  8. Среднее арифметическое элеметов массива
float ArithmeticMean (int[] array)
{
    return NumSum (array)/ ((float)array.Length); // float ArithmeticMean (int[] array) => NumSum (array)/ ((float)array.Length);
}
//  9. Подсчёт количества отрицательных элементов массива
int CountNegative (int[] array)
{
    int countneg = 0;
    for(int index = 0; index < array.Length; index++)
        if(array[index]<0)
            countneg++;
    return countneg;
}
//  10. Подсчёт количества вхождений элемента в массиве
int CounteElement (int[] array, int inputnum)
{
    int count = 0;
    for(int index = 0; index < array.Length; index++)
        if(array[index]==inputnum)
            count++;
    return count;
}
//  11. Подсчёт количества чётных элементов в массиве
int EvenNum (int[] array)
{
    int counteven = 0;
    for(int index = 0; index < array.Length; index++)
        if(array[index]%2==0)
            counteven++; 
    return counteven;
}
//  12. Подсчёт количества положительных элементов в массиве
int CountPositiv (int[] array)
{
    int countpos = 0;
    for(int index = 0; index < array.Length; index++)
        if(array[index]>=0)
            countpos++;
    return countpos;
}
//  13. Подсчёт количества нечётных элементов в массиве
int OddNum (int[] array)
{
    int counteodd = 0;
    for(int index = 0; index < array.Length; index++)
        if(array[index]%2!=0)
            counteodd++; 
    return counteodd;
}
// Сортировка массива
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) 
            {
                minPosition = j;
            }           
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
//14. Проверка является ли массив отсортированным по возрастанию. Если массив отсортирован, то возвращать true, иначе - false.
bool TrueFalseSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
        if(array[i+1] < array[i])  
                return false; 
return true;
}

Console.Write ("Введите размер массива:  ");
int size = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
Console.Clear();

int[] array = new int[size];

FillArray(array,1,15);

Console.Clear();

//task1 - Поиск минимума!

Console.WriteLine("task1 - Поиск минимума!");
Console.WriteLine();

Console.WriteLine("Ваш массив: "); 
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
int min = NumMin(array);
Console.WriteLine($"Минимум найден и равен {min}");

Console.ReadKey();
Console.Clear();

// task2 - Поиск максимума!

Console.WriteLine("task2 - Поиск максимума!");
Console.WriteLine();

Console.WriteLine("Ваш массив: "); 
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
int max = NumMax(array);
Console.WriteLine($"Максимум найден и равен {max}");

Console.ReadKey();
Console.Clear();

//task3 - Поиск суммы элементов массива!

Console.WriteLine("task3 - Поиск суммы элементов массива!");
Console.WriteLine();

Console.WriteLine("Ваш массив: "); 
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
int sum = NumSum(array);
Console.WriteLine($"Сумма элементов массива равна {sum}");

Console.ReadKey();
Console.Clear();

//task4 - Поиск произведения элементов массива!

Console.WriteLine("task4 - Поиск произведения элементов массива!");
Console.WriteLine();

Console.WriteLine("Ваш массив: "); 
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
double mult = NumProduct(array);
Console.WriteLine($"Произведения элементов найдено и равно {mult}");

Console.ReadKey();
Console.Clear();

//task5 - Поиск индекса заданного элемента в массиве, если такого элемента в массиве нет то возвращать -1!

Console.WriteLine("task5 - Поиск индекса заданного элемента в массиве, если такого элемента в массиве нет то возвращать -1!");
Console.WriteLine();

Console.WriteLine("Ваш массив: "); 
PrintArray(array);
Console.WriteLine();

Console.WriteLine();
Console.Write ("Введите число для поиска индекса этого элемента в массиве:  ");
int find = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine();

int indexof = IndexOf(array, find);
Console.WriteLine($"Индекс заданного элемента в массиве равен {indexof}");

Console.ReadKey();
Console.Clear();

//task6 - Проверка наличия элемента в массиве. Возвращает true, если элемент в массиве есть, false – нет.!

Console.WriteLine("task6 - Проверка наличия элемента в массиве. Возвращает true, если элемент в массиве есть, false – нет.");
Console.WriteLine();

Console.WriteLine("Ваш массив: "); 
PrintArray(array);
Console.WriteLine();

Console.WriteLine();
Console.Write ("Введите число для проверки наличия элемента в массиве:  ");
int element = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine();

bool elementTF=ElementTrueFalse(array,element);
Console.WriteLine(elementTF);

Console.WriteLine();

Console.ReadKey();
Console.Clear();

//task7 - Печать массива на экран!

Console.WriteLine("task7 - Печать массива на экран!");
Console.WriteLine();

Console.WriteLine($"Размер массива равен: {size} ");
Console.WriteLine();

int[] arr = new int[size];
Console.WriteLine("Ваш массив: ");   
PrintArray(arr);

Console.ReadKey();
Console.Clear();

//task8 - Среднее арифметическое элеметов массива!

Console.WriteLine("task8 - Среднее арифметическое элеметов массива!");
Console.WriteLine();

Console.WriteLine($"Размер массива равен: {size} ");
Console.WriteLine();

Console.WriteLine("Ваш массив: "); 
PrintArray(array);

Console.WriteLine();
Console.WriteLine($"Среднее арифметическое элеметов массива равно {ArithmeticMean(array)}");

Console.ReadKey();
Console.Clear();

//task9 - Подсчёт количества отрицательных элементов массива!

Console.WriteLine("task9 - Подсчёт количества отрицательных элементов массива!");
Console.WriteLine();
FillArray(array,-10,10);
Console.WriteLine("Ваш массив: "); 
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
int neg = CountNegative(array);
Console.WriteLine($"Количества отрицательных элементов массива {neg}");

Console.ReadKey();
Console.Clear();

// task10 - Подсчёт количества вхождений элемента в массив!

Console.WriteLine("task10 - Подсчёт количества вхождений элемента в массив!");
Console.WriteLine();

FillArray(array,-10,10);
Console.WriteLine("Ваш массив: "); 
PrintArray(array);
Console.WriteLine();

Console.Write ("Введите число для поиска количества элемента в массиве:  ");
int inputnum = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine();

int countelement = CounteElement(array, inputnum);
Console.WriteLine($"Количество вхождений элемента в массив равно {countelement}");

Console.ReadKey();
Console.Clear();

//task11 - Подсчёт количества чётных элементов в массиве!

Console.WriteLine("task11 - Подсчёт количества чётных элементов в массиве!");
Console.WriteLine();

Console.WriteLine("Ваш массив: "); 
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
int even = EvenNum(array);
Console.WriteLine($"Количество чётных элементов в массиве равно {even}");

Console.ReadKey();
Console.Clear();

//task12 - Подсчёт количества положительных элементов в массиве!

Console.WriteLine("task12 - Подсчёт количества положительных элементов в массиве!");
Console.WriteLine();

Console.WriteLine("Ваш массив: "); 
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
int pos = CountPositiv(array);
Console.WriteLine($"Количества положительных элементов массива {pos}");

Console.ReadKey();
Console.Clear();

//task13 - Подсчёт количества нечётных элементов в массиве!

Console.WriteLine("task13 - Подсчёт количества нечётных элементов в массиве!");
Console.WriteLine();

Console.WriteLine("Ваш массив: "); 
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
int odd = OddNum(array);
Console.WriteLine($"Количество нечётных элементов в массиве равно {odd}");

Console.ReadKey();
Console.Clear();

// task14- Проверка является ли массив отсортированным по возрастанию. Если массив отсортирован, то возвращать true, иначе - false.

Console.WriteLine("task14 - Проверка является ли массив отсортированным по возрастанию. Если массив отсортирован, то возвращать true, иначе - false."); 

FillArray(array,55,66);
Console.WriteLine("Ваш массив: ");  
PrintArray(array);
Console.WriteLine();
Console.WriteLine($": {TrueFalseSort(array)} ");
Console.WriteLine();

SelectionSort(array);
Console.WriteLine("Ваш массив : ");  
PrintArray(array);
Console.WriteLine();
Console.WriteLine($": {TrueFalseSort(array)} ");

Console.ReadKey();
Console.Clear();
