namespace MethodOverLoading
{
    internal partial class Program
    {
        public  class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Draw a Circle");
            }
            
        }
        public class RectAnagle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Draw a Rectangle");
            }
        }
        public class Triangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Draw a Triangle");
            }
        }
        public class Shape
        {
            public int Width { get; set; }
            public int Height { get; set; }
          //  public Position Position
           // { get; set; }

            public virtual void Draw()
            {

            }

            //public ShapeType Type { get; set; }
        }
    }
}
