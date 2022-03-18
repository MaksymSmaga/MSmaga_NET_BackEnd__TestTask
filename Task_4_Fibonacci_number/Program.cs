class Program
{
    #region Theory Big O Notation https://en.wikipedia.org/wiki/Big_O_notation

    // Big O notation is a mathematical notation that describes the limiting behavior
    // of a function when the argument tends towards a particular value or infinity.

    // Big O notation is used to classify algorithms according to how their run time
    // or space requirements grow as the input size grows.

    // O(1) - Constant: Get an element 
    // - public int GetLastElement ( int [] array) => array[ array.Length - 1 ]

    // O(n) - Linear: use a forN loop 
    // - public int GetSumElements ( int [] array) =>  for ( int i = 0; i < n; i++) { Sum...

    // O( log(n) ) - Logarithmic: use binary search - division array by 2 parts 
    // O( n * log(n)) - Logarithmic: use binary search - division array by 2 parts 

    // O(n ^ 2) - Quadratic: use a forN loop and nested loop
    // - for (< n  for (< n  ...

    // O(n ^ 3) - Cubic: use a forN loop and nested loop forN and nested loop forN
    // - for (< n  for (< n  for (< n  ...

    // O(2 ^ n) - Exponentially: Fibonachi recurce
    // - for (< n  for (< n  for (< n  ...

    // O( n! ) - Factorial: commivoyager problem - number of ways

    // O(k * n) ~ O(n) shorten the constant Sequence of k loops
    // - for (< n) +  for (< n) +  for (< n ) +  for (< n) ...

    // O( n + n ^ 2) ~ O(n ^ 2)  n ^ 2 grows faster than n  
    // - for (< n) +  for (< n  for (< n  ...

    // O( n + log(n)) ~ O(n)  n grows faster than log(n) 

    // O( 60 * 2 ^ n + 10 * n ^ 100) ~ O( 2 ^ n + n ^ 100) 
    // O( 2 ^ n + n ^ 100) ~ O(n ^ 2)  2 ^ n grows faster than n ^ 100 

    // O( n ^ 2  + m) ~ O( n ^ 2  + m)   m - unknown

    // O( (n ^ 2) / 2) ~ O(n ^ 2)
    // - for (i = 0 for ( j = i ...

    // O( n )  - use native method .IndexOf, filter

    // O( n ^ 2 )  - use native method .IndexOf
    // - for (i = 0  .IndexOf

    // MEMORY

    // O( n ) - copy array

    // O(1) - Constant: Get an element 
    // - public int GetLastElement ( int [] array) => array[ array.Length - 1 ]
    // https://www.youtube.com/watch?v=pqivnzmSbq4

    #endregion

    /// <summary>
    /// Calcs iteratively Fibonacci number by its index.
    /// Time complexity: O(n) - Linear.
    /// Space complexity: O(1) or constant.
    /// There can be exception - Stack Over Flow
    /// </summary>
    /// <param name="index"></param>
    /// <returns>int Fibonacci number</returns>
    static int FibonIter(int index)
    {
        #region Time & Space Complexity of Fibonacci iteration
        #region Time Complexity
        // Time complexity: O(n) - Linear.
        // The time complexity of the iterative code is linear, as the loop runs from 
        // 2 to n, i.e. it runs in O(n) time.
        #endregion
        #region  Space Complexity
        // Space complexity:
        // The amount of space required is the same for fib(n) and fib(n+1), 
        // i.e. as N changes the space/memory used remains the same. 
        // Hence it’s space complexity is O(1) or constant.
        #endregion
        #endregion

        if (index >= 0)
        {
            int fibA = 0;
            int fibB = 1;

            for (int i = 0; i < index; i++)
            {
                int buffer = fibA;
                fibA = fibB;
                fibB += buffer;
            }
            return fibA;
        }
        else return 0;
    }

    /// <summary>
    /// Calcs recursively Fibonacci number by its index.
    /// Time complexity: Lower bound - (n / 2)/ Upper bound - O(2 ^ n) or exponential.
    /// Space complexity: O(n) - Linear.
    /// </summary>
    /// <param name="index"></param>
    /// <returns>int Fibonacci number</returns>
    static int FibonRec(int index)
    {
        #region Time & Space Complexity of Fibonacci recursion
        #region Time complexity
        // Time complexity: Lower bound - (n / 2)/ Upper bound - O(2 ^ n) or exponential.

        // for n > 1:
        // T(n) = T(n - 1) + T(n - 2) + 4 (1 comparison, 2 subtractions, 1 addition)

        // Lower bound T(n-1) ~ T(n - 2):
        // T(n) = T(n - 1) + T(n - 2) + c = 2T(n - 2) + c  = 2 * (2T(n - 4) + c) +c
        //      = 4T(n - 4) + 3c = 8T(n - 6) + 7c = 2 ^ k * T(n - 2k) + (2 ^ k - 1) * c
        // Let's find the value of k for which: n - 2k = 0
        //    k = n / 2T(n) = 2 ^ (n / 2) * T(0) + (2 ^ (n / 2) - 1) * c
        //      = 2 ^ (n / 2) * (1 + c) - c
        //      i.e. T(n) ~ 2 ^ (n / 2)

        // Upper bound T(n - 2) ~ T(n - 1) as T(n - 2) ≤ T(n - 1):
        // T(n) = T(n - 1) + T(n - 2) + c = 2T(n - 1) + c = 2 * (2T(n - 2) + c) + c
        //      = 4T(n - 2) + 3c = 8T(n - 3) + 7c = 2 ^ k * T(n - k) + (2 ^ k - 1) * c
        // Let's find the value of k for which: n - k = 0
        //    k = n*T(n) = 2 ^ n * T(0) + (2 ^ n - 1) * c
        //      = 2 ^ n * (1 + c) - c
        //      i.e. T(n) ~ 2 ^ n
        #endregion
        #region Space complexity
        // Space complexity: O(n) - Linear.

        // For Fibonacci recursive implementation - the space required is proportional
        // to the maximum depth of the recursion tree, because, that is the maximum
        // number of elements that can be present in the implicit function call stack.
        // Pic is attached, as you can see the maximum depth is proportional to the N.
        #endregion
        #endregion

        if (index <= 1) return index;

        return FibonRec(index - 1) + FibonRec(index - 2);
    }

    static void Main()
    {
        #region Task 4
        // Write a method to find the nth Fibonacci number in the Fibonacci sequence 
        // both iterative and recursive ways. Describe the time and space complexity(O) 
        // of each implementation.
        // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987
        #endregion

        Console.WriteLine($"FibonIter: {FibonIter(13)}");

        Console.WriteLine($"FibonRec: {FibonRec(13)}");

        // Delay.
        Console.ReadLine();
    }
}