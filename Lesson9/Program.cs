//Task 1

/*void FromNTo1(int N){
    Console.Write(N+", ");
    if (N>2) FromNTo1(N-1);
        else Console.Write(N-1);
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(num + " -> ");
FromNTo1(num);*/



//Task2

/*int SumOfNumbersBetween(int N, int M){
    int sum = 0;
    for (int i = N; i <= M; i++){
        sum = sum + i;
    }
    return sum;
}

Console.Write("Input 1st number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 2nd number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 < num2) Console.Write($"N= {num1}, M= {num2} -> {SumOfNumbersBetween(num1 , num2)}");
else Console.Write($"N= {num1}, M= {num2} -> {SumOfNumbersBetween(num2 , num1)}");*/



//Task3

int AkkermanFunc(int n, int m){
    if (n == 0) return m + 1;
    else if (m == 0) return AkkermanFunc(n - 1, 1);
        else return AkkermanFunc(n - 1, AkkermanFunc(n, m - 1));
}

Console.Write("Input 1st number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 2nd number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {num1}, M = {num2} -> {AkkermanFunc(num2 , num1)}");
