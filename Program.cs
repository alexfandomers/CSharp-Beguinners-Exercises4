namespace Exercises4
{
     public class Program
    {
        static void Main(string[] args)
        {  
            //1- Write a program that reads a text file and displays the number of words.
            var path = @"C:\C#\text\Documento.txt";
            var numberWords = new List<string>(File.ReadAllText(path).Split(' '));
            Console.WriteLine(numberWords.Count());

            //2- Write a program that reads a text file and displays the longest word in the file.
            if (numberWords.Count > 0)
            {
                int longestIndex = 1;
                string longestWord = numberWords[0];
                for (int i = 0; i < numberWords.Count; i++)
                {
                    string item = numberWords[i];
                    if (item.Length > longestWord.Length)
                    {
                        longestWord = item;
                        longestIndex = i + 1;
                    }
                }
                Console.WriteLine("Longest Word: {0}\nFound at Position {1}", longestWord, longestIndex);
            }
        }
    }
}