//Задача 2.
//Напишите программу, которая на вход принимает два числа
//и выдет, какое число большее, а какое меньшее

/*
Console.WriteLine ("Input your 1st number: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input your 2nd number: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
if(num_1 > num_2)
{
    Console.WriteLine("You max number is: " + num_1 + " and you min number is: " + num_2);
}
else
{
    Console.WriteLine("Your max number is: "+ num_2 + " and your min number is: " + num_1); 
}
*/


//Задача 4
//Напишите программу, которая принимает на вход три числа
//и выдает максимальное из этих чисел.

//запросить 3 числа
//ввести перемунную max
//сделать цикл
/*
Console.WriteLine ("Input your 1st number: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input your 2nd number: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input your 3rd number: ");
int num_3 = Convert.ToInt32(Console.ReadLine());
int max = 0;

while(max )
{
    Console.WriteLine("Your max number is: "+ );
}



//Задача 6.
//Напишите программу, которая на вход принимает число и выдает, 
//является ли число четным (делится ли оно на 2 без остатка)

Console.WriteLine ("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
//int positiv_num - num (if num > 0) or num * (-1)

if (num % 2 != 0)
{
     Console.WriteLine("Your number: " + num + " is not even-numbered");
}
else
{
    Console.WriteLine("Your number: " + num + " is even-numbered");
}
*/


//Задача 8.
//Напишите программу, которая на вход принимает число(N), а на выходе
//показывает все четные числа от 1 до N.

Console.WriteLine ("Input your number: ");
int num_N = Convert.ToInt32(Console.ReadLine());
int current_i = num_N % 2;

while(current_i <= num_N)
{
    Console.Write(current_i + " ");
    current_i ++;  //curent_i += 1; curent_i = current_i + 1;

}