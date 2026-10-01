namespace SzallodaApp
{
    public class Lakosztaly : Szoba
    {
        public int ExtraSzolgaltatasAr { get; set; }

        public Lakosztaly(int _szam, int _alapar, int _extraSzolgAr) : base(_szam, _alapar)
        {
            ExtraSzolgaltatasAr = _extraSzolgAr;
        }

        public override int ArKiszamitas(int ejszakakSzama)
        {
            return base.ArKiszamitas(ejszakakSzama) + ExtraSzolgaltatasAr;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Extra szolgáltatás: {ExtraSzolgaltatasAr} Ft";
        }
    }
}