/*
Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}

int PowerOf(int _base_, int pow)
{
    if(pow==0) return 1;
    int answer=1;
    for(int i=0; i<pow;i++)
    {
        answer*=_base_;
    }

    return answer;
}

int b=Prompt("enter your number1: ");
int p=Prompt("enter your number2: ");

System.Console.WriteLine($" power number1 of number2 is: {PowerOf(b,p)}");

