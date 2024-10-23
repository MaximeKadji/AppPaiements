using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {
        CarteCredit achat1 = new CarteCredit(50.0, "Achat de livre", 123456789);
        CarteCredit achat2 = new CarteCredit(150.0, "Achat de vêtements", 987654321);
        CarteCredit achat3 = new CarteCredit(300.0, "Achat de téléphone", 586472159);

        achat1.AfficherDetails();
        achat2.AfficherDetails();
        achat3.AfficherDetails();
    }
}