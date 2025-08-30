namespace BaiTap04
{
    public static class Func
    {
        public static void Greeting(string name, bool sex)
        {
            MessageBox.Show(string.Format($"Greeting {(sex? "Mr." : "Ms.")} {name}"));
        }
        public static int GCD(int m, int n)
        {
            if (m < 0 || n < 0) return -1;
            if (m == 0 || n == 0) return 0;

            //Euclid's algorithm
            int frac = m, divr = n, remain;
            if (divr > frac)
                (frac, divr) = (divr, frac);
            while ((remain = frac % divr) != 0)
            {
                frac = divr;
                divr = remain;
            }
            return divr;
        }
    }
}
