//Напишите программу,которая на вход принимает координаты двух точек и находит расстояние между ними в 2D пространстве.
//A(3,6); B(2,1)=5.09
//a(7,-5);b(1,-1)=7.21
//AB=v(xb-xa)^2+(yb-ya)^2
//AB=v(xb-xa)^2+(yb-ya)^2+(xb-za)^2

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
