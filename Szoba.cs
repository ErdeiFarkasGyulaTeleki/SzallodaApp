namespace SzallodaApp
{
    public class Szoba
    {
        public int SzobaSzam { get; }

        protected int alapar;
        public int Alapar
        {
            get { return alapar; }
            set
            {
                if (value > 0) alapar = value;
            }
        }

        public Szoba(int _szam, int _alapar)
        {
            SzobaSzam = _szam;
            Alapar = _alapar;
        }

        public virtual int ArKiszamitas(int ejszakakSzama)
        {
            return ejszakakSzama * Alapar;
        }

        public override string ToString()
        {
            return $"Szoba {SzobaSzam} | Alapár: {Alapar} Ft/éj";
        }
    }
}
