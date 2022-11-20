// Задача № 19
//int N = new Random().Next(10000,99999);
//Console.WriteLine(N);
Console.WriteLine("Введите пятизначное число : ");
int N =int.Parse(Console.ReadLine ()!);
string numbers =Convert.ToString(N);
int first =Convert.ToInt32(numbers[0]);
int second =Convert.ToInt32(numbers[1]);
int third =Convert.ToInt32(numbers[3]);
int four =Convert.ToInt32(numbers[4]);
if (first==four && second == third )
Console.WriteLine("Число полиндромное");
else  Console.WriteLine("Число не полиндромное");
