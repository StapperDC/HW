// Task 1

/*int Exponentiation(int number, int degree){
    int result = 1;
    for (int i = 0; i < degree; i++)
    {
        result = result * number;
    }
    return result;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a degree of number: ");
int degree = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"your number {num} in degree {degree} = " + Exponentiation(num, degree));*/


//Task 2

/*int SumOfDigits(int number){
    int sum = 0;
    for (int i = number; i != 0; i = i / 10)
    {
        sum = sum + i % 10;
    }
    return sum;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num + " -> " + SumOfDigits(num));*/


//Task 3

/*int[] CreateArray(int size){
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i} number of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

Console.Write("Input a size of array: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(num);
for (int i = 0; i < num; i++){ 
    Console.Write(array[i]+ " ");
}*/