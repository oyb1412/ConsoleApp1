public static class SelectionSort {
    public static void Sort(int[] array) {
        int minNumber = int.MaxValue;
        int index = 0;
        //최소값 추출
        for(int j = 0; j < array.Length; j++) {
            for (int i = j; i < array.Length - 1; i++) {
                if (array[i] < minNumber) {
                    minNumber = array[i];
                    index = i;
                }
            }

            if (array[j] == array[index]) {
                minNumber = int.MaxValue;
                continue;
            }

            int temp = array[index];
            array[index] = array[j];
            array[j] = temp;
            minNumber = int.MaxValue;

        }
    }
}
