//Task1

/*int[,] RandomArray(int lines, int colums, int minvalue, int maxvalue){
    int[,] array = new int[lines, colums];
    for (int i = 0; i < lines; i++){
        for (int j = 0; j < colums; j++){
            array[i,j] = new Random().Next(minvalue, maxvalue + 1);
        } 
    }
    return array;
}

void Show2dArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void SortLines(int[,] array){
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1)-1; k++)
            {
                if (array[i,k] < array[i,k+1]){
                temp = array[i,k];
                array[i,k] = array[i,k+1];
                array[i,k+1] = temp;
                }
            }
        }
    }
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
Show2dArray(array);
Console.WriteLine();
SortLines(array);
Show2dArray(array);*/



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

void Show2dArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int MinLine(int[,] array){
    int min = 0, tempsum = 0, minline = 0;
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            tempsum = tempsum + array[i,j];
        }
        if (tempsum < min){
            min = tempsum;
            minline = i;
        }
        tempsum = 0;
    }
    return minline + 1;
}

Console.Write("Input amount of lines: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Input amount of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
if (lines != colums){
    Console.Write("Input min value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = RandomArray(lines, colums, min, max);
    Show2dArray(array);
    Console.WriteLine();
    Console.WriteLine("min line -> " + MinLine(array));
}
else Console.WriteLine("set non-square array");*/



//Task3

/*int[,] InputArray(int lines, int colums){
    int[,] array = new int[lines, colums];
    for (int i = 0; i < lines; i++){
        for (int j = 0; j < colums; j++){
            Console.Write($"Input a {i}, {j} number of matrix: ");
            array[i,j] = Convert.ToInt32(Console.ReadLine());
        } 
    }
    return array;
}

void Show2dArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] ProductOfMatrix(int[,] array1, int[,] array2){
    int[,] array = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                array[i,j] = array[i,j] + array1[i,k] * array2[k,j];
            }
        }
    }
    return array;
}

Console.Write("Input amount of lines for 1st matrix: ");
int lines1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input amount of colums for 1st matrix: ");
int colums1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input amount of lines for 2st matrix: ");
int lines2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input amount of colums for 2st matrix: ");
int colums2 = Convert.ToInt32(Console.ReadLine());

if (lines1 != colums2) Console.WriteLine("imposible to multiply matrix");
else{
    int[,] array1 = InputArray(lines1, colums1);
    int[,] array2 = InputArray(lines2, colums2);
    Show2dArray(array1);
    Console.WriteLine();
    Show2dArray(array2);
    Console.WriteLine();
    int[,] array = ProductOfMatrix(array1, array2); 
    Show2dArray(array);
}*/



//Task4 использование throw catch чтобы проверить вводимые числа на соответствие условию

/*int[,,] InputArray(int lines, int colums, int layers){
    try{
        int[] inputednumbers = new int[lines * colums * layers];
        int count = 0;
        int[,,] array = new int[lines, colums, layers];
        for (int i = 0; i < lines; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                for (int k = 0; k < layers; k++)
                {
                    Console.Write($"Input a {i},{j},{k} number of array: ");
                    array[i, j, k] = Convert.ToInt32(Console.ReadLine());
                    if (array[i, j, k] < 10 || array[i, j, k] > 99)
                        throw new Exception($"{array[i, j, k]} is incorrect number");
                    else
                    {
                        foreach (int num in inputednumbers)
                        {
                            if (num == array[i, j, k]) 
                                throw new Exception($"{array[i, j, k]} is not unique number");
                        }
                    }
                    inputednumbers[count] = array[i, j, k];
                    count++;
                }
            }
        }
        return array;
    }
        catch (Exception e) {
            throw;
    }
}

void Show3dArray(int[,,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            for (int k = 0; k < array.GetLength(2); k++)
            {
               Console.Write($"{array[i,j,k]}({i},{j},{k}) "); 
            }
        }
        Console.WriteLine();
    }
}

Console.Write("Input amount of lines: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Input amount of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Input amount of layers: ");
int layers = Convert.ToInt32(Console.ReadLine());

if (lines * colums * layers > 90)
    Console.Write("It is impossible to create such an array of unique two-digit numbers.");
else{
    try{
        int[,,] array = InputArray(lines, colums, layers);
        Show3dArray(array);
    }
    catch (Exception ex) {
        Console.WriteLine($"Error: {ex.Message}");
    }
}*/



//Task4 

/*int[,] Input4x4ArraySpirally(){
    int[,] array = new int[4, 4];
        Console.Write("Input a [0,0] number of matrix: ");
    array[0,0] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a [0,1] number of matrix: ");
    array[0,1] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a [0,2] number of matrix: ");
    array[0,2] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a [0,3] number of matrix: ");
    array[0,3] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a [1,3] number of matrix: ");
    array[1,3] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a [2,3] number of matrix: ");
    array[2,3] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a [3,3] number of matrix: ");
    array[3,3] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a [3,2] number of matrix: ");
    array[3,2] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a [3,1] number of matrix: ");
    array[3,1] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a [3,0] number of matrix: ");
    array[3,0] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a [2,0] number of matrix: ");
    array[2,0] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a [1,0] number of matrix: ");
    array[1,0] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a [1,1] number of matrix: ");
    array[1,1] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a [1,2] number of matrix: ");
    array[1,2] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a [2,2] number of matrix: ");
    array[2,2] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a [3,2] number of matrix: ");
    array[2,1] = Convert.ToInt32(Console.ReadLine());
    return array;
}

void Show2dArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if(array[i,j] < 10) Console.Write("0" + array[i,j] + " ");
            else Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = Input4x4ArraySpirally();
Console.WriteLine();
Show2dArray(array);*/
