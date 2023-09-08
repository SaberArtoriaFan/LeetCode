// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var v = new SuanFa.剑指29();
var m =new  int[3][];
m[0] = new int[3] { 1, 2, 3 };
m[1] = new int[3] { 4, 5, 6 };
m[2]= new int[3] {7,8, 9 };

Queue<int> s = new Queue<int>();
s.Reverse();


var l = new SuanFa.两个数组的交集();
int[] A1=new int[2] {1,1 };
int[] a2 = new int[2] { 1, 2 };
var r=l.Intersection(A1, a2);

foreach(var a in r)
{

    Console.WriteLine(a);
}
