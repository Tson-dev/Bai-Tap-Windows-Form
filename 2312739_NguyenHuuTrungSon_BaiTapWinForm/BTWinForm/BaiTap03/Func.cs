namespace BaiTap03
{
    public static class Func
    {
        /*Tìm vị trí ký tự ch ở giữa trong chuỗi str
         * 
         * Nếu như trong chuỗi không chứa ch thì trả về -1
         */
        private static int MidIndexOf(string str, char ch)
        {
            int total = str.Count(c => c == ch);
            if (total == 0) return -1;
            int m = (int)((total / 2f) + .5f)
            //Nếu total chẵn, lấy số gần bé hơn total/2
                , p = 0;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == ch)
                    if (++p == m)
                        return i;
            }
            return p;
        }
        public static void CutString(string str, out string left, out string right, int pos)
        {
            if (str != string.Empty)
            {
                int i = int.MinValue;
                char charToFind = ' ';
                switch (pos)
                {
                    case -1:
                        i = str!.IndexOf(charToFind);
                        break;
                    case 0:
                        i = MidIndexOf(str, charToFind);
                        break;
                    case 1:
                        i = str!.LastIndexOf(charToFind);
                        break;
                    default:
                        break;
                }
                if (i == -1)
                {
                    left = str;
                    right = string.Empty;
                    return;
                }
                if (i != 0)
                {
                    left = str[..i];
                    right = str[(i + 1)..];
                    return;
                }
            }
            left = string.Empty;
            right = string.Empty;
        }
        public static bool CheckClose(int n1, int n2)
        {
            return Math.Abs(n2 - n1) == 1;
        }
    }
}
