public class Program
{
    public static void Main(String[] args) {
        List<int> arr = new List<int>() { 4,5,3,7,2};

        var res = QuickSort(arr);
    }

    public static List<int> QuickSort(List<int> arr)
    {
        int pivot = arr[0];
        
        List<int> arrRight = new List<int>();
        List<int> arrLeft = new List<int>();


        for (int i = 1; i < arr.Count; i++)
        {
            if (arr[i] > pivot) 
            {
                arrRight.Add(arr[i]);
            }
            else
            {
                arrLeft.Add(arr[i]);
            }
        }

        arrLeft.Add((int)pivot);
        arrLeft.AddRange(arrRight);

        return arrLeft;
    }
}


