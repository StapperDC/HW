//task 1

/*int SecondNumber(int number){
    int result = number /10 % 10;
    return result;
}

Console.Write("Input a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = SecondNumber(num);
Console.WriteLine($"in your number {num} second digit is {result}");*/


//task 2

/*int ThirdNumber(int number){
    int thirdnum = -1;
    if (number % 1000 < 100) return thirdnum;
    else {
        while (number % 1000 >= 100){
            thirdnum = number % 10;
            number = number / 10;
        }
        return thirdnum;
    }
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = ThirdNumber(num);
if (result == -1) Console.WriteLine("your number is less then 3 digits");
else Console.WriteLine($"in your number {num} third digit is {result}");*/


//task 3

bool CheckWeekend(int num){
    if (num == 6 || num == 7) return true;
    else return false;
}

Console.Write("Input a number of day of the week : ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = CheckWeekend(number);
if (result == true) Console.WriteLine("it's a weekend!");
else Console.WriteLine("it's not a weekend :(");