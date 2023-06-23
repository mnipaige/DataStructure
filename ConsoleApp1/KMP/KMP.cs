namespace DataStructure.KMP
{
    public class KMPProgram
    {
        private static int[] GetNext(char[] str)
        {
            //初始化
            int[] next = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                next[i] = 0;
            }
            int j = 0;

            for (int i = 1; i < str.Length; i++)
            {   
                //使用回溯处理不相等的情况
                while (j > 0 && str[i] != str[j])
                {
                    j = next[j - 1];
                }
                //处理相等情况
                if (str[i] == str[j])
                {
                    j++;
                }
                //刷新
                next[i] = j;
            }
            return next;
        }

        public static int strStr(string haystack, string needle)
        {
            int n = needle.Length;
            if (n == 0)
            {
                return 0;
            }
            int[] next = GetNext(needle.ToArray<char>());
            int j = 0;
            for (int i = 0; i < haystack.Length; i++)
            {
                //如果不相等进行回溯
                while (j > 0 && haystack[i] != needle[j])
                {
                    j = next[j - 1];
                }
                if (haystack[i] == needle[j])
                {
                    j++;

                }
                //判断是否便利完
                if (j == n)
                {
                    return (i - n + 1);
                }
            }
            return -1;
        }
    }
}