namespace TLib
{
    public enum SortDirection
    {
        DESC = -1,
        ASC = 1
    }
    public static class Sorts
    {
        public static void BubbleSort<T>(T[] arr, SortDirection direction = SortDirection.ASC) where T: IComparable{
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int compare = arr[i].CompareTo(arr[j]);
                    if (compare == (int)direction)
                    {
                        T temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        public static void SelectionSort<T>(T[] arr, SortDirection direction = SortDirection.ASC) where T : IComparable
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                T current = arr[i];
                T replace = arr[i];
                int indexMin = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int compare = replace.CompareTo(arr[j]);
                    if (compare == (int)direction){
                        replace = arr[j];
                        indexMin = j;
                    }
                }
                if (i != indexMin)
                {
                    arr[i] = replace;
                    arr[indexMin] = current;
                }
            }
        }

        public static void InsertionSort<T>(T[] arr, SortDirection direction = SortDirection.ASC) where T: IComparable
        {
            for (int i = 1; i < arr.Length; i++)
            {
                T current = arr[i];
                int index = i;
                for (int j = i - 1; j >= 0 ; j--)
                {
                    int compare = current.CompareTo(arr[j]);
                    if (compare == -(int)direction)
                    {
                        T temp = current;
                        arr[index] = arr[j];
                        arr[j] = temp;
                        index--;
                    }
                    else if (compare == (int)direction)
                    {
                        break;
                    }
                } 
            }
        }
    }
}