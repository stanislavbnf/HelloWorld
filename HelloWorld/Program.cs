
using System.Text;

// МНе не понятно почему Else запускается всегда кроме как когда я выбираю возраст 25


Console.OutputEncoding = Encoding.UTF8;

//Console.Write("Введите Ваш Возраст:");
//string vozrast;
//vozrast = Console.ReadLine();
//int a = int.Parse(vozrast);


//if (a < 25)

//    Console.WriteLine("Доступ запрещен");
//else if (a > 25)
//    Console.WriteLine("Доступ разрешен");
//else if (a == 25)
//    Console.WriteLine("Круто,Вам 25 лет");


// ПОчемуто number подчеркнут красным

int number = 50;
switch (number)
{
    case 5:
        Console.WriteLine("ваш возраст не равен 50");
        break;
    case 10:
        Console.WriteLine("ваш возраст не равен 50");
        break;
    case 25:
        Console.WriteLine("ваш возраст не равен 50");
        break;
    case 50:
        Console.WriteLine("ваш возраст равен 50");
        break;
}




