using System.Diagnostics.Tracing;

namespace microsoftLearnExercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pangram = "The quick brown fox jumps over the lazy dog";

            string[] pangramArray = pangram.Split(' ');
            string stringResult = "";

            foreach (string word in pangramArray)
            {
                char[] wordArray = word.ToCharArray();
                wordArray.Reverse();
                stringResult += String.Join("", wordArray.Reverse()) + " ";
            }


            Console.WriteLine(stringResult);
        }
    }
}
