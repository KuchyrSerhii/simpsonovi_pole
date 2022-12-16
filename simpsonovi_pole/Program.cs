// See https://aka.ms/new-console-template for more information
string[] simpsonovi = {"Homer", "Marge", "Bart","Lisa", "Maggie"};
Console.WriteLine("Napíš jméno svého oblibeného Simpsona");
string oblibeny_simspon =Console.ReadLine();
int poradi = Array.IndexOf(simpsonovi, oblibeny_simspon);
if (poradi >= 0)
    Console.WriteLine("Jo jo. To je můj {0}. nejoblíbenější Simspon", poradi+1);
else
    Console.WriteLine("Tohle ale neni Simpson!!!");
Console.ReadKey();
