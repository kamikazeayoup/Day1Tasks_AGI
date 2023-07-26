namespace ArraysManipulation
{
    internal static class ArrayOperations
    {
        public static int FindMax(int[] array)
        {
            int MaxElement = int.MinValue;
            for(int i = 0; i < array.Length; i++)
            {
                MaxElement = Math.Max(MaxElement, array[i]);

            }
            return MaxElement;
        }
    }
}
