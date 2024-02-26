namespace MethodOverLoading
{
    internal partial class Program
    {
        public class Canvas
        {
            public void DrawShapes(List<Shape> shapes)
            {
                foreach(var shape in shapes)
                {
                    shape.Draw();
                    
                }
            }
        }
    }
}
