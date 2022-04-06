class Program
{
    /// <summary>
    /// Deletes duplicate elements of the array.
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    static int[] DelDuplicates(int[] array)
    {
        int[] _buffer = new int[array.Length];

        int i = 0;
        int k = 0;

        while (i < array.Length - 1)
        {
            if (array[i] != array[i + 1])
            {
                _buffer[k] = array[i];
                k++;
            }

            if (i == array.Length - 2)
            {
                _buffer[k] = array[i + 1];
                k++;
            }

            i++;
        }

        int j = 0;

        while (j < _buffer.Length - 1 && _buffer[j] != _buffer[j + 1])
        {
            j++;
        }

        Array.Resize(ref _buffer, j);

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

    int[] array = new int[] { 1, 3, 3, 3, 32, 5, 132, 132, 66, 66, 622, 622, 622 };

    int[] newarray = DelDuplicates(array);

    foreach (int element in array) Console.Write(element + " ");
    Console.WriteLine();

    foreach (int element in newarray) Console.Write(element + " ");
    Console.ReadLine();
}
}