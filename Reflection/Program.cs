using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine(dortIslem.Topla(1, 2));
            //Console.WriteLine(dortIslem.Topla2());

            var type = typeof(DortIslem);

            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type,3,7);
            //Console.WriteLine(dortIslem.Carp2());

            var instance = Activator.CreateInstance(type, 6, 5);
            

            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");

            Console.WriteLine(methodInfo.Invoke(instance,null));

            MethodInfo methodInfo2 = instance.GetType().GetMethod("Topla");

            Console.WriteLine(methodInfo2.Invoke(instance, new string[] {"3","4"}));

            var metodlar = type.GetMethods();

            foreach (var info in metodlar)
            {
                Console.WriteLine("Metod adı : " + info.Name);

                foreach (var attribue in info.GetCustomAttributes())
                {
                    Console.WriteLine("attribute name : " + attribue.GetType().Name);
                }
            }



            

            Console.ReadLine();
        }
    }

   public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem(int sayi1,int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        
        public int Topla(string sayi1,string sayi2)
        {
            return Convert.ToInt32(sayi1) + Convert.ToInt32(sayi2);
        }
        public int Carp(int sayi1,int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }

}
