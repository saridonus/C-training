//Console.WriteLine("Problem1");
//Problem1(120,120);
//void Problem1(int number1, int number2)
//{
//    if (number1 > number2)
//    {
//        Console.WriteLine("The maximum is " + number1);
//    }
//    else if(number1==number2)
//    {
//        Console.WriteLine("The numbers are equal " + number1);
//    }
//    else{
//        Console.WriteLine("The maximum is " + number2);
//    }
//} ;



//Console.WriteLine("Problem2");
//Problem2();
//void Problem2()
//{for(int i = 1; i <= 20; i++)
//{if (i % 2 == 0){
//    Console.WriteLine(i);
//}

//}
//}
//Console.WriteLine("Problem3");
//Problem3();
//void Problem3()
//{
//    int[] array = new int[] { 8, 15, 7, 10, 33, 4, 9 };
//    int max = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (array[i] > max)
//        {
//            max = array[i];

//        };
//    }

//    Console.WriteLine(max);
//}

//Console.WriteLine("Problem4");
//Problem4();
//void Problem4()
//{
//    for (int i = 20; i >= 1; i--)
//    {
//        if (i % 2 == 1)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}
//Console.WriteLine("Problem5");
//Problem5();

//void Problem5()
//{
//    var sum = 0;
//    for (int i = 0; i < 10; i++)
//    {
//        if (i % 3 == 0 || i % 5 == 0)
//        {
//            sum+=i;
//        }
//    }

//    Console.WriteLine(sum);
//}
//void Problem6 (){
//    int number = 5;
//    Console.WriteLine(number / 3);
//    Console.WriteLine(number % 3);
//}
//Problem6();

void Problem7()
{
    int sum = 0;
    int n = 1;
    do
    {
        sum = sum + n;
        n++;
    } while (n <= 10); 
    Console.WriteLine(sum);
}

Problem7();