namespace modul4_1302213005
{
    using static KodeBuah;
    using static PosisiKarakterGame;
    internal class Program
    {
        static void Main(string[] args)
        {
            KodeBuah k = new KodeBuah();
            Buah buah = Buah.Apel;
            Console.WriteLine(getKodeBuah(buah));

            PosisiKarakterGame g = new PosisiKarakterGame();
            
            g.command();
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

    internal class PosisiKarakterGame
    {
        public PosisiKarakterGame() { }
        public enum State { Jongkok, Berdiri, Tengkurap, Terbang, Exit};

        State state = State.Berdiri;

        public void command()
        {
            Console.WriteLine(" Tombol : x, s, w");
            
            string[] screenName = { "Jongkok", "Berdiri", "Tengkurap", "Terbang", "Exit" };
            while(state != State.Exit) {
                Console.WriteLine("Sedang " + screenName[(int)state]);
                Console.WriteLine("Enter Tombol :");

                string tombol = Console.ReadLine();

                switch (state)
                {
                    case State.Berdiri:
                        if(tombol == "s")
                        {
                            state= State.Jongkok;
                        }else if (tombol == "w")
                        {
                            state = State.Terbang;
                            Console.WriteLine("posisi take off");
                        }
                        else
                        {
                            state= State.Berdiri;
                        }
                        break;
                    case State.Terbang:
                        if(tombol == "s")
                        {
                            state = State.Berdiri;
                        }else if (tombol == "x")
                        {
                            state = State.Jongkok;
                            Console.WriteLine("posisi landing");
                        }
                        else
                        {
                            state= State.Terbang;
                        }
                        break;
                    case State.Jongkok:
                        if(tombol == "s")
                        {
                            state = State.Tengkurap;
                        }else if (tombol == "w")
                        {
                            state = State.Berdiri;
                        }
                        else
                        {
                            state = State.Jongkok;
                        }
                        break;
                    case State.Tengkurap:
                        if (tombol == "w")
                        {
                            state = State.Jongkok;
                        }
                        else
                        {
                            state = State.Tengkurap;
                        }
                        break;
                }
            }
        }
    }
}