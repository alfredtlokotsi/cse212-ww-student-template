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
        
        
        // Create an array to hold the multiples
        double[] multiples = new double[length];
        
        // Fill the array with multiples of the number
        for (int i = 0; i < length; i++)
        {
            // Multiply number by (i + 1) to get the correct multiple
            multiples[i] = number * (i + 1);
        }
        
        return multiples;
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
    
        
        // IMPLEMENTATION: Using Approach 1 (List slicing)
        
        // Handle edge case: If amount equals data.Count, no rotation needed
        if (amount == data.Count)
        {
            return; // Rotating by the full length results in the same list
        }
        
        // Calculate where to split the list
        int splitIndex = data.Count - amount;
        
        // Extract the last 'amount' elements (these will move to the front)
        List<int> elementsToMove = data.GetRange(splitIndex, amount);
        
        // Remove the last 'amount' elements from the list
        data.RemoveRange(splitIndex, amount);
        
        // Insert the extracted elements at the beginning of the list
        data.InsertRange(0, elementsToMove);
        
    
    }
}