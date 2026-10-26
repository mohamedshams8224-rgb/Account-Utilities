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