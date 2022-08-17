/*
Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}

int DigitsSum(int num)
{
    int answer=0;
    while(Math.Abs(num)>0)
    {
        answer+=Math.Abs(num)%10;
        num/=10;
    }

    return answer;
}

int val=Prompt("enter your number: ");


System.Console.WriteLine($" sum of your number digits is: {DigitsSum(val)}");
