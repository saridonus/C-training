for (int i=0;i<10; i++)
{
    Console.WriteLine(i);
}


List<int> numbers = new List<int> { 1,2,3 };
foreach (var number in numbers)
{
    Console.WriteLine(number);
    Console.WriteLine("works");
    
}