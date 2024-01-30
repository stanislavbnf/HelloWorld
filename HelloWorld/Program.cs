




using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

int age = 26;
int age1 = 27;
int result = age + age1;
long cash = 20;
long chash1 = 15;
long result1 = cash * chash1;
Console.WriteLine(result * ++result1);

Console.WriteLine(result - result1);
Console.WriteLine(result * result1 - age);



bool isAdult = true;
bool HasMoney = false;
bool HasID = true;
bool result3 = isAdult && HasMoney && HasID;
bool result4 = isAdult || HasMoney && HasID;


Console.WriteLine(result3);
Console.WriteLine(result4);

bool some = 10 <= 20;
bool result5 = result1 <= result;
Console.WriteLine(some);
Console.WriteLine(result5);

string name = "Stanley" ;
string fullname = "Kubrik";
Console.WriteLine(name + fullname);