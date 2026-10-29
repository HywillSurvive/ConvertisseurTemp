namespace convertisseur_temp;

class Program
{
    static void Main(string[] args)
    {
        // Créez un programme sur console qui converti une température rentrée par l’utilisateur dans l’unité de son choix.
        // Deux sens de conversion doivent être possibles : soit de degrés Celsius vers Fahrenheit, soit de degrés Fahrenheit vers Celsius.

        float réponseFahrenheit = 0f;
        float réponseCelsius = 0f;

        Console.WriteLine("Comment passer de Celsius à Fahrenheit et vice versa?");
        Console.WriteLine("Veuillez introduire un chiffre qui servira de température.");
        float choixTempérature = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Veuillez choisir la mesure suivante : 1 pour Celsius ou 2 pour Fahrenheit!");
        float choixMesure = Convert.ToInt32(Console.ReadLine());

        while (choixMesure != 1 && choixMesure != 2)
        {
            Console.WriteLine("Veuillez introduire le bon choix : 1 pour Celsius ou 2 pour Fahrenheit!");
            choixMesure = Convert.ToInt32(Console.ReadLine());
        }

        if (choixMesure == 1)
        {
            réponseFahrenheit = (choixTempérature * 9 / 5) + 32;
            Console.WriteLine("\n==========Formule============ \n°C à °F : \n(" + choixTempérature + "°C x 9/5) + 32 = " + réponseFahrenheit + "°F");
        }

        if (choixMesure == 2)
        {
            réponseCelsius = (choixTempérature - 32) * 5 / 9;
            Console.WriteLine("\n==========Formule============ \n°F à °C : \n(" + choixTempérature + "°F - 32) x 5/9 = " + réponseCelsius + "°C");
        }
    }
}