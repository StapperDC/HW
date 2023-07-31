//Task1

/*double[,] RandomArray(int lines, int colums, int minvalue, int maxvalue){
    double[,] array = new double[lines, colums];
    for (int i = 0; i < lines; i++){
        for (int j = 0; j < colums; j++){
            array[i,j] = new Random().NextDouble() + new Random().Next(minvalue, maxvalue);
        } 
    }
    return array;
}

Console.Write("Input amount of lines: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Input amount of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] array = RandomArray(lines, colums, min, max);
for (int i = 0; i < lines; i++){
    for (int j = 0; j < colums; j++){
        Console.Write(Math.Round(array[i,j] , 2) + " ");
    }
    Console.WriteLine();
}*/



//Task2

/*int[,] RandomArray(int lines, int colums, int minvalue, int maxvalue){
    int[,] array = new int[lines, colums];
    for (int i = 0; i < lines; i++){
        for (int j = 0; j < colums; j++){
            array[i,j] = new Random().Next(minvalue, maxvalue + 1);
        } 
    }
    return array;
}

bool CheckArray(int[,] array, int line, int colum){
    return (array.GetLength(0) > line && array.GetLength(1) > colum);
}

Console.Write("Input amount of lines: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Input amount of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = RandomArray(lines, colums, min, max);
    for (int i = 0; i < lines; i++){
        for (int j = 0; j < colums; j++){
            Console.Write(array[i, j] + " ");
        } 
        Console.WriteLine();
    }

Console.Write("Input a number of line: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colum: ");
int colum = Convert.ToInt32(Console.ReadLine());
if (CheckArray(array, line, colum)) Console.WriteLine(array[line, colum]);
    else Console.WriteLine("can't return a number outside of array");*/



//Task3

int[,] InputArray(int lines, int colums){
    int[,] array = new int[lines, colums];
    for (int i = 0; i < lines; i++){
        for (int j = 0; j < colums; j++){
            Console.Write($"Input a {i}, {j} number of array: ");
            array[i,j] = Convert.ToInt32(Console.ReadLine());
        } 
    }
    return array;
}
double[] Average(int[,] array){
    double[] result = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++){
        for (int j = 0; j < array.GetLength(0); j++){
            result[i] = result[i] + array[j,i];
        }
        result[i] = (double)(result[i] / array.GetLength(0));
    }
    return result;
}

Console.Write("Input amount of lines: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Input amount of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] array = InputArray(lines, colums);

for (int i = 0; i < lines; i++){
    for (int j = 0; j < colums; j++){
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}

double[] result = Average(array);
for (int i = 0; i < colums; i++)
{
    Console.Write(Math.Round(result[i], 2) + " ");
}
