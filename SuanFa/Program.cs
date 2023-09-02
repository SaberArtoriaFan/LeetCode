// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var v = new SuanFa.剑指29();
var m =new  int[3][];
m[0] = new int[3] { 1, 2, 3 };
m[1] = new int[3] { 4, 5, 6 };
m[2]= new int[3] {7,8, 9 };
foreach(var a in v.SpiralOrder(m))
{
    Console.WriteLine(a);
}
