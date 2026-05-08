public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
    // PLAN:
    // 1. Create an array with the size given by "length".
    // 2. Use a for loop to go through each position in the array.
    // 3. Multiply the starting number by the current position + 1.
    // 4. Store each multiple inside the array.
    // 5. Return the completed array.

    // Create the array
    double[] result = new double[length];

    // Fill the array with multiples
    for (int i = 0; i < length; i++)
    {
        result[i] = number * (i + 1);
    }

    // Return the array
    return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
    // PLAN:
    // 1. Get the last part of the list using GetRange.
    // 2. Get the first part of the list.
    // 3. Clear the original list.
    // 4. Add the last part first.
    // 5. Add the first part after it.
    // 6. The list will now be rotated to the right.

    // Get the ending section of the list
    List<int> endPart = data.GetRange(data.Count - amount, amount);

    // Get the beginning section of the list
    List<int> startPart = data.GetRange(0, data.Count - amount);

    // Clear the original list
    data.Clear();

    // Add the ending section first
    data.AddRange(endPart);

    // Add the beginning section after
    data.AddRange(startPart);
    }
}