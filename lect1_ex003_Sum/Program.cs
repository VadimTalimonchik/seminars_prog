// сумма двух чисел
/*
int numberA = 3;
int numberB = 5;
Console.WriteLine(numberA + numberB);
*/

// через промежуточную переменную
/*
int numberA = 33;
int numberB = 5;
int result = numberA + numberB;
Console.WriteLine(result);
*/

// применим случаное число
int numberA = new Random().Next(1,10); // 1 2 3 ... 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1,10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);