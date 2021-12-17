namespace _09._ExpressionBodiesForFunctions
{
    public class Point : ICloneable
    {
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }

        // Before:
        ////public void Print()
        ////{
        ////    Console.WriteLine(this.X + " " + this.Y);
        ////}
        // Now:
        public void Print() => Console.WriteLine(this.X + " " + this.Y);

        // Before:
        ////public object Clone() // Returns a new object that is a copy of this instance
        ////{
        ////    return new Point(this.X, this.Y);
        ////}
        // Now:
        public object Clone() => new Point(this.X, this.Y); // Returns a new object that is a copy of this instance

        public void Move(int x, int y)
        {
            this.X += x;
            this.Y += y;
        }
    }
}
