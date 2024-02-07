
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
int[]numbers = new int[5];
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;

Console.WriteLine(numbers[1]);
Console.WriteLine(numbers[3]);

string[] fruits = new string[3]
{ "Apple", "Banana" , "Orange" };
Console.WriteLine(fruits[0] + " " + fruits[1] + " " + fruits[2]);



fruits[2] = "Mango";
Console.WriteLine(fruits[0] + " " + fruits[1] + " " + fruits[2]);

int count = numbers.Length;
Console.WriteLine(count);


int count2 = fruits.Length;
Console.WriteLine(count2);




List<string> frutis = new List<string>()
{ "Apple", "Banana", "Orange"};

Console.WriteLine(frutis[0] + " " + frutis[2]);

frutis.Add("Mango");
Console.WriteLine(frutis[0] + " " + frutis[1] + " " + frutis[2] + " " + frutis[3]);

Console.WriteLine(frutis.Count);

// 