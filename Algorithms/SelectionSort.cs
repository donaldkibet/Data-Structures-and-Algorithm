namespace DataStructures.Algorithms {
    public class SelectionSort {
        public void Sort (int[] numbers) {
            int min;
            for (int i = 1; i < numbers.Length - 1; i++) {
                min = i;
                for (int j = i + 1; j < numbers.Length; j++) {
                    if (numbers[j] < numbers[min]) {
                        min = j;
                    }
                }
                if (min != i) {
                    int temp = numbers[min];
                    numbers[min] = numbers[i];
                    numbers[i] = temp;
                }
            }
        }
    }
}