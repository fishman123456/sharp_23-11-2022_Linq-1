
Random rand = new Random();
int [] arr = new int[10];    

for (int i = 0; i < 10; i++)
{
    arr[i] = rand.Next(1,100);
}
foreach (var a in arr )
{
    Console.WriteLine(a);
}
Console.WriteLine("---------------------");
var red = from r in arr
          where r % 3 == 0 && r %5!= 0
          select r;

foreach (var r in red)
{
    Console.WriteLine(r);
}