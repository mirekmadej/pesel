namespace pesel
{
    class PESEL
    {
        private string pesel;
        public PESEL(string pesel= "55030101193")
        {
            this.pesel = pesel;
        }

        public char sprawdzPlec(string pesel)
        {
            int n = pesel[9] - '0';
            if(n % 2 == 0) 
                return 'K';
            else
                return 'M';
        }
        public bool czyPoprawny(string pesel)
        {
            
            return false;
        }
        public override string ToString()
        {
            return pesel;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string p = "55030101183";
            PESEL pesel = new PESEL(p);
            Console.WriteLine(pesel.ToString());
            Console.WriteLine(pesel.sprawdzPlec(p));
            Console.WriteLine(pesel.czyPoprawny(p));
        }
    }
}
