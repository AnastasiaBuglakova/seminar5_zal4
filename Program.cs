// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных элементов.

int[] CreateRandomArray (int size, int minValue, int maxValue){
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue+1);
    return array;
}
void ShowArray(int[] array){
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine(" ");
}
/*
int FindNegativeSumm(int[] array){
    int sum = 0;
    for(int i = 0; i<array.Length; i++)
    if (array[i]<0)
        sum += array[i];
        return sum;
}

Console.WriteLine("Enter size of array:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max of array:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min of array:");
int min = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
int negativeSumm = FindNegativeSumm(myArray);
Console.WriteLine($"Sum of negative elements is " + negativeSumm);
*/
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
Console.WriteLine("Enter seeking number:");
int m = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(10, 0, 99);
ShowArray(myArray);

bool Result(int[] Array)
{
bool res = false;
for (int i = 0; i < myArray.Length; i++){
    if(myArray[i] == m) res = true;
}
Console.WriteLine("result is: " + res);
}
*/
//Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [a,b].
//3 12 54 2 36 9 5 165

/*
int Quantity(int[] myArray, int a, int b)
{
    int count = 0;
    for(int i = 0; i < myArray.Length; i++)
    {
        if((myArray[i] < b) && (myArray[i] > a))
        count += 1;
    }
    return count;
}

Console.WriteLine("Enter min:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max:");
int b = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(10, 0, 199);
ShowArray(myArray);
int count = Quantity(myArray, a, b);
Console.WriteLine(count);
*/
//Напишите программу замена элементов массива: положительные элементы замените на 
//соответствующие отрицательные, и наоборот.
int[] newArray(int[] myArray)
{
    for(int i = 0; i < myArray.Length; i++)
    {
        myArray[i] =  myArray[i] * (-1);
    }
    return myArray;
}
int[] myArray = CreateRandomArray(10, 0, 199);
ShowArray(myArray);
int[] nArray = newArray(myArray);
ShowArray(nArray);