public static class InsertionSort {
    public static void Sort(int[] array) {
        
        for(int i = 1; i < array.Length; i++) {
            int currentKey = array[i];
            int count = i - 1;
            bool change = false;
            while (count >= 0) {
                if (array[count] > currentKey) {
                    change = true;
                    array[count + 1] = array[count];
                }

                count--;
            }

            if(change)
                array[count + 1] = currentKey;
        }
    }
}
