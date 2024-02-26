using System.Globalization;
using System.Net.Http.Headers;

namespace MethodOverLoading
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var shape = new List<Shape>();
            shape.Add(new Circle());
            shape.Add(new RectAnagle());

            var canvas = new Canvas();
            canvas.DrawShapes(shape);
        }
    }
}
