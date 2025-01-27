namespace Ruoka_Annos
{
    internal class Program
    {
        enum PääRaakaAine
        {
            nautaa = 0, kanaa = 1, kasviksia = 2
        }
        enum Kastike
        {
            curry = 0, hapanimelä = 1, pippuri = 2, chili = 3
        }
        enum Lisuke
        {
            perunaa = 0, riisiä = 1, pastaa = 2
        }

        class Ateria
        {
            public override string ToString()
            {
                return $"Pääraaka-aine: {pääaine}, Lisuke: {lisuke}, Kastike: {kastike}";
            }
            public PääRaakaAine pääaine;
            public Kastike kastike;
            public Lisuke lisuke;

            public Ateria(PääRaakaAine pääaine, Lisuke lisuke, Kastike kastike)
            {
                this.pääaine = pääaine;
                this.lisuke = lisuke;
                this.kastike = kastike;
            }
        }
        static void Main(string[] args)
        {
            PääRaakaAine pAine1 = PääRaakaAine.kanaa;
            Kastike kastike1 = Kastike.chili;
            Lisuke lisuke1 = Lisuke.perunaa;

            string[] praakaaine = Enum.GetNames<PääRaakaAine>();

            for (int i = 0; i < praakaaine.Length; i++)
            {
                Console.WriteLine($"{praakaaine[i]} ");
            }

            Console.WriteLine("Valitse raakaianeet");
            string vastaus = Console.ReadLine();
            for (int i = 0; i < praakaaine.Length; i++)
            {
                if (praakaaine[i].ToLower() == vastaus.ToLower())
                {
                    pAine1 = (PääRaakaAine)i;
                    Console.WriteLine($"Valitsit {pAine1}");
                }
            }
            string[] Lisuke1 = Enum.GetNames<Lisuke>();

            for (int i = 0; i < Lisuke1.Length; i++)
            {
                Console.WriteLine($"{Lisuke1[i]} ");
            }

            Console.WriteLine("Valitse Lisukkeet");
            string vastaus1 = Console.ReadLine();
            for (int i = 0; i < Lisuke1.Length; i++)
            {
                if (Lisuke1[i].ToLower() == vastaus1.ToLower())
                {
                    lisuke1 = (Lisuke)i;
                    Console.WriteLine($"Valitsit {lisuke1}");
                }
            }
            string[] Kastike1 = Enum.GetNames<Kastike>();

            for (int i = 0; i < Kastike1.Length; i++)
            {
                Console.WriteLine($"{Kastike1[i]} ");
            }

            Console.WriteLine("Valitse Kastikkeet");
            string vastaus2 = Console.ReadLine();
            for (int i = 0; i < Kastike1.Length; i++)
            {
                if (Kastike1[i].ToLower() == vastaus2.ToLower())
                {
                    kastike1 = (Kastike)i;
                    Console.WriteLine($"Valitsit {kastike1}");
                }
            }
    
            
            Ateria Ruoka = new Ateria(pAine1, lisuke1, kastike1);
            Console.WriteLine(Ruoka.ToString());


        }
    }
}
