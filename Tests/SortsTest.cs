namespace Tests;

[TestClass]
public class SortsTest
{
    private int[] IntegerArray = new int[]{9,0,0,-503,-53,-235,-355,53,102,1230,10,54,23,45,20};
    private string ArrToString<T>(ref T[] array){
        string s = "";
        for (int i = 0; i < array.Length; i++){
            s += $"{array[i]} ";
        }
        return s;
    }
    private T[] GetArrCopy<T>(ref T[] array){
        T[] newArray = new T[array.Length];
        Array.Copy(array, newArray, array.Length);

        return newArray;
    }

    [TestMethod]
    public void AscTest()
    {
        int[] reference = GetArrCopy(ref IntegerArray);
        Array.Sort(reference);

        int[] arr1 = GetArrCopy(ref IntegerArray);
        TLib.Sorts.BubbleSort(arr1);
        CollectionAssert.AreEqual(reference,arr1, ArrToString(ref arr1));

        int[] arr2 = GetArrCopy(ref IntegerArray);
        TLib.Sorts.SelectionSort(arr2);
        CollectionAssert.AreEqual(reference, arr2, ArrToString(ref arr2));

        int[] arr3 = GetArrCopy(ref IntegerArray);
        TLib.Sorts.InsertionSort(arr3);
        CollectionAssert.AreEqual(reference, arr3, ArrToString(ref arr3));
    }

     [TestMethod]
    public void DescTest()
    {
        int[] reference = GetArrCopy(ref IntegerArray);
        Array.Sort(reference);
        Array.Reverse(reference);
        
        int[] arr1 = GetArrCopy(ref IntegerArray);
        TLib.Sorts.BubbleSort(arr1, SortDirection.DESC);
        CollectionAssert.AreEqual(reference,arr1, ArrToString(ref arr1));

        int[] arr2 = GetArrCopy(ref IntegerArray);
        TLib.Sorts.SelectionSort(arr2, SortDirection.DESC);
        CollectionAssert.AreEqual(reference, arr2, ArrToString(ref arr2));

        int[] arr3 = GetArrCopy(ref IntegerArray);
        TLib.Sorts.InsertionSort(arr3, SortDirection.DESC);
        CollectionAssert.AreEqual(reference, arr3, ArrToString(ref arr3));
    }
}