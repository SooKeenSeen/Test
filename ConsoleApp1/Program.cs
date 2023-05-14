namespace Test2
{
    internal class Program
    {
        static int ToDec(string S)
        {
            int toDecConv = int.Parse(Convert.ToString(S[^1]));
            for(int i= 2; i<=S.Length; i++)
            {
                toDecConv += Convert.ToInt32(int.Parse(Convert.ToString(S[^i]))*Math.Pow(3,i-1));
            }
            return toDecConv;
        }
        static void Main()
        {
            Console.WriteLine(ToDec(Console.ReadLine()));
        }
    }
}