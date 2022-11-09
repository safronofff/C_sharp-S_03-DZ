//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(int xa, int xb, int ya, int yb, int za, int zb)
{
	double ab = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
	return ab;
}

Console.WriteLine("Введите xa");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите xb");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите ya");
int n3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите yb");
int n4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите za");
int n5 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите zb");
int n6 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Distance(n1, n2, n3, n4, n5, n6));
