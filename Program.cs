using static System.Net.WebRequestMethods;

public class Program {
    static void Main(string[] args) {
        int[] testArray = { 10, 8, 6, 20, 4, 3, 22, 1, 0, 15, 16 };
        //BubbleSort.Sort(testArray);
        //SelectionSort.Sort(testArray);
        InsertionSort.Sort(testArray);

        //for(int i = 0; i < 10; i++) {
        //    MaxHeap.Add(i);
        //}
        //ShellSort.Sort(testArray);
        foreach (int i in testArray) {
            Console.WriteLine(i);
        }
    }
}
