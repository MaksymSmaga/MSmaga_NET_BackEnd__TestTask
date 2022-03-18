class Program
{
    /// <summary>
    /// Adds an element into the array.
    /// </summary>
    /// <param name="array"></param>
    /// <param name="element"></param>
    static void AddElement(ref int[] array, int element)
    {
        Array.Resize(ref array, array.Length + 1);
        array[^1] = element;
    }

    /// <summary>
    /// Deletes duplicate elements of the array.
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    static int[] DelDuplicates(int[] array)
    {
        int[] _buffer = new int[0];

        int i = 0;
        while (i < array.Length - 1)
        {
            if (array[i] != array[i + 1])
                AddElement(ref _buffer, array[i]);

            if (i == array.Length - 2)
                AddElement(ref _buffer, array[i + 1]);
            i++;
        }
        return _buffer;
    }

    static void Main()
    {
        #region Task
        // 3.Write a program to remove duplicates from a sorted int[]
        // INPUT: int[] { 1,2,3,4,4,56}
        // OUTPUT: int[] { 1,2,3,4,56}
        // You are not allowed to modify an existing array.
        // You are not allowed to use LINQ.
        #endregion

        int[] array = new int[] { 1, 1, 1, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 6, 6 };

        int[] newarray = DelDuplicates(array);

        foreach (int element in array) Console.Write(element + " ");
        Console.WriteLine();

        foreach (int element in newarray) Console.Write(element + " ");
        Console.ReadLine();
    }
}