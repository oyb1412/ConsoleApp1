public static class BubbleSort {
    public static void Sort(int[] array) {
        for(int i = 0; i < array.Length - 2; i++) {
            for(int j = 0;  j < array.Length - 1; j++) {
                if (array[j] > array[j + 1]) {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}
