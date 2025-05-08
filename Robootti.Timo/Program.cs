namespace Robootti.Timo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robotti terminator = new Robotti();
            {
                Console.WriteLine("Käynnistä robotti käyttämäl käynnistä komentoa");

                string answer = Console.ReadLine();
                if (answer == "käynnistä")
                {
                    terminator.OnKäynnissä = true;
                    Console.WriteLine("Robotti käynnistetään.");
                    Console.WriteLine("Mitä komentoja syötetään robotille? vaihtoehdot:sammuta, ylös, alas, oikee, vasen. ");
                }
                else
                {
                    Console.WriteLine("Mitä komentoja syötetään robotille? vaihtoehdot:sammuta, ylös, alas, oikee, vasen. " + answer);
                }
                List <RobottiKäsky>käskyt = new List<RobottiKäsky> ();
                for (int i = 0; i < 3; i++)
                {
                    answer = Console.ReadLine();
                    RobottiKäsky Uusi = null;
                    switch (answer)
                    {
                        case "käynnistä":
                            Uusi = new Käynnistä();
                            break;
                        case "sammuta":
                            Uusi = new Sammuta();
                            break;
                        case "ylös":
                            Uusi = new YlösKäsky();
                            break;
                        case "alas":
                            Uusi = new AlasKäsky();
                            break;
                        case "oikea":
                            Uusi = new OikeaKäsky();
                            break;
                        case "vasen":
                            Uusi = new VasenKäsky();
                            break;

                    }
                    terminator.Käskyt [i] = (Uusi);
                }
                terminator.Suorita();
            }

        }
    }
}


