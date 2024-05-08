public static class MaxHeap {
    public static List<int> Element = new List<int>();
    public static void Add(int value) {
        
        Element.Add(value);

        int index = Element.Count - 1;
        int parentIndex = (index - 1) / 2;

        while (parentIndex >= 0 && index > 0) {
            if (Element[index] > Element[parentIndex]) {
                int temp = Element[index];
                Element[index] = Element[parentIndex];
                Element[parentIndex] = temp;

                index = parentIndex;
                parentIndex = (index - 1) / 2;
            }
            else {
                break;
            }
        }
    }

    public static int Pop() {
        //트리 가장 첫번째 값을 반환
        //가장 마지막 값을 첫번째 값으로 지정
        //자식간의 크기 비교, 더 큰 값이 승자가 됨
        //부모와 승자의 값을 비교, 자식이 승리시 교환 -> 반복
        
        int save = Element[0];
        Element[0] = Element[Element.Count - 1];
        Element.RemoveAt(Element.Count - 1);
        int index = 0;
        
        while(true) {
            int leftIndex = (index * 2) + 1;
            int rightIndex = (index + 1) * 2;
            int nextIndex = index;

            if (leftIndex < Element.Count - 1 && Element[leftIndex] > Element[nextIndex])
                nextIndex = leftIndex;

            if(rightIndex < Element.Count - 1 && Element[rightIndex] > Element[nextIndex])
                nextIndex = rightIndex;

            if (index != nextIndex) {
                int temp = Element[index];
                Element[index] = Element[nextIndex];
                Element[nextIndex] = temp;

                index = nextIndex;
            } else {
                return save;
            }
        }
    }
}
