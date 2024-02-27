namespace ExceptionHandlingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0);
                
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("You cannot Divide by 0");
            }
            catch(ArithmeticException ex)
            {

            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, an unexpected error occurred.");
            }
            finally
            {
                Console.WriteLine("");
            }
        }
    }
}
