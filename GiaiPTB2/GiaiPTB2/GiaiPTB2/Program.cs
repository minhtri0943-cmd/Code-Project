using System;

class PTBac1
{
    protected double a, b;

    public PTBac1(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public virtual void Giai()
    {
        if (a == 0)
        {
            if (b == 0)
                Console.WriteLine("Phuong trinh vo so nghiem.");
            else
                Console.WriteLine("Phuong trinh vo nghiem.");
        }
        else
        {
            double x = -b / a;
            Console.WriteLine("Phuong trinh co nghiem: x = " + x);
        }
    }
}

class PTBac2 : PTBac1
{
    private double c;

    public PTBac2(double a, double b, double c) : base(a, b)
    {
        this.c = c;
    }

    public override void Giai()
    {
        if (a == 0)
        {
            // Nếu a = 0 thì trở về phương trình bậc 1 bx + c = 0
            Console.WriteLine("Phuong trinh tro thanh bac 1:");
            PTBac1 pt1 = new PTBac1(b, c);
            pt1.Giai();
            return;
        }

        double delta = b * b - 4 * a * c;

        if (delta < 0)
        {
            Console.WriteLine("Phuong trinh vo nghiem thuc.");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("Phuong trinh co nghiem kep: x = " + x);
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Phuong trinh co 2 nghiem phan biet:");
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhap b = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Nhap c = ");
        double c = double.Parse(Console.ReadLine());

        PTBac2 pt2 = new PTBac2(a, b, c);
        pt2.Giai();

        Console.ReadKey();
    }
}
