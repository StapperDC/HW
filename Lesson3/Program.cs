//task 1

/*bool Check(int number){
    int reverse = 0;
    for (int i = number; i != 0; i = i / 10)
    {
        reverse = reverse * 10 + i % 10;
    }
    if (reverse == number) return true;
    else return false;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

bool result = Check(num);
if (result == true) Console.WriteLine(num + " -> yes");
else Console.WriteLine(num + " -> no");*/


//task 2

/*double Distance(int x1, int y1, int z1, int x2, int y2, int z2){
    double result = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
    return result;
}

Console.Write("Input a coordinates of first point:\nx: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a coordinates of second point:\nx: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("distance beetwen your points = " + Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2));*/


//task 3

void Pow3(int num){
    int count=1;
    while(count<=num){
        Console.WriteLine($"{count} - {count*count*count}");
        count++;
    }
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Pow3(num);