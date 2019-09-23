namespace DataStructures.Algorithms
{
    public class InsertionSort
    {
        public void Sort(int [] numbers) 
        {
            int temp,j;
            for(int i =0; i<numbers.Length; i++)
            {
                temp = numbers[i];
                j = i;

                while(j>0 && temp < numbers[j-1])
                {
                    numbers[j] = numbers[j-1];
                    j = j - 1;
                }

                numbers[j] = temp;
            }
        }
    }
}