namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = Topla;

            Console.WriteLine(add(2,4));

            Func<int> getRandomNumber = delegate ()
            {
                return new Random().Next(1, 100);
            };

            Func<int> getRnadomNumber2 = () => new Random().Next(1, 100);

            Console.WriteLine(getRandomNumber());
            Console.WriteLine(getRnadomNumber2());
        }
        public static int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}
