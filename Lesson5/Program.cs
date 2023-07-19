//Task  1

/*int[] CreateRandomArray(int size){
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}
int EvenNumbersInArray(int[] array){
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]% 2 == 0)result++;
    }
    return result;
}

Console.Write("Input a size of array: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(num);
for (int i = 0; i < num; i++){ 
    Console.Write(array[i]+ " ");
}
Console.WriteLine();
Console.WriteLine("There is "+ EvenNumbersInArray(array)+" even numbers in this array");*/


//Task 2

/*int[] CreateRandomArray(int size, int min, int max){
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min,max+1);
    }
    return array;
}
int OddPositionInArray(int[] array){
    int result = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        result = result + array[i];
    }
    return result;
}

Console.Write("Input a size of array: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min number in array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max number in array: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(num,min,max);
for (int i = 0; i < num; i++){ 
    Console.Write(array[i]+ " ");
}
Console.WriteLine("-> "+ OddPositionInArray(array));*/

//Task 3


double[] CreateArray(int size){
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i} number of array: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}
double MaxMin(double[] array){
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    return max-min;
}

Console.Write("Input a size of array: ");
int num = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArray(num);
for (int i = 0; i < num; i++){ 
    Console.Write(array[i]+ " ");
}
Console.Write("-> "+ MaxMin(array));