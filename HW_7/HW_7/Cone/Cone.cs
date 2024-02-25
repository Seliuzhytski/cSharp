using System.Numerics;

namespace ConeLib
{
    public class Cone
    {
        public double radius;
        public double height;
        public Cone(double r, double h)
        {
            this.radius = r;
            this.height = h;
        }

        public void ConeArea ()
        {
            double s = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Площадь поверхности основания конуса с радиусом - {radius} и высотой - {height} = {s}");
        }

        public void ConeFullArea()
        {
            double s = Math.PI * radius * (Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(height, 2)) + radius);
            Console.WriteLine($"Площадь полной поверхности конуса с радиусом - {radius} и высотой - {height} = {s}");
        }
    }
}
