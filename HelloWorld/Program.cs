
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
//     <<<<ПЕРВАЯ ЧАСТЬ FOR>>>>
//for (int i = 0; i <= 10; i++)
//{
//    if (i % 2 == 0)
//        Console.WriteLine(i + " четное ");
//    else
//        Console.WriteLine(i + " не четное");
//}


//  <<<<< ВТОРАЯ ЧАСТЬ WHILE>>>>
//int count = 1;
//while (count < 10)
//{
//count++;
//    if (count % 3 == 0)
//        Console.WriteLine(count + " делится на 3");
//    else
//        Console.WriteLine(count + " не делится 3") ;
//}



//   <<<<<DO WHILE>>>>
//Решил задачу МЕТОДОМ ТЫКА. Но я не понимаю что у меня делает guess в начале и конце и зачем оно вобще нужно мне и как оно работает
//по Заданию я должен был сначала инициализоравать guess = 0 А потом написать int guess = Convert.ToInt32(Console.Readline());
// Но  если так делаю оно подчеркивает красным guess. Короче непонятно на этом моменте
// нужна пояснительная бригада обяснить что происходит тут вобще

//int guess = 0;
//do
//{
//    Console.WriteLine("Угадайте задуманное число");
//    string gg = Console.ReadLine();
//    int number = Convert.ToInt32(gg);

//    if (number == 5)
//    { Console.WriteLine("Угадали");
//        break; 
//    }

//    else if (number < 5)
//        Console.WriteLine("Ваше число меньше загаданного");

//    else if (number > 5)
//        Console.WriteLine("Ваше число больше загаданного");  
//}
//while (guess == 0);


//          <<<< FOR EACH >>>>>

int[] numbers = { 10, 20, 30, 40, 50 };
foreach (int nomer in numbers)
{
    Console.WriteLine(nomer);
    if (nomer < 30)
    Console.WriteLine(nomer + " меньше 30");

    else if (nomer > 30) 
    Console.WriteLine(nomer + " больше 30");

    else if (nomer == 30) 
    Console.WriteLine(nomer + " равен 30");
}

