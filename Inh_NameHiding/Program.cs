namespace Inh_NameHiding
{
    class X
    {
        protected int a;
        public X(int a)
        {
            this.a = a;
        }
        public X()
        {

        }
        public int A
        { 
            get 
            {
                Console.WriteLine("X sınıfı");
                return a; 
            } 
        }   
    }
    class Y : X
    {
        protected int b;
        public Y(int a)
        {
            this.b = a;
        }
        public int A
        {
            get
            {
                Console.WriteLine("Y sınıfı");
                return b;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Y y = new Y(5);
            int deneme = y.A;
            Console.WriteLine(deneme);
        }
    }
}
