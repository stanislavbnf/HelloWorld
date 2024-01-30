
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Введите имя:");
string name;
name = Console.ReadLine();


Console.Write("Введите фамилию:");
string fullname;
fullname = Console.ReadLine();

Console.Write("Введите возраст:");
string age;
age = Console.ReadLine();
int a = int.Parse(age);


Console.Write("Введите профессию:");
string prof;
prof = Console.ReadLine();
string privet;
privet = "Приветствую";
Console.WriteLine("Приветсвую " + name + " " + fullname + " не думал что вам " + " "+ a + " лет ");
