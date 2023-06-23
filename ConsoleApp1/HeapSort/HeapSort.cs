namespace DataStructure.HeapSort
{
    public class HeapSortProgram
    {

        private static void Swap(int[] tree, int i, int j)
        {
            (tree[j], tree[i]) = (tree[i], tree[j]);
        }

        //对指定的节点进行操作保证父节点大于子节点
        private static void Heapify(int[] tree, int len, int i)
        {
            if (i >= len)
            {
                return;
            }

            int c1 = 2 * i + 1;
            int c2 = 2 * i + 2;
            int max = i;
            if (c1 < len && tree[c1] > tree[max])
            {
                max = c1;
            }
            if (c2 < len && tree[c2] > tree[max])
            {
                max = c2;
            }

            //如果节点发生了交换，那么递归的继续去保证被交换的节点也满足：父节点大于子节点
            if (max != i)
            {
                Swap(tree, max, i);
                Heapify(tree, len, max);
            }
        }

        //从最后节点的父节点开始，进行heapify操作，构建出堆
        private static void HeapBuild(int[] tree, int len)
        {
            int last = len - 1;
            int parent = (last - 1) / 2;
            for (int i = parent; i >= 0; i--)
            {
                Heapify(tree, len, i);
            }
        }

        //堆排序，构建堆，将最后一个元素跟第一个元素进行交换，然后缩小数组长度继续上面的操作
        public static void HeapSort(int[] tree, int len)
        {
            HeapBuild(tree, len);
            for (int i = len - 1; i >= 0; i--)
            {
                Swap(tree, i, 0);
                HeapBuild(tree, i);
            }
        }

        public static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
