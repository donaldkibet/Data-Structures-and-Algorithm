namespace DataStructures.Algorithms
{
    public class BubbleSort
    {
        int tempNumber;
        bool isSorted;
        public void Sort(int[] numbers)
        {
            if (numbers.Length > 0)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    isSorted = false;
                    for (int i = 0; i < numbers.Length - 1; i++)
                    {
                        if (numbers[i] > numbers[i + 1])
                        {
                            // swap numbers
                            tempNumber = numbers[i];
                            numbers[i] = numbers[i + 1];
                            numbers[i + 1] = tempNumber;
                            isSorted = true;
                        }
                    }
                    if (!isSorted)
                    {
                        break;
                    }
                }
            }
        }
    }
}