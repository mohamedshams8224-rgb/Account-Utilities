
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
//////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////
namespace Vowels_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception("mhmd");
        }
        public static void Exception(string word)
        {
            word.ToLower();
            char[] vowels = [ 'a','e' ,'i' ,'o' ,'u' ];
            bool flag = false;
            foreach(char letter in word)
            {
                if (vowels.Contains(letter))
                {
                    flag = true;
                }
            }
            if(!flag)
                Console.WriteLine("the string doesn't contain Vowels");
            else
                Console.WriteLine(word);

        }
    }
}
