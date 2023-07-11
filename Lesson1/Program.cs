// task 1

/*Console.Write("введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2) Console.WriteLine("числа равны");
else {
    if (num1 > num2) Console.WriteLine("большее число "+ num1);
    else Console.WriteLine("большее число "+ num2);
}*/



// task 2

/*Console.Write("введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if ((num1 == num2) && (num1 == num3)) Console.WriteLine("числа равны");
else {
    if ((num1 >= num2) && (num1 >= num2)) Console.WriteLine("наибольшее число "+ num1);
    else {
         if ((num2 >= num1) && (num2 >= num3)) Console.WriteLine("наибольшее число "+ num2);
         else Console.WriteLine("наибольшее число "+ num3);
         }
}*/



//task 3

/*Console.Write("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) Console.WriteLine("это чётное число");
else Console.WriteLine("это нечётное число");*/


//task 3

Console.Write("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;

while(count <=num) {
    if (count % 2 == 0) Console.Write(count + " ");
    count++;
}