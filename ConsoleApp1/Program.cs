using System.Globalization;

//vytvoření pole jmen
string[] jmena = { "Jirka", "Pepa", "Jana", "David", "Lucka", "Lukas" };

//vypis jmen diky cyklu foreach
foreach (string jmeno in jmena)
{
    Console.Write(jmeno + ",");
}

// vypis jmen pomosí string.join
Console.WriteLine(string.Join(", ", jmena));

//využití funkce ToString pro výpis desetinného čísla a datumu s časem
double pi = 3.14159;
DateTime dt= DateTime.Now;
Console.WriteLine("Pi je " + pi.ToString(CultureInfo.InvariantCulture));
Console.WriteLine("Ted je " + dt.ToString("dd.MM.yyyy HH:mm:ss"));

//možnosti zápisu cesty k souboru
string cesta1 = "C:\\novy\\text.txt";
string cesta2 = "C:/novy/text.txt";
string cesta3 = @"C:\novy\text.txt";

//vytvoření adresáře(složky)
Directory.CreateDirectory("C:\\novy");

//ověření existence cesty k souboru
if(File.Exists(cesta1))
{
    Console.WriteLine("Soubor exisuje");
}
else
{
    Console.WriteLine("Soubor neexituje");
}

// přidání řádků do souboru. Pokud soubor neexistuje je vytvořen. Pokud neexistuje adresář dojde k chybě.
// pokud by se využila funkce WriteAllLines je obsah souboru přepsán, Append přidá vždy řádky na konec souboru
File.AppendAllLines(cesta1, jmena);

// vypsání obsahu celého souboru.
Console.Write(File.ReadAllText(cesta1));

Console.ReadLine();
