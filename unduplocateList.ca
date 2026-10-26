namespace different_integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            List<int> unDuplicate = new List<int>();
            for(int i= 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (!unDuplicate.Contains(arr[i]))
                {
                    unDuplicate.Add(arr[i]);
                }else
                {
                    Console.WriteLine("already exist");
                    continue;

                }
            }
            foreach (int item in unDuplicate)
            {
                Console.Write(item + " ");
            }
   
        }
    }
}