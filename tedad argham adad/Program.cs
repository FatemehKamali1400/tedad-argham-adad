int num, a, count=0;
System.Console.WriteLine("Enter a number:");
num=int.Parse(Console.ReadLine());
while (num != 0)
{
    a = num % 10 ;
    num = num / 10 ;
   count ++ ;
}

System.Console.WriteLine("tedad argham adad=" + count);
 
