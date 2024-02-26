namespace AbstractClasses
{
    internal partial class Program
    {
        public abstract class Shape
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public abstract void Draw();

            public void Copy() {

                Console.WriteLine("Copy the shape ClipBoard");

            }
            public  void Select()
            {
                Console.WriteLine("Select the Shape");
            }


        }
        }
    }
