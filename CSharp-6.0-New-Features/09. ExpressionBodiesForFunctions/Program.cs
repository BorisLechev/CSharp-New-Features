namespace _09._ExpressionBodiesForFunctions
{
    public static class Program
    {
        public static void Main()
        {
            var point1 = new Point(40, 80);
            var point2 = point1.Clone() as Point;

            point1.Move(100, 100);
            point2.Print();
            point1.Print();

            point1.Move(200, 200);
            point1.Print();
        }
    }
}
