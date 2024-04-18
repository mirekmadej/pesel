namespace pesel
{
    class PESEL
    {
        private string pesel;
        public PESEL(string pesel= "55030101193")
        {
            this.pesel = pesel;
        }
        /*****************************************
         * nazwa funkcji: char sprawdzPlec(string pesel)
         * opis funkcji:  funkcja dla danej wartości ciągu znaków
         *                będącego numerem PESEL wyznacza płeć osoby
         * parametry:     string reprezentujący numer PESEL
         * zwracany typ i opis: typ char, wartości: 'K' dla peselu kobiety 
         *                lub 'M' dla mężczyzny
         * autor:         mm
         * ***************************************/
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
            int[] wagi = new int[10] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int suma = 0;
            for (int i = 0; i < 10; i++)
                suma += wagi[i] * int.Parse(pesel[i].ToString());
            int m = suma % 10;
            //Console.WriteLine(suma);
            int r = 10 - m;
            //Console.WriteLine(r);
            if (r == pesel[10]-'0')
                return true;
            else
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
            string p = "55030101193";
            PESEL pesel = new PESEL(p);
            Console.WriteLine(pesel.ToString());
            Console.WriteLine(pesel.sprawdzPlec(p));
            Console.WriteLine(pesel.czyPoprawny(p));

            
        }
    }
}
