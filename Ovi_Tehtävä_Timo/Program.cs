namespace Ovi_Tehtävä_Timo
{
    internal class Program
    {
        enum Oventila
        {
            Auki,
            Kiinni,
            Lukossa
        }
        enum Toiminto
        {
            Avaa = 0,
            Lukitse = 1,
            Avaa_Lukko = 2,
            Sulje = 3,
        }
        static void Main(string[] args)
        {
            Oventila tila = Oventila.Auki;
            string[] toiminnot = Enum.GetNames<Toiminto>();
            Console.WriteLine($"Ovi on nyt {tila}");
            while (true)
            {


                Console.WriteLine("Valitse toiminta.");
                for (int i = 0; i < toiminnot.Length; i++)
                {
                    Console.WriteLine($"{i + 1}: {toiminnot[i]}");
                }
                string vastaus = Console.ReadLine();
                Toiminto valittu = Toiminto.Avaa;
                for (int i = 0; i < toiminnot.Length; i++)
                {
                    if (toiminnot[i].ToLower() == vastaus.ToLower())
                    {
                        valittu = (Toiminto)i;
                        Console.WriteLine($"Valitsit {valittu}");
                    }
                }
                if (valittu <= Toiminto.Avaa && Oventila.Kiinni == tila)
                {
                    tila = Oventila.Auki;
                    Console.WriteLine($"Ovi on nyt {tila}");
                }
                else if (tila == Oventila.Kiinni && Toiminto.Avaa == valittu)
                {
                    tila = Oventila.Auki;
                    Console.WriteLine($"Ovi on nyt {tila}");
                }
                else if (tila == Oventila.Auki && Toiminto.Sulje == valittu)
                {
                    tila = Oventila.Kiinni;
                    Console.WriteLine($"Ovi on nyt {tila}");
                }
                else if (tila == Oventila.Kiinni && Toiminto.Lukitse == valittu)
                {
                    tila = Oventila.Lukossa;
                    Console.WriteLine($"Ovi on nyt {tila}");
                }
                else if (tila == Oventila.Lukossa && Toiminto.Avaa_Lukko == valittu)
                {
                    tila = Oventila.Kiinni;
                    Console.WriteLine($"Ovi on nyt {tila}");
                }
            }
        }
    }
}
