namespace Labb5___Grunderna_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);//Circel with radius 5
            Circle circle2 = new Circle(6);//Circel with radius 6

            Console.WriteLine("Circel med Radie 5;");
            Console.WriteLine("Arean = " + circle1.getArea());//Calling the Area for the circul with radius 6 from the class circle.
            Console.WriteLine("Omkrets = " + circle1.getOmkrets());//Calling the Circumference for the circul with radius 5 from the class circle.

            Console.WriteLine("----------------------");

            Console.WriteLine("Circel med Radie 6");
            Console.WriteLine("Arean = " + circle2.getArea()); //Calling the Area for the circul with radius 6 from the class circle.
            Console.WriteLine("Omkrets = " + circle2.getOmkrets());//Calling the Circumference for the circul with radius 6 from the class circle.

            Console.WriteLine("----------------------");

            Console.WriteLine("Ange egen radie för att räkna ut area och omkrets!");//Option to put in your own radius.
            Console.Write("radie = ");
            int i = Convert.ToInt32(Console.ReadLine());
            Circle circle3 = new Circle(i);//Send value too class circle
            Console.WriteLine("Arean = " + circle3.getArea());
            Console.WriteLine("Omkrets = " + circle3.getOmkrets());

            Console.WriteLine("----------------------");

            Console.WriteLine($"Nu ska vi räkna ut arean på en triangel");
            Console.Write("Ange Bas; ");
            int B = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Ange höjd; ");
            int H = Convert.ToInt32(Console.ReadLine());
            Triangel triangel = new Triangel(B, H);//send value tooo class triangle
            Console.WriteLine("Arean = " + triangel.TriangleArea()); //Calling the Area for the triangle from the class "triangle". we let the user deside the measurement

        }
    }
}