using System.Globalization;

namespace Test3
{
    internal class Program
    {
        static void Main()
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            List<Car> list = new List<Car>();
            string s = Console.ReadLine();
            while (s != "")
            {
                list.Add(new Car() { Brand = s.Split(" ")[0], Type = s.Split()[1], Price = int.Parse(s.Split()[2]) });
                s = Console.ReadLine();
            }
            int pos = 1;
            foreach (var v in list)
            {
                Console.WriteLine($"{pos}\t{v.Brand}\t{v.Type}\t{v.Price:C0}");
                pos++;
            }
        }
    }
}