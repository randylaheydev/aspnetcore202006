using System;
using System.Net;

namespace DIDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning(new TilfældighedsGeneratorRandomOrg());

            for (int i = 0; i < 10; i++)
            {
                t.Ryst();
                Console.WriteLine(t.Værdi);

            }
        }
    }

    class Terning
    {
        // Hårdt bundet...
        // System.Random rnd = new Random();
        ITilfældighedsGenerator rnd;

        public int Værdi { get; private set; }
        public void Ryst() {
            this.Værdi = rnd.TilfældigtTal(1, 7);
        }
        public Terning(ITilfældighedsGenerator g = null)
        {
            if (g == null)
                g = new TilfældighedsGeneratorRandom();
            rnd = g;
            this.Ryst();
        }
    }

    public interface ITilfældighedsGenerator {
        int TilfældigtTal(int min, int max);
    }

    public class TilfældighedsGeneratorRandom : ITilfældighedsGenerator
    {
        System.Random rnd = new Random();
        public int TilfældigtTal(int min, int max)
        {
            return rnd.Next(1, 7);
        }
    }


    public class TilfældighedsGeneratorMock : ITilfældighedsGenerator
    {
        
        public int TilfældigtTal(int min, int max)
        {
            return 6;
        }
    }

    public class TilfældighedsGeneratorRandomOrg : ITilfældighedsGenerator
    {

        public int TilfældigtTal(int min, int max)
        {
            using (WebClient w = new WebClient())
            {
                return Convert.ToInt32(w.DownloadString("https://www.random.org/integers/?num=1&min=1&max=6&col=1&base=10&format=plain&rnd=new"));
            }

        }
    }

}
