namespace Delegates
{ 
    public delegate void MyDelegate(); // void olan ve parametre almayan opreasyonlara delegelik yapıyor.
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1, int number2);
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage; //yukardaki elçilik bu ise özel bir elçi olarak düşünebiliriz. bir delegate den birdden fazla delege oluşturulabilir
            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            MyDelegate3 myDelegate3 = customerManager.Sum;

            myDelegate3 += customerManager.Impact;
            myDelegate2 += customerManager.ShowAlert2;
            
            myDelegate += customerManager.ShowAlert;
            
            myDelegate();

            myDelegate2("Hello");

            Console.WriteLine("*****************");

            Console.WriteLine(myDelegate3(3,5)); //en son verdiğimiz delege çalışır yani çarpma 





        }
    }
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");

        }
        public void SendMessage2(string message)
        {
            Console.WriteLine("Hello");
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);

        }

        public int Sum(int number1,int number2)
        {
            return number1 + number2;
        }
        public int Impact(int number1, int number2)
        {
            return number1 * number2;
        }
    }


}