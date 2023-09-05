namespace Tests;

[TestClass]
public class SortsTest
{
    private int[] IntegerArray = new int[]{9,0,0,-503,-53,-235,-355,53,102,1230,10,54,23,45,20};
    private T[] GetArrCopy<T>(ref T[] array){
        T[] newArray = new T[array.Length];
        Array.Copy(array, newArray, array.Length);

        return newArray;
    }

    [TestMethod]
    public void BubbleSortTest()
    {
        int[] reference = GetArrCopy(ref IntegerArray);
        Array.Sort(reference);

        int[] arr1 = GetArrCopy(ref IntegerArray);
        TLib.Sorts.BubbleSort(arr1);
        CollectionAssert.AreEqual(reference,arr1, string.Join(", ",arr1));

        int[] arr2 = GetArrCopy(ref IntegerArray);
        TLib.Sorts.BubbleSort(arr2, SortDirection.DESC);
        Array.Reverse(reference);
        CollectionAssert.AreEqual(reference,arr2, string.Join(", ", arr2));
    }

     [TestMethod]
    public void SelectionSortTest()
    {
        int[] reference = GetArrCopy(ref IntegerArray);
        Array.Sort(reference);

        int[] arr1 = GetArrCopy(ref IntegerArray);
        TLib.Sorts.SelectionSort(arr1);
        CollectionAssert.AreEqual(reference,arr1, string.Join(", ", arr1));

        int[] arr2 = GetArrCopy(ref IntegerArray);
        TLib.Sorts.SelectionSort(arr2, SortDirection.DESC);
        Array.Reverse(reference);
        CollectionAssert.AreEqual(reference,arr2, string.Join(", ", arr2));
    }
    [TestMethod]
    public void InsertionSortTest()
    {
        int[] reference = GetArrCopy(ref IntegerArray);
        Array.Sort(reference);

        int[] arr1 = GetArrCopy(ref IntegerArray);
        TLib.Sorts.InsertionSort(arr1);
        CollectionAssert.AreEqual(reference,arr1, string.Join(", ", arr1));

        int[] arr2 = GetArrCopy(ref IntegerArray);
        TLib.Sorts.InsertionSort(arr2, SortDirection.DESC);
        Array.Reverse(reference);
        CollectionAssert.AreEqual(reference,arr2, string.Join(", ", arr2));
    }
}