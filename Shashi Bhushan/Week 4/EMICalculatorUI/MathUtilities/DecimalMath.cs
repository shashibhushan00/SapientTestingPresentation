namespace MathUtilities
{
    public static class DecimalMath
    {
        public static decimal DecimalPow(decimal exponentBase, decimal exponentIndex)
        {
            double b = (double) exponentBase;
            double i = (double) exponentIndex;

            decimal p = (decimal) System.Math.Pow(b, i);
            return p;
        }
    }
}
