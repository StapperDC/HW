//Task1 

/*int AmountOfPositive(int quanity){
    int result = 0;
    for (int i = 0; i < quanity; i++)
    {
        Console.Write($"Input a {i+1} number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0) result++;
    }
    return result;
}

Console.Write("Input amount of numbers: ");
int quanity = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Amount of positive numbers = " + AmountOfPositive(quanity));*/


//Task2



Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1==k2 && b1==b2) Console.WriteLine("straight lines match");
    else
        if (k1 == k2) Console.WriteLine("straight lines are parallel");
            else {  
                double x = (b2-b1)/(k1-k2);
                double y = k2*((b2-b1)/(k1-k2)) + b2;
                Console.WriteLine($"the lines intersect at a point ({Math.Round(x,2)}, {Math.Round(y,2)})");
            }
    



