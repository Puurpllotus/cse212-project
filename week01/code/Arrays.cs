public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// Example: MultiplesOf(7,5) -> {7,14,21,28,35}
    /// </summary>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create an array that will hold the multiples.
        // The size of the array should be equal to the length parameter.
        double[] result = new double[length];

        // Step 2: Use a loop to go through each index of the array.
        // The loop will run from 0 up to length - 1.
        for (int i = 0; i < length; i++)
        {
            // Step 3: For each position in the array, calculate the multiple.
            // The first multiple should be number * 1, the second number * 2, etc.
            // Since array indexing starts at 0, we use (i + 1).
            result[i] = number * (i + 1);
        }

        // Step 4: Return the array of multiples.
        return result;
    }

    /// <summary>
    /// Rotate the list to the right by the specified amount.
    /// Example:
    /// data = {1,2,3,4,5,6,7,8,9}, amount = 3
    /// result = {7,8,9,1,2,3,4,5,6}
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Determine where the split point will be.
        // The split index is the position where the rotated section starts.
        int splitIndex = data.Count - amount;

        // Step 2: Create a list that contains the last 'amount' elements.
        // These elements will move to the front of the list.
        List<int> endPart = data.GetRange(splitIndex, amount);

        // Step 3: Create another list containing the first part of the list.
        // These elements will move after the rotated section.
        List<int> startPart = data.GetRange(0, splitIndex);

        // Step 4: Clear the original list so we can rebuild it in the correct order.
        data.Clear();

        // Step 5: Add the rotated portion (endPart) to the list first.
        data.AddRange(endPart);

        // Step 6: Add the remaining elements (startPart) after it.
        data.AddRange(startPart);
    }
}