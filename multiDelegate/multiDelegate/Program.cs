namespace multiDelegate
{
    public delegate void Rectangle(double length,double width);
    internal class Program
    {
        static void Main(string[] args)
        {
            RectangleHelp rec1 = new RectangleHelp();
            Rectangle rec = new Rectangle(rec1.getArea);
            rec += rec1.getPerimeter;
            rec += rec1.Add;
            rec += rec1.Sub;
            rec += rec1.Div;
            rec(10, 12);
        }
    }

    class RectangleHelp
    {
        public double width { get; set; }
        public double height { get; set; }
        public void getArea(double width, double height)
        {
            Console.WriteLine($"The Area is : {width*height}");

        }
        public void getPerimeter(double width, double height)
        {
            Console.WriteLine($"The Perimeter is : {2*(width+ height)}");

        }

        public void Add(double width, double height)
        {
            Console.WriteLine($"The Add of width and height is : {width + height}");

        }
        public void Sub(double width, double height)
        {
            Console.WriteLine($"The Sub of width and height is : {width - height}");

        }
       
        public void Div(double width, double height)
        {
            Console.WriteLine($"The Div of width and height is: {width / height}");

        }



    }
}