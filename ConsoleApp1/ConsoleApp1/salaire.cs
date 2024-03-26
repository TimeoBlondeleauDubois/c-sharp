using System;

class Salaire
{
    static void Main(string[] args)
    {
        int choix = ObtenirChoixUtilisateur();

        if (choix == 1)
        {
            CalculerSalaireNet();
        }
        else if (choix == 2)
        {
            CalculerInteretsComposes();
        }
    }

    static int ObtenirChoixUtilisateur()
    {
        int choix = 0;
        Console.WriteLine("Tapez 1 pour calculer votre salaire mensuel net, tapez 2 pour calculer vos intérêts composés :");

        while (!int.TryParse(Console.ReadLine(), out choix) || (choix != 1 && choix != 2))
        {
            Console.WriteLine("Veuillez entrer un choix valide (1 ou 2).");
        }

        return choix;
    }

    static void CalculerSalaireNet()
    {
        Console.WriteLine("Entrer votre salaire brut annuel :");
        int salaire_brut_annuel = DemanderEntierValide("salaire");

        Console.WriteLine("Entrer le taux d'imposition :");
        int taux_imposition = DemanderEntierValide("taux d'imposition");

        int salaire_brut_mensuel = salaire_brut_annuel / 12;
        int Salaire_net = salaire_brut_mensuel * (100 - taux_imposition) / 100;

        Console.WriteLine("Le salaire net mensuel est de " + Salaire_net + " euros");

        if (salaire_brut_mensuel > 50000)
        {
            Console.WriteLine("Vous devriez faire des dons pour réduire vos impôts.");
        }
        else if (salaire_brut_mensuel < 1500)
        {
            Console.WriteLine("C'est normal pour un étudiant.");
        }
        else if (salaire_brut_mensuel >= 30000 && salaire_brut_mensuel <= 40000)
        {
            Console.WriteLine("Venez au Cesi pour un bac+5.");
        }
    }

    static void CalculerInteretsComposes()
    {
        Console.WriteLine("Entrer votre capital investi :");
        double capital_investi = DemanderDoubleValide("capital investi");

        Console.WriteLine("Entrer sur combien d'années :");
        int annee = DemanderEntierValide("nombre d'années");

        Console.WriteLine("Entrer le taux (en pourcentage) :");
        double taux = DemanderDoubleValide("taux");

        Console.WriteLine("Année\tCapital");

        for (int i = 1; i <= annee; i++)
        {
            double montantTotal = capital_investi * Math.Pow(1 + (taux / 100), i);
            Console.WriteLine($"{i}\t{montantTotal}");
        }
    }

    static int DemanderEntierValide(string nomValeur)
    {
        int valeur;
        while (!int.TryParse(Console.ReadLine(), out valeur))
        {
            Console.WriteLine($"Veuillez entrer un nombre entier valide pour {nomValeur}.");
        }
        return valeur;
    }

    static double DemanderDoubleValide(string nomValeur)
    {
        double valeur;
        while (!double.TryParse(Console.ReadLine(), out valeur))
        {
            Console.WriteLine($"Veuillez entrer un nombre valide pour {nomValeur}.");
        }
        return valeur;
    }
}
