namespace BaiTap02
{
    public static class Func
    {
        public static void ConnectString(string left, string right, out string output)
        {
            output = string.Format("{0} {1}", left, right);
        }
        public static long Factorial(int n)
        {
            if (n == 0) return 1;
            long prod = 1;
            int i = 0;
            while (n > 0)
            {
                i++;
                prod *= i;
                n--;
            }
            return prod;
        }
    }
}
