namespace AljabarLibraries
{
    public static class PersamaanKuadrat
    {
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            double D = b * b - 4 * a * c;

            if (D < 0)
            {
                throw new Exception("Persamaan ini tidak memiliki akar real");
            }
            else if (D == 0)
            {
                double x = -b / (2 * a);
                return new double[] { x };
            }
            else
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                return new double[] { x1, x2 };
            }
        }

        public static double[] HasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];

            double hasilKuadratA = a * a;
            double hasilKuadratB = 2 * a * b;
            double hasilKuadratC = b * b;

            return new double[] { hasilKuadratA, hasilKuadratB, hasilKuadratC };
        }
    }
}
