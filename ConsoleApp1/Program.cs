using System.Globalization;

string[] jmena = { "Jirka", "Pepa", "Jana", "David", "Lucka", "Lukas" };

//foreach(string jmeno in jmena)
//{
//    Console.Write(jmeno + ",");
//}

Console.WriteLine(string.Join(", ", jmena));

double pi = 3.14159;
DateTime dt= DateTime.Now;
Console.WriteLine("Pi je " + pi.ToString(CultureInfo.InvariantCulture));
Console.WriteLine("Ted je " + dt.ToString("dd.MM.yyyy HH:mm:ss"));

string cesta1 = "C:\\novy\\text.txt";
string cesta2 = "C:/novy/text.txt";
string cesta3 = @"C:\novy\text.txt";

Directory.CreateDirectory("C:\\novy");

if(File.Exists(cesta1))
{
    Console.WriteLine("Soubor exisuje");
}
else
{
    Console.WriteLine("Soubor neexituje");
}

File.AppendAllLines(cesta1, jmena);

Console.Write(File.ReadAllText(cesta1));

Console.ReadLine();
