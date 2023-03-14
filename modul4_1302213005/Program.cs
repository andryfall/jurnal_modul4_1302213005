namespace modul4_1302213005
{
    using static KodeBuah;
    internal class Program
    {
        static void Main(string[] args)
        {
            KodeBuah k = new KodeBuah();
            Buah buah = Buah.Apel;
            Console.WriteLine(getKodeBuah(buah));
        }
    }
    
    internal class KodeBuah
    {
        public KodeBuah() { }
        
        public enum Buah { Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung }
        public static String getKodeBuah(Buah buah)
        {
            String[] kodeBuah = { "A00", "B00","C00", "D00", "E00", "F00", "H00", "I00", "J00" };
            return kodeBuah[(int)buah];
        }
    }
}