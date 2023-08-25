namespace Demo01Biblioteque
{
    public class Calcul
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Divide(double x, double y)
        {
            if (y != 0) return x / y;

            throw new DivideByZeroException("Impossible to divide by zero");
        }
    }
}