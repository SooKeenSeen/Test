namespace Test1
{
    internal class Program
    {
        static void Main()
        {
            string sets = Console.ReadLine()!;
            char[] seps = { ' ', '.' };
            string[] words = sets.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(String.Join(" ", Array.FindAll(words, x => x != words[0] & x.Length <= 5)));
        }
    }
}