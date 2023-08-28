namespace Chapter6
{
    public abstract class Shape
    {
        public double Height;
        public double Width;
        public double Area;
        public Shape(double Height)
        {
            this.Height = Height;
        }
        public Shape(double Height, double Width)
        {
            this.Height = Height;
            this.Width = Width;
        }
    }

    public class Rectangle : Shape
    {
        public Rectangle(double Height, double Width) : base(Height, Width)
        {
            this.Height = base.Height;
            this.Width = base.Width;
            Area = Height * Width;
        }

        public override String ToString()
        {
            return $"The rectangle's height is {Height}, width is {Width}, area is {Area}.";
        }
    }

    public class Square : Shape
    {
        public Square(double Height) : base(Height)
        {
            this.Height = base.Height;
            Area = Height * Height;
        }

        public override String ToString()
        {
            return $"The Square's height is {Height}, area is {Area}.";
        }
    }

    public class Circle : Shape
    {
        public Circle(double Height) : base(Height)
        {
            this.Height = base.Height;
            Area = Math.PI * Height * Height;
        }

        public override String ToString()
        {
            return $"The Circle's radius is {Height}, area is {Area}.";
        }
    }
}
