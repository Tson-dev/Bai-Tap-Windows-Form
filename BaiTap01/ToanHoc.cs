namespace WinForm
{
    public static class ToanHoc
    {
        public static void Plus(int a, int b, out int s)
        {
            s = a + b;
        }
        public static int Sum(int n)
        {
            int sum = 0, i = 0;
            while (n > 0)
            {
                i++;
                sum += i;
                n--;
            }
            return sum;
        }
    }
}
