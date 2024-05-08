 public static class ShellSort {
    public static void Sort(int[] array) {
        if (array.Length < 2)
            return;

        int gap = (array.Length / 2);
        int currentKey;

        while(gap > 0) {
            if (gap % 2 == 0)
                gap++;

            for (int i = 0; i < array.Length - gap; i++) {
                currentKey = i + gap;
                for(int j = 0; j < gap; j++) {
                    if (array[j] > array[currentKey]) {
                        int temp = array[j];
                        array[j] = array[currentKey];
                        array[currentKey] = temp;
                    }
                }
                
            }

            gap = gap / 2;
        }
        
    }
 }
